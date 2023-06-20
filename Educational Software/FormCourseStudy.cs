﻿using Educational_Software.Model;
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
    public partial class FormCourseStudy : Form
    {
        private int courseId;
        private Image courseImage;
        private string courseName;
        private Form1 form1;
        private int lessonId = 1;

        public FormCourseStudy(int courseId, Form1 form1, Image courseImage, string courseName)
        {
            InitializeComponent();
            this.courseId = courseId;
            this.form1 = form1;
            this.courseImage = courseImage;
            this.courseName = courseName;
        }

        private void loadLesson()
        {
            using (StreamReader cour = new StreamReader("CourseMaterial/lessons" + courseId + ".json"))
            {
                string jsonc = cour.ReadToEnd();
                List<Lesson> lessons = JsonConvert.DeserializeObject<List<Lesson>>(jsonc);

                if((lessons.Count) < lessonId)
                {
                    form1.openChildForm(new FormCourseComplete(courseImage, courseName, form1));
                    return;
                }

                Lesson lesson = lessons.Where(c => c.Code == this.lessonId).First();

                labelTitle.Text = lesson.Name;

                Label[] labels = { label1, label2, label3, label4, label5};
                PictureBox[] pictureBoxes = {pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5};
                Panel[] panels = { panelBody1, panelBody2, panelBody3, panelBody4, panelBody5 };

                // label5/panel5 is for the Goals
                panelBody5.Show();
                StringBuilder sb = new StringBuilder();
                sb.Append("Μαθησιακά Αποτελέσματα του μαθήματος:\n");
                foreach(Goal goal in lesson.Goals) {
                    sb.Append(" > ");
                    sb.Append(goal.Text);
                    sb.Append('\n');
                }
                label5.Text = sb.ToString();

                for (int i= lesson.Paragraphs.Count-1; i>=0; i--)
                {
                    panels[i].Show();
                    labels[i].Text = lesson.Paragraphs[i].Text;
                    if (!lesson.Paragraphs[i].ImageName.Equals(""))
                    {
                        pictureBoxes[i].ImageLocation = "CourseMaterial/images/" + lesson.Paragraphs[i].ImageName;
                        pictureBoxes[i].Show();
                    }
                    else
                    {
                        pictureBoxes[i].Hide();
                    }                   
                }

                labelDesc.Text = lesson.Description;
                panelBodyDesc.Visible = true;

                panelBodyDesc.Select();
            }
        }


        private void Prev_Click(object sender, EventArgs e)
        {
            if(lessonId==1)
                form1.openChildForm(new FormCourseOverview(courseId, form1, courseImage));
            else
            {
                lessonId -= 1;
                loadLesson();
            }
        }

        private void FormCourseStudy_Load(object sender, EventArgs e)
        {
            loadLesson();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            lessonId += 1;
            loadLesson();
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            ((RoundedButton)sender).BorderColor = Color.FromArgb(242, 139, 29);
            ((RoundedButton)sender).ForeColor = Color.FromArgb(242, 139, 29);
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            ((RoundedButton)sender).BorderColor = Color.FromArgb(90, 116, 176);
            ((RoundedButton)sender).ForeColor = Color.FromArgb(90, 116, 176);
        }
    }
}
