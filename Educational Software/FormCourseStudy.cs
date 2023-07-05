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
    public partial class FormCourseStudy : Form
    {
        private int courseId;
        private Image courseImage;
        private string courseName;
        private Form1 form1;
        private int lessonId = 1;

        private int professionId;
        private bool isProfession = false;
        private Profession profession;

        public FormCourseStudy(int courseId, Form1 form1, Image courseImage, string courseName)
        {
            InitializeComponent();
            this.courseId = courseId;
            this.form1 = form1;
            this.courseImage = courseImage;
            this.courseName = courseName;
        }

        public FormCourseStudy(int professionId, Form1 form1, Image courseImage)
        {
            InitializeComponent();
            this.professionId = professionId;
            this.form1 = form1;
            this.courseImage = courseImage;
            this.isProfession = true;
        }

        private void loadLesson()
        {
            using (StreamReader cour = new StreamReader("CourseMaterial/lessons" + courseId + ".json"))
            {
                string jsonc = cour.ReadToEnd();
                List<Lesson> lessons = JsonConvert.DeserializeObject<List<Lesson>>(jsonc);

                if((lessons.Count) < lessonId)
                {
                    form1.openChildForm(new FormCourseComplete(courseImage, courseName, form1, false,courseId));
                    return;
                }

                Lesson lesson = lessons.Where(c => c.Code == this.lessonId).First();

                labelTitle.Text = lesson.Name;

                Label[] labels = { label1, label2, label3, label4};
                PictureBox[] pictureBoxes = {pictureBox1, pictureBox2, pictureBox3, pictureBox4};
                Panel[] panels = { panelBody1, panelBody2, panelBody3, panelBody4 };

                foreach (Panel panel in panels)
                {
                    panel.Visible = false;
                }

                // label5/panel5 is for the Goals
                panelBody5.Show();
                StringBuilder sb = new StringBuilder();
                sb.Append("Μαθησιακά Αποτελέσματα του μαθήματος:\n");
                sb.Append('\n');
                foreach (Goal goal in lesson.Goals) {
                    sb.Append(" > \t ");
                    sb.Append(goal.Text);
                    sb.Append('\n');
                    sb.Append('\n');
                }
                label5.Text = sb.ToString();

                for (int i= panels.Length-1; i>=0; i--)
                {
                    Console.WriteLine(i);
                    if (i >= lesson.Paragraphs.Count)
                    {
                        panels[i].Visible = false;
                        Console.WriteLine("skip");
                        continue;
                    }

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

                int body_index = panelBody.Controls.GetChildIndex(panelBody5);
                foreach (Panel panel in panels.Reverse())
                {
                    panelBody.Controls.SetChildIndex(panel, ++body_index);
                }

                Console.WriteLine(label4.Text.ToString());

                labelDesc.Text = lesson.Description;
                panelBodyDesc.Show();
                panelBody.Controls.SetChildIndex(panelBodyDesc, ++body_index);

                panelBodyDesc.Select();

                // extra links
                if (lesson.Extras != null)
                {
                    if(lesson.Extras.Count > 0)
                    {
                        Label[] labelLinks = { labelLink1, labelLink2, labelLink3 };
                        Button[] btnLinks = { roundedButtonLink1, roundedButtonLink2, roundedButtonLink3 };

                        for(int i= 0; i< lesson.Extras.Count; i++)
                        {
                            labelLinks[i].Text = lesson.Extras[i].Title;
                            btnLinks[i].Tag = lesson.Extras[i].Url;
                        }
                    }
                }

            }
        }

        private void loadProfession()
        {
            using (StreamReader cour = new StreamReader("CourseMaterial/profession" + professionId + ".json"))
            {
                string jsonc = cour.ReadToEnd();
                profession = JsonConvert.DeserializeObject<Profession>(jsonc);
            }
        }

        private void showProfession()
        {
            panelBodyDesc.Hide();
            Label[] labels = { label1, label2, label3, label4, label5 };
            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 };
            Panel[] panels = { panelBody1, panelBody2, panelBody3, panelBody4, panelBody5 };

            foreach (Panel panel in panels)
            {
                panel.Visible = false;
            }

            panelButtons.Visible = false;

            switch (lessonId)
            {
                case 1:
                    labelTitle.Text = profession.Name + " Κοινωνικές Δεξιότητες (Soft Skills)";
                    for (int i= panels.Length-1; i>=0; i--)
                    {
                        panels[i].Visible = true;
                        labels[i].Text = profession.SoftSkills[i].Text;
                    }
                    panelBody1.Select();
                    break;

                case 2:
                    labelTitle.Text = profession.Name + " Τεχνικές δεξιότητες (Hard Skills)";
                    for (int i = panels.Length - 1; i >= 0; i--)
                    {
                        panels[i].Visible = true;
                        labels[i].Text = profession.HardSkills[i].Text;
                    }
                    panelBody1.Select();
                    break;

                case 3:
                    labelTitle.Text = profession.Name + " Βασικά Στοιχεία";
                    for (int i = panels.Length - 1; i >= 0; i--)
                    {
                        if (i > profession.Paragraphs.Count-1)
                            continue;

                        panels[i].Visible = true;
                        labels[i].Text = profession.Paragraphs[i].Text;
                    }
                    panelBody1.Select();
                    break;

                case 4:
                    labelTitle.Text = profession.Name + " Απαραίτητα Μαθήματα";

                    StringBuilder sb = new StringBuilder();
                    sb.Append('\n');
                    foreach (Paragraph paragraph in profession.Requirements)
                    {
                        sb.Append(" > \t ");
                        sb.Append(paragraph.Text);
                        sb.Append('\n');
                    }
                    label2.Text = sb.ToString();
                    
                    panelBody2.Show();
                    
                    panelBody1.Show();
                    label1.Text = "Από τα μαθήματα που περιγράφηκαν, τα παρακάτω είναι απαραίτητα για την καριέρα ενός " + profession.Name;

                    panelBody1.Select();

                    break;

                 case 5:
                    form1.openChildForm(new FormCourseComplete(courseImage, profession.Name, form1, true,professionId));
                    return;
            }
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (isProfession && lessonId == 1)
            {
                form1.openChildForm(form1.formCareers);
                return;
            }

            if (isProfession)
            {
                lessonId -= 1;
                showProfession();
                return;
            }


            if (lessonId==1)
                form1.openChildForm(new FormCourseOverview(courseId, form1, courseImage));
            else
            {
                lessonId -= 1;
                loadLesson();
            }
        }

        private void FormCourseStudy_Load(object sender, EventArgs e)
        {
            if (isProfession)
            {
                loadProfession();
                showProfession();


                return;
            }
            loadLesson();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            lessonId += 1;

            if (isProfession)
            {
                showProfession();
                return;
            }

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

        private void roundedButtonLink1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(((Control)sender).Tag.ToString());
            //MessageBox.Show(((Control)sender).Tag.ToString());
        }

        private void roundedButtonLink2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(((Control)sender).Tag.ToString());
            //MessageBox.Show(((Control)sender).Tag.ToString());
        }

        private void roundedButtonLink3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(((Control)sender).Tag.ToString());
            //MessageBox.Show(((Control)sender).Tag.ToString());
        }
    }
}
