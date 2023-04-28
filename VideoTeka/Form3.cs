using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace VideoTeka
{
    public partial class Form3 : Form
    {
        public Form3(string bekert)
        {
            //tb_search.Text = text;
            InitializeComponent();
            //Kereses van_e = Form2.gyors(bekert);
            //string id = van_e.Search[0].imdbID;
            Filmlista elso = Form2.reszletes(bekert);
            actor_text.MaximumSize = new Size(500, 0);
            plot_text.MaximumSize = new Size(500, 0);
            title_text.Text = elso.Title;
            year_text.Text = elso.Year;
            actor_text.Text = elso.Actors;
            director_text.Text = elso.Director;
            genre_text.Text = elso.Genre;
            run_text.Text = elso.Runtime;
            plot_text.Text = elso.Plot;
            imdb_text.Text = elso.imdbRating;
            pictureBox1.ImageLocation = elso.Poster;

        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
