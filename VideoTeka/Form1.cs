using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
<<<<<<< Updated upstream
using MySqlX.XDevAPI.Common;
using System.Data.SqlClient;
=======
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
>>>>>>> Stashed changes

namespace VideoTeka
{
    public partial class Form1 : Form
    {
<<<<<<< Updated upstream
        List<loginData> userLoginData;
        
=======
        List<loginData> userLoginData; //Itt tároljuk a felhasználokat
        string user; //Felhasználónév tárolása és továbbítása a többi Windows Forms-nak
>>>>>>> Stashed changes
        public Form1()
        {
            getDataFromDatabase(); //Lekérjük az adatokat
            InitializeComponent();

        }

<<<<<<< Updated upstream
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string user = userText.Text;
            string pwd = pwdText.Text;

            string pwdFromDatabase = getPwd(user);
            if (pwdFromDatabase != "error") chechkIfPwdCorrect(pwd, pwdFromDatabase);
            else {
                errorMsg.Text = "Incorrect login data!";
                errorMsg.Visible = true;
                userText.Clear();
                pwdText.Clear();
            }
        }

=======
        //Megnézi hogy a jelszó korrekt-e össszehasonlítja az adatbázisban lévõ jelszót és a bekért jelszót ha nem akkor egy msg feljön "Incorret login data!"
>>>>>>> Stashed changes
        private void chechkIfPwdCorrect(string pwd, string inDataBase)
        {
            if(pwd==inDataBase)
            {
<<<<<<< Updated upstream
                errorMsg.Visible=true;
                errorMsg.Text = "Correct login data!";
                //opennewTab
=======
                //Sikeres bejelentlezés. Megnyitja a Form2-t
                this.Hide();
                Form2 form = new Form2(user);
                form.ShowDialog();
>>>>>>> Stashed changes
            }
            else
            {
                //Sikertelen belépés. Hibaüzenet.
                errorMsg.Text = "Incorrect login data!";
                errorMsg.Visible = true;
                userText.Clear();
                pwdText.Clear();
            }
        }

        //Lekérjük a felhazsnálónévhez,emailhez tartozó jelszót a Lista objektumunkból 
        private string getPwd(string user)
        {
            string result = "error";
            for (int i = 0; i < userLoginData.Count(); i++)
            {
                if(user == userLoginData[i].Username || user == userLoginData[i].Email) result = userLoginData[i].Password;
            }
            return result;
        }

        //Adatbázis adatainek lekérése és feltöltése a Lista objektumba
        private void getDataFromDatabase()
        {
            userLoginData = new List<loginData>();

            //Kapcsolat létrehozása
            const string connectionString = "server=mysql.nethely.hu;port=3306;database=galack;uid=galack;password=Webprog2023;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            //SQL lekérdezés
            string sqlCmd = "SELECT * FROM VT_user ";
            MySqlCommand command = new MySqlCommand(sqlCmd, connection);

            //Lista feltöltése az adatokkal
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

            //Kapcsolat bontása
            reader.Close();
            connection.Close();
        }

        //Bejelentkezés
        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            //Admin bejelentkezés ellenõrzése
            user = userText.Text;
            string pwd = pwdText.Text;

            if (user == "admin" && pwd == "admin")
            {
                //Sikeres bejelentkezés. Megnyílik az admin forms.
                this.Hide();
                admin a = new admin();
                a.ShowDialog();
            }


            //Felhasználói bejelentkezés
            string pwdFromDatabase = getPwd(user);
            if (pwdFromDatabase != "error") chechkIfPwdCorrect(pwd, pwdFromDatabase);
            else
            {
                //Hiba. Error msg a forms-on.
                errorMsg.Text = "Incorrect login data!";
                errorMsg.Visible = true;
                userText.Clear();
                pwdText.Clear();
            }
        }
    }
}