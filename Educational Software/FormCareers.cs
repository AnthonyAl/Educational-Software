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
    public partial class FormCareers : Form
    {
        Form1 form1;

        public FormCareers(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {

            form1.openChildForm(new FormCourseStudy(4, form1, pictureBox4.Image));
        }
    }
}
