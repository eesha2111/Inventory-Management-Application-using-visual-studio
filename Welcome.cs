﻿using System;
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
    public partial class frm1Con : Form
    {
        DBconnection obj = new DBconnection();
        public frm1Con()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            obj.connect();
            
                MessageBox.Show("Connected Successfully!");
                frm2ver vr= new frm2ver();
                vr.ShowDialog();
                this.Hide();
            
        }
    }
}
