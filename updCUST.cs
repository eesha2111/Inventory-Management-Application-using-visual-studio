using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory_Management_Application
{
    public partial class frm12UC : Form
    {
        int i = 0;
        DBconnection obj = new DBconnection();
        DataTable dt = new DataTable();
        string connection = "Server=(localdb)\\mssqllocaldb; Database=C:\\USERS\\LOVEE\\DOCUMENTS\\STUDENTS.MDF; Integrated Security=True;";
        SqlConnection conn = new SqlConnection();

        public frm12UC()
        {
            InitializeComponent();
            dt = obj.select_Customers();
            dataGridView1.DataSource = dt;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
                string I = textBox1.Text;
                string N = textBox7.Text;
                string E = textBox6.Text;
                string P = textBox2.Text;
                if (obj.update_Customer(Convert.ToInt32(I), N, E, P))
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
