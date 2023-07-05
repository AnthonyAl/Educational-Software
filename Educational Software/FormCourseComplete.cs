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
    public partial class FormCourseComplete : Form
    {
        Image courseImage;
        string courseTitle;
        Form1 form1;
        private bool isProfession = false;
        int courseId;

        private Random random = new Random();

        public FormCourseComplete(Image courseImage, string courseTitle, Form1 form1, bool isProfession, int courseId)
        {
            InitializeComponent();
            this.courseImage = courseImage;
            this.courseTitle = courseTitle;
            this.form1 = form1;
            this.isProfession = isProfession;
            this.courseId = courseId;   
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            if (isProfession)
            {
                form1.openChildForm(form1.formCareers);
                return;
            }

            form1.openChildForm(new FormCourses(form1));
        }

        private void FormCourseComplete_Load(object sender, EventArgs e)
        {
            labelDesc.Text = courseTitle + "!\n" + "\nΤώρα μπορείτε να συνεχίσεται στις επόμενες ενότητες, ή να ξεκινήσετε " +
                "τη διαδικασία εκτίμησης καριέρας.";
            pictureBoxDesc.Image = courseImage;

            if (isProfession)
            {
                roundedButton3.Text = "Πίσω στις καριέρες";
            }
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            //test
            //List<Question> allQuestions1;
            //using (StreamReader cour = new StreamReader("CourseMaterial/p1.json"))
            //{
            //    string jsonc = cour.ReadToEnd();
            //    allQuestions1 = JsonConvert.DeserializeObject<List<Question>>(jsonc);
            //}
            //form1.panelSideMenu.Visible = false;
            //form1.openChildForm(new FormTest(allQuestions1, courseImage, courseTitle, form1, courseId, isProfession));
            //return;

            if (isProfession)
            {
                List<Question> allQuestions1;
                using (StreamReader cour = new StreamReader("CourseMaterial/p"+ courseId + ".json"))
                {
                    string jsonc = cour.ReadToEnd();
                    allQuestions1 = JsonConvert.DeserializeObject<List<Question>>(jsonc);
                }
                form1.panelSideMenu.Visible = false;
                form1.openChildForm(new FormTest(allQuestions1, courseImage, courseTitle, form1, courseId, isProfession));
                return;
            }



            // create a quiz




            // create question list
            List<Question> questions = new List<Question>();

            List<Question> allQuestions;
            List<Question> selectedQuestions;

            using (StreamReader cour = new StreamReader("CourseMaterial/questions"+courseId+".json"))
            {
                string jsonc = cour.ReadToEnd();
                allQuestions = JsonConvert.DeserializeObject<List<Question>>(jsonc);             
            }


            int numberOfLessons=1;

            if (courseId == 1)
                numberOfLessons = 7;
            if (courseId == 2)
                numberOfLessons = 4;
            if (courseId == 3)
                numberOfLessons = 4;
            if (courseId == 4)
                numberOfLessons = 3;

            for (int i= 1; i <= numberOfLessons; i++)
            {
                selectedQuestions = allQuestions.Where(q => q.LessonCode == i).ToList();
                selectedQuestions = selectedQuestions.OrderBy(q => random.Next()).ToList(); // source: https://stackoverflow.com/questions/273313/randomize-a-listt
                selectedQuestions = selectedQuestions.Take(2).ToList();
                questions = questions.Concat(selectedQuestions).ToList();
            }

            if (courseId == 4)
            {
                // load rev questions
                using (StreamReader cour = new StreamReader("CourseMaterial/questions4rev.json"))
                {
                    string jsonc = cour.ReadToEnd();
                    List<Question> revQuestions = JsonConvert.DeserializeObject<List<Question>>(jsonc);
                    questions = questions.Concat(revQuestions).ToList();
                }
            }


            // suffle all questions
            questions = questions.OrderBy(q => random.Next()).ToList();

            form1.panelSideMenu.Visible = false;
            form1.openChildForm(new FormTest(questions, courseImage, courseTitle, form1, courseId, isProfession));
        }
    }
}
