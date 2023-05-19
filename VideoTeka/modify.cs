using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoTeka
{
    public partial class modify : Form
    {
        //Kapcsolat az adatbázishoz
        const string connectionString = "server=mysql.nethely.hu;port=3306;database=galack;uid=galack;password=Webprog2023;";
        MySqlConnection connection = new MySqlConnection(connectionString);
        int userId; //User Id-je, ez alapján tudjuk az adatait módosítani az adatbázisban
        public modify(int id)
        {
            
            userId = id;
            InitializeComponent();
        }

        //Modosítás véglegesítése
        private void uploadBtn_Click(object sender, EventArgs e)
        {
            connection.Open();//Kapcsolat megnyitása
            //Megnézzük, hogy melyik értéket kell módosítani --> mit jelölt ki a felhasználó
            string selectedText = "";
            if(uNameRBtn.Checked) selectedText = uNameRBtn.Text;
            if(emailRBtn.Checked) selectedText = emailRBtn.Text;
            if (pwdRBtn.Checked) selectedText = pwdRBtn.Text;


            try
            {
                //SQl parancs módosításra
                string sqlCmd = "UPDATE VT_user Set " + selectedText + " = '" + valueTB.Text + "' Where ID = " + userId;
                MySqlCommand command = new MySqlCommand(sqlCmd, connection);

                //Parancs végrehajtása
                command.ExecuteNonQuery();

                //Siker
                MessageBox.Show("Az adatok módosítása sikeres volt!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {//Hiba
                MessageBox.Show("Nem lehetett az adatokat módosítani: " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close(); //Kapcsolat bontása
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            //Vissza az admin oldalra
            this.Hide();
            admin a = new admin();
            a.ShowDialog();
        }
    }
}
