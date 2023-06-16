using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsFormFlat;

namespace Educational_Software
{
    public partial class Form1 : FormFlat
    {
        private Panel leftBorderBtn;
        private Button currentSelected = null;
        private Form childForm = null;

        // loaded forms
        private FormCourses formCourses = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 45);
            panelSideMenu.Controls.Add(leftBorderBtn);

            formCourses = new FormCourses();
        }

        private void ActivateButton(Button senderBtn, Color color)
        {
            resetCurrentButton();
            //Button
            senderBtn.BackColor = Color.FromArgb(37, 36, 81);
            senderBtn.ForeColor = color;
            senderBtn.TextAlign = ContentAlignment.MiddleCenter;
            senderBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            senderBtn.ImageAlign = ContentAlignment.MiddleRight;
            //Left border button
            leftBorderBtn.BackColor = color;
            leftBorderBtn.Location = new Point(0, senderBtn.Location.Y);
            leftBorderBtn.Visible = true;
            leftBorderBtn.BringToFront();

            currentSelected = senderBtn;
        }

        private void resetCurrentButton()
        {
            if (currentSelected != null)
            {
                leftBorderBtn.Visible = false;
                //Button
                currentSelected.BackColor = panelSideMenu.BackColor;
                currentSelected.ForeColor = Color.Gainsboro;
                currentSelected.TextAlign = ContentAlignment.MiddleLeft;
                currentSelected.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentSelected.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void openChildForm(Form newChildForm)
        {
            if (childForm != null)
                //childForm.Close();
                childForm.Hide();
            childForm = newChildForm;
            newChildForm.TopLevel = false;
            newChildForm.FormBorderStyle = FormBorderStyle.None;
            newChildForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(newChildForm);
            panelChildForm.Tag = newChildForm;

            newChildForm.BringToFront();
            newChildForm.Show();

        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender, Color.FromArgb(154, 71, 237));
            openChildForm(formCourses);
        }

        private void btnDevices_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender, Color.FromArgb(154, 71, 237));
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender, Color.FromArgb(154, 71, 237));
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender, Color.FromArgb(154, 71, 237));
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender, Color.FromArgb(154, 71, 237));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender, Color.FromArgb(154, 71, 237));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender, Color.FromArgb(154, 71, 237));
        }
    }
}
