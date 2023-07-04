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
    public partial class FormTestComplete : Form
    {

        Image courseImage;
        string courseTitle;
        Form1 form1;

        public FormTestComplete(Image courseImage, string courseTitle, Form1 form1)
        {
            InitializeComponent();
            this.courseImage = courseImage;
            this.courseTitle = courseTitle;
            this.form1 = form1;
        }

        private void FormTestComplete_Load(object sender, EventArgs e)
        {
            labelDesc.Text = courseTitle + "!\n" + "\nΤώρα μπορείτε να συνεχίσεται στις επόμενες ενότητες.";
            pictureBoxDesc.Image = courseImage;
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            form1.openChildForm(new FormCourses(form1));
        }
    }
}
