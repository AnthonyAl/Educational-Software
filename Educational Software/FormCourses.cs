using Educational_Software.CustomControls;
using Rounded;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Educational_Software
{
    public partial class FormCourses : Form
    {
        public FormCourses()
        {
            InitializeComponent();
        }

        private void FormCourses_Load(object sender, EventArgs e)
        {

            List<string> courseGroupNames = new List<string>();
            courseGroupNames.Add("Θεμελιωδεις γνωσεις Πληροφορικής");
            courseGroupNames.Add("Εισαγωγη στην αναπτυξη εφαρμογων");
            courseGroupNames.Add("Προηγμένες γνωσεις Πληροφορικής");
            courseGroupNames.Add("Εισαγωγη σε Ευφυη Συστηματα");

        }
    }
}
