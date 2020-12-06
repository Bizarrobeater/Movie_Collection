using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Microsoft.SqlServer.Server;
using System.Xml.Schema;
using System.Windows.Forms;
using System.ComponentModel;
using System.Globalization;

namespace MovieCollection
{
    class Search
    {
        private string search_string;
        private bool random_search;
        private bool has_keywords;
        Dictionary<string, List<string>> keywords_search_terms = new Dictionary<string, List<string>>();

        Dictionary<string, bool> search_keywords_dict = new Dictionary<string, bool>()
            {
                { "@all", false },
                { "@person", false },
                { "@actor", false },
                { "@director", false },
                { "@writer", false },
                { "@genre", false },
                { "@title", false },
                { "@franchise", false },
                { "@collection", false },
                { "@box", false },
                { "@subs", false },
                { "@subtitle", false },
                { "@language", false },
                { "@spoken", false},
                { "@country", false },
                { "@rating", false },
                { "@meta", false },
                { "@metacritic", false },
                { "@imdb", false },
                { "@imdbscore", false },
                { "@year", false },
                { "@releaseyear", false },
                { "@time", false },
                { "@min", false },
                { "@minutes", false },
                { "@runtime", false },
                { "@lastwatched", false }

            };

        private Dictionary<string, List<string>> Keywords_search_terms { get => keywords_search_terms; set => keywords_search_terms = value; }
        private Dictionary<string, bool> Search_keywords_dict { get => search_keywords_dict; set => search_keywords_dict = value; }

        public string Search_string { get => search_string; set => search_string = value; }
        public bool Random_search { get => random_search; set => random_search = value; }
        public bool Has_keywords { get => has_keywords; set => has_keywords = value; }

        public Search(string search)
        {
            Search_string = search + " ";       
            Random_search = false;
            Has_keywords = false;
            SearchForKeywords(Search_string);
        }

        public string RetrieveSelectString()
        {
            StringBuilder select_string_builder = new StringBuilder();
            string random_search_select = "TOP 1";
            string random_search_order = "NEWID()";
            if (!random_search)
            {
                random_search_select = "DISTINCT";
                random_search_order = "Title";
            }
            
            select_string_builder.AppendFormat("SELECT {0} movie_data.id " + 
                                        "   , movie_title.title as 'Original Title' " +
                                        "   , movie_data.run_time as 'Run Time' " +
                                        "   , movie_data.imdb_score as 'IMDB Score' " +
                                        "   , movie_data.metacritic_score as 'Metacritic Score' " +
                                        "   , movie_data.release_date as 'Release Date' " +
                                        " 	, last_watched_log.last_watched_date as 'Last Watched' " +
                                        "FROM dbo.movie_title " +
                                        "   JOIN dbo.movie_data " +
                                        "       ON movie_title.movie_data_id = movie_data.id " +
                                        "   LEFT OUTER JOIN dbo.last_watched_log " +
                                        "       ON movie_data.id = last_watched_log.movie_data_id " +
                                        "WHERE movie_title.original_title = 1 ",
                                        random_search_select);
            if (has_keywords)
            {
                foreach (string keyword in keywords_search_terms.Keys)
                {
                    if (keywords_search_terms.Count == 0) { continue; }
                    switch (keyword)
                    {
                        case "@meta":
                        case "@metacritic":
                        case "@imdb":
                        case "@imdbscore":
                        case "@time":
                        case "@minutes":
                        case "@runtime":
                        case "@year":
                        case "@releaseyear":    
                            WhereMovieDataTableBuilder(ref select_string_builder, keyword, keywords_search_terms[keyword]);
                            break;                        

                        case "@person":
                        case "@genre":
                        case "@franchise":
                        case "@collection":
                        case "@box":
                        case "@country":  
                            WhereStandardBuilder(ref select_string_builder, keyword, keywords_search_terms[keyword]);
                            break;                        

                        case "@actor":
                        case "@director":
                        case "@writer":
                            WherePersonTypeBuilder(ref select_string_builder, keyword, keywords_search_terms[keyword]);
                            break;                        
  
                        case "@subs":
                        case "@subtitle":
                        case "@spoken":
                            WhereLanguageSpecificBuilder(ref select_string_builder, keyword, keywords_search_terms[keyword]);
                            break;
                        
                        case "@language":
                            WhereLanguageAllBuilder(ref select_string_builder, keywords_search_terms[keyword]);
                            break;

                        case "@rating":
                            WhereRatingAllBuilder(ref select_string_builder, keywords_search_terms[keyword]);
                            break;

                        case "@title":
                            WhereTitleBuilder(ref select_string_builder, keywords_search_terms[keyword]);
                            break;

                        case "@all":
                            WhereAllBuilder(ref select_string_builder, keywords_search_terms[keyword]);
                            break;
                            
                        default:
                            break;
                    }
                }
            }
            else if (!string.IsNullOrWhiteSpace(Search_string))
            {
                List<string> search_term_list = new List<string>(ExtractSearchTerms(Search_string));
                WhereAllBuilder(ref select_string_builder, search_term_list);
            }                                                    
            select_string_builder.AppendFormat("ORDER BY {0}", random_search_order);
            return select_string_builder.ToString();
        }

