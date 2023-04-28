using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace VideoTeka
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            var labels = Controls.OfType<Label>();
            foreach (var label in labels)
            {
                label.Hide();
                label.MaximumSize = new Size(122, 0);
                label.AutoSize = true;

            }

            //var labels = Controls.OfType<Label>().Where(x => x.Name.StartsWith("label"));
            //foreach (var label in labels)
            //{
            //    label.Hide();
            //}

        }
        private void data_Click(object sender, EventArgs e)
        {
            if (tb_search.Text != "")
            {
                //keresés
                //string apiKey = "c2ff92c4";
                //string baseUri = $"http://www.omdbapi.com/?apikey={apiKey}";

                //string name = tb_search.Text;
                //var sb = new StringBuilder(baseUri);
                //sb.Append($"&s={name}");

                //var request = WebRequest.Create(sb.ToString());
                //request.Timeout = 1000;
                //request.Method = "GET";
                //request.ContentType = "application/json";

                //Kereses van_e;
                //string result = string.Empty;
                //using (var response = request.GetResponse())
                //{
                //    using (var stream = response.GetResponseStream())
                //    {
                //        using (var reader = new StreamReader(stream, Encoding.UTF8))
                //        {
                //            result = reader.ReadToEnd();
                //            van_e = JsonConvert.DeserializeObject<Kereses>(result);

                //        }
                //    }
                //}
                var labels = Controls.OfType<Label>();
                foreach (var label in labels)
                {
                    label.Hide();
                    label.ResetText();
                }
                Kereses van_e = gyors(tb_search.Text);
                //korábban megjelenített poszterek elrejtése
                var boxes = Controls.OfType<PictureBox>();
                foreach (var box in boxes)
                {
                    box.Visible = false;
                }
                //Találatok kiírása poszterrel, ha van találat
                if (van_e.Response != "False")
                {
                    int hany_darab = int.Parse(van_e.totalResults);
                    int kisebb;
                    if (hany_darab <= 6)
                    { kisebb = hany_darab; }
                    else { kisebb = 6; }
                    for (int i = 0; i < kisebb; i++)
                    {
                        if (i == 0)
                        {
                            pictureBox1.ImageLocation = van_e.Search[i].Poster;
                            pictureBox1.Show();
                            elso_cim.Text = van_e.Search[i].Title;
                            elso_ev.Text = van_e.Search[i].Year;
                            elso_mufaj.Text = van_e.Search[i].Type;
                        }
                        if (i == 1)
                        {
                            pictureBox2.ImageLocation = van_e.Search[i].Poster;
                            pictureBox2.Show();
                            mas_cim.Text = van_e.Search[i].Title;
                            mas_ev.Text = van_e.Search[i].Year;
                            mas_mufaj.Text = van_e.Search[i].Type;
                        }
                        if (i == 2)
                        {
                            pictureBox3.ImageLocation = van_e.Search[i].Poster;
                            pictureBox3.Show();
                            har_cim.Text = van_e.Search[i].Title;
                            har_ev.Text = van_e.Search[i].Year;
                            har_mufaj.Text = van_e.Search[i].Type;
                        }
                        if (i == 3)
                        {
                            pictureBox4.ImageLocation = van_e.Search[i].Poster;
                            pictureBox4.Show();
                            negy_cim.Text = van_e.Search[i].Title;
                            negy_ev.Text = van_e.Search[i].Year;
                            negy_mufaj.Text = van_e.Search[i].Type;
                        }
                        if (i == 4)
                        {
                            pictureBox5.ImageLocation = van_e.Search[i].Poster;
                            pictureBox5.Show();
                            ot_cim.Text = van_e.Search[i].Title;
                            ot_ev.Text = van_e.Search[i].Year;
                            ot_mufaj.Text = van_e.Search[i].Type;
                        }
                        if (i == 5)
                        {
                            pictureBox6.ImageLocation = van_e.Search[i].Poster;
                            pictureBox6.Show();
                            hat_cim.Text = van_e.Search[i].Title;
                            hat_ev.Text = van_e.Search[i].Year;
                            hat_mufaj.Text = van_e.Search[i].Type;
                        }
                        //Labelek megjelenítése
                        foreach (var label in labels)
                        {
                            label.Show();
                        }
                    }
                    label1.Text = hany_darab.ToString();
                    label1.Show();
                }
                else
                {
                    //Ha olyan találat lett beütve amilyen film nincs
                    tb_search.PlaceholderText = "Ilyen film nincs az adatbázisban!";
                }
            }
            else
            {
                //ha nem lett beütve semmise a keresőbe
                tb_search.PlaceholderText = "Kérem adjon meg egy film címet!";
            }
        }

        public static Filmlista reszletes(string keres)
        {
            //Ha már megvan a film ID-je, részletesebb keresés helyet rá
            string apiKey = "c2ff92c4";
            string baseUri = $"http://www.omdbapi.com/?apikey={apiKey}";

            string name = keres;
            var sb = new StringBuilder(baseUri);
            sb.Append($"&i={name}");
            var request = WebRequest.Create(sb.ToString());
            request.Timeout = 1000;
            request.Method = "GET";
            request.ContentType = "application/json";


            Filmlista Talalat;
            using (var response = request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    using (var reader = new StreamReader(stream, Encoding.UTF8))
                    {
                        Talalat = JsonConvert.DeserializeObject<Filmlista>(reader.ReadToEnd());
                    }
                }
            }
            return Talalat;
        }
        public static Kereses gyors(string keres)
        {
            //első keresésre
            //megadja az összes találatot
            //imdbID-vel, Cimmel, Poszter linkkel és műfajjal
            string apiKey = "c2ff92c4";
            string baseUri = $"http://www.omdbapi.com/?apikey={apiKey}";

            string name = keres;
            var sb = new StringBuilder(baseUri);
            sb.Append($"&s={name}");
            var request = WebRequest.Create(sb.ToString());
            request.Timeout = 1000;
            request.Method = "GET";
            request.ContentType = "application/json";


            Kereses Talalat;
            using (var response = request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    using (var reader = new StreamReader(stream, Encoding.UTF8))
                    {
                        Talalat = JsonConvert.DeserializeObject<Kereses>(reader.ReadToEnd());
                    }
                }
            }
            return Talalat;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kereses van_e = gyors(tb_search.Text);
            string id = van_e.Search[0].imdbID;
            Form3 f3 = new Form3(id);
            f3.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kereses van_e = gyors(tb_search.Text);
            string id = van_e.Search[1].imdbID;
            Form3 f3 = new Form3(id);
            f3.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kereses van_e = gyors(tb_search.Text);
            string id = van_e.Search[2].imdbID;
            Form3 f3 = new Form3(id);
            f3.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kereses van_e = gyors(tb_search.Text);
            string id = van_e.Search[3].imdbID;
            Form3 f3 = new Form3(id);
            f3.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kereses van_e = gyors(tb_search.Text);
            string id = van_e.Search[4].imdbID;
            Form3 f3 = new Form3(id);
            f3.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kereses van_e = gyors(tb_search.Text);
            string id = van_e.Search[5].imdbID;
            Form3 f3 = new Form3(id);
            f3.ShowDialog();
        }
    }
}