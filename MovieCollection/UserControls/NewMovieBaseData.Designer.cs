namespace MovieCollection
{
    partial class NewMovieBaseData
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImdbIDLabel = new System.Windows.Forms.Label();
            this.MetaScoreMskTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.ReleaseDateLabel = new System.Windows.Forms.Label();
            this.ImdbScoreLabel = new System.Windows.Forms.Label();
            this.MetacriticScoreLabel = new System.Windows.Forms.Label();
            this.RunTimeLabel = new System.Windows.Forms.Label();
            this.HeadLineLabel = new System.Windows.Forms.Label();
            this.ImdbScoreMskTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.ImdbIdMskTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.RunTimeMskTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.ReleaseDateMskTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // ImdbIDLabel
            // 
            this.ImdbIDLabel.AutoSize = true;
            this.ImdbIDLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ImdbIDLabel.Location = new System.Drawing.Point(5, 32);
            this.ImdbIDLabel.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.ImdbIDLabel.Name = "ImdbIDLabel";
            this.ImdbIDLabel.Size = new System.Drawing.Size(42, 13);
            this.ImdbIDLabel.TabIndex = 0;
            this.ImdbIDLabel.Text = "Imdb Id";
            // 
            // MetaScoreMskTxtBox
            // 
            this.MetaScoreMskTxtBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MetaScoreMskTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MetaScoreMskTxtBox.Location = new System.Drawing.Point(97, 98);
            this.MetaScoreMskTxtBox.Mask = "009";
            this.MetaScoreMskTxtBox.Name = "MetaScoreMskTxtBox";
            this.MetaScoreMskTxtBox.Size = new System.Drawing.Size(114, 20);
            this.MetaScoreMskTxtBox.TabIndex = 1;
            // 
            // ReleaseDateLabel
            // 
            this.ReleaseDateLabel.AutoSize = true;
            this.ReleaseDateLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ReleaseDateLabel.Location = new System.Drawing.Point(5, 55);
            this.ReleaseDateLabel.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.ReleaseDateLabel.Name = "ReleaseDateLabel";
            this.ReleaseDateLabel.Size = new System.Drawing.Size(72, 13);
            this.ReleaseDateLabel.TabIndex = 0;
            this.ReleaseDateLabel.Text = "Release Date";
            // 
            // ImdbScoreLabel
            // 
            this.ImdbScoreLabel.AutoSize = true;
            this.ImdbScoreLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ImdbScoreLabel.Location = new System.Drawing.Point(5, 78);
            this.ImdbScoreLabel.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.ImdbScoreLabel.Name = "ImdbScoreLabel";
            this.ImdbScoreLabel.Size = new System.Drawing.Size(61, 13);
            this.ImdbScoreLabel.TabIndex = 0;
            this.ImdbScoreLabel.Text = "Imdb Score";
            // 
            // MetacriticScoreLabel
            // 
            this.MetacriticScoreLabel.AutoSize = true;
            this.MetacriticScoreLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MetacriticScoreLabel.Location = new System.Drawing.Point(5, 101);
            this.MetacriticScoreLabel.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.MetacriticScoreLabel.Name = "MetacriticScoreLabel";
            this.MetacriticScoreLabel.Size = new System.Drawing.Size(84, 13);
            this.MetacriticScoreLabel.TabIndex = 0;
            this.MetacriticScoreLabel.Text = "Metacritic Score";
            // 
            // RunTimeLabel
            // 
            this.RunTimeLabel.AutoSize = true;
            this.RunTimeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RunTimeLabel.Location = new System.Drawing.Point(5, 124);
            this.RunTimeLabel.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.RunTimeLabel.Name = "RunTimeLabel";
            this.RunTimeLabel.Size = new System.Drawing.Size(53, 13);
            this.RunTimeLabel.TabIndex = 0;
            this.RunTimeLabel.Text = "Run Time";
            // 
            // HeadLineLabel
            // 
            this.HeadLineLabel.AutoSize = true;
            this.HeadLineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.HeadLineLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.HeadLineLabel.Location = new System.Drawing.Point(5, 5);
            this.HeadLineLabel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.HeadLineLabel.Name = "HeadLineLabel";
            this.HeadLineLabel.Size = new System.Drawing.Size(74, 17);
            this.HeadLineLabel.TabIndex = 0;
            this.HeadLineLabel.Text = "Base Data";
            // 
            // ImdbScoreMskTxtBox
            // 
            this.ImdbScoreMskTxtBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ImdbScoreMskTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImdbScoreMskTxtBox.Location = new System.Drawing.Point(97, 75);
            this.ImdbScoreMskTxtBox.Mask = "09.9";
            this.ImdbScoreMskTxtBox.Name = "ImdbScoreMskTxtBox";
            this.ImdbScoreMskTxtBox.Size = new System.Drawing.Size(114, 20);
            this.ImdbScoreMskTxtBox.TabIndex = 1;
            this.ImdbScoreMskTxtBox.ValidatingType = typeof(int);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(97, 52);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox3.TabIndex = 1;
            // 
            // ImdbIdMskTxtBox
            // 
            this.ImdbIdMskTxtBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ImdbIdMskTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImdbIdMskTxtBox.Location = new System.Drawing.Point(97, 29);
            this.ImdbIdMskTxtBox.Mask = "LL0000000";
            this.ImdbIdMskTxtBox.Name = "ImdbIdMskTxtBox";
            this.ImdbIdMskTxtBox.Size = new System.Drawing.Size(114, 20);
            this.ImdbIdMskTxtBox.TabIndex = 1;
            // 
            // RunTimeMskTxtBox
            // 
            this.RunTimeMskTxtBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RunTimeMskTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RunTimeMskTxtBox.Location = new System.Drawing.Point(97, 121);
            this.RunTimeMskTxtBox.Mask = "0099";
            this.RunTimeMskTxtBox.Name = "RunTimeMskTxtBox";
            this.RunTimeMskTxtBox.Size = new System.Drawing.Size(114, 20);
            this.RunTimeMskTxtBox.TabIndex = 1;
            // 
            // ReleaseDateMskTxtBox
            // 
            this.ReleaseDateMskTxtBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ReleaseDateMskTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReleaseDateMskTxtBox.Location = new System.Drawing.Point(97, 52);
            this.ReleaseDateMskTxtBox.Mask = "0000-00-00";
            this.ReleaseDateMskTxtBox.Name = "ReleaseDateMskTxtBox";
            this.ReleaseDateMskTxtBox.Size = new System.Drawing.Size(114, 20);
            this.ReleaseDateMskTxtBox.TabIndex = 1;
            // 
            // NewMovieBaseData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.ReleaseDateMskTxtBox);
            this.Controls.Add(this.ImdbIdMskTxtBox);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.RunTimeMskTxtBox);
            this.Controls.Add(this.ImdbScoreMskTxtBox);
            this.Controls.Add(this.MetaScoreMskTxtBox);
            this.Controls.Add(this.RunTimeLabel);
            this.Controls.Add(this.MetacriticScoreLabel);
            this.Controls.Add(this.ImdbScoreLabel);
            this.Controls.Add(this.ReleaseDateLabel);
            this.Controls.Add(this.HeadLineLabel);
            this.Controls.Add(this.ImdbIDLabel);
            this.Name = "NewMovieBaseData";
            this.Size = new System.Drawing.Size(214, 154);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ImdbIDLabel;
        private System.Windows.Forms.MaskedTextBox MetaScoreMskTxtBox;
        private System.Windows.Forms.Label ReleaseDateLabel;
        private System.Windows.Forms.Label ImdbScoreLabel;
        private System.Windows.Forms.Label MetacriticScoreLabel;
        private System.Windows.Forms.Label RunTimeLabel;
        private System.Windows.Forms.Label HeadLineLabel;
        private System.Windows.Forms.MaskedTextBox ImdbScoreMskTxtBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox ImdbIdMskTxtBox;
        private System.Windows.Forms.MaskedTextBox RunTimeMskTxtBox;
        private System.Windows.Forms.MaskedTextBox ReleaseDateMskTxtBox;
    }
}
