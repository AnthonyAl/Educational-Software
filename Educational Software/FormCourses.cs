using Rounded;
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
    public partial class FormCourses : Form
    {
        public FormCourses()
        {
            InitializeComponent();
        }

        private void FormCourses_Load(object sender, EventArgs e)
        {
            // parse courses from file


            


            List<string> courseNames = new List<string>();
            courseNames.Add("Θεμελιωδεις γνωσεις Πληροφορικής");
            courseNames.Add("Εισαγωγη στην αναπτυξη εφαρμογων");
            courseNames.Add("Προηγμένες γνωσεις Πληροφορικής");
            courseNames.Add("Εισαγωγη σε Ευφυη Συστηματα");

            foreach (string name in courseNames)
            {
                ShadowPanel.ShadowPanel shadowPanel = new ShadowPanel.ShadowPanel();

                // shadow panel controls
                Label label = new Label();
                RoundedButton roundedButton = new RoundedButton();
                PictureBox pictureBox = new PictureBox();

                label.Text = name;
                roundedButton.Text = "Έναρξη";
                pictureBox.Image = Properties.Resources.icons8_concert_day_96;


                shadowPanel.BorderColor = System.Drawing.Color.Empty;
                shadowPanel.Controls.Add(label);
                shadowPanel.Controls.Add(roundedButton);
                shadowPanel.Controls.Add(pictureBox);
                shadowPanel.Location = new System.Drawing.Point(30, 30);
                shadowPanel.Margin = new System.Windows.Forms.Padding(30);
                shadowPanel.PanelColor = System.Drawing.Color.Empty;
                shadowPanel.Size = new System.Drawing.Size(299, 299);
                shadowPanel.TabIndex = 10;

                roundedButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
                roundedButton.Location = new Point(42, 232);
                roundedButton.Size = new Size(207, 40);

                label.Location = new System.Drawing.Point(39, 20);
                label.Name = "label1";
                label.Size = new System.Drawing.Size(224, 16);

                pictureBox.Location = new System.Drawing.Point(71, 75);
                pictureBox.Size = new System.Drawing.Size(135, 117);


                flowLayoutPanel2.Controls.Add(shadowPanel);
            }
        }
    }
}
