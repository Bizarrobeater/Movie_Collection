using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace MovieCollection
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Search search = new Search("");
            FillDataGridView(search.RetrieveSelectString());
            LastWatchedDatePicker.Value = DateTime.Now;
        }
        private void CloseButton_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void FillDataGridView(string select_string)
        {
            string connection_string = new ExecuteSQLCommand().ConnectionString;
            SqlDataAdapter data_adapter = new SqlDataAdapter(select_string, connection_string);
            DataSet data_set = new DataSet();
            data_adapter.Fill(data_set);
            MovieDataGridView.ReadOnly = true;
            MovieDataGridView.DataSource = data_set.Tables[0];
            MovieDataGridView.Columns["id"].Visible = false;
            MovieDataGridView.Columns[1].Width = 161;
            MovieDataGridView.Columns[2].Width = 40;
            MovieDataGridView.Columns[3].Width = 40;
            MovieDataGridView.Columns[4].Width = 60;
            MovieDataGridView.Columns[5].Width = 68;
            MovieDataGridView.Columns[6].Width = 68;
            MovieDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            MovieDataGridView.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            int results_count = MovieDataGridView.Rows.Count;
            string result_s = "s";
            if (results_count == 1) { result_s = ""; }

            ResultLabel.Text = string.Format("Found {0} result{1}", results_count, result_s);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            MovieDataGridView.ClearSelection();
            Search search = new Search(SearchField.Text);
            FillDataGridView(search.RetrieveSelectString());
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            MovieDataGridView.ClearSelection();
            Search search = new Search(SearchField.Text)
            {
                Random_search = true, 
            };
            FillDataGridView(search.RetrieveSelectString());
        }

        // takes selected rows and updates the last watched date
        private void LastWatchedButton_Click(object sender, System.EventArgs e)
        {
            // gets amount of rows selected
            Int32 selected_row_count =
                MovieDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);

            StringBuilder dialog_string = new StringBuilder();
            
            List<string> id_list = new List<string>();
            string watched_date = LastWatchedDatePicker.Value.Date.ToString("yyyy-MM-dd");
            
            if (selected_row_count > 0)
            {
                dialog_string.AppendFormat("Have you watched the following movies{1}on the {0}?{1}",
                                            watched_date,
                                            Environment.NewLine);
                for (int i = 0; i < selected_row_count; i++)
                {
                    // adds movie_id to list and adds name to string
                    id_list.Add(MovieDataGridView.SelectedRows[i].Cells["id"].Value.ToString());
                    dialog_string.AppendFormat("{0}{1}",
                        MovieDataGridView.SelectedRows[i].Cells["Original Title"].Value.ToString(),
                        Environment.NewLine);
                }
            }
            // confirmation dialog showing selected movies and date
            DialogResult dialog_result = MessageBox.Show(dialog_string.ToString(), "Add Watched Date?", MessageBoxButtons.OKCancel);
            switch (dialog_result)
            {
                case DialogResult.OK:
                    LastWatchedUpdate last_watched_update = new LastWatchedUpdate(id_list, watched_date);
                    new ExecuteSQLCommand().Execute(last_watched_update.InsertStringBuilder());
                    //ExecuteSQLCommand(last_watched_update.InsertStringBuilder());
                    // Virtually presses the search button to update data
                    SearchButton.PerformClick();
                    break;
                case DialogResult.Cancel:
                    break;
                default:
                    break;
            }
        }

        // if Enter is clicked in the search field - the search button is pressed
        private void SearchField_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SearchButton.PerformClick();
            }
        }
        
        private void MainForm_Click(object sender, EventArgs e)
        {
            MovieDataGridView.ClearSelection();
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

        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            NewMovieForm newMovieForm = new NewMovieForm(mainform: this)
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };
            newMovieForm.Show();
            this.Hide();
        }
    }
}
