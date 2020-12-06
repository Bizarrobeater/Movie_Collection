using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace MovieCollection
{
    public partial class NewMovieBaseData : UserControl
    {
        public NewMovieBaseData()
        {
            InitializeComponent();
        }

        public string ImdbId
        {
            get
            {
                return ImdbIdMskTxtBox.Text;
            }
            set
            {
                ImdbIdMskTxtBox.Text = value;
            }
        }

        public string ReleaseDate
        {
            get
            {
                return ReleaseDateMskTxtBox.Text;
            }
            set
            {
                ReleaseDateMskTxtBox.Text = value;
            }
        }

        public string ImdbScore
        {
            get
            {
                return ImdbScoreMskTxtBox.Text.Replace(',', '.');
            }
            set
            {
                if (double.TryParse(value, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out double result))
                {
                    ImdbScoreMskTxtBox.Text = result.ToString("00.0");
                }
                else
                {
                    ImdbScoreMskTxtBox.Text = null;
                }
            }
        }

        public string MetacriticScore
        {
            get
            {
                return MetaScoreMskTxtBox.Text;
            }
            set
            {
                MetaScoreMskTxtBox.Text = value;
            }
        }

        public string RunTime
        {
            get
            {
                return RunTimeMskTxtBox.Text;
            }
            set
            {
                RunTimeMskTxtBox.Text = value;
            }
        }

    }
}
