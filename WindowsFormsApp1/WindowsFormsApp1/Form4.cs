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
    public partial class Form4 : Form
    {
        MySqlConnection conn;
        public Form4()
        {
            InitializeComponent();
            conn = new MySqlConnection("server=localhost;Database=orderingSystem;uid=root; Pwd = root;");
        }

        public void loadOrder()
        {
            string query = "select order_id, amount, discount from orders;";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["order_id"].HeaderText = "ID";
            dataGridView1.Columns["amount"].HeaderText = "Amount";
            dataGridView1.Columns["discount"].HeaderText = "Discount";
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            loadOrder();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "select m.item, m.price, c.category_name from category c inner join menu m on c.category_id = m.category_category_id inner join order_details od on m.menu_id = od.menu_menu_id inner join orders o on od.order_order_id = o.order_id where o.order_id= '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "';";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView2.DataSource = dt;
            dataGridView2.Columns["item"].HeaderText = "Menu";
            dataGridView2.Columns["price"].HeaderText = "Price";
            dataGridView2.Columns["category_name"].HeaderText = "Category";
        }
    }
}
