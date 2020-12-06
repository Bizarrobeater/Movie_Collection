using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MovieCollection.UserControls
{
    public partial class NewMovieTitle : UserControl
    {
        public NewMovieTitle()
        {
            InitializeComponent();
        }

        public string Title
        {
            get
            {
                return TitleTextBox.Text;
            }
            set
            {
                TitleTextBox.Text = value;
            }
        }

        public string TitleLanguage
        {
            get
            {
                return LanguageTextBox.Text;
            }
            set
            {
                LanguageTextBox.Text = value;
            }
        }

        public bool OriginalTitle
        {
            get
            {
                return (OriginalTitleCheckBox.Checked);
            }
            set
            {
                if (value == true)
                {
                    OriginalTitleCheckBox.CheckState = CheckState.Checked;
                }
                else
                {
                    OriginalTitleCheckBox.CheckState = CheckState.Unchecked;
                }
            }
        }
    }
}
