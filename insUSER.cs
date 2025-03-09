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
    public partial class frm9IU : Form
    {
        DBconnection obj = new DBconnection();
        public frm9IU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uid = textBox1.Text;
            string name = textBox7.Text;
            string pass = textBox6.Text;
            string role = textBox2.Text;
            if (obj.insert_User(Convert.ToInt32(uid), name, pass, role))
            {

                MessageBox.Show("Data Inserted Successfully!");
                textBox1.Clear();
                textBox2.Clear();
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
