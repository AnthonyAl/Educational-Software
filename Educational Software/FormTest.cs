using Educational_Software.Model;
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
    public partial class FormTest : Form
    {
        private List<Question> questions;

        private int index = 0;

        public FormTest(List<Question> questions)
        {
            InitializeComponent();
            this.questions = questions;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void hideAll()
        {
            panelCheckBoxes.Hide();
            panelRadioButtons.Hide();
            panelComboBoxes.Hide();
            panelImageOption.Hide();
            pictureBoxQuestion.Hide();
        }

        private void loadQuestion()
        {
            hideAll();
            labelSentence.Text = questions[index].Sentence;

            switch(questions[index].Type)
            {
                case "radio":
                    panelRadioButtons.Show();

                    

                    break;



                case "check":
                    panelCheckBoxes.Show();

                    break;


                case "image":

                    panelImageOption.Show();
                    pictureBoxQuestion.Show();

                    pictureBoxQuestion.ImageLocation = "CourseMaterial/images/" + questions[index].Image;

                    break;



                case "matching":

                    panelComboBoxes.Show();

                    break;
            }
        }

        private void FormTest_Load(object sender, EventArgs e)
        {       
            loadQuestion();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            index += 1;
            loadQuestion();
        }
    }
}
