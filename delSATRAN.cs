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
    public partial class frm18DT : Form
    {
        DBconnection obj = new DBconnection();
        public frm18DT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tid = textBox1.Text;
            if (obj.delete_SalesTrans(Convert.ToInt32(tid)))
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
