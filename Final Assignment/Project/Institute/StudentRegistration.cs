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

namespace Institute
{
    public partial class StudentRegistration : Form
    {
        public StudentRegistration()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cashier cashier = new cashier();    
            cashier.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\NSBM\\NSBM Year 1\\Semester 2\\OOP C#\\Final Assignment\\Project\\Institute\\ClassAdminDB\\Database.mdf\";Integrated Security=True;Connect Timeout=30");

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO StudentData (Name, ID, Telephone, Gaurdian, Gender, Address, Class) VALUES (@Name, @ID, @Telephone, @Gaurdian, @Gender, @Address, @Class)", con);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@ID", int.Parse(textBox2.Text));
                cmd.Parameters.AddWithValue("@Telephone", textBox3.Text);
                cmd.Parameters.AddWithValue("@Gaurdian", textBox4.Text);
                if (radioButton1.Checked)
                {
                    cmd.Parameters.AddWithValue("@Gender", radioButton1.Text);
                }
                if (radioButton2.Checked)
                {
                    cmd.Parameters.AddWithValue("@Gender", radioButton2.Text);
                }
                cmd.Parameters.AddWithValue("@Address", textBox5.Text);
                cmd.Parameters.AddWithValue("@Class", comboBox1.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully Student Profile Created", "Successful", MessageBoxButtons.OK);

                cashier cashier = new cashier();
                cashier.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            comboBox1.Text = "";
        }
    }
}
