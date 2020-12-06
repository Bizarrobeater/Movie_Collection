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
    public partial class NewMovieStandardDataControl : UserControl
    {
        public NewMovieStandardDataControl()
        {
            InitializeComponent();
        }

        public RichTextBox StandardDataRichTextBox
        {
            get
            {
                return StandardDataRichTextbox;
            }
            set
            {
                StandardDataRichTextbox = value;
            }
        }

        public string RichTextBoxTextContent
        {
            set
            {
                StandardDataRichTextbox.Text = value;
            }
        }

        public List<string> TextBoxTextList
        {
            get
            {
                List<string> raw_data_list = new List<string>();
                List<string> data_list = new List<string>();
                data_list.Clear();
                raw_data_list.Clear();
                raw_data_list.AddRange(StandardDataRichTextbox.Lines);
                foreach (string data in raw_data_list)
                {
                    if (!string.IsNullOrWhiteSpace(data))
                    {
                        data_list.Add(data.Trim());
                    }
                }
                return data_list;
            }
        }

        public string HeadlineLabelText
        {
            set
            {
                HeadLineLabel.Text = value;
            }
        }

        public string TitleLabelText
        {
            set
            {
                TitleLabel.Text = string.Format("Add one {0} per line", value);
            }
        }

    }
}
