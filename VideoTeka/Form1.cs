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
        List<loginData> userLoginData; //Itt t�roljuk a felhaszn�lokat
        string user; //Felhaszn�l�n�v t�rol�sa �s tov�bb�t�sa a t�bbi Windows Forms-nak
>>>>>>> Stashed changes
        public Form1()
        {
            getDataFromDatabase(); //Lek�rj�k az adatokat
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
        //Megn�zi hogy a jelsz� korrekt-e �ssszehasonl�tja az adatb�zisban l�v� jelsz�t �s a bek�rt jelsz�t ha nem akkor egy msg felj�n "Incorret login data!"
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
                //Sikeres bejelentlez�s. Megnyitja a Form2-t
                this.Hide();
                Form2 form = new Form2(user);
                form.ShowDialog();
>>>>>>> Stashed changes
            }
            else
            {
                //Sikertelen bel�p�s. Hiba�zenet.
                errorMsg.Text = "Incorrect login data!";
                errorMsg.Visible = true;
                userText.Clear();
                pwdText.Clear();
            }
        }

        //Lek�rj�k a felhazsn�l�n�vhez,emailhez tartoz� jelsz�t a Lista objektumunkb�l 
        private string getPwd(string user)
        {
            string result = "error";
            for (int i = 0; i < userLoginData.Count(); i++)
            {
                if(user == userLoginData[i].Username || user == userLoginData[i].Email) result = userLoginData[i].Password;
            }
            return result;
        }

        //Adatb�zis adatainek lek�r�se �s felt�lt�se a Lista objektumba
        private void getDataFromDatabase()
        {
            userLoginData = new List<loginData>();

            //Kapcsolat l�trehoz�sa
            const string connectionString = "server=mysql.nethely.hu;port=3306;database=galack;uid=galack;password=Webprog2023;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            //SQL lek�rdez�s
            string sqlCmd = "SELECT * FROM VT_user ";
            MySqlCommand command = new MySqlCommand(sqlCmd, connection);

            //Lista felt�lt�se az adatokkal
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

            //Kapcsolat bont�sa
            reader.Close();
            connection.Close();
        }

        //Bejelentkez�s
        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            //Admin bejelentkez�s ellen�rz�se
            user = userText.Text;
            string pwd = pwdText.Text;

            if (user == "admin" && pwd == "admin")
            {
                //Sikeres bejelentkez�s. Megny�lik az admin forms.
                this.Hide();
                admin a = new admin();
                a.ShowDialog();
            }


            //Felhaszn�l�i bejelentkez�s
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