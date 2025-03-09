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
    public partial class frm25URec : Form
    {
        public frm25URec()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm10UP frm10UP = new frm10UP();
            frm10UP.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm11US frm11US = new frm11US();
            frm11US.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm12UC frm12UC = new frm12UC();
            frm12UC.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm13UT frm13UT = new frm13UT();
            frm13UT.ShowDialog();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm14UU frm14UU = new frm14UU();
            frm14UU.ShowDialog();
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
