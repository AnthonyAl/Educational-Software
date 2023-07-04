using Educational_Software.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educational_Software
{
    // check the power point to make sure you understand how the questions work

    public partial class FormTest : Form
    {
        private List<Question> questions;

        private int index = 0;

        private bool check = true;

        Image courseImage;
        string courseTitle;
        Form1 form1;
        private int courseId;
        private bool isProfession;

        private int total;
        private int corrents = 0;

        public FormTest(List<Question> questions, Image courseImage, string courseTitle, Form1 form1, int courseId, bool isProfession)
        {
            InitializeComponent();
            this.questions = questions;
            this.courseImage = courseImage;
            this.courseTitle = courseTitle;
            this.form1 = form1;

            this.total = questions.Count;
            this.courseId = courseId;
            this.isProfession = isProfession;
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

                    RadioButton[] radioButtons = { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5, radioButton6 };
                    Label[] labelradios = { labelradio1, labelradio2, labelradio3, labelradio4, labelradio5, labelradio6 };

                    for (int i = 0; i < radioButtons.Length; i++)
                    {
                        radioButtons[i].Checked = false;
                        radioButtons[i].Hide();
                        labelradios[i].Text = "";

                        if (i < questions[index].Choices.Count)
                        {
                            radioButtons[i].Text = questions[index].Choices[i].Text;
                            radioButtons[i].Show();
                            radioButtons[i].Enabled = true;
                        }
                    }


                    break;



                case "check":
                    panelCheckBoxes.Show();

                    CheckBox[] checkBoxes = { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6 };
                    Label[] labelchecks = { labelcheck1, labelcheck2, labelcheck3, labelcheck4, labelcheck5, labelcheck6 };

                    for (int i = 0; i < checkBoxes.Length; i++)
                    {
                        checkBoxes[i].Checked = false;
                        checkBoxes[i].Hide();
                        labelchecks[i].Text = "";

                        if (i < questions[index].Choices.Count)
                        {
                            checkBoxes[i].Text = questions[index].Choices[i].Text;
                            checkBoxes[i].Show();
                            checkBoxes[i].Enabled = true;
                        }
                    }


                    break;


                case "image":

                    panelImageOption.Show();
                    pictureBoxQuestion.Show();

                    pictureBoxQuestion.ImageLocation = "CourseMaterial/images/" + questions[index].Image;

                    labelImageChoose.Text = "";

                    comboBoxImage.Items.Clear();
                    comboBoxImage.Enabled = true;

                    foreach (Paragraph paragraph in questions[index].Choices)
                    {
                        comboBoxImage.Items.Add(paragraph.Text);
                    }
                    comboBoxImage.SelectedIndex = 0; // check this https://stackoverflow.com/questions/30113145/how-to-show-a-first-item-in-a-combobox-in-c-sharp-winform

                    break;



                case "matching":

                    Label[] labels = { label2, label3, label4, label5, label6, label7 };
                    ComboBox[] comboBoxes = { comboBoxMatch1, comboBoxMatch2, comboBoxMatch3, comboBoxMatch4, comboBoxMatch5, comboBoxMatch6 };

                    Label[] labelmatchshows = { labelmatchshow1, labelmatchshow2, labelmatchshow3, labelmatchshow4, labelmatchshow5, labelmatchshow6 };

                    panelComboBoxes.Show();

                    for (int i = 0; i < labels.Length; i++)
                    {
                        labels[i].Hide();
                        comboBoxes[i].Hide();

                        labelmatchshows[i].Text = "";

                        if (i < questions[index].Rows.Count)
                        {
                            labels[i].Text = questions[index].Rows[i].Text;
                            labels[i].Show();
                            comboBoxes[i].Show();
                            comboBoxes[i].Enabled = true;
                            comboBoxes[i].Items.Clear();
                            foreach (Paragraph paragraph in questions[index].Choices)
                            {
                                comboBoxes[i].Items.Add(paragraph.Text);
                            }
                            comboBoxes[i].SelectedIndex = 0;

                        }
                    }

                    break;
            }
        }

        private void FormTest_Load(object sender, EventArgs e)
        {       
            loadQuestion();
        }

        private void checkAnswer()
        {
            switch (questions[index].Type)
            {
                case "radio":

                    // highlight
                    RadioButton[] radioButtons = { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5, radioButton6 };
                    Label[] labelradios = { labelradio1, labelradio2, labelradio3, labelradio4, labelradio5, labelradio6 };
                    String answer = questions[index].Corrects[0].Text;

                    for (int i = 0; i < questions[index].Choices.Count; i++)
                    {
                        if(radioButtons[i].Checked && !radioButtons[i].Text.Equals(answer))
                        {
                            //radioButtons[i].ForeColor = Color.Green;
                            labelradios[i].Text = "ΛΑΘΟΣ! ->";
                            labelradios[i].ForeColor = Color.Red;
                            
                        }

                        if (!radioButtons[i].Checked && radioButtons[i].Text.Equals(answer))
                        {
                            //radioButtons[i].ForeColor = Color.Green;
                            labelradios[i].Text = "ΛΑΘΟΣ! ->";
                            labelradios[i].ForeColor = Color.Red;

                        }

                        if (radioButtons[i].Checked && radioButtons[i].Text.Equals(answer))
                        {
                            //radioButtons[i].ForeColor = Color.Green;
                            labelradios[i].Text = "ΣΩΣΤΟ! ->";
                            labelradios[i].ForeColor = Color.Green;
                            corrents += 1;
                        }

                        radioButtons[i].Enabled = false;


                    }


                    break;



                case "check":
                    panelCheckBoxes.Show();

                    CheckBox[] checkBoxes = { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6 };
                    Label[] labelchecks = { labelcheck1, labelcheck2, labelcheck3, labelcheck4, labelcheck5, labelcheck6 };

                    List<string> ans = new List<string>();
                    foreach(Paragraph paragraph in questions[index].Corrects)
                        ans.Add(paragraph.Text);

                    bool check = true;

                    for (int i = 0; i < questions[index].Choices.Count; i++)
                    {
                        if (checkBoxes[i].Checked && !ans.Contains(checkBoxes[i].Text))
                        {
                            labelchecks[i].Text = "ΛΑΘΟΣ! ->";
                            labelchecks[i].ForeColor = Color.Red;
                            check = false;
                        }

                        if (checkBoxes[i].Checked && ans.Contains(checkBoxes[i].Text))
                        {
                            labelchecks[i].Text = "ΣΩΣΤΟ! ->";
                            labelchecks[i].ForeColor = Color.Green;

                        }

                        if (!checkBoxes[i].Checked && ans.Contains(checkBoxes[i].Text))
                        {
                            labelchecks[i].Text = "ΛΑΘΟΣ! ->";
                            labelchecks[i].ForeColor = Color.Red;
                            check = false;
                        }

                        checkBoxes[i].Enabled = false;


                    }

                    if (check) corrents += 1;

                    break;


                case "image":
                    String answerImage = questions[index].Corrects[0].Text;

                    if (comboBoxImage.Text.Equals(answerImage))
                    {
                        labelImageChoose.Text = " ΣΩΣΤΟ!";
                        labelImageChoose.ForeColor = Color.Green;
                        corrents += 1;
                    }
                    else
                    {
                        labelImageChoose.Text = " ΛΑΘΟΣ! ("+ answerImage+")";
                        labelImageChoose.ForeColor = Color.Red;
                    }

                    comboBoxImage.Enabled = false;

                    break;



                case "matching":


                    ComboBox[] comboBoxes = { comboBoxMatch1, comboBoxMatch2, comboBoxMatch3, comboBoxMatch4, comboBoxMatch5, comboBoxMatch6 };

                    Label[] labelmatchshows = { labelmatchshow1, labelmatchshow2, labelmatchshow3, labelmatchshow4, labelmatchshow5, labelmatchshow6 };

                    bool check2 = true;

                    for(int i = 0; i < questions[index].Corrects.Count; i++)
                    {
                        if (comboBoxes[i].Text.Equals(questions[index].Corrects[i].Text))
                        {
                            labelmatchshows[i].Text = " ΣΩΣΤΟ!";
                            labelmatchshows[i].ForeColor = Color.Green;
                        }
                        else
                        {
                            labelmatchshows[i].Text = " ΛΑΘΟΣ! (" + questions[index].Corrects[i].Text+")";
                            labelmatchshows[i].ForeColor = Color.Red;
                            check2 = false;
                        }

                        comboBoxes[i].Enabled = false;
                    }

                    if (check2) corrents += 1;

                    break;
            }
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
            if(index == questions.Count - 1)
            {
                form1.openChildForm(new FormTestComplete(courseImage, courseTitle, form1, corrents, total, courseId, isProfession));
                return;
            }


            if (check)
            {
                checkAnswer();
                roundedButton1.Text = "Επόμενη Ερώτηση";
                check = !check;
                return;
            }


            index += 1;
            loadQuestion();
            check = !check;
            roundedButton1.Text = "Επιβεβαίωση";
        }

        private void comboBoxMatch5_DropDownClosed(object sender, EventArgs e)
        {
            labelSentence.Focus();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelradio1_VisibleChanged(object sender, EventArgs e)
        {
            string name = ((Label)sender).Name;
            switch (name[name.Length - 1])
            {
                case '1':
                    shadowRadioPanel1.PanelColor = ((Label)sender).ForeColor;
                    break;
                case '2':
                    shadowRadioPanel2.PanelColor = ((Label)sender).ForeColor;
                    break;
                case '3':
                    shadowRadioPanel3.PanelColor = ((Label)sender).ForeColor;
                    break;
                case '4':
                    shadowRadioPanel4.PanelColor = ((Label)sender).ForeColor;
                    break;
                case '5':
                    shadowRadioPanel5.PanelColor = ((Label)sender).ForeColor;
                    break;
                case '6':
                    shadowRadioPanel6.PanelColor = ((Label)sender).ForeColor;
                    break;
            }
            
        }
    }
}
