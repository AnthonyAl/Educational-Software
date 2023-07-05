namespace Educational_Software
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.animation_timer = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnCareers = new System.Windows.Forms.Button();
            this.btnFAQ = new System.Windows.Forms.Button();
            this.btnForum = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnCareerTest = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.roundedToggleButton1 = new Rounded.RoundedToggleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelContent.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.panelHeader.IClose = global::Educational_Software.Properties.Resources._24_gray9;
            this.panelHeader.IHelp = global::Educational_Software.Properties.Resources._24_gray6;
            this.panelHeader.IMaximize = global::Educational_Software.Properties.Resources._24_gray10;
            this.panelHeader.IMinimize = global::Educational_Software.Properties.Resources._24_gray11;
            this.panelHeader.Size = new System.Drawing.Size(1094, 46);
            this.panelHeader.ButtonHelpClick += new System.EventHandler(this.panelHeader_ButtonHelpClick);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(59)))));
            this.panelContent.Controls.Add(this.panelChildForm);
            this.panelContent.Controls.Add(this.panel1);
            this.panelContent.Size = new System.Drawing.Size(1094, 585);
            // 
            // animation_timer
            // 
            this.animation_timer.Interval = 2;
            this.animation_timer.Tag = "";
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Onyx", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStart.Image = global::Educational_Software.Properties.Resources._24_gray5;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(0, 315);
            this.btnStart.Name = "btnStart";
            this.btnStart.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStart.Size = new System.Drawing.Size(250, 45);
            this.btnStart.TabIndex = 17;
            this.btnStart.Tag = "ΕΞΟΔΟΣ";
            this.btnStart.Text = "ΕΞΟΔΟΣ";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.MouseEnter += new System.EventHandler(this.btnStart_MouseEnter);
            this.btnStart.MouseLeave += new System.EventHandler(this.btnStart_MouseLeave);
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Onyx", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(0, 270);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProfile.Size = new System.Drawing.Size(250, 45);
            this.btnProfile.TabIndex = 16;
            this.btnProfile.Tag = " ΠΡΟΦΙΛ";
            this.btnProfile.Text = "ΠΡΟΦΙΛ";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            this.btnProfile.MouseEnter += new System.EventHandler(this.btnProfile_MouseEnter);
            this.btnProfile.MouseLeave += new System.EventHandler(this.btnProfile_MouseLeave);
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Onyx", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAbout.Image = global::Educational_Software.Properties.Resources._24_gray6;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(0, 495);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(250, 45);
            this.btnAbout.TabIndex = 10;
            this.btnAbout.Tag = "ΣΧΕΤΙΚΑ ΜΕ ΤΗΝ ΕΦΑΡΜΟΓΗ";
            this.btnAbout.Text = "ΣΧΕΤΙΚΑ ΜΕ ΤΗΝ ΕΦΑΡΜΟΓΗ";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.MouseEnter += new System.EventHandler(this.btnAbout_MouseEnter);
            this.btnAbout.MouseLeave += new System.EventHandler(this.btnAbout_MouseLeave);
            // 
            // btnCareers
            // 
            this.btnCareers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCareers.FlatAppearance.BorderSize = 0;
            this.btnCareers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCareers.Font = new System.Drawing.Font("Onyx", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCareers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCareers.Image = global::Educational_Software.Properties.Resources._24_gray3;
            this.btnCareers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCareers.Location = new System.Drawing.Point(0, 180);
            this.btnCareers.Name = "btnCareers";
            this.btnCareers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCareers.Size = new System.Drawing.Size(250, 45);
            this.btnCareers.TabIndex = 9;
            this.btnCareers.Tag = "ΚΑΡΙΕΡΕΣ";
            this.btnCareers.Text = "ΚΑΡΙΕΡΕΣ";
            this.btnCareers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCareers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCareers.UseVisualStyleBackColor = true;
            this.btnCareers.Click += new System.EventHandler(this.btnCareers_Click);
            this.btnCareers.MouseEnter += new System.EventHandler(this.btnCareers_MouseEnter);
            this.btnCareers.MouseLeave += new System.EventHandler(this.btnCareers_MouseLeave);
            // 
            // btnFAQ
            // 
            this.btnFAQ.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFAQ.FlatAppearance.BorderSize = 0;
            this.btnFAQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFAQ.Font = new System.Drawing.Font("Onyx", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFAQ.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFAQ.Image = global::Educational_Software.Properties.Resources._24_gray1;
            this.btnFAQ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFAQ.Location = new System.Drawing.Point(0, 135);
            this.btnFAQ.Name = "btnFAQ";
            this.btnFAQ.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFAQ.Size = new System.Drawing.Size(250, 45);
            this.btnFAQ.TabIndex = 8;
            this.btnFAQ.Tag = "ΣΥΧΝΕΣ ΕΡΩΤΗΣΕΙΣ";
            this.btnFAQ.Text = "ΣΥΧΝΕΣ ΕΡΩΤΗΣΕΙΣ";
            this.btnFAQ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFAQ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFAQ.UseVisualStyleBackColor = true;
            this.btnFAQ.Visible = false;
            this.btnFAQ.Click += new System.EventHandler(this.btnFAQ_Click);
            this.btnFAQ.MouseEnter += new System.EventHandler(this.btnFAQ_MouseEnter);
            this.btnFAQ.MouseLeave += new System.EventHandler(this.btnFAQ_MouseLeave);
            // 
            // btnForum
            // 
            this.btnForum.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnForum.FlatAppearance.BorderSize = 0;
            this.btnForum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForum.Font = new System.Drawing.Font("Onyx", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForum.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnForum.Image = global::Educational_Software.Properties.Resources._24_gray13;
            this.btnForum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnForum.Location = new System.Drawing.Point(0, 90);
            this.btnForum.Name = "btnForum";
            this.btnForum.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnForum.Size = new System.Drawing.Size(250, 45);
            this.btnForum.TabIndex = 6;
            this.btnForum.Tag = "ΦΟΡΟΥΜ";
            this.btnForum.Text = "ΦΟΡΟΥΜ";
            this.btnForum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnForum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnForum.UseVisualStyleBackColor = true;
            this.btnForum.Click += new System.EventHandler(this.btnForum_Click);
            this.btnForum.MouseEnter += new System.EventHandler(this.btnForum_MouseEnter);
            this.btnForum.MouseLeave += new System.EventHandler(this.btnForum_MouseLeave);
            // 
            // btnScore
            // 
            this.btnScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScore.FlatAppearance.BorderSize = 0;
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.Font = new System.Drawing.Font("Onyx", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnScore.Image = global::Educational_Software.Properties.Resources._24_gray7;
            this.btnScore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScore.Location = new System.Drawing.Point(0, 45);
            this.btnScore.Name = "btnScore";
            this.btnScore.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnScore.Size = new System.Drawing.Size(250, 45);
            this.btnScore.TabIndex = 5;
            this.btnScore.Tag = "ΠΡΟΕΠΙΣΚΟΠΗΣΗ";
            this.btnScore.Text = " ΠΡΟΕΠΙΣΚΟΠΗΣΗ";
            this.btnScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            this.btnScore.MouseEnter += new System.EventHandler(this.btnScore_MouseEnter);
            this.btnScore.MouseLeave += new System.EventHandler(this.btnScore_MouseLeave);
            // 
            // btnCourses
            // 
            this.btnCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCourses.FlatAppearance.BorderSize = 0;
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.Font = new System.Drawing.Font("Onyx", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourses.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCourses.Image = global::Educational_Software.Properties.Resources._24_gray2;
            this.btnCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourses.Location = new System.Drawing.Point(0, 0);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCourses.Size = new System.Drawing.Size(250, 45);
            this.btnCourses.TabIndex = 3;
            this.btnCourses.Tag = "ΕΝΟΤΗΤΕΣ";
            this.btnCourses.Text = " ΕΝΟΤΗΤΕΣ";
            this.btnCourses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            this.btnCourses.MouseEnter += new System.EventHandler(this.btnCourses_MouseEnter);
            this.btnCourses.MouseLeave += new System.EventHandler(this.btnCourses_MouseLeave);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.panelSideMenu.Controls.Add(this.btnStart);
            this.panelSideMenu.Controls.Add(this.btnProfile);
            this.panelSideMenu.Controls.Add(this.btnAbout);
            this.panelSideMenu.Controls.Add(this.btnCareerTest);
            this.panelSideMenu.Controls.Add(this.btnCareers);
            this.panelSideMenu.Controls.Add(this.btnFAQ);
            this.panelSideMenu.Controls.Add(this.btnForum);
            this.panelSideMenu.Controls.Add(this.btnScore);
            this.panelSideMenu.Controls.Add(this.btnCourses);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 540);
            this.panelSideMenu.TabIndex = 8;
            // 
            // btnCareerTest
            // 
            this.btnCareerTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCareerTest.FlatAppearance.BorderSize = 0;
            this.btnCareerTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCareerTest.Font = new System.Drawing.Font("Onyx", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCareerTest.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCareerTest.Image = global::Educational_Software.Properties.Resources._24_gray;
            this.btnCareerTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCareerTest.Location = new System.Drawing.Point(0, 225);
            this.btnCareerTest.Name = "btnCareerTest";
            this.btnCareerTest.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCareerTest.Size = new System.Drawing.Size(250, 45);
            this.btnCareerTest.TabIndex = 18;
            this.btnCareerTest.Tag = "ΤΕΣΤ ΚΑΡΙΕΡΑΣ";
            this.btnCareerTest.Text = "ΤΕΣΤ ΚΑΡΙΕΡΑΣ";
            this.btnCareerTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCareerTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCareerTest.UseVisualStyleBackColor = true;
            this.btnCareerTest.Click += new System.EventHandler(this.btnCareerTest_Click);
            this.btnCareerTest.MouseEnter += new System.EventHandler(this.btnCareerTest_MouseEnter);
            this.btnCareerTest.MouseLeave += new System.EventHandler(this.btnCareerTest_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.roundedToggleButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 45);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.Font = new System.Drawing.Font("Onyx", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(139)))), ((int)(((byte)(29)))));
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "ΕΚΠΑΙΔΕΥΤΙΚΟ  ΛΟΓΙΣΜΙΚΟ";
            // 
            // roundedToggleButton1
            // 
            this.roundedToggleButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.roundedToggleButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.roundedToggleButton1.Fill = true;
            this.roundedToggleButton1.Location = new System.Drawing.Point(575, 12);
            this.roundedToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.roundedToggleButton1.Name = "roundedToggleButton1";
            this.roundedToggleButton1.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.roundedToggleButton1.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(139)))), ((int)(((byte)(29)))));
            this.roundedToggleButton1.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(139)))), ((int)(((byte)(29)))));
            this.roundedToggleButton1.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(139)))), ((int)(((byte)(29)))));
            this.roundedToggleButton1.Size = new System.Drawing.Size(504, 22);
            this.roundedToggleButton1.TabIndex = 9;
            this.roundedToggleButton1.Text = "roundedToggleButton1";
            this.roundedToggleButton1.UseVisualStyleBackColor = false;
            this.roundedToggleButton1.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.Font = new System.Drawing.Font("Onyx", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(139)))), ((int)(((byte)(29)))));
            this.label1.Location = new System.Drawing.Point(487, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ΕΠΙΠΕΔΟ";
            this.label1.Visible = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.panelChildForm.Controls.Add(this.panelSideMenu);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 45);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1094, 540);
            this.panelChildForm.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 637);
            this.Main = true;
            this.MinimumSize = new System.Drawing.Size(1100, 637);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelContent.ResumeLayout(false);
            this.panelSideMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnFAQ;
        private System.Windows.Forms.Button btnForum;
        private System.Windows.Forms.Button btnScore;
        public System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Timer animation_timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label label1;
        private Rounded.RoundedToggleButton roundedToggleButton1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnCareerTest;
        public System.Windows.Forms.Button btnCareers;
    }
}