        //Builds a sub query based on the non-deviating tables
        private void WhereStandardBuilder(ref StringBuilder sub_query_builder ,string keyword, List<string> search_term_list)
        {
            keyword = keyword.Replace("@", "");
            foreach (string search_term_iter in search_term_list)
            {
                string search_term = search_term_iter;
                string remove_string = "";
                CheckSearchTermForFirstDash(ref remove_string, ref search_term);
                sub_query_builder.AppendFormat("AND movie_data.id {2} IN " +
                                                " (SELECT movie_{0}.movie_data_id " +
                                                "         FROM dbo.movie_{0} " +
                                                "         JOIN dbo.{0} " +
                                                "           ON movie_{0}.{0}_id = {0}.id " +
                                                "         WHERE {0}.{0}_name LIKE '%{1}%') ",
                                                keyword, search_term, remove_string);
            }
        }

        // Builds a sub_query based on a search for a specific person in a specific role
        private void WherePersonTypeBuilder(ref StringBuilder sub_query_builder , string keyword, List<string> search_term_list)
        {
            keyword = keyword.Replace("@", "");
            foreach (string search_term_iter in search_term_list)
            {
                string search_term = search_term_iter;
                string remove_string = "";

                CheckSearchTermForFirstDash(ref remove_string, ref search_term);
                sub_query_builder.AppendFormat("AND movie_data.id {2} IN " +
                                                "(SELECT movie_person.movie_data_id " +
                                                "FROM dbo.movie_person " +
                                                "   JOIN dbo.person ON movie_person.person_id = person.id " +
                                                "   JOIN dbo.person_type ON movie_person.person_type_id = person_type.id " +
                                                "WHERE person.person_name LIKE '%{0}%' " +
                                                "   AND person_type.person_type_name LIKE '{1}') ",
                                                search_term, keyword, remove_string);
            }
        }
        
        private void WhereLanguageSpecificBuilder(ref StringBuilder sub_query_builder, string keyword, List<string> search_term_list)
        {
            switch (keyword)
            {
                case "@subtitle":
                case "@subs":
                    keyword = "subtitle";
                    break;
                case "@spoken":
                    keyword = "original";
                    break;
                default:
                    keyword = keyword.Replace("@", "");
                    break;
            }

            foreach (string search_term_iter in search_term_list)
            {
                string search_term = search_term_iter;
                string remove_string = "";

                CheckSearchTermForFirstDash(ref remove_string, ref search_term);
                sub_query_builder.AppendFormat("AND movie_data.id {2} IN " +
                                                "(SELECT {0}_language.movie_data_id " +
                                                "FROM dbo.{0}_language " +
                                                "   JOIN dbo.language ON {0}_language.language_id = language.id " +
                                                "WHERE language.language_name LIKE '%{1}%' ) ",
                                                keyword, search_term, remove_string);
            }
        }

        private void WhereMovieDataTableBuilder(ref StringBuilder sub_query_builder, string keyword, List<string> search_term_list)
        {
            Dictionary<string, List<string>> extracted_search_terms_dict = ExtractSearchTermNumbers(search_term_list);
            if (keyword is "@year" || keyword is "@releaseyear")
            {
                keyword = "release_date";
                extracted_search_terms_dict = ConvertSearchNumbersToDate(extracted_search_terms_dict);
            }
            else
            {
                keyword = MovieDataStandardKeywordFix(keyword);
            }
            WhereMovieDataTableBaseBuilder(ref sub_query_builder, keyword, extracted_search_terms_dict);
        }

