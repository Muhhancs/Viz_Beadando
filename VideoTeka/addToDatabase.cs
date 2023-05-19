using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace VideoTeka
{
    public partial class addToDatabase : Form
    {
        //Adatbázis kapcsolathoz szükséges connection string és MySqlConnection objektum 
        const string connectionString = "server=mysql.nethely.hu;port=3306;database=galack;uid=galack;password=Webprog2023;";
        MySqlConnection connection = new MySqlConnection(connectionString);

        public addToDatabase()
        {
            connection.Open(); // A kapcsolat megnyitása mielőtt betöltődnének a Windows Forms obejktumok
            InitializeComponent(); 

        }
        //Felhasználó hozáaadása az adatbázishoz
        private void addUserBtn_Click(object sender, EventArgs e)
        {
            try
            {   //Megnézzük, hogy már van-e ilyen felhasználó az adatbázisban
                if (checkUserExist() == false) {

                    //Email, felhasználónév és jelszó validálása
                    if(checkUsernameAndPassword(nameTB.Text) == true && checkEmail(emailTB.Text) == true && checkUsernameAndPassword(pwdTB.Text) == true)
                    {
                        //SQL parancs az adatrögízéshez, ha minden input megfelelő
                        string sqlCmd = "INSERT INTO VT_user(Username, Email, Password) values('" + nameTB.Text + "','" + emailTB.Text + "','" + pwdTB.Text + "')";
                        MySqlCommand command = new MySqlCommand(sqlCmd, connection);

                        //SQL parancs végrehajtása
                        command.ExecuteNonQuery();
                        //SQl kapcsolat megszakítása
                        connection.Close();
                        MessageBox.Show("Az adatfeltöltés sikeres volt!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Hibás beviteli formátum!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else MessageBox.Show("Ez a felhasználó vagy email cím már szerepel az adatbázisban!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Az adatfeltöltés során hiba történt: " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Megnézzük, hogy már van-e ilyen felhasználó az adatbázisban
        private bool checkUserExist()
        {
            //SQL parancs segítségével megnézzük, hogy a felhasználó már szerepelt korábban az adatbázisban
            string sqlCmd = "Select Count(*) from VT_user where Username = '" + nameTB.Text + "' or Email = '" + emailTB.Text + "'";
            MySqlCommand command = new MySqlCommand(sqlCmd, connection);

            //Az SQL parancs egy számot ad vissza, amit így tudunk változóba menteni
            int count = Convert.ToInt32(command.ExecuteScalar());

            if (count > 0) return true; //A felhasználó már szerepelt az adatbázisban
            else return false; //A felhasználó még nem szerepelt az adatbázisban

        }

        //Visszatérés az admin oldalra
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin a = new admin();
            a.ShowDialog();
        }

        //Felhasználónév és jelszó inputuk validálása
        private bool checkUsernameAndPassword(string a){
            bool textOk = false;
            
            //Helyes input 8 és 15 karakter hosszúság közt lehet és tartalmaz nagy illetve kisbetűt
            if (a.Length >= 8 && a.Length <= 15 && a.Any(char.IsUpper) && a.Any(char.IsLower)) textOk = true; //Helyes input

            return textOk; //Helytelen input
        }

        //Email validálása
        private bool checkEmail(string a)
        {
            bool textOk = false;

            if (IsValidEmail(a) != false) textOk = true; //Helyes email

            return textOk; //Nem helyes email
        }

        //Email validálása
        public bool IsValidEmail(string a)
        {
            try
            {
                var addr = new MailAddress(a);
                return addr.Address == a;
            }
            catch
            {
                return false;
            }
        }
    }
}
