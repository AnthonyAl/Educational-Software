using System.Windows.Forms;

namespace WindowsFormsFormFlat
{
    public class Content : Panel
    {
        public override DockStyle Dock { get => base.Dock; set => base.Dock = DockStyle.Fill; }

        public Content()
        {
            Dock = DockStyle.Top;
        }

    }
}