        private void WhereMovieDataTableBaseBuilder(ref StringBuilder sub_query_builder, string keyword, Dictionary<string, List<string>> search_dict)
        {
            foreach (string search_type in search_dict.Keys)
            {
                if (search_type is "BetweenHigh") { continue; }

                for (int i = 0; i < search_dict[search_type].Count(); i++)
                {
                    string high_search_term = "";
                    if (search_type is "BetweenLow")
                    {
                        high_search_term = search_dict["BetweenHigh"][i];
                    }
                    string search_term = search_dict[search_type][i];

                    sub_query_builder.AppendFormat("AND movie_data.{0} ", keyword);
                    switch (search_type)
                    {
                        case "GreaterThan":
                            sub_query_builder.AppendFormat(" >= {0} ", search_term);
                            break;
                        case "LesserThan":
                            sub_query_builder.AppendFormat(" <= {0} ", search_term);
                            break;
                        case "BetweenLow":
                            sub_query_builder.AppendFormat(" BETWEEN {0} AND {1} ", search_term, high_search_term);
                            break;
                        case "Exact":
                            sub_query_builder.AppendFormat(" = {0} ", search_term);
                            break;
                    }
                }
            }
        }

        // Builds the where clause for both subtitles and spoken language at the same time
        // The search will result in movies with the searched language in either subtitles or spoken language
        private void WhereLanguageAllBuilder(ref StringBuilder sub_query_builder, List<string> search_term_list)
        {
            StringBuilder string_builder = new StringBuilder();
            string sub_where_query;
            foreach (string search_term_iter in search_term_list)
            {
                string_builder.Clear();
                string search_term = search_term_iter;
                string remove_string = "";

                CheckSearchTermForFirstDash(ref remove_string, ref search_term);
                
                WhereLanguageSpecificBuilder(ref string_builder, "@subtitle", new List<string> { search_term });
                //Removes the first part of the string that is not needed
                sub_where_query = string_builder.ToString().Substring(21);
                string_builder.Clear();

                sub_query_builder.AppendFormat("AND ( movie_data.id {0} IN {1} ", remove_string, sub_where_query);

                WhereLanguageSpecificBuilder(ref string_builder, "@original", new List<string> { search_term });
                // Again
                sub_where_query = string_builder.ToString().Substring(21);
                string_builder.Clear();

                sub_query_builder.AppendFormat("OR movie_data.id {0} IN {1} ) ", remove_string, sub_where_query);
            }
        }

        private void WhereTitleBuilder (ref StringBuilder sub_query_builder, List<string> search_term_list)
        {


            foreach (string search_term in search_term_list)
            {
                sub_query_builder.AppendFormat("AND movie_data.id IN " +
                                                "(SELECT movie_title.movie_data_id " +
                                                "FROM dbo.movie_title " +
                                                "WHERE movie_title.title LIKE '%{0}%') ",
                                                search_term);
            }
        }

        private void WhereRatingAllBuilder(ref StringBuilder sub_query_builder, List<string> search_term_list)
        {
            StringBuilder imdb_stringBuilder = new StringBuilder();
            StringBuilder metacritic_stringBuilder = new StringBuilder();
            foreach (string search_term in search_term_list)
            {
                imdb_stringBuilder.Clear();
                metacritic_stringBuilder.Clear();
                List<string> list = new List<string>() {search_term};
                Dictionary<string, List<string>> imdb_search_dict = ConvertNumbersForRatingSearch(
                                                                    ExtractSearchTermNumbers(list), "imdb");
                Dictionary<string, List<string>> metacritic_search_dict = ConvertNumbersForRatingSearch(
                                                                    ExtractSearchTermNumbers(list), "metacritic");
                WhereMovieDataTableBaseBuilder(ref imdb_stringBuilder, "imdb_score", imdb_search_dict);
                WhereMovieDataTableBaseBuilder(ref metacritic_stringBuilder, "metacritic_score", metacritic_search_dict);
                sub_query_builder.AppendFormat(" AND ( {0} OR {1} ) ", 
                                                imdb_stringBuilder.ToString().Substring(3),
                                                metacritic_stringBuilder.ToString().Substring(3));
            }
        }

