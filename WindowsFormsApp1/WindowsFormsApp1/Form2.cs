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
    public partial class Form2 : Form
    {
        MySqlConnection conn;
        DataTable dt = new DataTable();
        public Form previousform;
        public Form2()
        {
            InitializeComponent();
            conn = new MySqlConnection("server=localhost;Database=orderingSystem;uid=root; Pwd = root;");
        }
        private void executeQuery(string q)
        {
            conn.Open();
            MySqlCommand comm = new MySqlCommand(q, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }

        public void loadAll()
        {
            string query = "select m.item, c.category_name, m.price from menu m inner join category c on m.category_category_id = c.category_id;";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["item"].HeaderText = "Menu";
            dataGridView1.Columns["category_name"].HeaderText = "Category";
            dataGridView1.Columns["price"].HeaderText = "Price";
        }
        public void categLoad()
        {
            string query = "SELECT category_name FROM category;";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            for (int x = 0; x < dt.Rows.Count; x++)
            {
                categ.Items.Add(dt.Rows[x][0].ToString());
            }
        }
        private void CreateDataTableColumns()
        {
            dt.Columns.Add("Item");
            dt.Columns.Add("Category");
            dt.Columns.Add("Amount", typeof(decimal));
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadAll();
            categLoad();
            CreateDataTableColumns();
        }

        private void categ_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select m.item, c.category_name, m.price from menu m inner join category c on m.category_category_id = c.category_id where c.category_name='" + categ.Text + "';";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void addOrder_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            DataRow dr = dt.NewRow();
            dr["Item"] = item.Text;
            dr["Category"] = category.Text;
            dr["Amount"] = price.Text;
            dt.Rows.Add(dr);
            dataGridView2.DataSource = dt;
            decimal sum = Convert.ToDecimal(dt.Compute("SUM(Amount)", string.Empty));
            amount.Text = sum.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            item.Text = dataGridView1.Rows[e.RowIndex].Cells["item"].Value.ToString();
            category.Text = dataGridView1.Rows[e.RowIndex].Cells["category_name"].Value.ToString();
            price.Text = dataGridView1.Rows[e.RowIndex].Cells["price"].Value.ToString();
        }

        private void removeItem_Click(object sender, EventArgs e)
        {
            if(dataGridView2.Rows.Count != 0)
            {
                int row = dataGridView2.CurrentCell.RowIndex;
                dataGridView2.Rows.RemoveAt(row);
                decimal sum = Convert.ToDecimal(dt.Compute("SUM(Amount)", string.Empty));
                amount.Text = sum.ToString();
            }
            else MessageBox.Show("No order placed", "Please order again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void coupon_Click(object sender, EventArgs e)
        {
            if (coup.Text == "GODISC10")
            {
                decimal sum = Convert.ToDecimal(dt.Compute("SUM(Amount)", string.Empty));
                string discount = string.Format("{0:0.00}", sum * 0.90m);
                amount.Text = discount;

            }
            else MessageBox.Show("Invalid Coupon Code", "Please type again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void placeOrder_Click(object sender, EventArgs e)
        {
            if(amount.Text != "-")
            {
                Form3 f3 = new Form3();
                f3.Show();
                f3.amount.Text = amount.Text;
                f3.dataGridView1.DataSource = dt;
                if(coup.Text == "GODISC10")
                {
                    f3.coupCopy.Text = "GODISC10";
                }
            }
            else MessageBox.Show("No order placed", "Please type again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void viewOrders_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to log out?",
          "Log Out", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
                Form1 a = new Form1();
                a.Show();
            }
        }
    }
}
