namespace Educational_Software
{
    partial class FormCourseComplete
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelBodyDesc = new System.Windows.Forms.Panel();
            this.panelLabelDesc = new System.Windows.Forms.Panel();
            this.labelDesc = new System.Windows.Forms.Label();
            this.pictureBoxDesc = new System.Windows.Forms.PictureBox();
            this.labelOverview = new System.Windows.Forms.Label();
            this.shadowPanel1 = new ShadowPanel.ShadowPanel();
            this.roundedButton3 = new Rounded.RoundedButton();
            this.shadowPanel2 = new ShadowPanel.ShadowPanel();
            this.roundedButton1 = new Rounded.RoundedButton();
            this.panelHeader.SuspendLayout();
            this.panelBodyDesc.SuspendLayout();
            this.panelLabelDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDesc)).BeginInit();
            this.shadowPanel1.SuspendLayout();
            this.shadowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(85, 0, 85, 0);
            this.panelHeader.Size = new System.Drawing.Size(1067, 74);
            this.panelHeader.TabIndex = 20;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Onyx", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(77, 11);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(260, 45);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Συγχαρητήρια!";
            // 
            // panelBodyDesc
            // 
            this.panelBodyDesc.Controls.Add(this.panelLabelDesc);
            this.panelBodyDesc.Controls.Add(this.pictureBoxDesc);
            this.panelBodyDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBodyDesc.Location = new System.Drawing.Point(0, 133);
            this.panelBodyDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBodyDesc.Name = "panelBodyDesc";
            this.panelBodyDesc.Padding = new System.Windows.Forms.Padding(0, 0, 43, 30);
            this.panelBodyDesc.Size = new System.Drawing.Size(1067, 263);
            this.panelBodyDesc.TabIndex = 22;
            // 
            // panelLabelDesc
            // 
            this.panelLabelDesc.Controls.Add(this.labelDesc);
            this.panelLabelDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLabelDesc.Location = new System.Drawing.Point(0, 0);
            this.panelLabelDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLabelDesc.Name = "panelLabelDesc";
            this.panelLabelDesc.Size = new System.Drawing.Size(536, 233);
            this.panelLabelDesc.TabIndex = 6;
            // 
            // labelDesc
            // 
            this.labelDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDesc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesc.Location = new System.Drawing.Point(0, 0);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Padding = new System.Windows.Forms.Padding(128, 0, 0, 0);
            this.labelDesc.Size = new System.Drawing.Size(536, 233);
            this.labelDesc.TabIndex = 1;
            this.labelDesc.Text = "Τίτλος Ενότητας";
            // 
            // pictureBoxDesc
            // 
            this.pictureBoxDesc.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxDesc.Location = new System.Drawing.Point(536, 0);
            this.pictureBoxDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxDesc.Name = "pictureBoxDesc";
            this.pictureBoxDesc.Size = new System.Drawing.Size(488, 233);
            this.pictureBoxDesc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDesc.TabIndex = 7;
            this.pictureBoxDesc.TabStop = false;
            // 
            // labelOverview
            // 
            this.labelOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOverview.Font = new System.Drawing.Font("Onyx", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOverview.Location = new System.Drawing.Point(0, 74);
            this.labelOverview.Name = "labelOverview";
            this.labelOverview.Padding = new System.Windows.Forms.Padding(107, 0, 0, 0);
            this.labelOverview.Size = new System.Drawing.Size(1067, 59);
            this.labelOverview.TabIndex = 21;
            this.labelOverview.Text = "Ολοκληρώσατε την Ενότητα";
            // 
            // shadowPanel1
            // 
            this.shadowPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.shadowPanel1.BorderColor = System.Drawing.Color.Empty;
            this.shadowPanel1.Controls.Add(this.roundedButton3);
            this.shadowPanel1.Location = new System.Drawing.Point(270, 423);
            this.shadowPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shadowPanel1.Name = "shadowPanel1";
            this.shadowPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 8, 7);
            this.shadowPanel1.PanelColor = System.Drawing.Color.Empty;
            this.shadowPanel1.Size = new System.Drawing.Size(240, 59);
            this.shadowPanel1.TabIndex = 23;
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
            this.roundedButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.Size = new System.Drawing.Size(232, 52);
            this.roundedButton3.TabIndex = 3;
            this.roundedButton3.Text = "Πίσω  στις  Ενότητες";
            this.roundedButton3.UseVisualStyleBackColor = false;
            this.roundedButton3.Click += new System.EventHandler(this.roundedButton3_Click);
            // 
            // shadowPanel2
            // 
            this.shadowPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.shadowPanel2.BorderColor = System.Drawing.Color.Empty;
            this.shadowPanel2.Controls.Add(this.roundedButton1);
            this.shadowPanel2.Location = new System.Drawing.Point(603, 423);
            this.shadowPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.shadowPanel2.Name = "shadowPanel2";
            this.shadowPanel2.Padding = new System.Windows.Forms.Padding(0, 0, 8, 7);
            this.shadowPanel2.PanelColor = System.Drawing.Color.Empty;
            this.shadowPanel2.Size = new System.Drawing.Size(240, 59);
            this.shadowPanel2.TabIndex = 24;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(139)))), ((int)(((byte)(29)))));
            this.roundedButton1.BorderColor = System.Drawing.Color.Black;
            this.roundedButton1.BorderRadius = 4;
            this.roundedButton1.BorderSize = 0;
            this.roundedButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Onyx", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.roundedButton1.Location = new System.Drawing.Point(0, 0);
            this.roundedButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(232, 52);
            this.roundedButton1.TabIndex = 3;
            this.roundedButton1.Text = "Έναρξη Τεστ";
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // FormCourseComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.shadowPanel2);
            this.Controls.Add(this.shadowPanel1);
            this.Controls.Add(this.panelBodyDesc);
            this.Controls.Add(this.labelOverview);
            this.Controls.Add(this.panelHeader);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCourseComplete";
            this.Text = "FormCourseComplete";
            this.Load += new System.EventHandler(this.FormCourseComplete_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelBodyDesc.ResumeLayout(false);
            this.panelLabelDesc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDesc)).EndInit();
            this.shadowPanel1.ResumeLayout(false);
            this.shadowPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelBodyDesc;
        private System.Windows.Forms.Panel panelLabelDesc;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.PictureBox pictureBoxDesc;
        private System.Windows.Forms.Label labelOverview;
        private ShadowPanel.ShadowPanel shadowPanel1;
        private Rounded.RoundedButton roundedButton3;
        private ShadowPanel.ShadowPanel shadowPanel2;
        private Rounded.RoundedButton roundedButton1;
    }
}