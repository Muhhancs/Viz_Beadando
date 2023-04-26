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
namespace VideoTeka
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //getDataFromDatabase();
        }
        private void rentBtn_Click(object sender, EventArgs e)
        {

        }

        private void tb_search_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void data_Click(object sender, EventArgs e)
        {
            if (tb_search.Text != "")
            {
                //data.Text = "Keresés";
                string apiKey = "c2ff92c4";
                string baseUri = $"http://www.omdbapi.com/?apikey={apiKey}";


                string name = tb_search.Text;
                //string type = "movies";

                var sb = new StringBuilder(baseUri);
                sb.Append($"&s={name}");
                // sb.Append($"&type={type}");

                var request = WebRequest.Create(sb.ToString());
                request.Timeout = 1000;
                request.Method = "GET";
                request.ContentType = "application/json";

                string result = string.Empty;


                using (var response = request.GetResponse())
                {
                    using (var stream = response.GetResponseStream())
                    {
                        using (var reader = new StreamReader(stream, Encoding.UTF8))
                        {
                            result = reader.ReadToEnd();
                        }
                    }
                }
                //label1.Text = result;
                //string szerep;
                //string ev;
                //string cim;
                //string poszter;
                //string hossz;
                //int poz = 0;
                //int veg = 0;

                //poz = result.IndexOf("Year");
                //ev = result.Substring(poz + 7, 4);
                //poz = result.IndexOf("Runtime");
                //hossz = result.Substring(poz + 10, 3);
                //label4.Text = ev;


                //var serializer = new Newtonsoft.Json.JsonSerializer();
                //Filmek = (List<Filmlista>)serializer.Deserialize(result, typeof(List<Filmlista>));

                //List <Filmlista>Filmek = JsonConvert.DeserializeObject<List<Filmlista>>(result);

                List<Filmlista>  Filmek = LoadFromJsonString(result);
                Tabla.DataSource = Filmek;
            }
            else
            {
                tb_search.PlaceholderText = "Kérem adjon meg egy film címet!";
            }
        }
        private static List<Filmlista> LoadFromJsonString(string jsonString)
        {
            List<Filmlista> result = JsonConvert.DeserializeObject<List<Filmlista>>(jsonString);
            return result;
        }
    }
}
