namespace MovieCollection.UserControls
{
    partial class NewMovieStandardDataControl
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.StandardDataRichTextbox = new System.Windows.Forms.RichTextBox();
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
            this.HeadLineLabel.Size = new System.Drawing.Size(95, 17);
            this.HeadLineLabel.TabIndex = 2;
            this.HeadLineLabel.Text = "*PlaceHolder*";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TitleLabel.Location = new System.Drawing.Point(5, 32);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(174, 13);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "Add one *PLACEHOLDER* per line";
            // 
            // StandardDataRichTextbox
            // 
            this.StandardDataRichTextbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StandardDataRichTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StandardDataRichTextbox.Location = new System.Drawing.Point(5, 50);
            this.StandardDataRichTextbox.Margin = new System.Windows.Forms.Padding(5);
            this.StandardDataRichTextbox.Name = "StandardDataRichTextbox";
            this.StandardDataRichTextbox.Size = new System.Drawing.Size(204, 146);
            this.StandardDataRichTextbox.TabIndex = 6;
            this.StandardDataRichTextbox.Text = "";
            // 
            // NewMovieStandardDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.StandardDataRichTextbox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.HeadLineLabel);
            this.Name = "NewMovieStandardDataControl";
            this.Size = new System.Drawing.Size(214, 201);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadLineLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.RichTextBox StandardDataRichTextbox;
    }
}
