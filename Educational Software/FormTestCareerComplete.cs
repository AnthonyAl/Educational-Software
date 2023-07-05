using Educational_Software.Properties;
using Rounded;
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
    public partial class FormTestCareerComplete : Form
    {

        Form1 form1;
        int[] points;
        private string[] careers = { "Game Developer", "UX Designer", "Software Engineer", "Machine Learning Engineer",
            "Full-Stack Developer", "Data Scientist", "Back-end Developer", "Front-end Developer" };
        private Image[] images = { Resources.game, Resources.ux, Resources.softeng, Resources.mlenginerr,
            Resources.fulls, Resources.datascient, Resources.backend, Resources.frontend };

        public FormTestCareerComplete(Form1 form1, int[] points)
        {
            InitializeComponent();
            this.form1 = form1;
            this.points = points;
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            form1.panelSideMenu.Visible = true;
            form1.btnCareers.PerformClick();
        }

        private void career_Click(object sender, EventArgs e)
        {
            RoundedButton[] career_btns = { form1.formCareers.roundedButton1, form1.formCareers.roundedButton2, 
                form1.formCareers.roundedButton3, form1.formCareers.roundedButton4, form1.formCareers.roundedButton5, 
                form1.formCareers.roundedButton6, form1.formCareers.roundedButton7, form1.formCareers.roundedButton8};
            form1.panelSideMenu.Visible = true;
            form1.btnCareers.PerformClick();
            char id = ((Control)sender).Name[((Control)sender).Name.Length - 1];
            switch(id)
            {
                case '1':
                    career_btns[Array.IndexOf(careers, labelCareer1.Text)].PerformClick();
                    break;
                case '2':
                    career_btns[Array.IndexOf(careers, labelCareer2.Text)].PerformClick();
                    break;
                case '3':
                    career_btns[Array.IndexOf(careers, labelCareer3.Text)].PerformClick();
                    break;
            }
        }

        private void FormTestCareerComplete_Load(object sender, EventArgs e)
        {
            List<int> points = this.points.ToList();
            int maxIndex = points.IndexOf(points.Max());
            labelCareer1.Text = careers[maxIndex];
            pictureBoxCareer1.Image = images[maxIndex];
            points[maxIndex] = -1;
            maxIndex = points.IndexOf(points.Max());
            labelCareer2.Text = careers[maxIndex];
            pictureBoxCareer2.Image = images[maxIndex];
            points[maxIndex] = -1;
            maxIndex = points.IndexOf(points.Max());
            labelCareer3.Text = careers[maxIndex];
            pictureBoxCareer3.Image = images[maxIndex];
            points[maxIndex] = -1;
        }
    }
}
