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
    public partial class frm4IRec : Form
    {
        public frm4IRec()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm5IP frm5IP = new frm5IP();
            frm5IP.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm6IS frm6IS = new frm6IS();
            frm6IS.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm7IC frm7IC = new frm7IC();
            frm7IC.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm8IT frm8IT = new frm8IT();
            frm8IT.ShowDialog();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm9IU frm9IU = new frm9IU();
            frm9IU.ShowDialog();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm3chos frm3chos = new frm3chos();
            frm3chos.ShowDialog();
            this.Hide();
        }
    }
}
