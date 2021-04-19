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
    public partial class Form3 : Form
    {
        Form2 f2 = new Form2();
        MySqlConnection conn;
        public Form previousform;
        public Form3()
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


        private void placePayment_Click(object sender, EventArgs e)
        {
            int discount = 0;
            if(coupCopy.Text == "GODISC10")
            {
                discount = 10;
            }
            if (dataGridView1.Rows.Count != 0)
            {
                string queryInsert = "insert into orders(amount, discount) values('" + amount.Text + "', '" + discount + "');";
                executeQuery(queryInsert);
                for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
                {
                    string value = dataGridView1.Rows[rows].Cells[0].Value.ToString();
                    string queryInsertMenu = "insert into order_details(order_order_id, menu_menu_id) " +
                        "values((select order_id from orders order by order_id desc limit 1)," +
                        " (select menu_id from menu where item = '" + value + "'))";
                    executeQuery(queryInsertMenu);
                }
                MessageBox.Show("Payment in ₱'" + amount.Text + "' placed.", "Please order again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                f2.Show();
            }
        }

        private void bank_SelectedIndexChanged(object sender, EventArgs e)
        {
            bankNumber.Enabled = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            bankNumber.Enabled = false;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void bankNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
