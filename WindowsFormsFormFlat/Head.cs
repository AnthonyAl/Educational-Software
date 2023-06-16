using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsFormFlat.Properties;

namespace WindowsFormsFormFlat
{
    public class Head : Panel
    {
        private Panel panelStreak = new Panel();
        private Button buttonClose = new Button();
        private Button buttonMinimize = new Button();
        private Button buttonMaximize = new Button();
        private Button buttonHelp = new Button();

        #region Event Handlers
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when the user clicks the close button.")]
        public event EventHandler ButtonCloseClick;
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when the user clicks the minimize button.")]
        public event EventHandler ButtonMinimizeClick;
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when the user clicks the maximize button.")]
        public event EventHandler ButtonMaximizeClick;
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when the user clicks the help button.")]
        public event EventHandler ButtonHelpClick;
        [Browsable(true)]
        [Category("Mouse")]
        [Description("Occurs when the mouse pointer is over the Streak component and a mouse button is pressed.")]
        public event MouseEventHandler PanelStreakMouseDown;
        #endregion

        #region Custom Properties
        private bool streak = true;
        private bool close = true;
        private bool minimize = true;
        private bool maximize = true;
        private bool help = true;
        private Image iClose = Resources.icons8_close_16;
        private Image iMinimize = Resources.icons8_subtract_16;
        private Image iMaximize = Resources.icons8_maximize_button_16;
        private Image iHelp = Resources.icons8_help_25;

        [Category("ControlButtons")]
        public Image IClose
        {
            get => iClose;
            set
            {
                iClose = value;
                buttonClose.Image = iClose;
            }
        }
        [Category("ControlButtons")]
        public Image IMinimize
        {
            get => iMinimize;
            set
            {
                iMinimize = value;
                buttonMinimize.Image = iMinimize;
            }
        }
        [Category("ControlButtons")]
        public Image IMaximize
        {
            get => iMaximize;
            set
            {
                iMaximize = value;
                buttonMaximize.Image = iMaximize;
            }
        }
        [Category("ControlButtons")]
        public Image IHelp
        {
            get => iHelp;
            set
            {
                iHelp = value;
                buttonHelp.Image = iHelp;
            }
        }
        [Category("Design")]
        public bool Streak
        {
            get => streak;
            set
            {
                streak = value;
                panelStreak.Visible = streak;
            }
        }
        [Category("ControlButtons")]
        public bool Close
        {
            get => close;
            set
            {
                close = value;
                buttonClose.Visible = close;
            }
        }
        [Category("ControlButtons")]
        public bool Minimize
        {
            get => minimize;
            set
            {
                minimize = value;
                buttonMinimize.Visible = minimize;
            }
        }
        [Category("ControlButtons")]
        public bool Maximize
        {
            get => maximize;
            set
            {
                maximize = value;
                buttonMaximize.Visible = maximize;
            }
        }
        [Category("ControlButtons")]
        public bool Help
        {
            get => help;
            set
            {
                help = value;
                buttonHelp.Visible = help;
            }
        }
        #endregion

