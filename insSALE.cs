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
    public partial class frm6IS : Form
    {
        DBconnection obj=new DBconnection();
        DateTime date=new DateTime();
        public frm6IS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sid = textBox1.Text;
            string pid = textBox7.Text;
            date = dateTimePicker1.Value;
            string quan = textBox2.Text;
            string rev = textBox3.Text;
            if (obj.insert_Sales(Convert.ToInt32(sid),Convert.ToInt32(pid), date, Convert.ToInt32(quan), Convert.ToInt32(rev)))
            {
                MessageBox.Show("Data Inserted Successfully!");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox7.Clear();
                dateTimePicker1.CustomFormat = "dd / MM / yyy";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm4IRec frm4IRec = new frm4IRec();
            frm4IRec.ShowDialog();
            this.Hide();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}

