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
    public partial class frm11US : Form
    {
        int i = 0;
        DBconnection obj = new DBconnection();
        DataTable dt = new DataTable();
        
        DateTime date = new DateTime();
        public frm11US()
        {
            InitializeComponent();
            dt = obj.select_Sales();
            dataGridView1.DataSource = dt;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string I = textBox1.Text;
            string PI = textBox7.Text;
            date = dateTimePicker1.Value;
            string Q = textBox2.Text;
            string R = textBox3.Text;
            if (obj.update_Sales(Convert.ToInt32(I), Convert.ToInt32(PI), date, Convert.ToInt32(Q),Convert.ToInt32(R)))
            {
                MessageBox.Show("Record Updated Successfully!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            textBox1.Text = dt.Rows[i][0].ToString();
            textBox7.Text = dt.Rows[i][1].ToString();
            dateTimePicker1.Value = (DateTime)dt.Rows[i][2];
            textBox2.Text = dt.Rows[i][3].ToString();
            textBox3.Text = dt.Rows[i][4].ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                textBox1.Text = dt.Rows[i][0].ToString();
                textBox7.Text = dt.Rows[i][1].ToString();
                dateTimePicker1.Value = (DateTime)dt.Rows[i][2];
                textBox2.Text = dt.Rows[i][3].ToString();
                textBox3.Text = dt.Rows[i][4].ToString();
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
                dateTimePicker1.Value = (DateTime)dt.Rows[i][2];
                textBox2.Text = dt.Rows[i][3].ToString();
                textBox3.Text = dt.Rows[i][4].ToString();
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
            dateTimePicker1.Value = (DateTime)dt.Rows[total - 1][2];
            textBox2.Text = dt.Rows[total - 1][3].ToString();
            textBox3.Text = dt.Rows[total - 1][4].ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm25URec frm25URec = new frm25URec();
            frm25URec.ShowDialog();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }
    }
}
