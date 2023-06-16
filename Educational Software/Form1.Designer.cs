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
            this.shadowPanel1 = new ShadowPanel.ShadowPanel();
            this.roundedButton1 = new Rounded.RoundedButton();
            this.roundedToggleButton1 = new Rounded.RoundedToggleButton();
            this.shadowPanel2 = new ShadowPanel.ShadowPanel();
            this.roundedButton2 = new Rounded.RoundedButton();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(13)))), ((int)(((byte)(48)))));
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(59)))));
            this.panelContent.Controls.Add(this.roundedButton2);
            this.panelContent.Controls.Add(this.shadowPanel2);
            this.panelContent.Controls.Add(this.roundedToggleButton1);
            this.panelContent.Controls.Add(this.roundedButton1);
            this.panelContent.Controls.Add(this.shadowPanel1);
            // 
            // shadowPanel1
            // 
            this.shadowPanel1.BorderColor = System.Drawing.Color.Empty;
            this.shadowPanel1.Location = new System.Drawing.Point(87, 34);
            this.shadowPanel1.Name = "shadowPanel1";
            this.shadowPanel1.PanelColor = System.Drawing.Color.Empty;
            this.shadowPanel1.Size = new System.Drawing.Size(200, 100);
            this.shadowPanel1.TabIndex = 0;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButton1.BorderColor = System.Drawing.Color.Black;
            this.roundedButton1.BorderRadius = 20;
            this.roundedButton1.BorderSize = 0;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(314, 128);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(143, 84);
            this.roundedButton1.TabIndex = 1;
            this.roundedButton1.Text = "roundedButton1";
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // roundedToggleButton1
            // 
            this.roundedToggleButton1.AutoSize = true;
            this.roundedToggleButton1.Fill = true;
            this.roundedToggleButton1.Location = new System.Drawing.Point(314, 100);
            this.roundedToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.roundedToggleButton1.Name = "roundedToggleButton1";
            this.roundedToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.roundedToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.roundedToggleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.roundedToggleButton1.Size = new System.Drawing.Size(135, 22);
            this.roundedToggleButton1.TabIndex = 2;
            this.roundedToggleButton1.Text = "roundedToggleButton1";
            this.roundedToggleButton1.UseVisualStyleBackColor = true;
            // 
            // shadowPanel2
            // 
            this.shadowPanel2.BorderColor = System.Drawing.Color.Empty;
            this.shadowPanel2.Location = new System.Drawing.Point(87, 158);
            this.shadowPanel2.Name = "shadowPanel2";
            this.shadowPanel2.PanelColor = System.Drawing.Color.Empty;
            this.shadowPanel2.Size = new System.Drawing.Size(200, 100);
            this.shadowPanel2.TabIndex = 3;
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButton2.BorderColor = System.Drawing.Color.Black;
            this.roundedButton2.BorderRadius = 20;
            this.roundedButton2.BorderSize = 0;
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.ForeColor = System.Drawing.Color.White;
            this.roundedButton2.Location = new System.Drawing.Point(306, 218);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(143, 40);
            this.roundedButton2.TabIndex = 4;
            this.roundedButton2.Text = "roundedButton2";
            this.roundedButton2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Main = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Rounded.RoundedToggleButton roundedToggleButton1;
        private Rounded.RoundedButton roundedButton1;
        private ShadowPanel.ShadowPanel shadowPanel1;
        private Rounded.RoundedButton roundedButton2;
        private ShadowPanel.ShadowPanel shadowPanel2;
    }
}

