using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VideoTeka
{
    public partial class admin : Form
    {
        List<loginData> userLoginData; //Adatbázisból kinyert felhasználói adatok itt tárolódnak
        public admin()
        {
            getDataFromDatabase();
            InitializeComponent();
            setDataToGrid();
        }
        
        //Adatok lekérdezése adatbázisból
        private void getDataFromDatabase()
        {
            userLoginData = new List<loginData>();

            //Adatbázis kapcsolat létrehozása
            const string connectionString = "server=mysql.nethely.hu;port=3306;database=galack;uid=galack;password=Webprog2023;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //SQL parancs az összes felhasználó kinyeréséhez
            string sqlCmd = "SELECT * FROM VT_user ";
            MySqlCommand command = new MySqlCommand(sqlCmd, connection);

            //Az adatok listába töltése
            MySqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string uName = reader.GetString(1);
                string email = reader.GetString(2);
                string pwd = reader.GetString(3);

                loginData a = new loginData(id, uName, email, pwd);
                userLoginData.Add(a);
            }

            //Kapcsolat megszakítása
            reader.Close();
            connection.Close();
        }


        //DataGridView feltöltése adatokkal
        private void setDataToGrid()
        {
            //Fejlécek
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("USER", typeof(string));
            dt.Columns.Add("EMAIL", typeof(string));
            dt.Columns.Add("PASSWORD", typeof(string));

            //Felhasználói adatok
            for (int i = 0; i < userLoginData.Count(); i++)
            {
                dt.Rows.Add(userLoginData.ElementAt(i).Id, userLoginData.ElementAt(i).Username, userLoginData.ElementAt(i).Email, userLoginData.ElementAt(i).Password);
            }

            dataGridView1.DataSource = dt;
            //Oszlopok szélességének beállítása
            dataGridView1.Columns[0].Width = 27;
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[2].Width = 170;
            dataGridView1.Columns[3].Width = 120;
            
        }

        //Törlés az adatbázisból
        private void deleteFromDatabase(int id) {
            //Kapcsolat létrehozása
            const string connectionString = "server=mysql.nethely.hu;port=3306;database=galack;uid=galack;password=Webprog2023;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            //SQL parancs a törléshez
            string sqlCmd = "DELETE FROM VT_user WHERE id = "+ id;
            MySqlCommand command = new MySqlCommand(sqlCmd, connection);
            
            //Parancs végre hajtás és kapcsolat bontása
            command.ExecuteNonQuery();
            connection.Close();
            //DataGridView újboli feltöltése
            getDataFromDatabase();
        }


        //Gombnyomásra törlés az adatbázisból
        private void removeBtn_Click(object sender, EventArgs e)
        {
            //Ha van kiválasztott sor a DataGridView-ban akkor lehet törölni is
            if (dataGridView1.SelectedRows.Count >0 )
            {
                //Megerősítés a törléshez, ha igen, akkor mehet a felhasználó törlése
                DialogResult result = MessageBox.Show("Biztosan törölni szeretnéd ezt a sort?", "Sor törlése", MessageBoxButtons.YesNo);
                try
                {
                    //Törlés
                    if (result == DialogResult.Yes)
                    {
                        //Id alapján törüljük a felhasználót az adatbázisból
                        int id = int.Parse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                        //Törlés
                        deleteFromDatabase(id);
                        MessageBox.Show("Az adatok törölve lettek az adatbázisból!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    //Hiba
                    MessageBox.Show("Az adatok törlése nem sikerült: " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }//Hiba
            else MessageBox.Show("Valassza ki azt a sort, amit törölni szeretne!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Felhasználó hozzáadása ablak megnyitása
        private void addBtn_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            addToDatabase a = new addToDatabase();
            a.ShowDialog();
        }

        //Update user data megnyitása
        private void updateBtn_Click(object sender, EventArgs e)
        {
            //Ki kell választani egy sort, amit módosítani akarunk
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //Id alapján történik a módosítás
                int userId = int.Parse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
                //Update user data megnyitása
                this.Hide();
                modify a = new modify(userId);
                a.ShowDialog();
            }//Hiba
            else MessageBox.Show("Valassza ki azt a sort, amit modositani szeretne!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
