namespace MovieCollection.UserControls
{
    partial class NewMovieOneLineData
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
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.HeadLineLabel.Size = new System.Drawing.Size(161, 17);
            this.HeadLineLabel.TabIndex = 1;
            this.HeadLineLabel.Text = "*PLACEHOLDER* Name";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(8, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 2;
            // 
            // NewMovieOneLineData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.HeadLineLabel);
            this.Name = "NewMovieOneLineData";
            this.Size = new System.Drawing.Size(214, 53);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadLineLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}
