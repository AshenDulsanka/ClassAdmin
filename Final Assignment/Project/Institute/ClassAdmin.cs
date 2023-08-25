using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Institute
{
    public partial class ClassAdmin : Form
    {
        public ClassAdmin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUser.Text =="Admin" && txtPass.Text == "Admin_123")
            {
                Admin Admin = new Admin();
                Admin.Show();
                this.Hide();
            }
            else if(txtUser.Text == "Cashier" && txtPass.Text == "Cashier_123")
            {
                cashier cashier = new cashier();    
                cashier.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password","Message box!!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
