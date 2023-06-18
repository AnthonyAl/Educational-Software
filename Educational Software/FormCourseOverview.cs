using Educational_Software.Model;
using Newtonsoft.Json;
using Rounded;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educational_Software
{
    public partial class FormCourseOverview : Form
    {
        private int courseId;
        private Image courseImage;
        private Form1 form1;

        public FormCourseOverview(int courseId, Form1 form1, Image courseImage)
        {
            InitializeComponent();
            this.courseId = courseId;
            this.form1 = form1;
            this.courseImage = courseImage;
        }

        private void FormTeaching_Load(object sender, EventArgs e)
        {
            using (StreamReader cour = new StreamReader("CourseMaterial/courses.json"))
            {
                string jsonc = cour.ReadToEnd();
                List<Course> courses = JsonConvert.DeserializeObject<List<Course>>(jsonc);

                Course course = courses.Where(c => c.Number == this.courseId).First();

                labelTitle.Text = course.Name;
                labelDesc.Text = course.Introduction;
                pictureBoxDesc.Image = courseImage;

            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            form1.openChildForm(new FormCourseStudy(courseId, form1, courseImage, labelTitle.Text));
        }

        private void Back_Click(object sender, EventArgs e)
        {
            form1.openChildForm(new FormCourses(form1));
        }

        private void panelFooter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            ((RoundedButton)sender).BorderColor = Color.FromArgb(242, 139, 29);
            ((RoundedButton)sender).ForeColor = Color.FromArgb(242, 139, 29);
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            ((RoundedButton)sender).BorderColor = Color.FromArgb(36, 45, 66);
            ((RoundedButton)sender).ForeColor = Color.FromArgb(36, 45, 66);
        }
    }
}
