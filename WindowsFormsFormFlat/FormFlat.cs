using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsFormFlat
{
    public partial class FormFlat : Form
    {
        public bool Main { get; set; }
        public bool DeleteOnClose { get; set; }
        private int resizeGrip = 10;
        private Size formSizeMinimized;
        private Size formSizeMaximized;
        private Padding padding;



        // Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        public FormFlat()
        {
            InitializeComponent();
            formSizeMinimized = this.Size;
            formSizeMaximized = this.Size;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void FormFlat_Load(object sender, EventArgs e)
        {
            padding = Padding;
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            formSizeMinimized = this.ClientSize;
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                Padding = new Padding(0, 0, 0, 0);
                resizeGrip = -10;
                formSizeMaximized = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                resizeGrip = 10;
                Padding = padding;
                this.WindowState = FormWindowState.Normal;
                this.Size = formSizeMaximized;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (Main) Application.Exit();
            else if (DeleteOnClose) this.Close();
            else this.Hide();
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (panelHeader.Maximize && e.Clicks == 2)
            {
                buttonMaximize_Click(null, null);
                return;
            }
            ReleaseCapture();
            if (this.WindowState == FormWindowState.Maximized) return;
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override void WndProc(ref Message m)
        {
            #region Constants
            // Resize/WM_NCHITTEST values
            const int HTLEFT = 10;  //Left border of a window
            const int HTRIGHT = 11; //Right border of a window
            const int HTTOP = 12;   //Upper-horizontal border of a window
            const int HTTOPLEFT = 13;//Upper-left corner of a window border
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border
            const int HTBOTTOM = 15; //Lower-horizontal border of a window
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border
            #endregion

            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                #region Form Resize
                if (pos.X >= this.ClientSize.Width - resizeGrip)
                {
                    if(pos.Y >= this.ClientSize.Height - resizeGrip)
                    {
                        m.Result = (IntPtr)HTBOTTOMRIGHT;
                        return;
                    }
                    if (pos.Y <= resizeGrip)
                    {
                        m.Result = (IntPtr)HTTOPRIGHT;
                        return;
                    }
                   m.Result = (IntPtr)HTRIGHT;
                    return;
                }
                if (pos.X <= resizeGrip)
                {
                    if (pos.Y >= this.ClientSize.Height - resizeGrip)
                    {
                        m.Result = (IntPtr)HTBOTTOMLEFT;
                        return;
                    }
                    if (pos.Y <= resizeGrip)
                    {
                        m.Result = (IntPtr)HTTOPLEFT;
                        return;
                    }
                    m.Result = (IntPtr)HTLEFT;
                    return;
                }
                if (pos.Y <= resizeGrip)
                {
                    m.Result = (IntPtr)HTTOP;
                    return;
                }
                if (pos.Y >= this.ClientSize.Height - resizeGrip)
                {
                    m.Result = (IntPtr)HTBOTTOM;
                    return;
                }
                #endregion

            }
            base.WndProc(ref m);
        }
    }
}
