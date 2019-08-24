using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace whiteish
{
    public partial class form_whiteish : Form
    {
        public form_whiteish()
        {
            InitializeComponent();
        }

        private void form_whiteish_Load(object sender, EventArgs e)
        {
            int screenLeft = SystemInformation.VirtualScreen.Left;
            int screenTop = SystemInformation.VirtualScreen.Top;
            int screenWidth = SystemInformation.VirtualScreen.Width;
            int screenHeight = SystemInformation.VirtualScreen.Height;

            this.Size = new System.Drawing.Size(screenWidth + 100, screenHeight + 100);
            this.Location = new System.Drawing.Point(screenLeft, screenTop);
        }
    }
}
