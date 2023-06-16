
namespace WindowsFormsFormFlat
{
    partial class FormFlat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFlat));
            this.panelContent = new WindowsFormsFormFlat.Content();
            this.panelHeader = new WindowsFormsFormFlat.Head();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(3, 49);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(794, 398);
            this.panelContent.TabIndex = 7;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Orange;
            this.panelHeader.Close = true;
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Help = true;
            this.panelHeader.IClose = ((System.Drawing.Image)(resources.GetObject("panelHeader.IClose")));
            this.panelHeader.IHelp = ((System.Drawing.Image)(resources.GetObject("panelHeader.IHelp")));
            this.panelHeader.IMaximize = ((System.Drawing.Image)(resources.GetObject("panelHeader.IMaximize")));
            this.panelHeader.IMinimize = ((System.Drawing.Image)(resources.GetObject("panelHeader.IMinimize")));
            this.panelHeader.Location = new System.Drawing.Point(3, 3);
            this.panelHeader.Maximize = true;
            this.panelHeader.Minimize = true;
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(794, 46);
            this.panelHeader.Streak = true;
            this.panelHeader.TabIndex = 6;
            this.panelHeader.ButtonCloseClick += new System.EventHandler(this.buttonClose_Click);
            this.panelHeader.ButtonMinimizeClick += new System.EventHandler(this.buttonMinimize_Click);
            this.panelHeader.ButtonMaximizeClick += new System.EventHandler(this.buttonMaximize_Click);
            this.panelHeader.PanelStreakMouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // FormFlat
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFlat";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.Load += new System.EventHandler(this.FormFlat_Load);
            this.ResumeLayout(false);

        }

        #endregion
        protected Head panelHeader;
        protected Content panelContent;
    }
}

