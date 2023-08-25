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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Institute
{
    public partial class TeacherRegistration : Form
    {
        public TeacherRegistration()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin Admin = new Admin();
            Admin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\NSBM\\NSBM Year 1\\Semester 2\\OOP C#\\Final Assignment\\Project\\Institute\\ClassAdminDB\\Database.mdf\";Integrated Security=True;Connect Timeout=30");

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("insert into TeacherData values (@Name, @ID, @Telephone, @EducationDepartment, @Gender, @Address, @Class)", con);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@ID", int.Parse(textBox2.Text));
                cmd.Parameters.AddWithValue("@Telephone", textBox3.Text);
                cmd.Parameters.AddWithValue("@EducationDepartment", textBox4.Text);
                if (radioButton1.Checked)
                {
                    cmd.Parameters.AddWithValue("@Gender", radioButton1.Text);

                }
                if (radioButton2.Checked)
                {
                    cmd.Parameters.AddWithValue("@Gender", radioButton2.Text);
                }

                cmd.Parameters.AddWithValue("@Address", textBox5.Text);

                string selectedClasses = "";
                if (checkBox1.Checked) selectedClasses += checkBox1.Text + " ";
                if (checkBox2.Checked) selectedClasses += checkBox2.Text + " ";
                if (checkBox3.Checked) selectedClasses += checkBox3.Text + " ";
                if (checkBox4.Checked) selectedClasses += checkBox4.Text + " ";
                if (checkBox5.Checked) selectedClasses += checkBox5.Text + " ";
                if (checkBox7.Checked) selectedClasses += checkBox7.Text + " ";

                cmd.Parameters.AddWithValue("@Class", selectedClasses.Trim());

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Successfully Student Profile Created", "Successful", MessageBoxButtons.OK);

                cashier cashier = new cashier();
                cashier.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox7.Checked = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
