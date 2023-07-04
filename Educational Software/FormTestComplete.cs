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
    public partial class FormTestComplete : Form
    {

        Image courseImage;
        string courseTitle;
        Form1 form1;

        private int corrects;
        private int total;
        private int courseId;
        private bool isProfession;

        public FormTestComplete(Image courseImage, string courseTitle, Form1 form1, int corrects, int total, int courseId, bool isProfession)
        {
            InitializeComponent();
            this.courseImage = courseImage;
            this.courseTitle = courseTitle;
            this.form1 = form1;
            this.corrects = corrects;
            this.total = total;
            this.courseId = courseId;
            this.isProfession = isProfession;
        }

        private void FormTestComplete_Load(object sender, EventArgs e)
        {
            labelOverview.Text = "Ολοκληρώσατε το Τεστ της Ενότητας " + courseTitle;

            labelDesc.Text = "Score: " + corrects.ToString() + "/" + total.ToString();
            pictureBoxDesc.Image = courseImage;

            Console.WriteLine(courseId);
            Console.WriteLine(isProfession);
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            form1.openChildForm(new FormCourses(form1));
        }
    }
}
