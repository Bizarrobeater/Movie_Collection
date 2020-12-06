using MovieCollection.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieCollection
{
    public partial class NewMovieForm : Form
    {
        MainForm main_form;
        private NewMovie new_movie;
        string active_new_data;
        
        public MainForm Main_form { get => main_form; set => main_form = value; }
        internal NewMovie New_movie { get => new_movie; set => new_movie = value; }

        public NewMovieForm(MainForm mainform)
        {
            Main_form = mainform;
            InitializeComponent();
            New_movie = new NewMovie();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Shows mainform again at this forms position and closes this one
        private void BackButton_Click(object sender, EventArgs e)
        {
            Main_form.Show();
            Main_form.StartPosition = FormStartPosition.Manual;
            Main_form.Location = this.Location;
            this.Close();
        }

        // Functionality for moving the form by clicking and dragging the top of the window
        private bool mouseDown;
        private Point lastLocation;

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        // Moving window Functionality end

        // Standard buttons click functions
        private void BaseDataButton_Click(object sender, EventArgs e)
        {
            if (UpdateNewMovie())
            {
                UpdateUserControls(BaseDataControl);
                active_new_data = "BaseData";
                //fill textboxes with current data
                var bdc = BaseDataControl;
                var nmbd = New_movie.Base_data;
                bdc.ImdbId = nmbd.Imdb_id;
                bdc.ReleaseDate = nmbd.Release_date;
                bdc.ImdbScore = nmbd.Imdb_score;//.Replace('.', ',');
                bdc.MetacriticScore = nmbd.Metacritic_score;
                bdc.RunTime = nmbd.Run_time;
            }
        }

        private void TitleButton_Click(object sender, EventArgs e)
        {
            if (UpdateNewMovie())
            {
                UpdateUserControls(TitleControl);
                active_new_data = "Title";
            }
        }

        private void GenreButton_Click(object sender, EventArgs e)
        {
            if (UpdateNewMovie())
            {
                UpdateUserControls(StandardDataControl);
                UpdateStandardControl("Genre", "Genres", New_movie.Genre_set.Data_list);
            }

        }

        private void BoxButton_Click(object sender, EventArgs e)
        {
            if (UpdateNewMovie())
            {
                UpdateUserControls(OneLineDataControl);
                UpdateOneDataControl("Box", New_movie.Box_set.Data_list);
            }
        }

        private void CountryButton_Click(object sender, EventArgs e)
        {
            if (UpdateNewMovie())
            {
                UpdateUserControls(StandardDataControl);
                UpdateStandardControl("Country", "Countries", New_movie.Country_set.Data_list);
            }
        }
        
        private void LanguageButton_Click(object sender, EventArgs e)
        {
            if (UpdateNewMovie())
            {
                UpdateUserControls(StandardDataControl);
                UpdateStandardControl("Language", "Spoken Languages", New_movie.Spoken_set.Data_list);
            }
        }
      
        private void ActorButton_Click(object sender, EventArgs e)
        {
            if (UpdateNewMovie())
            {
                UpdateUserControls(StandardDataControl);
                UpdateStandardControl("Actor", "Actors", New_movie.Actor_set.Data_list);
            }
        }

        private void DirectorButton_Click(object sender, EventArgs e)
        {
            if (UpdateNewMovie())
            {
                UpdateUserControls(StandardDataControl);
                UpdateStandardControl("Director", "Directors", New_movie.Director_set.Data_list);
            }
        }

        private void WriterButton_Click(object sender, EventArgs e)
        {
            if (UpdateNewMovie())
            {
                UpdateUserControls(StandardDataControl);
                UpdateStandardControl("Writer", "Writers", New_movie.Writer_set.Data_list);
            }
        }
        private void FranchiseButton_Click(object sender, EventArgs e)
        {
            if (UpdateNewMovie())
            {
                UpdateUserControls(StandardDataControl);
                UpdateStandardControl("Franchise", "Franchises", New_movie.Franchise_set.Data_list);
            }
        }

        private void SubtitleButton_Click(object sender, EventArgs e)
        {
            if (UpdateNewMovie())
            {
                UpdateUserControls(StandardDataControl);
                UpdateStandardControl("Subtitle", "Subtitle Languages", New_movie.Subtitle_set.Data_list);
            }
        }

        private void CollectionButton_Click(object sender, EventArgs e)
        {
            if (UpdateNewMovie())
            {
                UpdateUserControls(OneLineDataControl);
                UpdateOneDataControl("Collection", New_movie.Collection_set.Data_list);
            }
        }
        // Standard buttons click functions - end


        private bool people_button_enabled = false;
        private void PeopleButton_Click(object sender, EventArgs e)
        {
            if (people_button_enabled)
            {
                BackPeopleButton_Click(sender, e);
                people_button_enabled = false;
            }
            else
            {
                OptionalGroupBox.Visible = false;
                OptionalGroupBox.Enabled = false;

                PeopleGroupBox.Visible = true;
                PeopleGroupBox.Enabled = true;
                people_button_enabled = true;
            }
        }
        private void BackPeopleButton_Click(object sender, EventArgs e)
        {

            OptionalGroupBox.Visible = true;
            OptionalGroupBox.Enabled = true;

            PeopleGroupBox.Visible = false;
            PeopleGroupBox.Enabled = false;
            people_button_enabled = false;
        }

        private void UpdateStandardControl(string type, string plural_type, List<string> data_list)
        {

            StandardDataControl.HeadlineLabelText = plural_type;
            StandardDataControl.TitleLabelText = type.ToLower();

            StringBuilder string_builder = new StringBuilder();
            foreach (string data in data_list)
            {
                string_builder.AppendFormat("{0}{1}", data, Environment.NewLine);
            }
            StandardDataControl.RichTextBoxTextContent = string_builder.ToString().Trim(Environment.NewLine.ToCharArray());
            active_new_data = type;
        }

        private void UpdateOneDataControl(string type, List<string> data_list)
        {
            OneLineDataControl.HeadlineLabelText = type;
            if (data_list.Count > 0)
            {
                OneLineDataControl.TextBoxText = data_list[0];
            }
            else
            {
                OneLineDataControl.TextBoxText = "";
            }
            active_new_data = type;
        }

        private bool UpdateNewMovie()
        {
            var nm = New_movie;

            switch (active_new_data)
            {
                case "BaseData":
                    return AddBaseDate();                    
                case "Title":
                    return true;
                case "Genre":
                    return AddGenreData();
                case "Box":
                    AddOneItemList(nm.Box_set);
                    return true;
                case "Country":
                    AddStandardDataList(nm.Country_set);
                    return true;
                case "Language":
                    AddStandardDataList(nm.Spoken_set);
                    return true;
                case "Actor":
                    AddStandardDataList(nm.Actor_set);
                    return true;
                case "Director":
                    AddStandardDataList(nm.Director_set);
                    return true;
                case "Writer":
                    AddStandardDataList(nm.Writer_set);
                    return true;
                case "Franchise":
                    AddStandardDataList(nm.Franchise_set);
                    return true;
                case "Subtitle":
                    AddStandardDataList(nm.Subtitle_set);
                    return true;
                case "Collection":
                    AddOneItemList(nm.Collection_set);
                    return true;
                default:
                    return true;
            }
        }

        // Add title button - either adds title or tells why it was rejected
        private void AddTitleButton_Click(object sender, EventArgs e)
        {
            var tc = TitleControl;
            bool title_added = New_movie.AddNewTitle(
                                        tc.Title,
                                        tc.TitleLanguage,
                                        tc.OriginalTitle);
            if (title_added)
            {
                tc.OriginalTitle = false;
                tc.Title = "";
                tc.TitleLanguage = "";
            }
            else
            {
                //Message if you are trying to add an original title, but such one has already been added
                if (tc.OriginalTitle)
                {
                    MessageBox.Show("An original title has already been added.");
                }
                // message if the user didn't fill out title or language
                else if (string.IsNullOrWhiteSpace(tc.Title) || string.IsNullOrWhiteSpace(tc.TitleLanguage))
                {
                    MessageBox.Show("Please fill out both title and language");
                }
                // if the title has already been added
                else
                {
                    MessageBox.Show("Title has already been added");
                }
            }
        }
            
        // A way to update the visible usercontrol
        private UserControl current_user_control;
        private void UpdateUserControls(UserControl new_user_control)
        {
            if (new_user_control != current_user_control)
            {
                if (current_user_control != null)
                {
                    current_user_control.Visible = false;
                    current_user_control.Enabled = false;
                }

                new_user_control.Visible = true;
                new_user_control.Enabled = true;
                current_user_control = new_user_control;

                // Extra button outside the usercontrol - is enabled/visible same with the control Titlecontrol
                AddTitleButton.Visible = (new_user_control == TitleControl);
                AddTitleButton.Enabled = (new_user_control == TitleControl);
            }          
        }

        private bool AddBaseDate()
        {
            var bdc = BaseDataControl;
            Dictionary<string, string> keyValues = new Dictionary<string, string>()
                    {
                        { "imdb_id", bdc.ImdbId.Trim() },
                        { "release_date", bdc.ReleaseDate.Trim().Trim('-') },
                        { "imdb_score", bdc.ImdbScore.Trim().Trim('0').TrimEnd(',') },
                        { "metacritic_score", bdc.MetacriticScore.Trim() },
                        { "run_time", bdc.RunTime.Trim() }
                    };
            List<string> not_accepted_data = New_movie.AddBaseData(keyValues);
            
            // if all data is accepted, let the menu change (also the data has been added)
            if (not_accepted_data.Count == 0)
            {
                return true;
            }
            // if theres 1-4 datapoints that has a problem, don't change and tell the user which ones it is
            else if (not_accepted_data.Count > 0 && not_accepted_data.Count < 5)
            {
                StringBuilder message = new StringBuilder();
                message.Append("Something is wrong with the following data ");
                foreach (string data in not_accepted_data)
                {
                    message.AppendFormat("{0}{1}", Environment.NewLine, data);
                }
                message.AppendFormat("{0}Please fix", Environment.NewLine);
                MessageBox.Show(message.ToString());
                return false;
            }
            // if all the data is wrong, change the menu (but don't add the data)
            else
            {
                return true;
            }
        }

        private bool AddGenreData()
        {
            List<string> genre_list = StandardDataControl.TextBoxTextList;

            if (genre_list.Count > 3)
            {
                DialogResult dialog_result = MessageBox.Show("You're about to add more than 3 genres, confirm this.", "Genre amount!", MessageBoxButtons.OKCancel);
                if (dialog_result != DialogResult.OK)
                {
                    return false;
                }
            }

            if (genre_list.Count > 0)
            {
                New_movie.AddStandardData(genre_list, New_movie.Genre_set);
            }
            return true;
        }

        private void AddStandardDataList(StandardDataSet standard_data_set)
        {
            List<string> data_list = StandardDataControl.TextBoxTextList;
            if (data_list.Count > 0)
            {
                New_movie.AddStandardData(data_list, standard_data_set);
            }
            else
            {
                standard_data_set.RemoveData();
            }
        }

        private void AddOneItemList(StandardDataSet standard_data_set)
        {
            List<string> data_list = OneLineDataControl.TextBoxTextList;
            if (data_list.Count > 0)
            {
                New_movie.AddStandardData(data_list, standard_data_set);
            }
            else
            {
                standard_data_set.RemoveData();
            }
        }

        private void CheckDataButton_Click(object sender, EventArgs e)
        {
            UpdateNewMovie();

            var nm = new_movie;

            // Checks if all the data required are there, shows a messagebox and stops the method if not
            if (MissingData(out List<string> missing_data))
            {
                AddMovieButton.Enabled = false;
                StringBuilder message_builder = new StringBuilder();
                message_builder.Append("The following data is missing \n");
                foreach (string data in missing_data)
                {
                    message_builder.AppendFormat("{0}{1}", data, Environment.NewLine);
                }
                message_builder.Append("Fix before continuing");
                MessageBox.Show(message_builder.ToString());
                return;
            }
            else
            {
                AddMovieButton.Enabled = true;
            }
        }

        private bool MissingData(out List<string> missing_data)
        {
            missing_data = new List<string>();
            bool is_missing = false;

            var nm = new_movie;
            if (nm.Base_data.Imdb_id == null)
            {
                missing_data.Add("Base data");
                is_missing = true;
            }
            if (!nm.CheckForOriginalTitle())
            {
                missing_data.Add("An original title");
                is_missing = true;
            }
            if (nm.Actor_set.Data_list.Count == 0)
            {
                missing_data.Add("Actor data");
                is_missing = true;
            }
            if (nm.Director_set.Data_list.Count == 0)
            {
                missing_data.Add("Director data");
                is_missing = true;
            }
            if (nm.Writer_set.Data_list.Count == 0)
            {
                missing_data.Add("Writer data");
                is_missing = true;
            }
            if (nm.Genre_set.Data_list.Count == 0)
            {
                missing_data.Add("Genre data");
                is_missing = true;
            }
            if (nm.Box_set.Data_list.Count == 0)
            {
                missing_data.Add("Box data");
                is_missing = true;
            }
            if (nm.Country_set.Data_list.Count == 0)
            {
                missing_data.Add("Country data");
                is_missing = true;
            }
            if (nm.Spoken_set.Data_list.Count == 0)
            {
                missing_data.Add("Spoken Language data");
                is_missing = true;
            }

            return is_missing;
        }

        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            new_movie.AddNewMovie();
        }
    }
}
