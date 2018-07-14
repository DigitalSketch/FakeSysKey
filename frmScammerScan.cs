using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using System.IO;

namespace FakeSysKey
{
    public partial class frmScammerScan : Form
    {
        delegate void StringArgReturningVoidDelegate(string text);

        private int i = 0;

        private List<string> strList = new List<string>();
        private string[] strArray;

        private List<int> intList = new List<int>();
        private int[] intArray;

        private System.Timers.Timer waitTimer;

        private bool allDone = false;

        public frmScammerScan()
        {
            InitializeComponent();
        }

        private void frmScammerScan_Load(object sender, EventArgs e)
        {
            // Need to either gather from the Comp, or grab it from an entry field elsewhere
            string ipAddress = "255.255.255.255"; 
            string location = "NEED LOCATION INFO FROM WIRESHARK";
            string provider = "NEED PROVIDER INFO FROM WIRESHARK";

            Random rnd = new Random();

            // Size the text box
            txtBoxMessage.Height = this.Height - 90;

            // Setup the timer
            waitTimer = new System.Timers.Timer(10);
            waitTimer.Elapsed += OnWaitTimerEvent;
            waitTimer.AutoReset = false;
            waitTimer.Enabled = false;

            // Setup display text
            addItems("Analyzing connected IP addresses",100);
            addItems(".", rnd.Next(100,1000));
            addItems(".", rnd.Next(500, 1000));
            addItems(".", rnd.Next(500, 1000));
            addItems(".", rnd.Next(100, 1000));
            addItems(".\r\n", rnd.Next(100, 1000));
            addItems("\r\n", 100);
            addItems("=====** SUSPICIOUS IP ADDRESS FOUND **=====\r\n", 250);
            addItems("\r\n", 100);

            //TODO Read the IP, area etc.
            addItems("IP Address: " + ipAddress + "\r\n", 500);
            addItems("Location: " + location + "\r\n", 500);
            addItems("Provider: " + provider + "\r\n", 500);
            addItems("\r\n", 100);

            addItems("SENT> HOST " + ipAddress + "\r\n", 200);
            addItems("SENT> USER Anonymous\r\n", 200);
            addItems("SENT> CWD\r\n", 200);
            addItems("\r\n", 100);
            addItems("Checking remote user's file structure", 100);
            addItems(".", rnd.Next(500, 1000));
            addItems(".", rnd.Next(500, 1000));
            addItems(".", rnd.Next(500, 1000));
            addItems(".", rnd.Next(500, 1000));
            addItems(".", rnd.Next(500, 1000));
            addItems(".", rnd.Next(500, 1000));
            addItems(".", rnd.Next(500, 1000));
            addItems("\r\n", 100);
            addItems("RECV> Opening BINARY mode data connection for MLSD\r\n", 200);
            addItems("RECV> 226 Transfer Complete\r\n", 200);
            addItems("\r\n", 100);
            addItems("=====** ILLEGAL ACTIVITY FOUND **=====\r\n", 1000);
            addItems("\r\n", 100);
            addItems("=====** SETTING SYSKEY ON " + ipAddress + " **=====\r\n", 5000);
            addItems("\r\n", 100);
            addItems("=====** PREPARING FILE DELETION ON " + ipAddress + " **=====\r\n", 5000);
            addItems("\r\n", 100);

            if (Directory.Exists("C:\\Program Files (x86)\\"))
            {
                string[] pf86Dir = Directory.GetDirectories("C:\\Program Files (x86)\\");
                foreach(string dir86 in pf86Dir)
                {
                    addItems("SENT> DELE ftp//" + ipAddress + ": " + dir86 + "\r\n", rnd.Next(50, 250));
                    addItems("RECV> DELE Command Successful\r\n", rnd.Next(10, 100));
                }
            }

            if (Directory.Exists("C:\\Program Files\\"))
            {
                string[] pfDir = Directory.GetDirectories("C:\\Program Files\\");
                foreach (string dir in pfDir)
                {
                    addItems("SENT> DELE ftp//" + ipAddress + ": " + dir + "\r\n", rnd.Next(50, 250));
                    addItems("RECV> DELE Command Successful\r\n", rnd.Next(10, 100));
                }
            }

            if (Directory.Exists("C:\\Windows\\System32\\"))
            {
                string[] winDir = Directory.GetDirectories("C:\\Windows\\System32\\");
                foreach (string wDir in winDir)
                {
                    addItems("SENT> DELE ftp//" + ipAddress + ": " + wDir + "\r\n", rnd.Next(50, 250));
                    if (rnd.Next(1, 10) <= 2)
                    {
                        addItems("RECV> DELE FAILED: File in use\r\n", rnd.Next(10, 100));
                    }
                    else
                    {
                        addItems("RECV> DELE Command Successful\r\n", rnd.Next(10, 100));
                    }
                }
            }

            addItems("\r\n=====** FILE DELETION COMPLETE **=====\r\n", 500);
            addItems("Check log file for deletion errors.\r\n", 1000);
            addItems("RECV> Entering Passive Mode", 500);

            // Setup the Array
            strArray = strList.ToArray();
            intArray = intList.ToArray();

            // Start the timer
            waitTimer.Enabled = true;
        }

        private void addItems(string str, int num)
        {
            strList.Add(str);
            intList.Add(num);
        }

        private void OnWaitTimerEvent(object sender, ElapsedEventArgs e)
        {
            waitTimer.Stop();

            if (i < intArray.Length)
            {
                string myTempString = txtBoxMessage.Text.ToString() + strArray[i].ToString();
                SetText(myTempString);
            }
            else
            {
                allDone = true;
            }
        }

        private void SetText(string text)
        {
            if (this.txtBoxMessage.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtBoxMessage.Text = text;
                txtBoxMessage.SelectionStart = txtBoxMessage.Text.Length;
                txtBoxMessage.ScrollToCaret();

                if (i == 7)
                {
                    txtBoxMessage.BackColor = Color.Black;
                    txtBoxMessage.ForeColor = Color.GreenYellow;
                }

                waitTimer = new System.Timers.Timer(Int32.Parse(intArray[i].ToString()));
                waitTimer.Elapsed += OnWaitTimerEvent;
                waitTimer.AutoReset = false;
                waitTimer.Enabled = true;

                i++;
            }
        }

        private void frmScammerScan_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (allDone)
            {
                Environment.Exit(1);
            }
        }
    }
}
