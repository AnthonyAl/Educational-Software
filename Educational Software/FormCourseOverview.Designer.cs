namespace Educational_Software
{
    partial class FormCourseOverview
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelStatBoard = new System.Windows.Forms.Panel();
            this.panelStatistics = new System.Windows.Forms.Panel();
            this.shadowPanel1 = new ShadowPanel.ShadowPanel();
            this.roundedButton3 = new Rounded.RoundedButton();
            this.shadowPanelPointsToEarn = new ShadowPanel.ShadowPanel();
            this.labelPointsToEarn = new System.Windows.Forms.Label();
            this.pictureBoxPointsToEarn = new System.Windows.Forms.PictureBox();
            this.shadowPanelCompleted = new ShadowPanel.ShadowPanel();
            this.labelCompleted = new System.Windows.Forms.Label();
            this.pictureBoxCompleted = new System.Windows.Forms.PictureBox();
            this.shadowPanelSolving = new ShadowPanel.ShadowPanel();
            this.labelSolving = new System.Windows.Forms.Label();
            this.pictureBoxSolving = new System.Windows.Forms.PictureBox();
            this.panelBodyDesc = new System.Windows.Forms.Panel();
            this.panelLabelDesc = new System.Windows.Forms.Panel();
            this.labelDesc = new System.Windows.Forms.Label();
            this.pictureBoxDesc = new System.Windows.Forms.PictureBox();
            this.labelOverview = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.shadowPanelBack = new ShadowPanel.ShadowPanel();
            this.Back = new Rounded.RoundedButton();
            this.shadowPanelNext = new ShadowPanel.ShadowPanel();
            this.Next = new Rounded.RoundedButton();
            this.panelHeader.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.panelStatistics.SuspendLayout();
            this.shadowPanel1.SuspendLayout();
            this.shadowPanelPointsToEarn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPointsToEarn)).BeginInit();
            this.shadowPanelCompleted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompleted)).BeginInit();
            this.shadowPanelSolving.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSolving)).BeginInit();
            this.panelBodyDesc.SuspendLayout();
            this.panelLabelDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDesc)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.shadowPanelBack.SuspendLayout();
            this.shadowPanelNext.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Onyx", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(77, 11);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(129, 45);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Τίτλος";
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(85, 0, 85, 0);
            this.panelHeader.Size = new System.Drawing.Size(1212, 74);
            this.panelHeader.TabIndex = 2;
            // 
            // panelBody
            // 
            this.panelBody.AutoScroll = true;
            this.panelBody.Controls.Add(this.panelStatBoard);
            this.panelBody.Controls.Add(this.panelStatistics);
            this.panelBody.Controls.Add(this.panelBodyDesc);
            this.panelBody.Controls.Add(this.labelOverview);
            this.panelBody.Controls.Add(this.panelFooter);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 74);
            this.panelBody.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1212, 1232);
            this.panelBody.TabIndex = 3;
            // 
            // panelStatBoard
            // 
            this.panelStatBoard.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatBoard.Location = new System.Drawing.Point(0, 731);
            this.panelStatBoard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelStatBoard.Name = "panelStatBoard";
            this.panelStatBoard.Size = new System.Drawing.Size(1212, 386);
            this.panelStatBoard.TabIndex = 21;
            // 
            // panelStatistics
            // 
            this.panelStatistics.Controls.Add(this.shadowPanel1);
            this.panelStatistics.Controls.Add(this.shadowPanelPointsToEarn);
            this.panelStatistics.Controls.Add(this.shadowPanelCompleted);
            this.panelStatistics.Controls.Add(this.shadowPanelSolving);
            this.panelStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatistics.Location = new System.Drawing.Point(0, 322);
            this.panelStatistics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelStatistics.Name = "panelStatistics";
            this.panelStatistics.Size = new System.Drawing.Size(1212, 409);
            this.panelStatistics.TabIndex = 20;
            // 
            // shadowPanel1
            // 
            this.shadowPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.shadowPanel1.BorderColor = System.Drawing.Color.Empty;
            this.shadowPanel1.Controls.Add(this.roundedButton3);
            this.shadowPanel1.Location = new System.Drawing.Point(488, 316);
            this.shadowPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shadowPanel1.Name = "shadowPanel1";
            this.shadowPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 8, 7);
            this.shadowPanel1.PanelColor = System.Drawing.Color.Empty;
            this.shadowPanel1.Size = new System.Drawing.Size(240, 59);
            this.shadowPanel1.TabIndex = 4;
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
            this.roundedButton3.Text = "Έναρξη Μαθημάτων";
            this.roundedButton3.UseVisualStyleBackColor = false;
            this.roundedButton3.Click += new System.EventHandler(this.Next_Click);
            // 
            // shadowPanelPointsToEarn
            // 
            this.shadowPanelPointsToEarn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.shadowPanelPointsToEarn.BorderColor = System.Drawing.Color.Empty;
            this.shadowPanelPointsToEarn.Controls.Add(this.labelPointsToEarn);
            this.shadowPanelPointsToEarn.Controls.Add(this.pictureBoxPointsToEarn);
            this.shadowPanelPointsToEarn.Location = new System.Drawing.Point(883, 53);
            this.shadowPanelPointsToEarn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shadowPanelPointsToEarn.Name = "shadowPanelPointsToEarn";
            this.shadowPanelPointsToEarn.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.shadowPanelPointsToEarn.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.shadowPanelPointsToEarn.Size = new System.Drawing.Size(253, 234);
            this.shadowPanelPointsToEarn.TabIndex = 2;
            // 
            // labelPointsToEarn
            // 
            this.labelPointsToEarn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.labelPointsToEarn.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPointsToEarn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPointsToEarn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelPointsToEarn.Location = new System.Drawing.Point(0, 145);
            this.labelPointsToEarn.Name = "labelPointsToEarn";
            this.labelPointsToEarn.Size = new System.Drawing.Size(245, 65);
            this.labelPointsToEarn.TabIndex = 4;
            this.labelPointsToEarn.Text = "Πόντοι απομένουν";
            this.labelPointsToEarn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBoxPointsToEarn
            // 
            this.pictureBoxPointsToEarn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.pictureBoxPointsToEarn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxPointsToEarn.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPointsToEarn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxPointsToEarn.Name = "pictureBoxPointsToEarn";
            this.pictureBoxPointsToEarn.Size = new System.Drawing.Size(245, 145);
            this.pictureBoxPointsToEarn.TabIndex = 3;
            this.pictureBoxPointsToEarn.TabStop = false;
            // 
            // shadowPanelCompleted
            // 
            this.shadowPanelCompleted.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.shadowPanelCompleted.BorderColor = System.Drawing.Color.Empty;
            this.shadowPanelCompleted.Controls.Add(this.labelCompleted);
            this.shadowPanelCompleted.Controls.Add(this.pictureBoxCompleted);
            this.shadowPanelCompleted.Location = new System.Drawing.Point(480, 53);
            this.shadowPanelCompleted.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shadowPanelCompleted.Name = "shadowPanelCompleted";
            this.shadowPanelCompleted.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.shadowPanelCompleted.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.shadowPanelCompleted.Size = new System.Drawing.Size(253, 234);
            this.shadowPanelCompleted.TabIndex = 1;
            // 
            // labelCompleted
            // 
            this.labelCompleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.labelCompleted.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCompleted.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompleted.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelCompleted.Location = new System.Drawing.Point(0, 145);
            this.labelCompleted.Name = "labelCompleted";
            this.labelCompleted.Size = new System.Drawing.Size(245, 65);
            this.labelCompleted.TabIndex = 4;
            this.labelCompleted.Text = "Μαθητές Έλυσαν";
            this.labelCompleted.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBoxCompleted
            // 
            this.pictureBoxCompleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.pictureBoxCompleted.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxCompleted.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCompleted.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxCompleted.Name = "pictureBoxCompleted";
            this.pictureBoxCompleted.Size = new System.Drawing.Size(245, 145);
            this.pictureBoxCompleted.TabIndex = 3;
            this.pictureBoxCompleted.TabStop = false;
            // 
            // shadowPanelSolving
            // 
            this.shadowPanelSolving.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.shadowPanelSolving.BorderColor = System.Drawing.Color.Empty;
            this.shadowPanelSolving.Controls.Add(this.labelSolving);
            this.shadowPanelSolving.Controls.Add(this.pictureBoxSolving);
            this.shadowPanelSolving.Location = new System.Drawing.Point(77, 53);
            this.shadowPanelSolving.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shadowPanelSolving.Name = "shadowPanelSolving";
            this.shadowPanelSolving.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.shadowPanelSolving.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.shadowPanelSolving.Size = new System.Drawing.Size(253, 234);
            this.shadowPanelSolving.TabIndex = 0;
            // 
            // labelSolving
            // 
            this.labelSolving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.labelSolving.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSolving.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSolving.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelSolving.Location = new System.Drawing.Point(0, 145);
            this.labelSolving.Name = "labelSolving";
            this.labelSolving.Size = new System.Drawing.Size(245, 65);
            this.labelSolving.TabIndex = 2;
            this.labelSolving.Text = "Μαθητές Συμμετέχουν";
            this.labelSolving.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBoxSolving
            // 
            this.pictureBoxSolving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.pictureBoxSolving.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxSolving.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSolving.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxSolving.Name = "pictureBoxSolving";
            this.pictureBoxSolving.Size = new System.Drawing.Size(245, 145);
            this.pictureBoxSolving.TabIndex = 0;
            this.pictureBoxSolving.TabStop = false;
            // 
            // panelBodyDesc
            // 
            this.panelBodyDesc.Controls.Add(this.panelLabelDesc);
            this.panelBodyDesc.Controls.Add(this.pictureBoxDesc);
            this.panelBodyDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBodyDesc.Location = new System.Drawing.Point(0, 59);
            this.panelBodyDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBodyDesc.Name = "panelBodyDesc";
            this.panelBodyDesc.Padding = new System.Windows.Forms.Padding(0, 0, 43, 30);
            this.panelBodyDesc.Size = new System.Drawing.Size(1212, 263);
            this.panelBodyDesc.TabIndex = 19;
            // 
            // panelLabelDesc
            // 
            this.panelLabelDesc.Controls.Add(this.labelDesc);
            this.panelLabelDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLabelDesc.Location = new System.Drawing.Point(0, 0);
            this.panelLabelDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLabelDesc.Name = "panelLabelDesc";
            this.panelLabelDesc.Size = new System.Drawing.Size(681, 233);
            this.panelLabelDesc.TabIndex = 6;
            // 
            // labelDesc
            // 
            this.labelDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDesc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesc.Location = new System.Drawing.Point(0, 0);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Padding = new System.Windows.Forms.Padding(128, 0, 0, 0);
            this.labelDesc.Size = new System.Drawing.Size(681, 233);
            this.labelDesc.TabIndex = 1;
            this.labelDesc.Text = "Description\r\n";
            // 
            // pictureBoxDesc
            // 
            this.pictureBoxDesc.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxDesc.Location = new System.Drawing.Point(681, 0);
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
            this.labelOverview.Location = new System.Drawing.Point(0, 0);
            this.labelOverview.Name = "labelOverview";
            this.labelOverview.Padding = new System.Windows.Forms.Padding(107, 0, 0, 0);
            this.labelOverview.Size = new System.Drawing.Size(1212, 59);
            this.labelOverview.TabIndex = 8;
            this.labelOverview.Text = "Περιγραφή";
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.shadowPanelBack);
            this.panelFooter.Controls.Add(this.shadowPanelNext);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 1167);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(85, 0, 85, 0);
            this.panelFooter.Size = new System.Drawing.Size(1212, 65);
            this.panelFooter.TabIndex = 3;
            this.panelFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFooter_Paint);
            // 
            // shadowPanelBack
            // 
            this.shadowPanelBack.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.shadowPanelBack.BorderColor = System.Drawing.Color.Empty;
            this.shadowPanelBack.Controls.Add(this.Back);
            this.shadowPanelBack.Location = new System.Drawing.Point(16, 4);
            this.shadowPanelBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shadowPanelBack.Name = "shadowPanelBack";
            this.shadowPanelBack.PanelColor = System.Drawing.Color.Empty;
            this.shadowPanelBack.Size = new System.Drawing.Size(171, 47);
            this.shadowPanelBack.TabIndex = 6;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(116)))), ((int)(((byte)(176)))));
            this.Back.BorderRadius = 2;
            this.Back.BorderSize = 2;
            this.Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(139)))), ((int)(((byte)(29)))));
            this.Back.FlatAppearance.BorderSize = 0;
            this.Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Onyx", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(116)))), ((int)(((byte)(176)))));
            this.Back.Location = new System.Drawing.Point(0, 0);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(171, 47);
            this.Back.TabIndex = 4;
            this.Back.Text = "←  Ενότητες  ";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            this.Back.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.Back.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // shadowPanelNext
            // 
            this.shadowPanelNext.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.shadowPanelNext.BorderColor = System.Drawing.Color.Empty;
            this.shadowPanelNext.Controls.Add(this.Next);
            this.shadowPanelNext.Location = new System.Drawing.Point(1025, 4);
            this.shadowPanelNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shadowPanelNext.Name = "shadowPanelNext";
            this.shadowPanelNext.PanelColor = System.Drawing.Color.Empty;
            this.shadowPanelNext.Size = new System.Drawing.Size(171, 47);
            this.shadowPanelNext.TabIndex = 5;
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.Transparent;
            this.Next.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(116)))), ((int)(((byte)(176)))));
            this.Next.BorderRadius = 2;
            this.Next.BorderSize = 2;
            this.Next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Next.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(139)))), ((int)(((byte)(29)))));
            this.Next.FlatAppearance.BorderSize = 0;
            this.Next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.Font = new System.Drawing.Font("Onyx", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(116)))), ((int)(((byte)(176)))));
            this.Next.Location = new System.Drawing.Point(0, 0);
            this.Next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(171, 47);
            this.Next.TabIndex = 4;
            this.Next.Text = "Επόμενο  →";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            this.Next.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.Next.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // FormCourseOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1212, 1306);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHeader);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCourseOverview";
            this.Text = "FormCourseOverview";
            this.Load += new System.EventHandler(this.FormTeaching_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.panelStatistics.ResumeLayout(false);
            this.shadowPanel1.ResumeLayout(false);
            this.shadowPanelPointsToEarn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPointsToEarn)).EndInit();
            this.shadowPanelCompleted.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompleted)).EndInit();
            this.shadowPanelSolving.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSolving)).EndInit();
            this.panelBodyDesc.ResumeLayout(false);
            this.panelLabelDesc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDesc)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.shadowPanelBack.ResumeLayout(false);
            this.shadowPanelNext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelBody;
        private Rounded.RoundedButton Next;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelBodyDesc;
        private System.Windows.Forms.Panel panelLabelDesc;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.PictureBox pictureBoxDesc;
        private System.Windows.Forms.Label labelOverview;
        private System.Windows.Forms.Panel panelStatistics;
        private ShadowPanel.ShadowPanel shadowPanelPointsToEarn;
        private ShadowPanel.ShadowPanel shadowPanelCompleted;
        private ShadowPanel.ShadowPanel shadowPanelSolving;
        private System.Windows.Forms.PictureBox pictureBoxSolving;
        private System.Windows.Forms.Label labelSolving;
        private System.Windows.Forms.Label labelPointsToEarn;
        private System.Windows.Forms.PictureBox pictureBoxPointsToEarn;
        private System.Windows.Forms.Label labelCompleted;
        private System.Windows.Forms.PictureBox pictureBoxCompleted;
        private Rounded.RoundedButton roundedButton3;
        private ShadowPanel.ShadowPanel shadowPanel1;
        private System.Windows.Forms.Panel panelStatBoard;
        private ShadowPanel.ShadowPanel shadowPanelNext;
        private ShadowPanel.ShadowPanel shadowPanelBack;
        private Rounded.RoundedButton Back;
    }
}