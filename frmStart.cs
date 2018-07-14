using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FakeSysKey
{
    public partial class frmStart : Form
    {
        private frmStartupKey frmStrtKey;

        public frmStart()
        {
            InitializeComponent();
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            if (frmStrtKey == null)
            {
                frmStrtKey = new frmStartupKey();
                frmStrtKey.frmStr = this;
                Point pnt = new Point(this.Location.X + 70, this.Location.Y + 70);
                frmStrtKey.Location = pnt;
                frmStrtKey.Show();
            }
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
