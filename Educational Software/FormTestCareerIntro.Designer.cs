namespace Educational_Software
{
    partial class FormTestCareerIntro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTestCareerIntro));
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelOverview = new System.Windows.Forms.Label();
            this.shadowPanel1 = new ShadowPanel.ShadowPanel();
            this.roundedButton3 = new Rounded.RoundedButton();
            this.shadowPanelCompleted = new ShadowPanel.ShadowPanel();
            this.labelCompleted = new System.Windows.Forms.Label();
            this.shadowPanelSolving = new ShadowPanel.ShadowPanel();
            this.labelSolving = new System.Windows.Forms.Label();
            this.pictureBoxCompleted = new System.Windows.Forms.PictureBox();
            this.pictureBoxSolving = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            this.shadowPanel1.SuspendLayout();
            this.shadowPanelCompleted.SuspendLayout();
            this.shadowPanelSolving.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompleted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSolving)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 483);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(2);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(64, 0, 64, 0);
            this.panelFooter.Size = new System.Drawing.Size(913, 53);
            this.panelFooter.TabIndex = 9;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(64, 0, 64, 0);
            this.panelHeader.Size = new System.Drawing.Size(913, 60);
            this.panelHeader.TabIndex = 10;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Onyx", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(58, 9);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(208, 36);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Τεστ καριέρας";
            // 
            // labelOverview
            // 
            this.labelOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOverview.Font = new System.Drawing.Font("Onyx", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOverview.Location = new System.Drawing.Point(0, 60);
            this.labelOverview.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOverview.Name = "labelOverview";
            this.labelOverview.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.labelOverview.Size = new System.Drawing.Size(913, 88);
            this.labelOverview.TabIndex = 11;
            this.labelOverview.Text = resources.GetString("labelOverview.Text");
            // 
            // shadowPanel1
            // 
            this.shadowPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.shadowPanel1.BorderColor = System.Drawing.Color.Empty;
            this.shadowPanel1.Controls.Add(this.roundedButton3);
            this.shadowPanel1.Location = new System.Drawing.Point(367, 395);
            this.shadowPanel1.Name = "shadowPanel1";
            this.shadowPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 6, 6);
            this.shadowPanel1.PanelColor = System.Drawing.Color.Empty;
            this.shadowPanel1.Size = new System.Drawing.Size(180, 53);
            this.shadowPanel1.TabIndex = 15;
            // 
            // roundedButton3
            // 
            this.roundedButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(139)))), ((int)(((byte)(29)))));
            this.roundedButton3.BorderColor = System.Drawing.Color.Black;
            this.roundedButton3.BorderRadius = 4;
            this.roundedButton3.BorderSize = 0;
            this.roundedButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedButton3.FlatAppearance.BorderSize = 0;
            this.roundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton3.Font = new System.Drawing.Font("Onyx", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.roundedButton3.Location = new System.Drawing.Point(0, 0);
            this.roundedButton3.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.Size = new System.Drawing.Size(174, 47);
            this.roundedButton3.TabIndex = 3;
            this.roundedButton3.Text = "Έναρξη του Τεστ Καριέρας";
            this.roundedButton3.UseVisualStyleBackColor = false;
            this.roundedButton3.Click += new System.EventHandler(this.roundedButton3_Click);
            // 
            // shadowPanelCompleted
            // 
            this.shadowPanelCompleted.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.shadowPanelCompleted.BorderColor = System.Drawing.Color.Empty;
            this.shadowPanelCompleted.Controls.Add(this.labelCompleted);
            this.shadowPanelCompleted.Controls.Add(this.pictureBoxCompleted);
            this.shadowPanelCompleted.Location = new System.Drawing.Point(512, 171);
            this.shadowPanelCompleted.Name = "shadowPanelCompleted";
            this.shadowPanelCompleted.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.shadowPanelCompleted.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.shadowPanelCompleted.Size = new System.Drawing.Size(190, 190);
            this.shadowPanelCompleted.TabIndex = 13;
            // 
            // labelCompleted
            // 
            this.labelCompleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.labelCompleted.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCompleted.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompleted.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelCompleted.Location = new System.Drawing.Point(0, 118);
            this.labelCompleted.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCompleted.Name = "labelCompleted";
            this.labelCompleted.Size = new System.Drawing.Size(184, 53);
            this.labelCompleted.TabIndex = 4;
            this.labelCompleted.Text = "Μαθητές Έλυσαν";
            this.labelCompleted.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // shadowPanelSolving
            // 
            this.shadowPanelSolving.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.shadowPanelSolving.BorderColor = System.Drawing.Color.Empty;
            this.shadowPanelSolving.Controls.Add(this.labelSolving);
            this.shadowPanelSolving.Controls.Add(this.pictureBoxSolving);
            this.shadowPanelSolving.Location = new System.Drawing.Point(210, 171);
            this.shadowPanelSolving.Name = "shadowPanelSolving";
            this.shadowPanelSolving.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.shadowPanelSolving.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.shadowPanelSolving.Size = new System.Drawing.Size(190, 190);
            this.shadowPanelSolving.TabIndex = 12;
            // 
            // labelSolving
            // 
            this.labelSolving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.labelSolving.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSolving.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSolving.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelSolving.Location = new System.Drawing.Point(0, 118);
            this.labelSolving.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSolving.Name = "labelSolving";
            this.labelSolving.Size = new System.Drawing.Size(184, 53);
            this.labelSolving.TabIndex = 2;
            this.labelSolving.Text = "Μαθητές Συμμετέχουν";
            this.labelSolving.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBoxCompleted
            // 
            this.pictureBoxCompleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.pictureBoxCompleted.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxCompleted.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCompleted.Name = "pictureBoxCompleted";
            this.pictureBoxCompleted.Size = new System.Drawing.Size(184, 118);
            this.pictureBoxCompleted.TabIndex = 3;
            this.pictureBoxCompleted.TabStop = false;
            // 
            // pictureBoxSolving
            // 
            this.pictureBoxSolving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.pictureBoxSolving.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxSolving.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSolving.Name = "pictureBoxSolving";
            this.pictureBoxSolving.Size = new System.Drawing.Size(184, 118);
            this.pictureBoxSolving.TabIndex = 0;
            this.pictureBoxSolving.TabStop = false;
            // 
            // FormTestCareerIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(913, 536);
            this.Controls.Add(this.shadowPanel1);
            this.Controls.Add(this.shadowPanelCompleted);
            this.Controls.Add(this.shadowPanelSolving);
            this.Controls.Add(this.labelOverview);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "FormTestCareerIntro";
            this.Text = "FormTestCareerIntro";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.shadowPanel1.ResumeLayout(false);
            this.shadowPanelCompleted.ResumeLayout(false);
            this.shadowPanelSolving.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompleted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSolving)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelOverview;
        private ShadowPanel.ShadowPanel shadowPanel1;
        private Rounded.RoundedButton roundedButton3;
        private ShadowPanel.ShadowPanel shadowPanelCompleted;
        private System.Windows.Forms.Label labelCompleted;
        private System.Windows.Forms.PictureBox pictureBoxCompleted;
        private ShadowPanel.ShadowPanel shadowPanelSolving;
        private System.Windows.Forms.Label labelSolving;
        private System.Windows.Forms.PictureBox pictureBoxSolving;
    }
}