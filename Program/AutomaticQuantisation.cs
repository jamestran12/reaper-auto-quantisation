using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reaper_auto_quantisation
{
    public partial class AutomaticQuantisation : Form
    {
        private static AutomaticQuantisation? instance;
        public static AutomaticQuantisation Instance
        {
            get
            {
                if (instance == null) instance = new AutomaticQuantisation();
                return instance;
            }
        }
        public AutomaticQuantisation()
        {
            InitializeComponent();
            instance = this;
            Menu m = new Menu();
            m.Dock = DockStyle.Fill;
            this.Controls.Add(m);
        }
    }
}
