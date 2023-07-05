using Educational_Software.Dao;
using Org.BouncyCastle.Tls.Crypto;
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
    public partial class FormRegister : FormFlat
    {
        private UserDao dao =new UserDao();

        public FormRegister()
        {
            InitializeComponent();
        }

        private void textBoxUsername_Click(object sender, EventArgs e)
        {
            labelUsername.ForeColor = Color.FromArgb(38, 166, 154);
            labelUnderline1.ForeColor = Color.FromArgb(38, 166, 154);
        }

        private void labelUsername_Click(object sender, EventArgs e)
        {
            if (labelUsername.Location.Y < textBoxUsername.Location.Y)
                return;
            labelUsername.ForeColor = Color.FromArgb(38, 166, 154);
            labelUnderline1.ForeColor = Color.FromArgb(38, 166, 154);
            textBoxUsername.Focus();
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            labelUsername.ForeColor = Color.Gainsboro;
            labelUnderline1.ForeColor = Color.Gainsboro;
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            labelPassword.ForeColor = Color.FromArgb(38, 166, 154);
            labelUnderline2.ForeColor = Color.FromArgb(38, 166, 154);
        }

        private void labelPassword_Click(object sender, EventArgs e)
        {
            if (labelPassword.Location.Y < textBoxPassword.Location.Y)
                return;
            labelPassword.ForeColor = Color.FromArgb(38, 166, 154);
            labelUnderline2.ForeColor = Color.FromArgb(38, 166, 154);
            textBoxPassword.Focus();
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            labelPassword.ForeColor = Color.Gainsboro;
            labelUnderline2.ForeColor = Color.Gainsboro;
        }

        private void textBoxConfirmPassword_Click(object sender, EventArgs e)
        {
            labelConfirmPassword.ForeColor = Color.FromArgb(38, 166, 154);
            labelUnderline3.ForeColor = Color.FromArgb(38, 166, 154);
        }

        private void labelConfirmPassword_Click(object sender, EventArgs e)
        {
            if (labelConfirmPassword.Location.Y < textBoxPassword.Location.Y)
                return;
            labelConfirmPassword.ForeColor = Color.FromArgb(38, 166, 154);
            labelUnderline3.ForeColor = Color.FromArgb(38, 166, 154);
            textBoxConfirmPassword.Focus();
        }

        private void textBoxConfirmPassword_Leave(object sender, EventArgs e)
        {
            labelConfirmPassword.ForeColor = Color.Gainsboro;
            labelUnderline3.ForeColor = Color.Gainsboro;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (labelUsername.Location.Y > textBoxUsername.Location.Y - 16)
                if (labelUsername.ForeColor == Color.FromArgb(38, 166, 154))
                {
                    labelUsername.Location = new Point(labelUsername.Location.X, labelUsername.Location.Y - 4);
                    if (labelUsername.Location.Y < textBoxUsername.Location.Y - 16)
                        labelUsername.Location = new Point(labelUsername.Location.X, textBoxUsername.Location.Y - 16);
                }

            if (labelUsername.Location.Y < textBoxUsername.Location.Y && textBoxUsername.Text.Length == 0)
                if (labelUsername.ForeColor == Color.Gainsboro)
                {
                    labelUsername.Location = new Point(labelUsername.Location.X, labelUsername.Location.Y + 4);
                    if (labelUsername.Location.Y > textBoxUsername.Location.Y)
                        labelUsername.Location = new Point(labelUsername.Location.X, textBoxUsername.Location.Y);
                }

            if (labelPassword.Location.Y > textBoxPassword.Location.Y - 16)
                if (labelPassword.ForeColor == Color.FromArgb(38, 166, 154))
                {
                    labelPassword.Location = new Point(labelPassword.Location.X, labelPassword.Location.Y - 4);
                    if (labelPassword.Location.Y < textBoxPassword.Location.Y - 16)
                        labelPassword.Location = new Point(labelPassword.Location.X, textBoxPassword.Location.Y - 16);
                }

            if (labelPassword.Location.Y < textBoxPassword.Location.Y && textBoxPassword.Text.Length == 0)
                if (labelPassword.ForeColor == Color.Gainsboro)
                {
                    labelPassword.Location = new Point(labelPassword.Location.X, labelPassword.Location.Y + 4);
                    if (labelPassword.Location.Y > textBoxPassword.Location.Y)
                        labelPassword.Location = new Point(labelPassword.Location.X, textBoxPassword.Location.Y);
                }

            if (labelConfirmPassword.Location.Y > textBoxConfirmPassword.Location.Y - 16)
                if (labelConfirmPassword.ForeColor == Color.FromArgb(38, 166, 154))
                {
                    labelConfirmPassword.Location = new Point(labelConfirmPassword.Location.X, labelConfirmPassword.Location.Y - 4);
                    if (labelConfirmPassword.Location.Y < textBoxConfirmPassword.Location.Y - 16)
                        labelConfirmPassword.Location = new Point(labelConfirmPassword.Location.X, textBoxConfirmPassword.Location.Y - 16);
                }

            if (labelConfirmPassword.Location.Y < textBoxConfirmPassword.Location.Y && textBoxConfirmPassword.Text.Length == 0)
                if (labelConfirmPassword.ForeColor == Color.Gainsboro)
                {
                    labelConfirmPassword.Location = new Point(labelConfirmPassword.Location.X, labelConfirmPassword.Location.Y + 4);
                    if (labelConfirmPassword.Location.Y > textBoxConfirmPassword.Location.Y)
                        labelConfirmPassword.Location = new Point(labelConfirmPassword.Location.X, textBoxConfirmPassword.Location.Y);
                }
        }

        private void roundedButtonSubmit_Click(object sender, EventArgs e)
        {
            Console.WriteLine(comboBox1.SelectedIndex.ToString());


            if (!textBoxConfirmPassword.Text.Equals(textBoxPassword.Text))
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            if (dao.register(textBoxUsername.Text, textBoxPassword.Text))
            {
                new Form1(dao.login(textBoxUsername.Text, textBoxPassword.Text)).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username already in database");
            }



        }

        private void comboBox1_DisplayMemberChanged(object sender, EventArgs e)
        {
            labelSubjects.Focus();
        }
    }
}
