using Educational_Software.CustomControls;
using Rounded;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Educational_Software
{
    public partial class FormCourses : Form
    {
        private Form1 form1;

        public FormCourses(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
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
            form1.openChildForm(new FormCourseOverview(1, form1));
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            form1.openChildForm(new FormCourseOverview(4, form1));
        }
    }
}
