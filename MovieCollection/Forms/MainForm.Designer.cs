namespace MovieCollection
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CloseButton = new System.Windows.Forms.Button();
            this.SearchField = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.RandomButton = new System.Windows.Forms.Button();
            this.MovieDataGridView = new System.Windows.Forms.DataGridView();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.LastWatchedButton = new System.Windows.Forms.Button();
            this.LastWatchedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AddMovieButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MovieDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.DimGray;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F);
            this.CloseButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CloseButton.Location = new System.Drawing.Point(470, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "×";
            this.CloseButton.UseCompatibleTextRendering = true;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseClick);
            // 
            // SearchField
            // 
            this.SearchField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SearchField.Location = new System.Drawing.Point(60, 80);
            this.SearchField.Name = "SearchField";
            this.SearchField.Size = new System.Drawing.Size(380, 22);
            this.SearchField.TabIndex = 1;
            this.SearchField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchField_KeyPress);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.BackColor = System.Drawing.Color.DimGray;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F);
            this.SearchButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SearchButton.Location = new System.Drawing.Point(157, 110);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(5);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(90, 30);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseCompatibleTextRendering = true;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // RandomButton
            // 
            this.RandomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RandomButton.BackColor = System.Drawing.Color.DimGray;
            this.RandomButton.FlatAppearance.BorderSize = 0;
            this.RandomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F);
            this.RandomButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RandomButton.Location = new System.Drawing.Point(253, 110);
            this.RandomButton.Margin = new System.Windows.Forms.Padding(5);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(90, 30);
            this.RandomButton.TabIndex = 2;
            this.RandomButton.Text = "Random";
            this.RandomButton.UseCompatibleTextRendering = true;
            this.RandomButton.UseVisualStyleBackColor = false;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // MovieDataGridView
            // 
            this.MovieDataGridView.AllowUserToAddRows = false;
            this.MovieDataGridView.AllowUserToDeleteRows = false;
            this.MovieDataGridView.AllowUserToResizeColumns = false;
            this.MovieDataGridView.AllowUserToResizeRows = false;
            this.MovieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieDataGridView.Location = new System.Drawing.Point(12, 148);
            this.MovieDataGridView.Name = "MovieDataGridView";
            this.MovieDataGridView.ReadOnly = true;
            this.MovieDataGridView.RowHeadersWidth = 20;
            this.MovieDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MovieDataGridView.Size = new System.Drawing.Size(476, 240);
            this.MovieDataGridView.TabIndex = 3;
            // 
            // TopPanel
            // 
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(467, 29);
            this.TopPanel.TabIndex = 4;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // LastWatchedButton
            // 
            this.LastWatchedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LastWatchedButton.BackColor = System.Drawing.Color.DimGray;
            this.LastWatchedButton.FlatAppearance.BorderSize = 0;
            this.LastWatchedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LastWatchedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LastWatchedButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LastWatchedButton.Location = new System.Drawing.Point(12, 396);
            this.LastWatchedButton.Margin = new System.Windows.Forms.Padding(5);
            this.LastWatchedButton.Name = "LastWatchedButton";
            this.LastWatchedButton.Size = new System.Drawing.Size(99, 26);
            this.LastWatchedButton.TabIndex = 5;
            this.LastWatchedButton.Text = "Last Watched";
            this.LastWatchedButton.UseCompatibleTextRendering = true;
            this.LastWatchedButton.UseVisualStyleBackColor = false;
            this.LastWatchedButton.Click += new System.EventHandler(this.LastWatchedButton_Click);
            // 
            // LastWatchedDatePicker
            // 
            this.LastWatchedDatePicker.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.LastWatchedDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.LastWatchedDatePicker.Location = new System.Drawing.Point(119, 397);
            this.LastWatchedDatePicker.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.LastWatchedDatePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.LastWatchedDatePicker.Name = "LastWatchedDatePicker";
            this.LastWatchedDatePicker.Size = new System.Drawing.Size(77, 20);
            this.LastWatchedDatePicker.TabIndex = 6;
            this.LastWatchedDatePicker.Value = new System.DateTime(2020, 7, 19, 0, 0, 0, 0);
            // 
            // AddMovieButton
            // 
            this.AddMovieButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddMovieButton.BackColor = System.Drawing.Color.DimGray;
            this.AddMovieButton.FlatAppearance.BorderSize = 0;
            this.AddMovieButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMovieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddMovieButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddMovieButton.Location = new System.Drawing.Point(403, 396);
            this.AddMovieButton.Margin = new System.Windows.Forms.Padding(5);
            this.AddMovieButton.Name = "AddMovieButton";
            this.AddMovieButton.Size = new System.Drawing.Size(83, 26);
            this.AddMovieButton.TabIndex = 7;
            this.AddMovieButton.Text = "Add Movie";
            this.AddMovieButton.UseCompatibleTextRendering = true;
            this.AddMovieButton.UseVisualStyleBackColor = false;
            this.AddMovieButton.Click += new System.EventHandler(this.AddMovieButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(12, 129);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(94, 13);
            this.ResultLabel.TabIndex = 8;
            this.ResultLabel.Text = "*PLACEHOLDER*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(500, 436);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.AddMovieButton);
            this.Controls.Add(this.LastWatchedDatePicker);
            this.Controls.Add(this.LastWatchedButton);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.MovieDataGridView);
            this.Controls.Add(this.RandomButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchField);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.MainForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.MovieDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox SearchField;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.DataGridView MovieDataGridView;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button LastWatchedButton;
        private System.Windows.Forms.DateTimePicker LastWatchedDatePicker;
        private System.Windows.Forms.Button AddMovieButton;
        private System.Windows.Forms.Label ResultLabel;
    }
}

