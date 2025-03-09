using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_Application
{
    public partial class frm5IP : Form
    {
        DBconnection obj = new DBconnection();
        public frm5IP()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string name=textBox2.Text;
            string desc = textBox3.Text;
            string sku = textBox4.Text;
            string cost = textBox5.Text;
            string sell = textBox6.Text;
            string quant = textBox7.Text;
            if (obj.insert_Product(Convert.ToInt32(id), name, desc, sku, Convert.ToInt32(cost), Convert.ToInt32(sell), Convert.ToInt32(quant)))
            {
                MessageBox.Show("Data Inserted Successfully!");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm4IRec frm4IRec= new frm4IRec();
            frm4IRec.ShowDialog();
            this.Hide();
        }
    }
}
