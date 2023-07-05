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
    public partial class FormTestCareerIntro : Form
    {
        private Form1 form1;

        public FormTestCareerIntro(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            form1.panelSideMenu.Visible = false;
            form1.openChildForm(new FormTestCareer(form1));
        }
    }
}