        private void WhereAllBuilder (ref StringBuilder sub_query_builder, List<string> search_term_list)
        {
            StringBuilder string_builder = new StringBuilder();
            string sub_where_query;
            
            // List of the keywords corresponding to standard tables
            List<string> standard_keyword_list = new List<string>()
            { 
                "@person",
                "@genre",
                "@franchise",
                "@collection",
                "@box",
                "@country"
            };

            for (int i = 0; i < search_term_list.Count; i++)
            {
                string_builder.Clear();
                string search_term = search_term_list[i];
                string remove_string = "";
                string first_through_string = "";
                

                CheckSearchTermForFirstDash(ref remove_string, ref search_term);
                // First part of the AND connecting all the upcoming SELECTs
                sub_query_builder.AppendFormat(" AND {0} ( ", remove_string);

                for (int j = 0; j < standard_keyword_list.Count; j++)
                {
                    // the first through does not need an OR
                    if (j > 0) { first_through_string = "OR "; }
                    WhereStandardBuilder(ref string_builder, standard_keyword_list[j], new List<string> { search_term });
                    //Removes the first part of the string that is not needed
                    sub_where_query = string_builder.ToString().Substring(21);
                    string_builder.Clear();

                    sub_query_builder.AppendFormat(" {0} movie_data.id IN {1} ", first_through_string, sub_where_query);
                }

                WhereTitleBuilder(ref string_builder, new List<string> { search_term });
                sub_where_query = string_builder.ToString().Substring(20);

                sub_query_builder.AppendFormat(" OR movie_data.id IN {0} ", sub_where_query);

                sub_query_builder.Append(" ) ");
            }
        }

        private void CheckSearchTermForFirstDash (ref string remove_string, ref string search_term)
        {
            if (search_term.Substring(0, 1) is "-" && search_term.Length > 1)
            {
                remove_string = "NOT ";
                search_term = search_term.Substring(1);
            }
        }

        private void SearchForKeywords(string search_string)
        {
            List<string> keys = new List<string>(Search_keywords_dict.Keys);
            foreach (string keyword in keys)
            {
                if (search_string.ToLower().Contains(keyword))
                {
                    Has_keywords = true;
                    Search_keywords_dict[keyword] = true;
                    /* 
                     Here first the search under a specific keyword is extracted (KeywordSearchString)
                     after which the individual search terms are put in a list (ExtractSearchTerms)
                     and added to a dict with the keyword as key.
                    */
                    Keywords_search_terms.Add(keyword, ExtractSearchTerms(
                        KeywordSearchString(keyword, search_string)));
                }
            }
        }

        // returns a string of search terms related to a given keyword
        private string KeywordSearchString(string keyword, string search_string)
        {
            StringBuilder string_builder = new StringBuilder();
            // Regex Explanation:
            // "keyword ([^@]*)" any combination of characters between the keyword and the next '@'
            foreach (Match match in Regex.Matches(search_string, keyword + " ([^@]*)"))
            {
                string_builder.AppendFormat("{0} ", match.Groups[1].ToString());
            }
            return string_builder.ToString();
        }

        // extract individual search terms from a search string
        private List<string> ExtractSearchTerms(string search_string)
        {
            List<string> search_terms = new List<string>();
            /* Regex Explanation:
            Group 1 -> "-?\".+\""                           - any number of any character between 2 quotation marks 
                                                            with a potential first dash
            Group 2 - ([a-zA-Z]+)                           - any number of letters, dashes or commas in one continuous string
            Group 3 - ((\>|\<)?\d+((\,|\.)\d)?              - any number (potentially 1 decimal) that is either for itself or with a ">"|"<" in front OR
                      | \d+((\,|\.)\d)?-\d+((\,|\.)\d)? )   - any number (potentially 1 decimal) with a dash
                                                            followed by any number (potentially 1 decimal)
            */
            string group_1 = "-?\".+\"";
            string group_2 = @"[a-zA-Z\-\,]+";
            string group_3 = @"(>|<)?\d+((,|\.)\d)? |\d+((,|\.)\d)?-\d+((,|\.)\d)? ";            
            foreach (Match match in Regex.Matches(search_string, string.Format("(({0})|({1})|({2}))", group_1, group_2, group_3)))
            {
                // First replace removes any double qoutationmarks (but leaving the first dash if present)
                // Second replace escapes single qoutes for the sql string
                search_terms.Add(match.Groups[1].ToString().Replace("\"", "").Replace("'", "''").TrimEnd());
            }
            return search_terms;
        }

