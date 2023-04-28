namespace VideoTeka
{
    partial class Form3
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
            bt_rent = new Button();
            bt_buy = new Button();
            pictureBox1 = new PictureBox();
            bt_back = new Button();
            title = new Label();
            year = new Label();
            run = new Label();
            genre = new Label();
            Director = new Label();
            plot = new Label();
            acot = new Label();
            imdb = new Label();
            imdb_text = new Label();
            actor_text = new Label();
            plot_text = new Label();
            director_text = new Label();
            genre_text = new Label();
            run_text = new Label();
            year_text = new Label();
            title_text = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bt_rent
            // 
            bt_rent.Location = new Point(93, 12);
            bt_rent.Name = "bt_rent";
            bt_rent.Size = new Size(75, 23);
            bt_rent.TabIndex = 0;
            bt_rent.Text = "Rent";
            bt_rent.UseVisualStyleBackColor = true;
            // 
            // bt_buy
            // 
            bt_buy.Location = new Point(174, 12);
            bt_buy.Name = "bt_buy";
            bt_buy.Size = new Size(75, 23);
            bt_buy.TabIndex = 1;
            bt_buy.Text = "Buy";
            bt_buy.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 450);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // bt_back
            // 
            bt_back.Location = new Point(12, 12);
            bt_back.Name = "bt_back";
            bt_back.Size = new Size(75, 23);
            bt_back.TabIndex = 3;
            bt_back.Text = "Back";
            bt_back.UseVisualStyleBackColor = true;
            bt_back.Click += bt_back_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(399, 68);
            title.Name = "title";
            title.Size = new Size(32, 15);
            title.TabIndex = 4;
            title.Text = "Title:";
            title.TextAlign = ContentAlignment.TopRight;
            // 
            // year
            // 
            year.AutoSize = true;
            year.Location = new Point(343, 93);
            year.Name = "year";
            year.Size = new Size(88, 15);
            year.TabIndex = 5;
            year.Text = "Year of Release:";
            year.TextAlign = ContentAlignment.TopRight;
            // 
            // run
            // 
            run.AutoSize = true;
            run.Location = new Point(376, 122);
            run.Name = "run";
            run.Size = new Size(55, 15);
            run.TabIndex = 6;
            run.Text = "Runtime:";
            run.TextAlign = ContentAlignment.TopRight;
            // 
            // genre
            // 
            genre.AutoSize = true;
            genre.Location = new Point(390, 150);
            genre.Name = "genre";
            genre.Size = new Size(41, 15);
            genre.TabIndex = 7;
            genre.Text = "Genre:";
            genre.TextAlign = ContentAlignment.TopRight;
            // 
            // Director
            // 
            Director.AutoSize = true;
            Director.Location = new Point(379, 176);
            Director.Name = "Director";
            Director.Size = new Size(52, 15);
            Director.TabIndex = 8;
            Director.Text = "Director:";
            Director.TextAlign = ContentAlignment.TopRight;
            // 
            // plot
            // 
            plot.AutoSize = true;
            plot.Location = new Point(400, 253);
            plot.Name = "plot";
            plot.Size = new Size(31, 15);
            plot.TabIndex = 9;
            plot.Text = "Plot:";
            plot.TextAlign = ContentAlignment.TopRight;
            // 
            // acot
            // 
            acot.AutoSize = true;
            acot.Location = new Point(387, 229);
            acot.Name = "acot";
            acot.Size = new Size(44, 15);
            acot.TabIndex = 10;
            acot.Text = "Actors:";
            acot.TextAlign = ContentAlignment.TopRight;
            // 
            // imdb
            // 
            imdb.AutoSize = true;
            imdb.Location = new Point(355, 203);
            imdb.Name = "imdb";
            imdb.Size = new Size(76, 15);
            imdb.TabIndex = 11;
            imdb.Text = "IMDB Rating:";
            imdb.TextAlign = ContentAlignment.TopRight;
            // 
            // imdb_text
            // 
            imdb_text.AutoSize = true;
            imdb_text.Location = new Point(449, 203);
            imdb_text.Name = "imdb_text";
            imdb_text.Size = new Size(76, 15);
            imdb_text.TabIndex = 19;
            imdb_text.Text = "IMDB Rating:";
            // 
            // actor_text
            // 
            actor_text.AutoSize = true;
            actor_text.Location = new Point(449, 229);
            actor_text.Name = "actor_text";
            actor_text.Size = new Size(44, 15);
            actor_text.TabIndex = 18;
            actor_text.Text = "Actors:";
            // 
            // plot_text
            // 
            plot_text.AutoSize = true;
            plot_text.Location = new Point(449, 253);
            plot_text.Name = "plot_text";
            plot_text.Size = new Size(28, 15);
            plot_text.TabIndex = 17;
            plot_text.Text = "Plot";
            // 
            // director_text
            // 
            director_text.AutoSize = true;
            director_text.Location = new Point(449, 176);
            director_text.Name = "director_text";
            director_text.Size = new Size(52, 15);
            director_text.TabIndex = 16;
            director_text.Text = "Director:";
            // 
            // genre_text
            // 
            genre_text.AutoSize = true;
            genre_text.Location = new Point(449, 150);
            genre_text.Name = "genre_text";
            genre_text.Size = new Size(41, 15);
            genre_text.TabIndex = 15;
            genre_text.Text = "Genre:";
            // 
            // run_text
            // 
            run_text.AutoSize = true;
            run_text.Location = new Point(449, 122);
            run_text.Name = "run_text";
            run_text.Size = new Size(55, 15);
            run_text.TabIndex = 14;
            run_text.Text = "Runtime:";
            // 
            // year_text
            // 
            year_text.AutoSize = true;
            year_text.Location = new Point(449, 93);
            year_text.Name = "year_text";
            year_text.Size = new Size(88, 15);
            year_text.TabIndex = 13;
            year_text.Text = "Year of Release:";
            // 
            // title_text
            // 
            title_text.AutoSize = true;
            title_text.Location = new Point(449, 68);
            title_text.Name = "title_text";
            title_text.Size = new Size(32, 15);
            title_text.TabIndex = 12;
            title_text.Text = "Title:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 543);
            Controls.Add(imdb_text);
            Controls.Add(actor_text);
            Controls.Add(plot_text);
            Controls.Add(director_text);
            Controls.Add(genre_text);
            Controls.Add(run_text);
            Controls.Add(year_text);
            Controls.Add(title_text);
            Controls.Add(imdb);
            Controls.Add(acot);
            Controls.Add(plot);
            Controls.Add(Director);
            Controls.Add(genre);
            Controls.Add(run);
            Controls.Add(year);
            Controls.Add(title);
            Controls.Add(bt_back);
            Controls.Add(pictureBox1);
            Controls.Add(bt_buy);
            Controls.Add(bt_rent);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_rent;
        private Button bt_buy;
        private PictureBox pictureBox1;
        private Button bt_back;
        private Label title;
        private Label year;
        private Label run;
        private Label genre;
        private Label Director;
        private Label plot;
        private Label acot;
        private Label imdb;
        private Label imdb_text;
        private Label actor_text;
        private Label plot_text;
        private Label director_text;
        private Label genre_text;
        private Label run_text;
        private Label year_text;
        private Label title_text;
    }
}