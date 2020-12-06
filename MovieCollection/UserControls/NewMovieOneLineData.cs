using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieCollection.UserControls
{
    public partial class NewMovieOneLineData : UserControl
    {
        public NewMovieOneLineData()
        {
            InitializeComponent();
        }

        public string HeadlineLabelText
        {
            set
            {
                HeadLineLabel.Text = value + " Name";
            }
        }
        
        public string TextBoxText
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }

        public List<string> TextBoxTextList
        {
            get
            {
                List<string> vs = new List<string>()
                {
                    textBox1.Text
                };
                return vs;
            }
        }

    }
}
