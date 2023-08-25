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
    public partial class cashier : Form
    {
        public cashier()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentRegistration StudentRegistration = new StudentRegistration();
            StudentRegistration.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            students.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            ClassAdmin classadmin = new ClassAdmin();
            classadmin.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Teachers teachers = new Teachers();
            teachers.Show();
            this.Hide();
        }
    }
}
