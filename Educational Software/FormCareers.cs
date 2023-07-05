using Educational_Software.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educational_Software
{
    public partial class FormCareers : Form
    {
        Form1 form1;

        public FormCareers(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }



        private void roundedButton1_Click(object sender, EventArgs e)
        {
            form1.openChildForm(new FormCourseStudy(1, form1, pictureBox1.Image));
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            form1.openChildForm(new FormCourseStudy(2, form1, pictureBox2.Image));
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            form1.openChildForm(new FormCourseStudy(3, form1, pictureBox3.Image));
        }
        private void roundedButton4_Click(object sender, EventArgs e)
        {
            form1.openChildForm(new FormCourseStudy(4, form1, pictureBox4.Image));
        }

        private void roundedButton8_Click(object sender, EventArgs e)
        {
            form1.openChildForm(new FormCourseStudy(5, form1, pictureBox5.Image));
        }

        private void roundedButton7_Click(object sender, EventArgs e)
        {
            form1.openChildForm(new FormCourseStudy(6, form1, pictureBox6.Image));
        }

        private void roundedButton6_Click(object sender, EventArgs e)
        {
            form1.openChildForm(new FormCourseStudy(7, form1, pictureBox7.Image));
        }

        private void roundedButton5_Click(object sender, EventArgs e)
        {
            form1.openChildForm(new FormCourseStudy(8, form1, pictureBox8.Image));
        }
    }
}
