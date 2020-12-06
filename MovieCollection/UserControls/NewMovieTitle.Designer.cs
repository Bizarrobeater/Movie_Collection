namespace MovieCollection.UserControls
{
    partial class NewMovieTitle
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
            this.HeadLineLabel = new System.Windows.Forms.Label();
            this.OriginalTitleLabel = new System.Windows.Forms.Label();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LanguageTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.OriginalTitleCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // HeadLineLabel
            // 
            this.HeadLineLabel.AutoSize = true;
            this.HeadLineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.HeadLineLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.HeadLineLabel.Location = new System.Drawing.Point(5, 5);
            this.HeadLineLabel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.HeadLineLabel.Name = "HeadLineLabel";
            this.HeadLineLabel.Size = new System.Drawing.Size(42, 17);
            this.HeadLineLabel.TabIndex = 1;
            this.HeadLineLabel.Text = "Titles";
            // 
            // OriginalTitleLabel
            // 
            this.OriginalTitleLabel.AutoSize = true;
            this.OriginalTitleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginalTitleLabel.Location = new System.Drawing.Point(5, 78);
            this.OriginalTitleLabel.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.OriginalTitleLabel.Name = "OriginalTitleLabel";
            this.OriginalTitleLabel.Size = new System.Drawing.Size(65, 13);
            this.OriginalTitleLabel.TabIndex = 2;
            this.OriginalTitleLabel.Text = "Original Title";
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LanguageLabel.Location = new System.Drawing.Point(5, 55);
            this.LanguageLabel.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(55, 13);
            this.LanguageLabel.TabIndex = 3;
            this.LanguageLabel.Text = "Language";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TitleLabel.Location = new System.Drawing.Point(5, 32);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Title";
            // 
            // LanguageTextBox
            // 
            this.LanguageTextBox.Location = new System.Drawing.Point(78, 52);
            this.LanguageTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.LanguageTextBox.Name = "LanguageTextBox";
            this.LanguageTextBox.Size = new System.Drawing.Size(131, 20);
            this.LanguageTextBox.TabIndex = 5;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(78, 29);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(131, 20);
            this.TitleTextBox.TabIndex = 5;
            // 
            // OriginalTitleCheckBox
            // 
            this.OriginalTitleCheckBox.AutoSize = true;
            this.OriginalTitleCheckBox.Location = new System.Drawing.Point(78, 77);
            this.OriginalTitleCheckBox.Name = "OriginalTitleCheckBox";
            this.OriginalTitleCheckBox.Size = new System.Drawing.Size(15, 14);
            this.OriginalTitleCheckBox.TabIndex = 6;
            this.OriginalTitleCheckBox.UseVisualStyleBackColor = true;
            // 
            // NewMovieTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.OriginalTitleCheckBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.LanguageTextBox);
            this.Controls.Add(this.OriginalTitleLabel);
            this.Controls.Add(this.LanguageLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.HeadLineLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "NewMovieTitle";
            this.Size = new System.Drawing.Size(214, 101);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadLineLabel;
        private System.Windows.Forms.Label OriginalTitleLabel;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox LanguageTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.CheckBox OriginalTitleCheckBox;
    }
}
