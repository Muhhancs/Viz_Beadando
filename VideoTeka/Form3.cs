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
        string User;
        Filmlista elso;
        public Form3(string bekert, string user) // film cime és felhasználó neve
        {
            User = user;
            //tb_search.Text = text;
            InitializeComponent();
            //Kereses van_e = Form2.gyors(bekert);
            //string id = van_e.Search[0].imdbID;

            elso = Form2.reszletes(bekert); //rákeresünk a filmre, hogy adatokat tudjunk róla megjeleníteni
            actor_text.MaximumSize = new Size(500, 0);
            plot_text.MaximumSize = new Size(500, 0);
            //film adatok megjelenítése
            title_text.Text = elso.Title;
            year_text.Text = elso.Year;
            actor_text.Text = elso.Actors;
            director_text.Text = elso.Director;
            genre_text.Text = elso.Genre;
            run_text.Text = elso.Runtime;
            plot_text.Text = elso.Plot;
            imdb_text.Text = elso.imdbRating;

            //Ha van a filmhez kép akkor azt töltjük be ellenkező esetben másik képet.
            if (elso.Poster == "N/A")
            {
                pictureBox1.ImageLocation = "https://janodob.hu/wp-content/uploads/2019/06/nincs1.png";
            }
            else
            {
                pictureBox1.ImageLocation = elso.Poster;
            }

        }

        

        private void bt_buy_Click(object sender, EventArgs e)
        {
            checkPurchase(User + ".txt"); //Ellenőrizzük, hogy a felhasznál már vásárolt-e filmet
            //Van e "username".txt nevu fajl
        }

        private void bt_inventory_Click(object sender, EventArgs e)
        {
            //Ha már vásárolt  a felhasználó filmet, akkor megnyílik az inventory forms.
            if(File.Exists(User + ".txt"))
            {
                this.Hide();
                Inventory a = new Inventory(User);
                a.ShowDialog();
            }//Hiba
            else MessageBox.Show("A felhasznalo meg nem vasarolt filmet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }


        private void back_Click(object sender, EventArgs e)
        {//Vissza a fotms2-re
            this.Hide();
            Form2 f2 = new Form2(User);
            f2.ShowDialog();
        }

        //Megnézzük, hogy a felhasználó már vásárolt-e filmet és hogy az adott filmet megveheti-e
        private void checkPurchase(string a)
        {

            bool purchased = false;
            //Ha mr vásárolt a felhasználó filmet
            if (File.Exists(a))
            {
                //Bekérjük a fájlból a film címeit
                List<string> titles = new List<string>();
                StreamReader sr;
                sr = new StreamReader(a);
                string[] lines = File.ReadAllLines(a);
                foreach (string line in lines)
                {
                    string[] values = line.Split(',');
                    titles.Add(values[0]);
                }
                sr.Close();

                int i = 0;

                for (i = 0; i < titles.Count(); i++)
                {
                    //Ha a listéban már szerepel az adott film akkor nem lehet megvenni
                    if (title_text.Text == titles.ElementAt(i))
                    {
                        purchased = true; //Már megvásárolt --> nem lehet újra megvenni
                    }
                }
            }

            if (purchased == false)
            {
                //Ha még nem vásolta meg ezt a filmet, akkor megvesszük és beleírjuk a fájlba
                StreamWriter sw = new StreamWriter(a, true);

                sw.WriteLine("{0}, {1}", title_text.Text, year_text.Text);
                sw.Close();
                MessageBox.Show("Sikeres vásárlás!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Ezt a filmet már megvásároltad!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);





        }
    }
}
