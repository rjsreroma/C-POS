using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        public Form1 previousform;
        public static string user = "";
        public static string id = "";
        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("server=localhost;Database=orderingSystem;uid=root; Pwd = root;");
        }

        private void login_Click(object sender, EventArgs e)
        {
            user = username.Text;
            String pass = password.Text;
            String query = "select username, password from employee" + " WHERE username = '" + user + "' AND password = '" + pass + "'";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                Form2 f2 = new Form2();
                MessageBox.Show("Welcome " + user);
                this.Hide();
                f2.Show();
                f2.previousform = this;
            }
            else MessageBox.Show("Wrong username or password", "Please type again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
