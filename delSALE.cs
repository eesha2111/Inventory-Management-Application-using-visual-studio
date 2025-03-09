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
    public partial class fm16DS : Form
    {
        DBconnection obj = new DBconnection();
        public fm16DS()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sid = textBox1.Text;
            if (obj.delete_Sales(Convert.ToInt32(sid)))
            {
                MessageBox.Show("Record Deleted Successfully!");
                textBox1.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm26DRec frm26DRec = new frm26DRec();
            frm26DRec.ShowDialog();
            this.Hide();
        }
    }
}
