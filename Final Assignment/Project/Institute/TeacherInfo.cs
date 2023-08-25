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
    public partial class TeacherInfo : Form
    {
        public TeacherInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\NSBM\\NSBM Year 1\\Semester 2\\OOP C#\\Final Assignment\\Project\\Institute\\ClassAdminDB\\Database.mdf\";Integrated Security=True;Connect Timeout=30");

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE TeacherData SET Name=@Name, Telephone=@Telephone, EducationDepartment=@EducationDepartment, Address=@Address, Class=@Class WHERE ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(textBox6.Text));
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Telephone", textBox2.Text);
                cmd.Parameters.AddWithValue("@EducationDepartment", textBox3.Text);
                cmd.Parameters.AddWithValue("@Address", textBox4.Text);
                cmd.Parameters.AddWithValue("@Class", textBox5.Text);
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Successfully Updated", "Successful", MessageBoxButtons.OK);

                Teachers teachers = new Teachers();
                teachers.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\NSBM\\NSBM Year 1\\Semester 2\\OOP C#\\Final Assignment\\Project\\Institute\\ClassAdminDB\\Database.mdf\";Integrated Security=True;Connect Timeout=30");

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("DELETE TeacherData WHERE ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(textBox6.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Successfully Deleted", "Successful", MessageBoxButtons.OK);

                Teachers teachers = new Teachers();
                teachers.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Teachers teachers = new Teachers();
            teachers.Show();
            this.Close();
        }
    }
}
