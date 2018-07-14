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
    public partial class frmStartupKey : Form
    {

        public frmStart frmStr;
        private frmScammerScan frmScamScan;

        public frmStartupKey()
        {
            InitializeComponent();
        }

        private void frmStartupKey_Load(object sender, EventArgs e)
        {

        }

        private void butOK_Click(object sender, EventArgs e)
        {
            if (radButPassStartup.Checked)
            {
                MessageBox.Show("Are you the one setting this password?\r\nIf someone is remotely controlling your computer, click 'No'.", "System Error", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (frmScamScan == null)
                {
                    this.Enabled = false;
                    frmScamScan = new frmScammerScan();
                    frmScamScan.Show();
                }
            }
            else
            {
                Environment.Exit(1);
            }
        }

        private void frmStartupKey_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void radButPassStartup_CheckedChanged(object sender, EventArgs e)
        {
            grpBoxPassStartup.Enabled = radButPassStartup.Checked;
            grpBoxSystemGenPass.Enabled = !radButPassStartup.Checked;

            if(radButPassStartup.Checked)
            {
                radButSysGenPass.Checked = false;
            }
        }

        private void radButSysGenPass_CheckedChanged(object sender, EventArgs e)
        {
            grpBoxPassStartup.Enabled = !radButSysGenPass.Checked;
            grpBoxSystemGenPass.Enabled = radButSysGenPass.Checked;

            if (radButSysGenPass.Checked)
            {
                radButPassStartup.Checked = false;
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            if (frmScamScan == null)
            {
                Environment.Exit(1);
            }
        }
    }
}
