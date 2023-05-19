using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace VideoTeka
{
    public partial class Form2 : Form
    {
        int page = 0; //Jelenlegi olda
        int max_page = 0; //Max oldalak
        int total_found = 0; //Összes keresési találat
        string User; // FElhasználó neve
        List<Search> flista = new List<Search>(); //Lista objektum a filmekhez

        public Form2(string user)
        {
            User = user; //Felhasználónév mentése
            InitializeComponent();
            //Label típusú objektumok beállítása
            var labels = Controls.OfType<Label>();
            foreach (var label in labels)
            {
                label.Hide();
                label.MaximumSize = new Size(115, 0);
                label.AutoSize = true;

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
        public List<Search> gyors()
        {
            //első keresésre
            //megadja az összes találatot
            //imdbID-vel, Cimmel, Poszter linkkel és műfajjal
            string apiKey = "c2ff92c4";
            string baseUri = $"http://www.omdbapi.com/?apikey={apiKey}";

            string name = tb_search.Text;
            var sb = new StringBuilder(baseUri);
            sb.Append($"&page={1}");
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
            int max = 0;
            if (Talalat.Response != "False")
            {
                total_found = int.Parse(Talalat.totalResults);
                max = total_found / 10;

                if (total_found % 10 != 0)
                {
                    max = max + 1;
                }

                foreach (var item in Talalat.Search)
                {
                    if (item.Type.ToString() != "game")
                    {
                        flista.Add(item);
                    }
                }

                for (int i = 2; i < max; i++)
                {
                    sb = new StringBuilder(baseUri);
                    sb.Append($"&page={i}");
                    sb.Append($"&s={name}");
                    request = WebRequest.Create(sb.ToString());
                    request.Timeout = 1000;
                    request.Method = "GET";
                    request.ContentType = "application/json";
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

                    foreach (var item in Talalat.Search)
                    {
                        if (item.Type.ToString() != "game")
                        {
                            flista.Add(item);
                        }
                    }
                }
            }
            else
            {
                //ha nem lett beütve semmise a keresőbe
                label2.Text = "There is no movie by that title in our movie base";
                label2.Show();
            }

            return flista;

        }

        private void mutat()
        {
            //A labeleket lenulázza és eltűnteti
            var labels = Controls.OfType<Label>();
            foreach (var label in labels)
            {
                label.Hide();
                label.ResetText();
            }
            //korábban megjelenített poszterek elrejtése
            var boxes = Controls.OfType<PictureBox>();
            foreach (var box in boxes)
            {
                box.Visible = false;
            }
            //Találatok kiírása poszterrel, ha van találat
            int hany_darab = flista.Count();
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
                if (i % 10 == 0)
                {
                    if (flista[page * 10].Poster == "N/A")
                    {
                        pictureBox1.ImageLocation = "https://janodob.hu/wp-content/uploads/2019/06/nincs1.png";
                    }
                    else
                    {
                        pictureBox1.ImageLocation = flista[page * 10].Poster;
                    }
                    pictureBox1.Show();
                    elso_cim.Text = flista[page * 10].Title;
                    elso_ev.Text = flista[page * 10].Year;
                    elso_mufaj.Text = flista[page * 10].Type;
                }
                if (i % 10 == 1)
                {
                    if (flista[page * 10 + 1].Poster == "N/A")
                    {
                        pictureBox2.ImageLocation = "I:\\Egyetem\\4. Félév\\Viz_Beadando\\VideoTeka\\Resources\\nincs1.png";
                    }
                    else
                    {
                        pictureBox2.ImageLocation = flista[page * 10 + 1].Poster;
                    }
                    pictureBox2.Show();
                    mas_cim.Text = flista[page * 10 + 1].Title;
                    mas_ev.Text = flista[page * 10 + 1].Year;
                    mas_mufaj.Text = flista[page * 10 + 1].Type;

                }
                if (i % 10 == 2)
                {
                    if (flista[page * 10 + 2].Poster == "N/A")
                    {
                        pictureBox3.ImageLocation = "https://janodob.hu/wp-content/uploads/2019/06/nincs1.png";
                    }
                    else
                    {
                        pictureBox3.ImageLocation = flista[page * 10 + 2].Poster;
                    }
                    pictureBox3.Show();
                    har_cim.Text = flista[page * 10 + 2].Title;
                    har_ev.Text = flista[page * 10 + 2].Year;
                    har_mufaj.Text = flista[page * 10 + 2].Type;
                }
                if (i % 10 == 3)
                {
                    if (flista[page * 10 + 3].Poster == "N/A")
                    {
                        pictureBox4.ImageLocation = "https://janodob.hu/wp-content/uploads/2019/06/nincs1.png";
                    }
                    else
                    {
                        pictureBox4.ImageLocation = flista[page * 10 + 3].Poster;
                    }
                    pictureBox4.Show();
                    negy_cim.Text = flista[page * 10 + 3].Title;
                    negy_ev.Text = flista[page * 10 + 3].Year;
                    negy_mufaj.Text = flista[page * 10 + 3].Type;

                }
                if (i % 10 == 4)
                {
                    if (flista[page * 10 + 4].Poster == "N/A")
                    {
                        pictureBox2.ImageLocation = "https://janodob.hu/wp-content/uploads/2019/06/nincs1.png";
                    }
                    else
                    {
                        pictureBox5.ImageLocation = flista[page * 10 + 4].Poster;
                    }
                    pictureBox5.Show();
                    ot_cim.Text = flista[page * 10 + 4].Title;
                    ot_ev.Text = flista[page * 10 + 4].Year;
                    ot_mufaj.Text = flista[page * 10 + 4].Type;
                }
                if (i % 10 == 5)
                {
                    if (flista[page * 10 + 5].Poster == "N/A")
                    {
                        pictureBox2.ImageLocation = "https://janodob.hu/wp-content/uploads/2019/06/nincs1.png";
                    }
                    else
                    {
                        pictureBox6.ImageLocation = flista[page * 10 + 5].Poster;
                    }
                    pictureBox6.Show();
                    hat_cim.Text = flista[page * 10 + 5].Title;
                    hat_ev.Text = flista[page * 10 + 5].Year;
                    hat_mufaj.Text = flista[page * 10 + 5].Type;
                }
                if (i % 10 == 6)
                {
                    if (flista[page * 10 + 6].Poster == "N/A")
                    {
                        pictureBox2.ImageLocation = "https://janodob.hu/wp-content/uploads/2019/06/nincs1.png";
                    }
                    else
                    {
                        pictureBox7.ImageLocation = flista[page * 10 + 6].Poster;
                    }
                    pictureBox7.Show();
                    het_cim.Text = flista[page * 10 + 6].Title;
                    het_ev.Text = flista[page * 10 + 6].Year;
                    het_mufaj.Text = flista[page * 10 + 6].Type;

                }
                if (i % 10 == 7)
                {
                    if (flista[page * 10 + 7].Poster == "N/A")
                    {
                        pictureBox2.ImageLocation = "https://janodob.hu/wp-content/uploads/2019/06/nincs1.png";
                    }
                    else
                    {
                        pictureBox8.ImageLocation = flista[page * 10 + 7].Poster;
                    }
                    pictureBox8.Show();
                    nyolc_cim.Text = flista[page * 10 + 7].Title;
                    nyolc_ev.Text = flista[page * 10 + 7].Year;
                    nyolc_mufaj.Text = flista[page * 10 + 7].Type;
                }
                if (i % 10 == 8)
                {
                    if (flista[page * 10 + 8].Poster == "N/A")
                    {
                        pictureBox2.ImageLocation = "https://janodob.hu/wp-content/uploads/2019/06/nincs1.png";
                    }
                    else
                    {
                        pictureBox9.ImageLocation = flista[page * 10 + 8].Poster;
                    }
                    pictureBox9.Show();
                    kil_cim.Text = flista[page * 10 + 8].Title;
                    kil_ev.Text = flista[page * 10 + 8].Year;
                    kil_mufaj.Text = flista[page * 10 + 8].Type;
                }
                if (i % 10 == 9)
                {
                    if (flista[page * 10 + 9].Poster == "N/A")
                    {
                        pictureBox2.ImageLocation = "https://janodob.hu/wp-content/uploads/2019/06/nincs1.png";
                    }
                    else
                    {
                        pictureBox10.ImageLocation = flista[page * 10 + 9].Poster;
                    }
                    pictureBox10.Show();
                    tiz_cim.Text = flista[page * 10 + 9].Title;
                    tiz_ev.Text = flista[page * 10 + 9].Year;
                    tiz_mufaj.Text = flista[page * 10 + 9].Type;
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (tb_search.Text != "")
            {
                page = 0;
                flista.Clear();
                gyors();
                mutat();
            }
            else
            {
                //ha nem lett beütve semmise a keresőbe
                tb_search.PlaceholderText = "Please enter a movie title";
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3(flista[page * 10].imdbID, User);
            f3.ShowDialog();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3(flista[page * 10+1].imdbID, User);
            f3.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3(flista[page * 10 + 2].imdbID, User);
            f3.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3(flista[page * 10 + 2].imdbID, User);
            f3.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3(flista[page * 10 + 4].imdbID, User);
            f3.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3(flista[page * 10 + 5].imdbID, User);
            f3.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3(flista[page * 10 + 6].imdbID, User);
            f3.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3(flista[page * 10 + 7].imdbID, User);
            f3.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3(flista[page * 10 + 8].imdbID, User);
            f3.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3(flista[page * 10 + 9].imdbID, User);
            f3.ShowDialog();
        }

        private void bt_prev_Click(object sender, EventArgs e)
        {
            if (page - 1 >= 0)
            {
                page = page - 1;
                mutat();
            }
        }

        private void bt_next_Click(object sender, EventArgs e)
        {
            if (page + 1 < max_page)
            {
                page = page + 1;
                mutat();
            }
        }
    }
}