        #region Property Overrides
        public override DockStyle Dock { get => base.Dock; set => base.Dock = DockStyle.Top; }
        public override Color BackColor { get => base.BackColor;
            set {
                base.BackColor = value;
                panelStreak.BackColor = ControlPaint.Dark(BackColor);
                buttonClose.BackColor = BackColor;
                buttonMinimize.BackColor = BackColor;
                buttonMinimize.FlatAppearance.MouseOverBackColor =
                    ControlPaint.Light(BackColor);
                buttonMinimize.FlatAppearance.MouseDownBackColor =
                    ControlPaint.LightLight(BackColor);
                buttonMaximize.BackColor = BackColor;
                buttonMaximize.FlatAppearance.MouseOverBackColor =
                    ControlPaint.Light(BackColor);
                buttonMaximize.FlatAppearance.MouseDownBackColor =
                    ControlPaint.LightLight(BackColor);
                buttonHelp.BackColor = BackColor;
                buttonHelp.FlatAppearance.MouseOverBackColor =
                    ControlPaint.Light(BackColor);
                buttonHelp.FlatAppearance.MouseDownBackColor =
                    ControlPaint.LightLight(BackColor);
            }
        }
        #endregion
        public Head()
        {
            InitializeComponent();
            Size = new Size(110, 46);
            BackColor = Color.Orange;
            Dock = DockStyle.Top;

            #region Control Initializing
            //Panel Streak
            panelStreak.Dock = DockStyle.Top;
            panelStreak.BackColor = ControlPaint.Dark(BackColor);
            panelStreak.Size = new Size(0, 5);
            panelStreak.Show();
            panelStreak.MouseDown += PanelStreak_MouseDown;
            //Button Close
            buttonClose.Dock = DockStyle.Right;
            buttonClose.BackColor = BackColor;
            buttonClose.Size = new Size(56, 0);
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 0, 0);
            buttonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 20, 20);
            buttonClose.Text = null;
            buttonClose.Show();
            buttonClose.Click += ButtonClose_Click;
            IClose = iClose;
            //Button Minimize
            buttonMinimize.Dock = DockStyle.Right;
            buttonMinimize.BackColor = BackColor;
            buttonMinimize.Size = new Size(56, 0);
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatAppearance.MouseOverBackColor =
                ControlPaint.Light(BackColor);
            buttonMinimize.FlatAppearance.MouseDownBackColor =
                ControlPaint.LightLight(BackColor);
            buttonMinimize.Text = null;
            buttonMinimize.Show();
            buttonMinimize.Click += ButtonMinimize_Click;
            IMinimize = iMinimize;
            //Button Maximize
            buttonMaximize.Dock = DockStyle.Right;
            buttonMaximize.BackColor = BackColor;
            buttonMaximize.Size = new Size(56, 0);
            buttonMaximize.FlatStyle = FlatStyle.Flat;
            buttonMaximize.FlatAppearance.BorderSize = 0;
            buttonMaximize.FlatAppearance.MouseOverBackColor =
                ControlPaint.Light(BackColor);
            buttonMaximize.FlatAppearance.MouseDownBackColor =
                ControlPaint.LightLight(BackColor);
            buttonMaximize.Text = null;
            buttonMaximize.Show();
            buttonMaximize.Click += ButtonMaximize_Click;
            IMaximize = iMaximize;
            //Button Help
            buttonHelp.Dock = DockStyle.Left;
            buttonHelp.BackColor = BackColor;
            buttonHelp.Size = new Size(56, 0);
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.FlatAppearance.BorderSize = 0;
            buttonHelp.FlatAppearance.MouseOverBackColor =
                ControlPaint.Light(BackColor);
            buttonHelp.FlatAppearance.MouseDownBackColor =
                ControlPaint.LightLight(BackColor);
            buttonHelp.Text = null;
            buttonHelp.Show();
            buttonHelp.Click += ButtonHelp_Click;
            IHelp = iHelp;
            #endregion
            Controls.Add(buttonHelp);
            Controls.Add(buttonMinimize);
            Controls.Add(buttonMaximize);
            Controls.Add(buttonClose);
            Controls.Add(panelStreak);
        }

        protected void ButtonClose_Click(object sender, EventArgs e)
        {
            if (this.ButtonCloseClick != null)
                this.ButtonCloseClick(this, e);
        }
        protected void ButtonMinimize_Click(object sender, EventArgs e)
        {
            if (this.ButtonMinimizeClick != null)
                this.ButtonMinimizeClick(this, e);
        }
        protected void ButtonMaximize_Click(object sender, EventArgs e)
        {
            if (this.ButtonMaximizeClick != null)
                this.ButtonMaximizeClick(this, e);
        }
        protected void ButtonHelp_Click(object sender, EventArgs e)
        {
            if (this.ButtonHelpClick != null)
                this.ButtonHelpClick(this, e);
        }
        protected void PanelStreak_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.PanelStreakMouseDown != null)
                this.PanelStreakMouseDown(this, e);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
