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
    public partial class frm19DU : Form
    {
        DBconnection obj = new DBconnection();
        public frm19DU()
        {
            InitializeComponent();
        }

        private void Form19_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uid = textBox1.Text;
            if (obj.delete_User(Convert.ToInt32(uid)))
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
