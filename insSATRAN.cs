using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory_Management_Application
{
   
    public partial class frm8IT : Form
    {
        DBconnection obj = new DBconnection();
        public frm8IT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tid=textBox1.Text;
            string pid = textBox7.Text;
            string cid = textBox6.Text;
            if (obj.insert_SalesTrans(Convert.ToInt32(tid), Convert.ToInt32(pid), Convert.ToInt32(cid)))
            {
                MessageBox.Show("Data Inserted Successfully!");
                textBox1.Clear();
                textBox6.Clear();
                textBox7.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm4IRec frm4IRec = new frm4IRec();
            frm4IRec.ShowDialog();
            this.Hide();
        }
    }
}

