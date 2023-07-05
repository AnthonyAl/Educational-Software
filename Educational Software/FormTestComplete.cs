using Educational_Software.Dao;
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

        UserDao dao = new UserDao();

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

            labelDesc.Text = "Score: " + corrects.ToString() + "/" + total.ToString() +" ή " + (corrects * 100) / total + "%";
            pictureBoxDesc.Image = courseImage;

            if (isProfession)
            {
                roundedButton3.Text = "Πίσω στις καριέρες";
            }

            Console.WriteLine(courseId);
            Console.WriteLine(isProfession);



            if (!isProfession)
            {
                dao.addcoursegrade(form1.userId, courseId, (corrects * 100) / total);
            }
            else
            {
                dao.addprofessiongrade(form1.userId, courseId, (corrects * 100) / total);
            }
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            form1.panelSideMenu.Visible = true;

            if (isProfession)
            {
                form1.openChildForm(form1.formCareers);
                return;
            }
            form1.openChildForm(new FormCourses(form1));
        }
    }
}
