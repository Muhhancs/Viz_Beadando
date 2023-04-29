using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace VideoTeka
{
    public partial class Form2 : Form
    {
        int page = 0;
        int max_page = 0;

        public Form2()
        {
            InitializeComponent();
            var labels = Controls.OfType<Label>();
            foreach (var label in labels)
            {
                label.Hide();
                label.MaximumSize = new Size(115, 0);
                label.AutoSize = true;

            }

        }
        private void data_Click(object sender, EventArgs e)
        {
            mutat(tb_search.Text);
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
        public static Kereses gyors(string keres, int oldal)
        {
            //első keresésre
            //megadja az összes találatot
            //imdbID-vel, Cimmel, Poszter linkkel és műfajjal
            string apiKey = "c2ff92c4";
            string baseUri = $"http://www.omdbapi.com/?apikey={apiKey}";

            string name = keres;
            int old = oldal + 1;
            var sb = new StringBuilder(baseUri);
            sb.Append($"&page={old}");
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
        private int szamlalo()
        {
            int szam = 0;

            return szam;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kereses van_e = gyors(tb_search.Text, page);
            string id = van_e.Search[0].imdbID;
            Form3 f3 = new Form3(id);
            f3.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kereses van_e = gyors(tb_search.Text, page);
            string id = van_e.Search[1].imdbID;
            Form3 f3 = new Form3(id);
            f3.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kereses van_e = gyors(tb_search.Text, page);
            string id = van_e.Search[2].imdbID;
            Form3 f3 = new Form3(id);
            f3.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kereses van_e = gyors(tb_search.Text, page);
            string id = van_e.Search[3].imdbID;
            Form3 f3 = new Form3(id);
            f3.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kereses van_e = gyors(tb_search.Text, page);
            string id = van_e.Search[4].imdbID;
            Form3 f3 = new Form3(id);
            f3.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kereses van_e = gyors(tb_search.Text, page);
            string id = van_e.Search[5].imdbID;
            Form3 f3 = new Form3(id);
            f3.ShowDialog();
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kereses van_e = gyors(tb_search.Text, page);
            string id = van_e.Search[6].imdbID;
            Form3 f3 = new Form3(id);
            f3.ShowDialog();
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kereses van_e = gyors(tb_search.Text, page);
            string id = van_e.Search[7].imdbID;
            Form3 f3 = new Form3(id);
            f3.ShowDialog();
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kereses van_e = gyors(tb_search.Text, page);
            string id = van_e.Search[8].imdbID;
            Form3 f3 = new Form3(id);
            f3.ShowDialog();
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kereses van_e = gyors(tb_search.Text, page);
            string id = van_e.Search[9].imdbID;
            Form3 f3 = new Form3(id);
            f3.ShowDialog();
        }

        private void bt_prev_Click(object sender, EventArgs e)
        {
            if (page - 1 >= 0)
            {
                page = page - 1;
                string text = tb_search.Text;
                mutat(text);
            }
        }

        private void bt_next_Click(object sender, EventArgs e)
        {
            if (page + 1 < max_page)
            {
                page = page + 1;
                string text = tb_search.Text;
                mutat(text);
            }
        }
        private void mutat(string keres)
        {
            if (tb_search.Text != "")
            {
                //A labeleket lenulázza és eltűnteti
                var labels = Controls.OfType<Label>();
                foreach (var label in labels)
                {
                    label.Hide();
                    label.ResetText();
                }
                Kereses van_e = gyors(keres, page);
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

                    max_page = hany_darab / 10;

                    if (hany_darab % 10 != 0)
                    {
                        max_page = max_page + 1;
                    }
                    int j = page * 10;
                    int kisebb;
                    int marad = hany_darab - j;
                    if (marad <= 10)
                    { kisebb = marad; }
                    else
                    { kisebb = 10; }

                    for (int i = 0; i < kisebb; i++)
                    {
                        if (van_e.Search[i].Type != "game")
                        {
                            if (i % 10 == 0)
                            {
                                if (van_e.Search[0].Poster == "N/A")
                                {
                                    pictureBox1.ImageLocation = "https://janodob.hu/wp-content/uploads/2019/06/nincs1.png";
                                }
                                else
                                {
                                    pictureBox1.ImageLocation = van_e.Search[0].Poster;
                                }
                                pictureBox1.Show();
                                elso_cim.Text = van_e.Search[0].Title;
                                elso_ev.Text = van_e.Search[0].Year;
                                elso_mufaj.Text = van_e.Search[0].Type;
                            }
                            if (i % 10 == 1)
                            {
                                if (van_e.Search[1].Poster == "N/A")
                                {
                                    pictureBox2.ImageLocation = "I:\\Egyetem\\4. Félév\\Viz_Beadando\\VideoTeka\\Resources\\nincs1.png";
                                }
                                else
                                {
                                    pictureBox2.ImageLocation = van_e.Search[1].Poster;
                                }
                                pictureBox2.Show();
                                mas_cim.Text = van_e.Search[1].Title;
                                mas_ev.Text = van_e.Search[1].Year;
                                mas_mufaj.Text = van_e.Search[1].Type;

                            }
                            if (i % 10 == 2)
                            {
                                if (van_e.Search[2].Poster == "N/A")
                                {
                                    pictureBox3.ImageLocation = "https://janodob.hu/wp-content/uploads/2019/06/nincs1.png";
                                }
                                else
                                {
                                    pictureBox3.ImageLocation = van_e.Search[2].Poster;
                                }
                                pictureBox3.Show();
                                har_cim.Text = van_e.Search[2].Title;
                                har_ev.Text = van_e.Search[2].Year;
                                har_mufaj.Text = van_e.Search[2].Type;
                            }
                            if (i % 10 == 3)
                            {
                                if (van_e.Search[3].Poster == "N/A")
                                {
                                    pictureBox4.ImageLocation = "https://janodob.hu/wp-content/uploads/2019/06/nincs1.png";
                                }
                                else
                                {
                                    pictureBox4.ImageLocation = van_e.Search[3].Poster;
                                }
                                pictureBox4.Show();
                                negy_cim.Text = van_e.Search[3].Title;
                                negy_ev.Text = van_e.Search[3].Year;
                                negy_mufaj.Text = van_e.Search[3].Type;

                            }
                            if (i % 10 == 4)
                            {
                                if (van_e.Search[4].Poster == "N/A")
                                {
                                    pictureBox2.ImageLocation = "https://janodob.hu/wp-content/uploads/2019/06/nincs1.png";
                                }
                                else
                                {
                                    pictureBox5.ImageLocation = van_e.Search[4].Poster;
                                }
                                pictureBox5.Show();
                                ot_cim.Text = van_e.Search[4].Title;
                                ot_ev.Text = van_e.Search[4].Year;
                                ot_mufaj.Text = van_e.Search[4].Type;
                            }
                            if (i % 10 == 5)
                            {
                                if (van_e.Search[5].Poster == "N/A")
                                {
                                    pictureBox2.ImageLocation = "https://janodob.hu/wp-content/uploads/2019/06/nincs1.png";
                                }
                                else
                                {
                                    pictureBox6.ImageLocation = van_e.Search[5].Poster;
                                }
                                pictureBox6.Show();
                                hat_cim.Text = van_e.Search[5].Title;
                                hat_ev.Text = van_e.Search[5].Year;
                                hat_mufaj.Text = van_e.Search[5].Type;
                            }
                            if (i % 10 == 6)
                            {
                                if (van_e.Search[6].Poster == "N/A")
                                {
                                    pictureBox2.ImageLocation = "https://janodob.hu/wp-content/uploads/2019/06/nincs1.png";
                                }
                                else
                                {
                                    pictureBox7.ImageLocation = van_e.Search[6].Poster;
                                }
                                pictureBox7.Show();
                                het_cim.Text = van_e.Search[6].Title;
                                het_ev.Text = van_e.Search[6].Year;
                                het_mufaj.Text = van_e.Search[6].Type;

                            }
                            if (i % 10 == 7)
                            {
                                if (van_e.Search[7].Poster == "N/A")
                                {
                                    pictureBox2.ImageLocation = "https://janodob.hu/wp-content/uploads/2019/06/nincs1.png";
                                }
                                else
                                {
                                    pictureBox8.ImageLocation = van_e.Search[7].Poster;
                                }
                                pictureBox8.Show();
                                nyolc_cim.Text = van_e.Search[7].Title;
                                nyolc_ev.Text = van_e.Search[7].Year;
                                nyolc_mufaj.Text = van_e.Search[7].Type;
                            }
                            if (i % 10 == 8)
                            {
                                if (van_e.Search[8].Poster == "N/A")
                                {
                                    pictureBox2.ImageLocation = "https://janodob.hu/wp-content/uploads/2019/06/nincs1.png";
                                }
                                else
                                {
                                    pictureBox9.ImageLocation = van_e.Search[8].Poster;
                                }
                                pictureBox9.Show();
                                kil_cim.Text = van_e.Search[8].Title;
                                kil_ev.Text = van_e.Search[8].Year;
                                kil_mufaj.Text = van_e.Search[8].Type;
                            }
                            if (i % 10 == 9)
                            {
                                if (van_e.Search[9].Poster == "N/A")
                                {
                                    pictureBox2.ImageLocation = "https://janodob.hu/wp-content/uploads/2019/06/nincs1.png";
                                }
                                else
                                {
                                    pictureBox10.ImageLocation = van_e.Search[9].Poster;
                                }
                                pictureBox10.Show();
                                tiz_cim.Text = van_e.Search[9].Title;
                                tiz_ev.Text = van_e.Search[9].Year;
                                tiz_mufaj.Text = van_e.Search[9].Type;
                            }


                            //Labelek megjelenítése
                            foreach (var label in labels)
                            {
                                label1.Text = "Found:";
                                label2.Text = hany_darab.ToString();
                                label.Show();
                            }
                        }
                    }
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

    }
}