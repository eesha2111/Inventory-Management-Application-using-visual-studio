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
    public partial class frm26DRec : Form
    {
        public frm26DRec()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm15DP frm15DP = new frm15DP();
            frm15DP.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fm16DS frm16DS = new fm16DS();
            frm16DS.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm17DC frm17DC = new frm17DC();
            frm17DC.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm18DT frm18DT = new frm18DT();
            frm18DT.ShowDialog();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm19DU frm19DU = new frm19DU();
            frm19DU.ShowDialog();
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
