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
            this.bt_inventory = new System.Windows.Forms.Button();
            this.bt_buy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.run = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.Label();
            this.Director = new System.Windows.Forms.Label();
            this.plot = new System.Windows.Forms.Label();
            this.acot = new System.Windows.Forms.Label();
            this.imdb = new System.Windows.Forms.Label();
            this.imdb_text = new System.Windows.Forms.Label();
            this.actor_text = new System.Windows.Forms.Label();
            this.plot_text = new System.Windows.Forms.Label();
            this.director_text = new System.Windows.Forms.Label();
            this.genre_text = new System.Windows.Forms.Label();
            this.run_text = new System.Windows.Forms.Label();
            this.year_text = new System.Windows.Forms.Label();
            this.title_text = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_inventory
            // 
            this.bt_inventory.Location = new System.Drawing.Point(343, 336);
            this.bt_inventory.Name = "bt_inventory";
            this.bt_inventory.Size = new System.Drawing.Size(194, 38);
            this.bt_inventory.TabIndex = 0;
            this.bt_inventory.Text = "Inventory";
            this.bt_inventory.UseVisualStyleBackColor = true;
            this.bt_inventory.Click += new System.EventHandler(this.bt_inventory_Click);
            // 
            // bt_buy
            // 
            this.bt_buy.Location = new System.Drawing.Point(343, 380);
            this.bt_buy.Name = "bt_buy";
            this.bt_buy.Size = new System.Drawing.Size(195, 38);
            this.bt_buy.TabIndex = 1;
            this.bt_buy.Text = "Buy";
            this.bt_buy.UseVisualStyleBackColor = true;
            this.bt_buy.Click += new System.EventHandler(this.bt_buy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(343, 68);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(32, 15);
            this.title.TabIndex = 4;
            this.title.Text = "Title:";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(343, 93);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(88, 15);
            this.year.TabIndex = 5;
            this.year.Text = "Year of Release:";
            this.year.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // run
            // 
            this.run.AutoSize = true;
            this.run.Location = new System.Drawing.Point(343, 122);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(55, 15);
            this.run.TabIndex = 6;
            this.run.Text = "Runtime:";
            this.run.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Location = new System.Drawing.Point(343, 150);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(41, 15);
            this.genre.TabIndex = 7;
            this.genre.Text = "Genre:";
            this.genre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Director
            // 
            this.Director.AutoSize = true;
            this.Director.Location = new System.Drawing.Point(343, 176);
            this.Director.Name = "Director";
            this.Director.Size = new System.Drawing.Size(52, 15);
            this.Director.TabIndex = 8;
            this.Director.Text = "Director:";
            this.Director.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // plot
            // 
            this.plot.AutoSize = true;
            this.plot.Location = new System.Drawing.Point(343, 253);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(31, 15);
            this.plot.TabIndex = 9;
            this.plot.Text = "Plot:";
            this.plot.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // acot
            // 
            this.acot.AutoSize = true;
            this.acot.Location = new System.Drawing.Point(343, 229);
            this.acot.Name = "acot";
            this.acot.Size = new System.Drawing.Size(44, 15);
            this.acot.TabIndex = 10;
            this.acot.Text = "Actors:";
            this.acot.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // imdb
            // 
            this.imdb.AutoSize = true;
            this.imdb.Location = new System.Drawing.Point(343, 203);
            this.imdb.Name = "imdb";
            this.imdb.Size = new System.Drawing.Size(76, 15);
            this.imdb.TabIndex = 11;
            this.imdb.Text = "IMDB Rating:";
            this.imdb.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // imdb_text
            // 
            this.imdb_text.AutoSize = true;
            this.imdb_text.Location = new System.Drawing.Point(449, 203);
            this.imdb_text.Name = "imdb_text";
            this.imdb_text.Size = new System.Drawing.Size(76, 15);
            this.imdb_text.TabIndex = 19;
            this.imdb_text.Text = "IMDB Rating:";
            // 
            // actor_text
            // 
            this.actor_text.AutoSize = true;
            this.actor_text.Location = new System.Drawing.Point(449, 229);
            this.actor_text.Name = "actor_text";
            this.actor_text.Size = new System.Drawing.Size(44, 15);
            this.actor_text.TabIndex = 18;
            this.actor_text.Text = "Actors:";
            // 
            // plot_text
            // 
            this.plot_text.AutoSize = true;
            this.plot_text.Location = new System.Drawing.Point(449, 253);
            this.plot_text.Name = "plot_text";
            this.plot_text.Size = new System.Drawing.Size(28, 15);
            this.plot_text.TabIndex = 17;
            this.plot_text.Text = "Plot";
            // 
            // director_text
            // 
            this.director_text.AutoSize = true;
            this.director_text.Location = new System.Drawing.Point(449, 176);
            this.director_text.Name = "director_text";
            this.director_text.Size = new System.Drawing.Size(52, 15);
            this.director_text.TabIndex = 16;
            this.director_text.Text = "Director:";
            // 
            // genre_text
            // 
            this.genre_text.AutoSize = true;
            this.genre_text.Location = new System.Drawing.Point(449, 150);
            this.genre_text.Name = "genre_text";
            this.genre_text.Size = new System.Drawing.Size(41, 15);
            this.genre_text.TabIndex = 15;
            this.genre_text.Text = "Genre:";
            // 
            // run_text
            // 
            this.run_text.AutoSize = true;
            this.run_text.Location = new System.Drawing.Point(449, 122);
            this.run_text.Name = "run_text";
            this.run_text.Size = new System.Drawing.Size(55, 15);
            this.run_text.TabIndex = 14;
            this.run_text.Text = "Runtime:";
            // 
            // year_text
            // 
            this.year_text.AutoSize = true;
            this.year_text.Location = new System.Drawing.Point(449, 93);
            this.year_text.Name = "year_text";
            this.year_text.Size = new System.Drawing.Size(88, 15);
            this.year_text.TabIndex = 13;
            this.year_text.Text = "Year of Release:";
            // 
            // title_text
            // 
            this.title_text.AutoSize = true;
            this.title_text.Location = new System.Drawing.Point(449, 68);
            this.title_text.Name = "title_text";
            this.title_text.Size = new System.Drawing.Size(32, 15);
            this.title_text.TabIndex = 12;
            this.title_text.Text = "Title:";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(343, 424);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(194, 38);
            this.back.TabIndex = 20;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 490);
            this.Controls.Add(this.back);
            this.Controls.Add(this.imdb_text);
            this.Controls.Add(this.actor_text);
            this.Controls.Add(this.plot_text);
            this.Controls.Add(this.director_text);
            this.Controls.Add(this.genre_text);
            this.Controls.Add(this.run_text);
            this.Controls.Add(this.year_text);
            this.Controls.Add(this.title_text);
            this.Controls.Add(this.imdb);
            this.Controls.Add(this.acot);
            this.Controls.Add(this.plot);
            this.Controls.Add(this.Director);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.run);
            this.Controls.Add(this.year);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_buy);
            this.Controls.Add(this.bt_inventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VideoTeka";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bt_inventory;
        private Button bt_buy;
        private PictureBox pictureBox1;
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
        private Button back;
    }
}