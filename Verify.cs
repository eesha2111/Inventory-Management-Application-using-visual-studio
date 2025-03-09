using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Inventory_Management_Application
{
    public partial class frm2ver : Form
    {   
       
        public frm2ver()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (txtusr.Text == "")
            {
                MessageBox.Show("Enter the Username");
            }
            else if(txtpass.Text =="")
            {
                MessageBox.Show("Enter the Password");
            }
           else
            {
                try
                {
                    SqlConnection cn = new SqlConnection("Server=(localdb)\\mssqllocaldb; Database=C:\\USERS\\LOVEE\\DOCUMENTS\\STUDENTS.MDF; Integrated Security=True;");
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Username = @Username AND Password = @Password", cn);
                    cmd.Parameters.AddWithValue("@username", txtusr.Text);
                    cmd.Parameters.AddWithValue("@password", txtpass.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Total No. of Customers: 6");
                        frm3chos cs = new frm3chos();
                        cs.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is Invalid");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :" + ex.Message);
                }

                
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ask the Admin to add your data (; ");
        }
    }
}