        private Dictionary<string, List<string>> ExtractSearchTermNumbers(List<string> search_term_list)
        {
            Dictionary<string, List<string>> keyValues = SearchNumbersDict();

            foreach (string search_term in search_term_list)
            {
                string search_term_fix = search_term.Replace(",", ".");
                if (search_term_fix.Substring(0,1) is ">")
                {
                    keyValues["GreaterThan"].Add(search_term_fix.Substring(1));
                }
                else if (search_term_fix.Substring(0,1) is "<")
                {
                    keyValues["LesserThan"].Add(search_term_fix.Substring(1));
                }
                // if there's a dash split them and add the numbers 
                else if (search_term_fix.IndexOf("-") >= 0)
                {
                    // Checks whether if the parts are actually numbers
                    if (!(IsNumeric(search_term_fix.Split('-')[0]) && IsNumeric(search_term_fix.Split('-')[1]))) { continue; }
                    // converts the string to number and sorts them
                    double part_0 = double.Parse(search_term_fix.Split('-')[0], NumberStyles.Any, NumberFormatInfo.InvariantInfo);
                    double part_1 = double.Parse(search_term_fix.Split('-')[1], NumberStyles.Any, NumberFormatInfo.InvariantInfo);
                    //CultureInfo.InvariantCulture makes sure that the string contains a . as decimal seperator instead of ,
                    if (part_0 > part_1)
                    {
                        keyValues["BetweenHigh"].Add(part_0.ToString(CultureInfo.InvariantCulture));
                        keyValues["BetweenLow"].Add(part_1.ToString(CultureInfo.InvariantCulture));
                    }
                    else if (part_1 > part_0)
                    {
                        keyValues["BetweenHigh"].Add(part_1.ToString(CultureInfo.InvariantCulture));
                        keyValues["BetweenLow"].Add(part_0.ToString(CultureInfo.InvariantCulture));
                    }
                    // if the numbers are the same, put one in the exact category
                    else
                    {
                        keyValues["Exact"].Add(part_0.ToString(CultureInfo.InvariantCulture));
                    }
                }
                else if (IsNumeric(search_term_fix))
                {
                    keyValues["Exact"].Add(search_term_fix);
                }
            }
            return keyValues;
        }

        private Dictionary<string, List<string>> ConvertSearchNumbersToDate(Dictionary<string, List<string>> search_dict)
        {
            Dictionary<string, List<string>> new_search_dict = SearchNumbersDict();
            foreach (string keyword in search_dict.Keys)
            {
                foreach (string search_term in search_dict[keyword])
                {
                    string new_search_term = string.Format("'{0}-01-01'", search_term);
                    
                    switch (keyword)
                    {
                        case "Exact":
                            string new_high_search = string.Format("'{0}-12-31'", search_term);
                            new_search_dict["BetweenLow"].Add(new_search_term);
                            new_search_dict["BetweenHigh"].Add(new_high_search);
                            break;
                        case "BetweenHigh":
                            new_search_term = string.Format("'{0}-12-31'", search_term);
                            new_search_dict[keyword].Add(new_search_term);
                            break;
                        default:
                            new_search_dict[keyword].Add(new_search_term);
                            break;
                    }
                }
            }
            return new_search_dict;
        }

        private Dictionary<string, List<string>> ConvertNumbersForRatingSearch (Dictionary<string, List<string>> search_dict, string rating_type)
        {
            Dictionary<string, List<string>> new_search_dict = SearchNumbersDict();
            foreach (string keyword in search_dict.Keys)
            {
                foreach (string search_term in search_dict[keyword])
                {
                    double search_num = double.Parse(search_term, NumberStyles.Any, NumberFormatInfo.InvariantInfo);
                    if (rating_type is "imdb" && search_num > 10)
                    {
                        search_num /=  10;
                    }
                    else if (rating_type is "metacritic" && search_num < 10)
                    {
                        search_num *= 10;
                    }
                    new_search_dict[keyword].Add(search_num.ToString(CultureInfo.InvariantCulture));
                }
            }
            return new_search_dict;
        }

        // from user GlorFindel here - https://stackoverflow.com/questions/894263/identify-if-a-string-is-a-number
        public static bool IsNumeric(object Expression)
        {
            double retNum;

            bool isNum = double.TryParse(Convert.ToString(Expression), NumberStyles.Any, NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        private string MovieDataStandardKeywordFix(string keyword)
        {
            switch (keyword)
            {
                case "@meta":
                case "@metacritic":
                    keyword = "metacritic_score";
                    break;
                case "@imdb":
                case "@imdbscore":
                    keyword = "imdb_score";
                    break;
                case "@time":
                case "@minutes":
                case "@runtime":
                    keyword = "run_time";
                    break;
            }
            return keyword;
        }

        private Dictionary<string, List<string>> SearchNumbersDict()
        {
            return new Dictionary<string, List<string>>()
            {
                { "GreaterThan", new List<string>() },
                { "LesserThan", new List<string>() },
                { "BetweenHigh", new List<string>() },
                { "BetweenLow", new List<string>() },
                { "Exact", new List<string>() },
            };
        }
    }
}
