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

        private Random random = new Random();

        public FormCourseComplete(Image courseImage, string courseTitle, Form1 form1)
        {
            InitializeComponent();
            this.courseImage = courseImage;
            this.courseTitle = courseTitle;
            this.form1 = form1;
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            form1.openChildForm(new FormCourses(form1));
        }

        private void FormCourseComplete_Load(object sender, EventArgs e)
        {
            labelDesc.Text = courseTitle + "!\n" + "\nΤώρα μπορείτε να συνεχίσεται στις επόμενες ενότητες, ή να ξεκινήσετε " +
                "τη διαδικασία εκτίμησης καριέρας.";
            pictureBoxDesc.Image = courseImage;
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            //test
            //List<Question> allQuestions1;
            //using (StreamReader cour = new StreamReader("CourseMaterial/questionsDEMO.json"))
            //{
            //    string jsonc = cour.ReadToEnd();
            //    allQuestions1 = JsonConvert.DeserializeObject<List<Question>>(jsonc);
            //}
            //form1.openChildForm(new FormTest(allQuestions1));
            //return;

            // create a quiz

            // create question list
            List<Question> questions = new List<Question>();

            List<Question> allQuestions;
            List<Question> selectedQuestions;

            using (StreamReader cour = new StreamReader("CourseMaterial/questions4.json"))
            {
                string jsonc = cour.ReadToEnd();
                allQuestions = JsonConvert.DeserializeObject<List<Question>>(jsonc);             
            }


            int numberOfLessons = 3;

            for(int i= 1; i <= numberOfLessons; i++)
            {
                selectedQuestions = allQuestions.Where(q => q.LessonCode == i).ToList();
                selectedQuestions = selectedQuestions.OrderBy(q => random.Next()).ToList(); // source: https://stackoverflow.com/questions/273313/randomize-a-listt
                selectedQuestions = selectedQuestions.Take(2).ToList();
                questions = questions.Concat(selectedQuestions).ToList();
            }


            // load rev questions
            using (StreamReader cour = new StreamReader("CourseMaterial/questions4rev.json"))
            {
                string jsonc = cour.ReadToEnd();
                List<Question>  revQuestions = JsonConvert.DeserializeObject<List<Question>>(jsonc);
                questions = questions.Concat(revQuestions).ToList();
            }



            // suffle all questions
            //questions = questions.OrderBy(q => random.Next()).ToList();

            form1.openChildForm(new FormTest(questions));
        }
    }
}
