using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_Management_Application
{
    public partial class frm24SU : Form
    {
        DBconnection obj = new DBconnection();
        DataTable dt = new DataTable();
        public frm24SU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt = obj.select_User();
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm27SRec frm27SRec = new frm27SRec();
            frm27SRec.ShowDialog();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            obj.connect();
            string query = textBox1.Text;
            DataTable dt = obj.GetTables(query);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.connect();
            dataGridView1.DataSource = dt;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dt = obj.Between();
            dataGridView1.DataSource = dt;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            dt = obj.GetSortedProducts();
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt = obj.GetCustomerProductInfo();
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            i = obj.GetTotalRevenue();
            MessageBox.Show("Total Revenue:" + i);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            int p = 0;
            p = obj.GetCustomerCount();
            MessageBox.Show("Total No. of customers:" + p);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dt = obj.GetProductsAndSales();
            dataGridView1.DataSource = dt;
        }
    }
}

