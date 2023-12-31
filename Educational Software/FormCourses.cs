﻿using Educational_Software.CustomControls;
using Educational_Software.Dao;
using Rounded;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Educational_Software
{
    public partial class FormCourses : Form
    {
        private Form1 form1;

        UserDao dao = new UserDao();

        public FormCourses(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;



            label1.Text = dao.getMaxCourseGrade(form1.userId, 1).ToString() + "%";
            label2.Text = dao.getMaxCourseGrade(form1.userId, 2).ToString() + "%";
            label3.Text = dao.getMaxCourseGrade(form1.userId, 3).ToString() + "%";
            label4.Text = dao.getMaxCourseGrade(form1.userId, 4).ToString() + "%";
        }

        private void FormCourses_Load(object sender, EventArgs e)
        {

            List<string> courseGroupNames = new List<string>();
            courseGroupNames.Add("Θεμελιωδεις γνωσεις Πληροφορικής");
            courseGroupNames.Add("Εισαγωγη στην αναπτυξη εφαρμογων");
            courseGroupNames.Add("Προηγμένες γνωσεις Πληροφορικής");
            courseGroupNames.Add("Εισαγωγη σε Ευφυη Συστηματα");

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            form1.openChildForm(new FormCourseOverview(1, form1, pictureBox1.Image));
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            form1.openChildForm(new FormCourseOverview(2, form1, pictureBox1.Image));
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            form1.openChildForm(new FormCourseOverview(3, form1, pictureBox1.Image));
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            form1.openChildForm(new FormCourseOverview(4, form1, pictureBox4.Image));
        }
    }
}
