using System;
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
    public partial class Inventory : Form
    {
        string User;
        public Inventory(string user)
        {
            User = user; //Felhasználónév
            
            InitializeComponent();
            userText.Text = "A(z) " + User + " felhasználó tulajdonában lévő filmek:";

            setDataToGrid(user); //A felhasználó áltál megvásárolt filmeket betöltjük a DataGridViewba
            
        }

        //Fájl megnyitása és DataGridView feltöltése
        public void  setDataToGrid(string b)
        {
            //DatagridView feltölsée fájlból
            DataTable dt = new DataTable();
            dt.Columns.Add("Cím", typeof(string));
            dt.Columns.Add("Készítés dátuma", typeof(string));
            string[] lines = File.ReadAllLines(b + ".txt");

            foreach (string line in lines)
            {
                string[] values = line.Split(',');
                dt.Rows.Add(values[0], values[1]);
            }

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 250;
            dataGridView1.Columns[1].Width = 107;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {//Vissza a forms 2-re
            this.Hide();
            Form2 a = new Form2(User);
            a.ShowDialog(); 
        }
    }
}
