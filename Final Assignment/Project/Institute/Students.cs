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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\NSBM\\NSBM Year 1\\Semester 2\\OOP C#\\Final Assignment\\Project\\Institute\\ClassAdminDB\\Database.mdf\";Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM StudentData WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("ID", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cashier cashier = new cashier();
            cashier.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentInfo studentInfo = new StudentInfo();
            studentInfo.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
