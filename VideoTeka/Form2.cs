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
        }
        private void rentBtn_Click(object sender, EventArgs e)
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
                //string type = "series";


                var sb = new StringBuilder(baseUri);
                sb.Append($"&t={name}");
                //sb.Append($"&type={type}");


                var request = WebRequest.Create(sb.ToString());
                request.Timeout = 1000;
                request.Method = "GET";
                request.ContentType = "application/json";

                string result = string.Empty;
                List<Filmlista> Filmek = new List<Filmlista>();

                Filmlista valami;
                //Kereses teszt;
                //List<Kereses> Keres = new List<Kereses>();
                using (var response = request.GetResponse())
                {
                    using (var stream = response.GetResponseStream())
                    {
                        using (var reader = new StreamReader(stream, Encoding.UTF8))
                        {
                            valami = JsonConvert.DeserializeObject<Filmlista>(reader.ReadToEnd());
                            Filmek.Add(valami);

                            //teszt = JsonConvert.DeserializeObject<Kereses>(reader.ReadToEnd());
                            //Keres.Add(teszt);
                        }
                    }
                }
                //Tabla.DataSource = Keres;
                Tabla.DataSource = Filmek;
            }
            else
            {
                tb_search.PlaceholderText = "Kérem adjon meg egy film címet!";
            }
        }
        //private static List<Filmlista> LoadFromJsonString(string jsonString)
        //{
        //    List<Filmlista> result = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Filmlista>>(jsonString);
        //    return result;
        //}

        //private static List<Filmlista> LoadFromJsonFile(string jsonFileName)
        //{
        //    var employeeList = new List<Filmlista>();

        //    using (StreamReader file = File.OpenText(jsonFileName))
        //    {
        //        var serializer = new Newtonsoft.Json.JsonSerializer();
        //        employeeList = (List<Filmlista>)serializer.Deserialize(file, typeof(List<Filmlista>));
        //    }

        //    return employeeList;
        //}

        //private static string SaveToJsonFile(List<Filmlista> employeeList, string jsonFileName)
        //{
        //    string jsonString = JsonConvert.SerializeObject(employeeList, Formatting.Indented);
        //    File.WriteAllText(jsonFileName, jsonString);
        //    return jsonString;
        //}
    }
}