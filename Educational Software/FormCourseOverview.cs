using Educational_Software.Model;
using Newtonsoft.Json;
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
        private Form1 form1;

        public FormCourseOverview(int courseId, Form1 form1)
        {
            InitializeComponent();
            this.courseId = courseId;
            this.form1 = form1;
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

            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            form1.openChildForm(new FormCourseStudy(courseId, form1));
        }

        private void Back_Click(object sender, EventArgs e)
        {
            form1.openChildForm(new FormCourses(form1));
        }
    }
}
