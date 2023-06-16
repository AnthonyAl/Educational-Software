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
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.roundedToggleButton1);
            this.panelContent.Controls.Add(this.roundedButton1);
            this.panelContent.Controls.Add(this.shadowPanel1);
            // 
            // shadowPanel1
            // 
            this.shadowPanel1.BorderColor = System.Drawing.Color.Empty;
            this.shadowPanel1.Location = new System.Drawing.Point(146, 61);
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
            this.roundedButton1.Location = new System.Drawing.Point(514, 127);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(150, 84);
            this.roundedButton1.TabIndex = 1;
            this.roundedButton1.Text = "roundedButton1";
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // roundedToggleButton1
            // 
            this.roundedToggleButton1.AutoSize = true;
            this.roundedToggleButton1.Fill = true;
            this.roundedToggleButton1.Location = new System.Drawing.Point(335, 274);
            this.roundedToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.roundedToggleButton1.Name = "roundedToggleButton1";
            this.roundedToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.roundedToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.roundedToggleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.roundedToggleButton1.Size = new System.Drawing.Size(167, 22);
            this.roundedToggleButton1.TabIndex = 2;
            this.roundedToggleButton1.Text = "roundedToggleButton1";
            this.roundedToggleButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
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
    }
}

