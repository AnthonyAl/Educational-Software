using Educational_Software.Dao;
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
    public partial class FormDetails : Form
    {

        int userid;
        UserDao userDao = new UserDao();

        public FormDetails(int userid)
        {
            InitializeComponent();
            this.userid = userid;
        }

        private void FormDetails_Load(object sender, EventArgs e)
        {
            label1.Text = label1.Text + userDao.getlastlogin(userid);
            label2.Text = label2.Text + userDao.getMaxCourseGrade(userid);
        }
    }
}
