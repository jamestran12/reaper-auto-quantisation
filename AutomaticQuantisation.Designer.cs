using System.Drawing.Text;
using System.Runtime.CompilerServices;

namespace reaper_auto_quantisation
{
    public partial class AutomaticQuantisation : Form
    {
        public AutomaticQuantisation()
        {
            InitializeComponent();
            Menu m = new Menu();
            m.Dock = DockStyle.Fill;
            this.Controls.Add(m);
        }
    }
}
