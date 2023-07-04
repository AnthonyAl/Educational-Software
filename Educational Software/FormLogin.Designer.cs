namespace Educational_Software
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.shadowPanelBody = new ShadowPanel.ShadowUpperPanel();
            this.roundedButtonCreateAccount = new Rounded.RoundedButton();
            this.shadowPanelLoginButton = new ShadowPanel.ShadowPanel();
            this.roundedButtonLogin = new Rounded.RoundedButton();
            this.labelForgotPassword = new System.Windows.Forms.Label();
            this.labelLoginTitle = new System.Windows.Forms.Label();
            this.labelUnderline1 = new System.Windows.Forms.Label();
            this.labelUnderline2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelContent.SuspendLayout();
            this.shadowPanelBody.SuspendLayout();
            this.shadowPanelLoginButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.panelHeader.IClose = global::Educational_Software.Properties.Resources._24_gray9;
            this.panelHeader.IHelp = global::Educational_Software.Properties.Resources._24_gray6;
            this.panelHeader.IMaximize = global::Educational_Software.Properties.Resources._24_gray10;
            this.panelHeader.IMinimize = global::Educational_Software.Properties.Resources._24_gray11;
            this.panelHeader.Size = new System.Drawing.Size(715, 46);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.panelContent.Controls.Add(this.shadowPanelBody);
            this.panelContent.Size = new System.Drawing.Size(715, 433);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.labelUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelUsername.Location = new System.Drawing.Point(40, 97);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(74, 15);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            this.labelUsername.Click += new System.EventHandler(this.labelUsername_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxUsername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxUsername.Location = new System.Drawing.Point(44, 97);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(553, 16);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.Click += new System.EventHandler(this.textBoxUsername_Click);
            this.textBoxUsername.Leave += new System.EventHandler(this.textBoxUsername_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxPassword.Location = new System.Drawing.Point(44, 169);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(553, 16);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.Click += new System.EventHandler(this.textBoxPassword_Click);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.labelPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelPassword.Location = new System.Drawing.Point(40, 169);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(71, 15);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password";
            this.labelPassword.Click += new System.EventHandler(this.labelPassword_Click);
            // 
            // shadowPanelBody
            // 
            this.shadowPanelBody.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shadowPanelBody.BorderColor = System.Drawing.Color.Empty;
            this.shadowPanelBody.Controls.Add(this.labelPassword);
            this.shadowPanelBody.Controls.Add(this.roundedButtonCreateAccount);
            this.shadowPanelBody.Controls.Add(this.shadowPanelLoginButton);
            this.shadowPanelBody.Controls.Add(this.labelForgotPassword);
            this.shadowPanelBody.Controls.Add(this.labelLoginTitle);
            this.shadowPanelBody.Controls.Add(this.labelUsername);
            this.shadowPanelBody.Controls.Add(this.textBoxPassword);
            this.shadowPanelBody.Controls.Add(this.textBoxUsername);
            this.shadowPanelBody.Controls.Add(this.labelUnderline1);
            this.shadowPanelBody.Controls.Add(this.labelUnderline2);
            this.shadowPanelBody.Location = new System.Drawing.Point(37, 26);
            this.shadowPanelBody.Name = "shadowPanelBody";
            this.shadowPanelBody.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.shadowPanelBody.Size = new System.Drawing.Size(641, 382);
            this.shadowPanelBody.TabIndex = 4;
            // 
            // roundedButtonCreateAccount
            // 
            this.roundedButtonCreateAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButtonCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.roundedButtonCreateAccount.BorderColor = System.Drawing.Color.Black;
            this.roundedButtonCreateAccount.BorderRadius = 4;
            this.roundedButtonCreateAccount.BorderSize = 0;
            this.roundedButtonCreateAccount.FlatAppearance.BorderSize = 0;
            this.roundedButtonCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonCreateAccount.Font = new System.Drawing.Font("Onyx", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonCreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            this.roundedButtonCreateAccount.Location = new System.Drawing.Point(44, 319);
            this.roundedButtonCreateAccount.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButtonCreateAccount.Name = "roundedButtonCreateAccount";
            this.roundedButtonCreateAccount.Size = new System.Drawing.Size(553, 42);
            this.roundedButtonCreateAccount.TabIndex = 7;
            this.roundedButtonCreateAccount.Text = "Νέος στην εφαρμογή μας;   Δημιούργησε λογαριασμό";
            this.roundedButtonCreateAccount.UseVisualStyleBackColor = false;
            this.roundedButtonCreateAccount.Click += new System.EventHandler(this.roundedButtonCreateAccount_Click);
            // 
            // shadowPanelLoginButton
            // 
            this.shadowPanelLoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shadowPanelLoginButton.BorderColor = System.Drawing.Color.Empty;
            this.shadowPanelLoginButton.Controls.Add(this.roundedButtonLogin);
            this.shadowPanelLoginButton.Location = new System.Drawing.Point(480, 212);
            this.shadowPanelLoginButton.Name = "shadowPanelLoginButton";
            this.shadowPanelLoginButton.Padding = new System.Windows.Forms.Padding(0, 0, 6, 6);
            this.shadowPanelLoginButton.PanelColor = System.Drawing.Color.Empty;
            this.shadowPanelLoginButton.Size = new System.Drawing.Size(117, 48);
            this.shadowPanelLoginButton.TabIndex = 6;
            // 
            // roundedButtonLogin
            // 
            this.roundedButtonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.roundedButtonLogin.BorderColor = System.Drawing.Color.Black;
            this.roundedButtonLogin.BorderRadius = 4;
            this.roundedButtonLogin.BorderSize = 0;
            this.roundedButtonLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedButtonLogin.FlatAppearance.BorderSize = 0;
            this.roundedButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonLogin.Font = new System.Drawing.Font("Onyx", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonLogin.ForeColor = System.Drawing.Color.White;
            this.roundedButtonLogin.Location = new System.Drawing.Point(0, 0);
            this.roundedButtonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButtonLogin.Name = "roundedButtonLogin";
            this.roundedButtonLogin.Size = new System.Drawing.Size(111, 42);
            this.roundedButtonLogin.TabIndex = 3;
            this.roundedButtonLogin.Text = "ΣΥΝΔΕΣΗ";
            this.roundedButtonLogin.UseVisualStyleBackColor = false;
            this.roundedButtonLogin.Click += new System.EventHandler(this.roundedButtonLogin_Click);
            // 
            // labelForgotPassword
            // 
            this.labelForgotPassword.AutoSize = true;
            this.labelForgotPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.labelForgotPassword.Font = new System.Drawing.Font("Onyx", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            this.labelForgotPassword.Location = new System.Drawing.Point(41, 220);
            this.labelForgotPassword.Name = "labelForgotPassword";
            this.labelForgotPassword.Size = new System.Drawing.Size(134, 17);
            this.labelForgotPassword.TabIndex = 5;
            this.labelForgotPassword.Text = "Ξεχάστηκε ο κωδικός;";
            // 
            // labelLoginTitle
            // 
            this.labelLoginTitle.AutoSize = true;
            this.labelLoginTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelLoginTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelLoginTitle.Font = new System.Drawing.Font("Onyx", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            this.labelLoginTitle.Location = new System.Drawing.Point(37, 23);
            this.labelLoginTitle.Name = "labelLoginTitle";
            this.labelLoginTitle.Size = new System.Drawing.Size(153, 36);
            this.labelLoginTitle.TabIndex = 4;
            this.labelLoginTitle.Text = "ΣΥΝΔΕΣΗ";
            // 
            // labelUnderline1
            // 
            this.labelUnderline1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUnderline1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.labelUnderline1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnderline1.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelUnderline1.Location = new System.Drawing.Point(44, 103);
            this.labelUnderline1.Name = "labelUnderline1";
            this.labelUnderline1.Size = new System.Drawing.Size(553, 23);
            this.labelUnderline1.TabIndex = 8;
            this.labelUnderline1.Text = resources.GetString("labelUnderline1.Text");
            // 
            // labelUnderline2
            // 
            this.labelUnderline2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUnderline2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.labelUnderline2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnderline2.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelUnderline2.Location = new System.Drawing.Point(44, 175);
            this.labelUnderline2.Name = "labelUnderline2";
            this.labelUnderline2.Size = new System.Drawing.Size(553, 23);
            this.labelUnderline2.TabIndex = 9;
            this.labelUnderline2.Text = resources.GetString("labelUnderline2.Text");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(721, 485);
            this.DeleteOnClose = true;
            this.Main = true;
            this.MinimumSize = new System.Drawing.Size(721, 485);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.panelContent.ResumeLayout(false);
            this.shadowPanelBody.ResumeLayout(false);
            this.shadowPanelBody.PerformLayout();
            this.shadowPanelLoginButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private ShadowPanel.ShadowUpperPanel shadowPanelBody;
        private System.Windows.Forms.Label labelLoginTitle;
        private System.Windows.Forms.Label labelForgotPassword;
        private Rounded.RoundedButton roundedButtonCreateAccount;
        private ShadowPanel.ShadowPanel shadowPanelLoginButton;
        private Rounded.RoundedButton roundedButtonLogin;
        private System.Windows.Forms.Label labelUnderline1;
        private System.Windows.Forms.Label labelUnderline2;
        private System.Windows.Forms.Timer timer1;
    }
}