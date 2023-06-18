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
    public partial class FormCourseComplete : Form
    {
        Image courseImage;
        string courseTitle;
        Form1 form1;

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
    }
}
