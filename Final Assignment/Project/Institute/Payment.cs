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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\NSBM\\NSBM Year 1\\Semester 2\\OOP C#\\Final Assignment\\Project\\Institute\\ClassAdminDB\\Database.mdf\";Integrated Security=True;Connect Timeout=30");
            con.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM StudentData WHERE ID=@ID", con);
                cmd.Parameters.AddWithValue("ID", int.Parse(textBox1.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                SqlCommand getClassCmd = new SqlCommand("SELECT Class FROM StudentData WHERE ID=@ID", con);
                getClassCmd.Parameters.AddWithValue("ID", int.Parse(textBox1.Text));

                object classValue = getClassCmd.ExecuteScalar(); 

                if (classValue != null)
                {
                    string classCode = classValue.ToString();

                    switch (classCode)
                    {
                        case "06":
                            label3.Text = "Amount is Rs.850";
                            break;
                        case "07":
                            label3.Text = "Amount is Rs.900";
                            break;
                        case "08":
                            label3.Text = "Amount is Rs.1000";
                            break;
                        case "09":
                            label3.Text = "Amount is Rs.1100";
                            break;
                        case "10":
                            label3.Text = "Amount is Rs.1200";
                            break;
                        case "11":
                            label3.Text = "Amount is Rs.1300";
                            break;
                        case "12":
                            label3.Text = "Amount is Rs.1400";
                            break;
                        default:
                            label3.Text = "Amount to be Paid";
                            break;
                    }
                }
                else
                {
                    label3.Text = "Class code not found";
                }
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

        private void button3_Click(object sender, EventArgs e)
        {
            cashier cashier = new cashier();
            cashier.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\NSBM\\NSBM Year 1\\Semester 2\\OOP C#\\Final Assignment\\Project\\Institute\\ClassAdminDB\\Database.mdf\";Integrated Security=True;Connect Timeout=30");
            con.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE StudentData SET Payment=@Payment WHERE ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@Payment", "Paid");

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Successfully Paid", "Payment", MessageBoxButtons.OK);

                    cashier cashier = new cashier();
                    cashier.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No records were updated.", "No Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

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

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\NSBM\\NSBM Year 1\\Semester 2\\OOP C#\\Final Assignment\\Project\\Institute\\ClassAdminDB\\Database.mdf\";Integrated Security=True;Connect Timeout=30");
            con.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE StudentData SET Payment=@Payment WHERE ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@Payment", "Not Paid");

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Payment updated to Not Paid", "Payment", MessageBoxButtons.OK);

                    cashier cashier = new cashier();
                    cashier.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No records were updated.", "No Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
