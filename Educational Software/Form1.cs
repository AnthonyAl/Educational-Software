using Educational_Software.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsFormFlat;

namespace Educational_Software
{
    public partial class Form1 : FormFlat
    {
        private Panel leftBorderBtn;
        private string currentSelectedId = null;
        private Button currentSelected = null;
        private Form childForm = null;
        ResourceManager rm = Resources.ResourceManager;

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

            formCourses = new FormCourses(this);

            btnCourses.PerformClick();
        }

        private void ActivateButton(Button senderBtn, Color color, string id)
        {
            resetCurrentButton();
            //Button
            senderBtn.BackColor = Color.FromArgb(37, 36, 81);
            senderBtn.ForeColor = color;
            senderBtn.Image = (Image)rm.GetObject("_24_gold"+id);
            senderBtn.TextAlign = ContentAlignment.MiddleCenter;
            senderBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            senderBtn.ImageAlign = ContentAlignment.MiddleRight;
            //Left border button
            leftBorderBtn.BackColor = color;
            leftBorderBtn.Location = new Point(0, senderBtn.Location.Y);
            leftBorderBtn.Visible = true;
            leftBorderBtn.BringToFront();

            currentSelected = senderBtn;
            currentSelectedId = id;
        }

        private void resetCurrentButton()
        {
            if (currentSelected != null)
            {
                leftBorderBtn.Visible = false;
                //Button
                currentSelected.BackColor = panelSideMenu.BackColor;
                currentSelected.ForeColor = Color.Gainsboro;
                currentSelected.Image = (Image)rm.GetObject("_24_gray" + currentSelectedId);
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

        private void btnCourses_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender, Color.FromArgb(242, 139, 29), "2");
            openChildForm(formCourses);
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender, Color.FromArgb(242, 139, 29), "7");
        }

        private void btnForum_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender, Color.FromArgb(242, 139, 29), "13");
        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender, Color.FromArgb(242, 139, 29), "1");
        }

        private void btnCareers_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender, Color.FromArgb(242, 139, 29), "3");
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender, Color.FromArgb(242, 139, 29), "12");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender, Color.FromArgb(242, 139, 29), "5");
        }

        private void btnCourses_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Image = (Image)rm.GetObject("_24_gold" + "2");
        }

        private void btnScore_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Image = (Image)rm.GetObject("_24_gold" + "7");
        }

        private void btnForum_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Image = (Image)rm.GetObject("_24_gold" + "13");
        }

        private void btnFAQ_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Image = (Image)rm.GetObject("_24_gold" + "1");
        }

        private void btnCareers_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Image = (Image)rm.GetObject("_24_gold" + "3");
        }

        private void btnProfile_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Image = (Image)rm.GetObject("_24_gold" + "12");
        }

        private void btnStart_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Image = (Image)rm.GetObject("_24_gold" + "5");
        }

        private void btnAbout_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Image = (Image)rm.GetObject("_24_gold" + "6");
        }

        private void btnCourses_MouseLeave(object sender, EventArgs e)
        {
            if(currentSelectedId != "2")
                ((Button)sender).Image = (Image)rm.GetObject("_24_gray" + "2");
        }

        private void btnScore_MouseLeave(object sender, EventArgs e)
        {
            if (currentSelectedId != "7")
                ((Button)sender).Image = (Image)rm.GetObject("_24_gray" + "7");
        }

        private void btnForum_MouseLeave(object sender, EventArgs e)
        {
            if (currentSelectedId != "13")
                ((Button)sender).Image = (Image)rm.GetObject("_24_gray" + "13");
        }

        private void btnFAQ_MouseLeave(object sender, EventArgs e)
        {
            if (currentSelectedId != "1")
                ((Button)sender).Image = (Image)rm.GetObject("_24_gray" + "1");
        }

        private void btnCareers_MouseLeave(object sender, EventArgs e)
        {
            if (currentSelectedId != "3")
                ((Button)sender).Image = (Image)rm.GetObject("_24_gray" + "3");
        }

        private void btnProfile_MouseLeave(object sender, EventArgs e)
        {
            if (currentSelectedId != "12")
                ((Button)sender).Image = (Image)rm.GetObject("_24_gray" + "12");
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            if (currentSelectedId != "5")
                ((Button)sender).Image = (Image)rm.GetObject("_24_gray" + "5");
        }

        private void btnAbout_MouseLeave(object sender, EventArgs e)
        {
            if (currentSelectedId != "6")
                ((Button)sender).Image = (Image)rm.GetObject("_24_gray" + "6");
        }
    }
}
