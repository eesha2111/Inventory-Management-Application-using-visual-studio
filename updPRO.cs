using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory_Management_Application
{
    public partial class frm10UP : Form
    {
        int i = 0;
        DBconnection obj = new DBconnection();
        DataTable dt = new DataTable();

        public frm10UP()
        {
            InitializeComponent();
            dt = obj.select_Product();
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string I = textBox1.Text;
            string N = textBox7.Text;
            string D = textBox6.Text;
            string SK = textBox2.Text;
            string C = textBox3.Text;
            string S = textBox4.Text;
            string Q = textBox5.Text;
            if (obj.update_Product(Convert.ToInt32(I), N, D, SK, Convert.ToInt32(C), Convert.ToInt32(S), Convert.ToInt32(Q)))
            {
                MessageBox.Show("Record Updated Successfully!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            textBox1.Text = dt.Rows[i][0].ToString();
            textBox7.Text = dt.Rows[i][1].ToString();
            textBox6.Text = dt.Rows[i][2].ToString();
            textBox2.Text = dt.Rows[i][3].ToString();
            textBox3.Text = dt.Rows[i][4].ToString();
            textBox4.Text = dt.Rows[i][5].ToString();
            textBox5.Text = dt.Rows[i][6].ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                textBox1.Text = dt.Rows[i][0].ToString();
                textBox7.Text = dt.Rows[i][1].ToString();
                textBox6.Text = dt.Rows[i][2].ToString();
                textBox2.Text = dt.Rows[i][3].ToString();
                textBox3.Text = dt.Rows[i][4].ToString();
                textBox4.Text = dt.Rows[i][5].ToString();
                textBox5.Text = dt.Rows[i][6].ToString();
            }
            else
            {
                MessageBox.Show("You reached start of the table!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int total = dt.Rows.Count;
            if (i < total - 1)
            {
                i++;
                textBox1.Text = dt.Rows[i][0].ToString();
                textBox7.Text = dt.Rows[i][1].ToString();
                textBox6.Text = dt.Rows[i][2].ToString();
                textBox2.Text = dt.Rows[i][3].ToString();
                textBox3.Text = dt.Rows[i][4].ToString();
                textBox4.Text = dt.Rows[i][5].ToString();
                textBox5.Text = dt.Rows[i][6].ToString();
            }
            else
            {
                MessageBox.Show("You reached end of the table!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int total = dt.Rows.Count;
            textBox1.Text = dt.Rows[total - 1][0].ToString();
            textBox7.Text = dt.Rows[total - 1][1].ToString();
            textBox6.Text = dt.Rows[total - 1][2].ToString();
            textBox2.Text = dt.Rows[total - 1][3].ToString();
            textBox3.Text = dt.Rows[total - 1][4].ToString();
            textBox4.Text = dt.Rows[total - 1][5].ToString();
            textBox5.Text = dt.Rows[total - 1][6].ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm25URec frm25URec = new frm25URec();
            frm25URec.ShowDialog();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
