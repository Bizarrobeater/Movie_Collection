namespace MovieCollection
{
    partial class NewMovieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMovieForm));
            this.CloseButton = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.AddMovieButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.AddDataLabel = new System.Windows.Forms.Label();
            this.TitleButton = new System.Windows.Forms.Button();
            this.AddTitleButton = new System.Windows.Forms.Button();
            this.RequiredGroupBox = new System.Windows.Forms.GroupBox();
            this.BaseDataButton = new System.Windows.Forms.Button();
            this.GenreButton = new System.Windows.Forms.Button();
            this.LanguageButton = new System.Windows.Forms.Button();
            this.CountryButton = new System.Windows.Forms.Button();
            this.PeopleButton = new System.Windows.Forms.Button();
            this.BoxButton = new System.Windows.Forms.Button();
            this.OptionalGroupBox = new System.Windows.Forms.GroupBox();
            this.FranchiseButton = new System.Windows.Forms.Button();
            this.SubtitleButton = new System.Windows.Forms.Button();
            this.CollectionButton = new System.Windows.Forms.Button();
            this.PeopleGroupBox = new System.Windows.Forms.GroupBox();
            this.ActorButton = new System.Windows.Forms.Button();
            this.BackPeopleButton = new System.Windows.Forms.Button();
            this.WriterButton = new System.Windows.Forms.Button();
            this.DirectorButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CheckDataButton = new System.Windows.Forms.Button();
            this.OneLineDataControl = new MovieCollection.UserControls.NewMovieOneLineData();
            this.TitleControl = new MovieCollection.UserControls.NewMovieTitle();
            this.StandardDataControl = new MovieCollection.UserControls.NewMovieStandardDataControl();
            this.BaseDataControl = new MovieCollection.NewMovieBaseData();
            this.RequiredGroupBox.SuspendLayout();
            this.OptionalGroupBox.SuspendLayout();
            this.PeopleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
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
            // AddMovieButton
            // 
            this.AddMovieButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddMovieButton.BackColor = System.Drawing.Color.DimGray;
            this.AddMovieButton.Enabled = false;
            this.AddMovieButton.FlatAppearance.BorderSize = 0;
            this.AddMovieButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMovieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddMovieButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddMovieButton.Location = new System.Drawing.Point(384, 396);
            this.AddMovieButton.Margin = new System.Windows.Forms.Padding(5);
            this.AddMovieButton.Name = "AddMovieButton";
            this.AddMovieButton.Size = new System.Drawing.Size(83, 26);
            this.AddMovieButton.TabIndex = 7;
            this.AddMovieButton.Text = "Add Movie";
            this.AddMovieButton.UseCompatibleTextRendering = true;
            this.AddMovieButton.UseVisualStyleBackColor = false;
            this.AddMovieButton.Click += new System.EventHandler(this.AddMovieButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.BackColor = System.Drawing.Color.DimGray;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BackButton.Location = new System.Drawing.Point(14, 396);
            this.BackButton.Margin = new System.Windows.Forms.Padding(5);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(83, 26);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Back";
            this.BackButton.UseCompatibleTextRendering = true;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddDataLabel
            // 
            this.AddDataLabel.AutoSize = true;
            this.AddDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AddDataLabel.ForeColor = System.Drawing.Color.Silver;
            this.AddDataLabel.Location = new System.Drawing.Point(14, 37);
            this.AddDataLabel.Margin = new System.Windows.Forms.Padding(5);
            this.AddDataLabel.Name = "AddDataLabel";
            this.AddDataLabel.Size = new System.Drawing.Size(202, 25);
            this.AddDataLabel.TabIndex = 10;
            this.AddDataLabel.Text = "Add All Relevant Data";
            // 
            // TitleButton
            // 
            this.TitleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleButton.BackColor = System.Drawing.Color.DimGray;
            this.TitleButton.FlatAppearance.BorderSize = 0;
            this.TitleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TitleButton.Location = new System.Drawing.Point(8, 63);
            this.TitleButton.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.TitleButton.Name = "TitleButton";
            this.TitleButton.Size = new System.Drawing.Size(83, 26);
            this.TitleButton.TabIndex = 9;
            this.TitleButton.Text = "Titles";
            this.TitleButton.UseCompatibleTextRendering = true;
            this.TitleButton.UseVisualStyleBackColor = false;
            this.TitleButton.Click += new System.EventHandler(this.TitleButton_Click);
            // 
            // AddTitleButton
            // 
            this.AddTitleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTitleButton.BackColor = System.Drawing.Color.DimGray;
            this.AddTitleButton.Enabled = false;
            this.AddTitleButton.FlatAppearance.BorderSize = 0;
            this.AddTitleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTitleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.AddTitleButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddTitleButton.Location = new System.Drawing.Point(253, 181);
            this.AddTitleButton.Margin = new System.Windows.Forms.Padding(5);
            this.AddTitleButton.Name = "AddTitleButton";
            this.AddTitleButton.Size = new System.Drawing.Size(63, 23);
            this.AddTitleButton.TabIndex = 9;
            this.AddTitleButton.Text = "Add Title";
            this.AddTitleButton.UseCompatibleTextRendering = true;
            this.AddTitleButton.UseVisualStyleBackColor = false;
            this.AddTitleButton.Visible = false;
            this.AddTitleButton.Click += new System.EventHandler(this.AddTitleButton_Click);
            // 
            // RequiredGroupBox
            // 
            this.RequiredGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RequiredGroupBox.Controls.Add(this.BaseDataButton);
            this.RequiredGroupBox.Controls.Add(this.GenreButton);
            this.RequiredGroupBox.Controls.Add(this.LanguageButton);
            this.RequiredGroupBox.Controls.Add(this.CountryButton);
            this.RequiredGroupBox.Controls.Add(this.PeopleButton);
            this.RequiredGroupBox.Controls.Add(this.BoxButton);
            this.RequiredGroupBox.Controls.Add(this.TitleButton);
            this.RequiredGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RequiredGroupBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RequiredGroupBox.Location = new System.Drawing.Point(12, 76);
            this.RequiredGroupBox.Name = "RequiredGroupBox";
            this.RequiredGroupBox.Size = new System.Drawing.Size(99, 312);
            this.RequiredGroupBox.TabIndex = 16;
            this.RequiredGroupBox.TabStop = false;
            this.RequiredGroupBox.Text = "Required";
            // 
            // BaseDataButton
            // 
            this.BaseDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseDataButton.BackColor = System.Drawing.Color.DimGray;
            this.BaseDataButton.FlatAppearance.BorderSize = 0;
            this.BaseDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BaseDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseDataButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BaseDataButton.Location = new System.Drawing.Point(8, 21);
            this.BaseDataButton.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.BaseDataButton.Name = "BaseDataButton";
            this.BaseDataButton.Size = new System.Drawing.Size(83, 26);
            this.BaseDataButton.TabIndex = 9;
            this.BaseDataButton.Text = "Base Data";
            this.BaseDataButton.UseCompatibleTextRendering = true;
            this.BaseDataButton.UseVisualStyleBackColor = false;
            this.BaseDataButton.Click += new System.EventHandler(this.BaseDataButton_Click);
            // 
            // GenreButton
            // 
            this.GenreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GenreButton.BackColor = System.Drawing.Color.DimGray;
            this.GenreButton.FlatAppearance.BorderSize = 0;
            this.GenreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.GenreButton.Location = new System.Drawing.Point(8, 105);
            this.GenreButton.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.GenreButton.Name = "GenreButton";
            this.GenreButton.Size = new System.Drawing.Size(83, 26);
            this.GenreButton.TabIndex = 9;
            this.GenreButton.Text = "Genres";
            this.GenreButton.UseCompatibleTextRendering = true;
            this.GenreButton.UseVisualStyleBackColor = false;
            this.GenreButton.Click += new System.EventHandler(this.GenreButton_Click);
            // 
            // LanguageButton
            // 
            this.LanguageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LanguageButton.BackColor = System.Drawing.Color.DimGray;
            this.LanguageButton.FlatAppearance.BorderSize = 0;
            this.LanguageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LanguageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.LanguageButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LanguageButton.Location = new System.Drawing.Point(8, 231);
            this.LanguageButton.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.LanguageButton.Name = "LanguageButton";
            this.LanguageButton.Size = new System.Drawing.Size(83, 26);
            this.LanguageButton.TabIndex = 9;
            this.LanguageButton.Text = "Language";
            this.LanguageButton.UseCompatibleTextRendering = true;
            this.LanguageButton.UseVisualStyleBackColor = false;
            this.LanguageButton.Click += new System.EventHandler(this.LanguageButton_Click);
            // 
            // CountryButton
            // 
            this.CountryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CountryButton.BackColor = System.Drawing.Color.DimGray;
            this.CountryButton.FlatAppearance.BorderSize = 0;
            this.CountryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CountryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CountryButton.Location = new System.Drawing.Point(8, 189);
            this.CountryButton.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.CountryButton.Name = "CountryButton";
            this.CountryButton.Size = new System.Drawing.Size(83, 26);
            this.CountryButton.TabIndex = 9;
            this.CountryButton.Text = "Countries";
            this.CountryButton.UseCompatibleTextRendering = true;
            this.CountryButton.UseVisualStyleBackColor = false;
            this.CountryButton.Click += new System.EventHandler(this.CountryButton_Click);
            // 
            // PeopleButton
            // 
            this.PeopleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PeopleButton.BackColor = System.Drawing.Color.DimGray;
            this.PeopleButton.FlatAppearance.BorderSize = 0;
            this.PeopleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PeopleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeopleButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PeopleButton.Location = new System.Drawing.Point(8, 273);
            this.PeopleButton.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.PeopleButton.Name = "PeopleButton";
            this.PeopleButton.Size = new System.Drawing.Size(83, 26);
            this.PeopleButton.TabIndex = 9;
            this.PeopleButton.Text = "People";
            this.PeopleButton.UseCompatibleTextRendering = true;
            this.PeopleButton.UseVisualStyleBackColor = false;
            this.PeopleButton.Click += new System.EventHandler(this.PeopleButton_Click);
            // 
            // BoxButton
            // 
            this.BoxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxButton.BackColor = System.Drawing.Color.DimGray;
            this.BoxButton.FlatAppearance.BorderSize = 0;
            this.BoxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BoxButton.Location = new System.Drawing.Point(8, 147);
            this.BoxButton.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.BoxButton.Name = "BoxButton";
            this.BoxButton.Size = new System.Drawing.Size(83, 26);
            this.BoxButton.TabIndex = 9;
            this.BoxButton.Text = "Box";
            this.BoxButton.UseCompatibleTextRendering = true;
            this.BoxButton.UseVisualStyleBackColor = false;
            this.BoxButton.Click += new System.EventHandler(this.BoxButton_Click);
            // 
            // OptionalGroupBox
            // 
            this.OptionalGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OptionalGroupBox.Controls.Add(this.FranchiseButton);
            this.OptionalGroupBox.Controls.Add(this.SubtitleButton);
            this.OptionalGroupBox.Controls.Add(this.CollectionButton);
            this.OptionalGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionalGroupBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OptionalGroupBox.Location = new System.Drawing.Point(123, 76);
            this.OptionalGroupBox.Name = "OptionalGroupBox";
            this.OptionalGroupBox.Size = new System.Drawing.Size(99, 197);
            this.OptionalGroupBox.TabIndex = 16;
            this.OptionalGroupBox.TabStop = false;
            this.OptionalGroupBox.Text = "Optional";
            // 
            // FranchiseButton
            // 
            this.FranchiseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FranchiseButton.BackColor = System.Drawing.Color.DimGray;
            this.FranchiseButton.FlatAppearance.BorderSize = 0;
            this.FranchiseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FranchiseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FranchiseButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FranchiseButton.Location = new System.Drawing.Point(8, 21);
            this.FranchiseButton.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.FranchiseButton.Name = "FranchiseButton";
            this.FranchiseButton.Size = new System.Drawing.Size(83, 26);
            this.FranchiseButton.TabIndex = 9;
            this.FranchiseButton.Text = "Franchises";
            this.FranchiseButton.UseCompatibleTextRendering = true;
            this.FranchiseButton.UseVisualStyleBackColor = false;
            this.FranchiseButton.Click += new System.EventHandler(this.FranchiseButton_Click);
            // 
            // SubtitleButton
            // 
            this.SubtitleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SubtitleButton.BackColor = System.Drawing.Color.DimGray;
            this.SubtitleButton.FlatAppearance.BorderSize = 0;
            this.SubtitleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubtitleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SubtitleButton.Location = new System.Drawing.Point(8, 105);
            this.SubtitleButton.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.SubtitleButton.Name = "SubtitleButton";
            this.SubtitleButton.Size = new System.Drawing.Size(83, 26);
            this.SubtitleButton.TabIndex = 9;
            this.SubtitleButton.Text = "Subtitles";
            this.SubtitleButton.UseCompatibleTextRendering = true;
            this.SubtitleButton.UseVisualStyleBackColor = false;
            this.SubtitleButton.Click += new System.EventHandler(this.SubtitleButton_Click);
            // 
            // CollectionButton
            // 
            this.CollectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CollectionButton.BackColor = System.Drawing.Color.DimGray;
            this.CollectionButton.FlatAppearance.BorderSize = 0;
            this.CollectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CollectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectionButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CollectionButton.Location = new System.Drawing.Point(8, 63);
            this.CollectionButton.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.CollectionButton.Name = "CollectionButton";
            this.CollectionButton.Size = new System.Drawing.Size(83, 26);
            this.CollectionButton.TabIndex = 9;
            this.CollectionButton.Text = "Collection";
            this.CollectionButton.UseCompatibleTextRendering = true;
            this.CollectionButton.UseVisualStyleBackColor = false;
            this.CollectionButton.Click += new System.EventHandler(this.CollectionButton_Click);
            // 
            // PeopleGroupBox
            // 
            this.PeopleGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PeopleGroupBox.Controls.Add(this.ActorButton);
            this.PeopleGroupBox.Controls.Add(this.BackPeopleButton);
            this.PeopleGroupBox.Controls.Add(this.WriterButton);
            this.PeopleGroupBox.Controls.Add(this.DirectorButton);
            this.PeopleGroupBox.Enabled = false;
            this.PeopleGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PeopleGroupBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PeopleGroupBox.Location = new System.Drawing.Point(123, 76);
            this.PeopleGroupBox.Name = "PeopleGroupBox";
            this.PeopleGroupBox.Size = new System.Drawing.Size(99, 197);
            this.PeopleGroupBox.TabIndex = 16;
            this.PeopleGroupBox.TabStop = false;
            this.PeopleGroupBox.Text = "People";
            this.PeopleGroupBox.Visible = false;
            // 
            // ActorButton
            // 
            this.ActorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ActorButton.BackColor = System.Drawing.Color.DimGray;
            this.ActorButton.FlatAppearance.BorderSize = 0;
            this.ActorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActorButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ActorButton.Location = new System.Drawing.Point(8, 21);
            this.ActorButton.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.ActorButton.Name = "ActorButton";
            this.ActorButton.Size = new System.Drawing.Size(83, 26);
            this.ActorButton.TabIndex = 9;
            this.ActorButton.Text = "Actors";
            this.ActorButton.UseCompatibleTextRendering = true;
            this.ActorButton.UseVisualStyleBackColor = false;
            this.ActorButton.Click += new System.EventHandler(this.ActorButton_Click);
            // 
            // BackPeopleButton
            // 
            this.BackPeopleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackPeopleButton.BackColor = System.Drawing.Color.DimGray;
            this.BackPeopleButton.FlatAppearance.BorderSize = 0;
            this.BackPeopleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackPeopleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.BackPeopleButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BackPeopleButton.Location = new System.Drawing.Point(8, 160);
            this.BackPeopleButton.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.BackPeopleButton.Name = "BackPeopleButton";
            this.BackPeopleButton.Size = new System.Drawing.Size(83, 26);
            this.BackPeopleButton.TabIndex = 9;
            this.BackPeopleButton.Text = "Back To Opt.";
            this.BackPeopleButton.UseCompatibleTextRendering = true;
            this.BackPeopleButton.UseVisualStyleBackColor = false;
            this.BackPeopleButton.Click += new System.EventHandler(this.BackPeopleButton_Click);
            // 
            // WriterButton
            // 
            this.WriterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WriterButton.BackColor = System.Drawing.Color.DimGray;
            this.WriterButton.FlatAppearance.BorderSize = 0;
            this.WriterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WriterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriterButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.WriterButton.Location = new System.Drawing.Point(8, 105);
            this.WriterButton.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.WriterButton.Name = "WriterButton";
            this.WriterButton.Size = new System.Drawing.Size(83, 26);
            this.WriterButton.TabIndex = 9;
            this.WriterButton.Text = "Writers";
            this.WriterButton.UseCompatibleTextRendering = true;
            this.WriterButton.UseVisualStyleBackColor = false;
            this.WriterButton.Click += new System.EventHandler(this.WriterButton_Click);
            // 
            // DirectorButton
            // 
            this.DirectorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DirectorButton.BackColor = System.Drawing.Color.DimGray;
            this.DirectorButton.FlatAppearance.BorderSize = 0;
            this.DirectorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DirectorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectorButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DirectorButton.Location = new System.Drawing.Point(8, 63);
            this.DirectorButton.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.DirectorButton.Name = "DirectorButton";
            this.DirectorButton.Size = new System.Drawing.Size(83, 26);
            this.DirectorButton.TabIndex = 9;
            this.DirectorButton.Text = "Directors";
            this.DirectorButton.UseCompatibleTextRendering = true;
            this.DirectorButton.UseVisualStyleBackColor = false;
            this.DirectorButton.Click += new System.EventHandler(this.DirectorButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(123, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 109);
            this.dataGridView1.TabIndex = 18;
            // 
            // CheckDataButton
            // 
            this.CheckDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckDataButton.BackColor = System.Drawing.Color.DimGray;
            this.CheckDataButton.FlatAppearance.BorderSize = 0;
            this.CheckDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CheckDataButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CheckDataButton.Location = new System.Drawing.Point(282, 396);
            this.CheckDataButton.Margin = new System.Windows.Forms.Padding(5);
            this.CheckDataButton.Name = "CheckDataButton";
            this.CheckDataButton.Size = new System.Drawing.Size(92, 26);
            this.CheckDataButton.TabIndex = 7;
            this.CheckDataButton.Text = "Check Data";
            this.CheckDataButton.UseCompatibleTextRendering = true;
            this.CheckDataButton.UseVisualStyleBackColor = false;
            this.CheckDataButton.Click += new System.EventHandler(this.CheckDataButton_Click);
            // 
            // OneLineDataControl
            // 
            this.OneLineDataControl.BackColor = System.Drawing.Color.DimGray;
            this.OneLineDataControl.Enabled = false;
            this.OneLineDataControl.Location = new System.Drawing.Point(253, 76);
            this.OneLineDataControl.Name = "OneLineDataControl";
            this.OneLineDataControl.Size = new System.Drawing.Size(214, 53);
            this.OneLineDataControl.TabIndex = 17;
            this.OneLineDataControl.TextBoxText = "";
            this.OneLineDataControl.Visible = false;
            // 
            // TitleControl
            // 
            this.TitleControl.BackColor = System.Drawing.Color.DimGray;
            this.TitleControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.TitleControl.Enabled = false;
            this.TitleControl.Location = new System.Drawing.Point(253, 72);
            this.TitleControl.Name = "TitleControl";
            this.TitleControl.OriginalTitle = false;
            this.TitleControl.Size = new System.Drawing.Size(214, 101);
            this.TitleControl.TabIndex = 15;
            this.TitleControl.Title = "";
            this.TitleControl.TitleLanguage = "";
            this.TitleControl.Visible = false;
            // 
            // StandardDataControl
            // 
            this.StandardDataControl.BackColor = System.Drawing.Color.DimGray;
            this.StandardDataControl.Enabled = false;
            this.StandardDataControl.Location = new System.Drawing.Point(253, 72);
            this.StandardDataControl.Name = "StandardDataControl";
            this.StandardDataControl.Size = new System.Drawing.Size(214, 201);
            this.StandardDataControl.TabIndex = 14;
            this.StandardDataControl.Visible = false;
            // 
            // BaseDataControl
            // 
            this.BaseDataControl.BackColor = System.Drawing.Color.DimGray;
            this.BaseDataControl.Enabled = false;
            this.BaseDataControl.ImdbId = "";
            this.BaseDataControl.ImdbScore = "  .";
            this.BaseDataControl.Location = new System.Drawing.Point(253, 72);
            this.BaseDataControl.MetacriticScore = "";
            this.BaseDataControl.Name = "BaseDataControl";
            this.BaseDataControl.ReleaseDate = "    -  -";
            this.BaseDataControl.RunTime = "";
            this.BaseDataControl.Size = new System.Drawing.Size(214, 154);
            this.BaseDataControl.TabIndex = 13;
            this.BaseDataControl.Visible = false;
            // 
            // NewMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(500, 436);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.OneLineDataControl);
            this.Controls.Add(this.PeopleGroupBox);
            this.Controls.Add(this.OptionalGroupBox);
            this.Controls.Add(this.RequiredGroupBox);
            this.Controls.Add(this.TitleControl);
            this.Controls.Add(this.StandardDataControl);
            this.Controls.Add(this.BaseDataControl);
            this.Controls.Add(this.AddDataLabel);
            this.Controls.Add(this.AddTitleButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CheckDataButton);
            this.Controls.Add(this.AddMovieButton);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewMovieForm";
            this.Text = "Form1";
            this.RequiredGroupBox.ResumeLayout(false);
            this.OptionalGroupBox.ResumeLayout(false);
            this.PeopleGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button AddMovieButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label AddDataLabel;
        private System.Windows.Forms.Button TitleButton;
        private NewMovieBaseData BaseDataControl;
        private UserControls.NewMovieStandardDataControl StandardDataControl;
        private UserControls.NewMovieTitle TitleControl;
        private System.Windows.Forms.Button AddTitleButton;
        private System.Windows.Forms.GroupBox RequiredGroupBox;
        private System.Windows.Forms.Button GenreButton;
        private System.Windows.Forms.Button PeopleButton;
        private System.Windows.Forms.Button BoxButton;
        private System.Windows.Forms.GroupBox OptionalGroupBox;
        private System.Windows.Forms.Button FranchiseButton;
        private System.Windows.Forms.Button SubtitleButton;
        private System.Windows.Forms.Button CollectionButton;
        private System.Windows.Forms.Button BaseDataButton;
        private System.Windows.Forms.Button LanguageButton;
        private System.Windows.Forms.Button CountryButton;
        private System.Windows.Forms.GroupBox PeopleGroupBox;
        private System.Windows.Forms.Button ActorButton;
        private System.Windows.Forms.Button BackPeopleButton;
        private System.Windows.Forms.Button WriterButton;
        private System.Windows.Forms.Button DirectorButton;
        private UserControls.NewMovieOneLineData OneLineDataControl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CheckDataButton;
    }
}

