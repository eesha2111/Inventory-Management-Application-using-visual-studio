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
    public partial class frm7IC : Form
    {
        DBconnection obj = new DBconnection();
        public frm7IC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cid = textBox1.Text;
            string name= textBox7.Text;
            string email= textBox6.Text;
            string phone= textBox2.Text;
            if(obj.insert_Customer(Convert.ToInt32(cid), name, email, phone)) 
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
