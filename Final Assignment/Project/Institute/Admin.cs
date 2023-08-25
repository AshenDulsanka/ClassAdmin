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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClassAdmin Form1 = new ClassAdmin();
            Form1.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TeacherRegistration TeacherRegistration = new TeacherRegistration();
            TeacherRegistration.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StudentRegistration student = new StudentRegistration();
            student.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            students.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teachers teachers = new Teachers();
            teachers.Show();
            this.Close();
        }
    }
}
