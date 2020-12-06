using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection
{
    public class TitleWords
    {
        readonly Dictionary<string, List<string>> lowercase_word_list = new Dictionary<string, List<string>>()
        {
            { "English", new List<string>()
                {
                    "a", "an", "the", "and", "or", "into",
                    "for", "of", "v", "vs", "v.", "vs.", "to",
                    "nor", "at", "from", "by", "but", "is", "are",
                    "from", "on", "your"
                }
            },
            {
                "Danish", new List<string>()
                {
                    "er", "de", "på", "om", "af", "og", "om", "i",
                    "hvor", "end", "til", "den"
                }
            }
        };
        readonly List<string> roman_numerals = new List<string>()
        {
            "I", "II", "III", "IV", "V",
            "VI", "VII", "VIII", "IX", "X"
        };

        public Dictionary<string, List<string>> Lowercase_word_list => lowercase_word_list;

        public List<string> Roman_numerals => roman_numerals;

        public List<string> GetLowerCaseWordsOrDefault(string key)
        {
            if (Lowercase_word_list.Keys.Contains(key))
            {
                return Lowercase_word_list[key];
            }
            else
            {
                return new List<string>();
            }
        }

        public string CapitaliseFirstLetter(string word)
        {
            if (word.Length > 0)
            {
                return word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
            }

            return word;
        }

        public string ConvertToTitleCase(string title, string title_language)
        {
            StringBuilder new_title = new StringBuilder();
            string sub_title_delimiter = "";

            List<string> lower_case_word_list = GetLowerCaseWordsOrDefault(title_language);
            List<string> roman_numerals = Roman_numerals;

            if (TestForSubTitle(ref sub_title_delimiter, title))
            {
                //splits the string in 2 at the first occurence of the delimiter
                List<string> sub_title_list = title.Split(new string[] { sub_title_delimiter }, 2, StringSplitOptions.None).ToList();
                for (int i = 0; i < sub_title_list.Count(); i++)
                {
                    //sub titles are converted in the same way as main titles and put together again
                    string sub_title = sub_title_list[i];
                    new_title.Append(ConvertToTitleCase(sub_title, title_language));
                    if (i != sub_title_list.Count() - 1)
                    {
                        new_title.Append(sub_title_delimiter);
                    }
                    else
                    {
                        new_title.Append(" ");
                    }
                }
            }
            // in case of no sub titles
            else
            {
                List<string> title_as_list = title.Split().ToList();
                for (int i = 0; i < title_as_list.Count(); i++)
                {
                    bool capitalise = true;
                    string word = title_as_list[i];

                    // if a word contains a dash
                    // split the word and capitalise both ends
                    // and continue to next word
                    if (word.IndexOf("-") > 0)
                    {
                        new_title.AppendFormat("{0}-{1} ",
                                               CapitaliseFirstLetter(word.Split('-')[0]),
                                               CapitaliseFirstLetter(word.Split('-')[1]));
                        continue;
                    }
                    // the word should be capitalised if it the first or last word in the title
                    if (i != 0 && i != title_as_list.Count - 1)
                    {
                        // if the word is in the provided wordlist - don't capitalise
                        if (lower_case_word_list.Contains(word.ToLower()))
                        {
                            capitalise = false;
                        }
                    }
                    //if the word is a roman numeral AND is the last word of a title/sub title, capitalise fully
                    //else if the word should be capitalised - do that - else lower
                    if (roman_numerals.Contains(word.ToUpper()) && i == title_as_list.Count - 1)
                    {
                        new_title.AppendFormat("{0} ", word.ToUpper());
                    }
                    else if (capitalise)
                    {
                        new_title.AppendFormat("{0} ", CapitaliseFirstLetter(word));
                    }
                    else
                    {
                        new_title.AppendFormat("{0} ", word.ToLower());
                    }
                }
            }
            return new_title.ToString().TrimEnd();
        }

        // Checks whether or not a title as a sub-title and returns the title and delimiter 
        private bool TestForSubTitle(ref string delimiter, string title)
        {
            bool subtitle_exist = true;
            if (title.IndexOf(": ") > 0)
            {
                delimiter = ": ";
            }
            else if (title.IndexOf(" - ") > 0)
            {
                delimiter = " - ";
            }
            else
            {
                subtitle_exist = false;
            }
            return subtitle_exist;
        }

    }
}
