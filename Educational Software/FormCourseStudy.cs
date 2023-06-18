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
    public partial class FormCourseStudy : Form
    {
        private int courseId;
        private Form1 form1;

        public FormCourseStudy(int courseId, Form1 form1)
        {
            InitializeComponent();
            this.courseId = courseId;
            this.form1 = form1;
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            form1.openChildForm(new FormCourseOverview(courseId, form1));
        }
    }
}
