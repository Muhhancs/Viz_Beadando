using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System.Data.SqlClient;

namespace VideoTeka
{
    public partial class Form1 : Form
    {
        List<loginData> userLoginData;

        public Form1()
        {
            getDataFromDatabase();
            InitializeComponent();

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string user = userText.Text;
            string pwd = pwdText.Text;

            string pwdFromDatabase = getPwd(user);
            if (pwdFromDatabase != "error") chechkIfPwdCorrect(pwd, pwdFromDatabase);
            else
            {
                errorMsg.Text = "Incorrect login data!";
                errorMsg.Visible = true;
                userText.Clear();
                pwdText.Clear();
            }
        }

        private void chechkIfPwdCorrect(string pwd, string inDataBase)
        {
            if (pwd == inDataBase)
            {
                errorMsg.Visible = true;
                errorMsg.Text = "Correct login data!";
                //opennewTab
                Form2 form = new Form2();
                form.ShowDialog();
            }
            else
            {
                errorMsg.Text = "Incorrect login data!";
                errorMsg.Visible = true;
                userText.Clear();
                pwdText.Clear();
            }
        }

        private string getPwd(string user)
        {
            string result = "error";
            for (int i = 0; i < userLoginData.Count(); i++)
            {
                if (user == userLoginData[i].Username || user == userLoginData[i].Email) result = userLoginData[i].Password;
            }
            return result;
        }

        private void getDataFromDatabase()
        {
            userLoginData = new List<loginData>();

            const string connectionString = "server=mysql.nethely.hu;port=3306;database=galack;uid=galack;password=Webprog2023;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string sqlCmd = "SELECT * FROM VT_user ";
            MySqlCommand command = new MySqlCommand(sqlCmd, connection);


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

            reader.Close();
            connection.Close();
        }
    }
}