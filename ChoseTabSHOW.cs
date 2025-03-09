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
    public partial class frm27SRec : Form
    {
        public frm27SRec()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm20SP frm20SP = new frm20SP();
            frm20SP.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm21SS frm21SS = new frm21SS();
            frm21SS.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm22SC frm22SC = new frm22SC();
            frm22SC.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm23ST frm23ST = new frm23ST();
            frm23ST.ShowDialog();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm24SU frm24SU = new frm24SU();
            frm24SU.ShowDialog();
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
