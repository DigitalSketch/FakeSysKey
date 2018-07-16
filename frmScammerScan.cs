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
            string ipAddress = "REMOTE COMPUTER"; 
            string location = "";
            string provider = "";
            Char del = '|';

            /*
             * 
             * Format for the clipboard:
             * IP=IP HERE|LOC=LOCATION HERE|ISP=ISP HERE
             * 
             * Example:
             * IP=192.0.0.10|LOC=Dubia, India|ISP=Comcast INC
             * 
            */

            if (Clipboard.ContainsText())
            {
                string cpText = Clipboard.GetText();
                if(cpText.IndexOf("|LOC=") != -1)
                {
                    string[] cpArray = cpText.Split(del);
                    ipAddress = cpArray[0].Replace("IP=", "");
                    location = cpArray[1].Replace("LOC=", "");
                    provider = cpArray[2].Replace("ISP=", "");
                }
            }

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
            if (ipAddress != "REMOTE COMPUTER")
            {
                addItems("IP Address: " + ipAddress + "\r\n", 500);
                addItems("Location: " + location + "\r\n", 500);
                addItems("Provider: " + provider + "\r\n", 500);
                addItems("\r\n", 100);
            }

            addItems("STAT> CONNECTED\r\n", 200);
            addItems("RECV> 220 FTP READY\r\n", 200);
            addItems("SENT> HOST " + ipAddress + "\r\n", 200);
            addItems("SENT> USER ANONYMOUS\r\n", 750);
            addItems("RECV> 230 ANONYMOUS LOGGED IN\r\n", 200);
            addItems("RECV> 257 CURRENT DIRECTORY IS 'c:\\' \r\n", 100);
            addItems("SENT> MLSD\r\n", 400);
            addItems("RECV> 150 OPENING BINARY MODE DATA CONNECTION FOR MLSD\r\n", 100);
            addItems("SENT> CWD 'c:\\' \r\n", 300);
            addItems("RECV> 250 CWD COMMAND SUCCESSFUL\r\n", 100);
            addItems("RECV> 226 TRANSFER SUCCESSFUL\r\n", 200);
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
            addItems("=====** ILLEGAL ACTIVITY FOUND **=====\r\n", 1000);
            addItems("\r\n", 100);
            addItems("=====** SETTING SYSKEY ON " + ipAddress + " **=====\r\n", 5000);
            addItems("\r\n", 100);
            addItems("=====** PREPARING FILE DELETION ON " + ipAddress + " **=====\r\n", 8000);
            addItems("\r\n", 100);

            if (Directory.Exists("C:\\Program Files (x86)\\"))
            {
                string[] pf86Dir = Directory.GetDirectories("C:\\Program Files (x86)\\");
                foreach(string dir86 in pf86Dir)
                {
                    addItems("SENT> DELE ftp://Anonymous@" + ipAddress + ": " + dir86 + "\r\n", rnd.Next(50, 200));
                    addItems("RECV> DELE COMMAND SUCCESSFUL\r\n", rnd.Next(10, 100));
                }
            }

            if (Directory.Exists("C:\\Program Files\\"))
            {
                string[] pfDir = Directory.GetDirectories("C:\\Program Files\\");
                foreach (string dir in pfDir)
                {
                    addItems("SENT> DELE ftp://Anonymous@" + ipAddress + ": " + dir + "\r\n", rnd.Next(50, 200));
                    addItems("RECV> DELE COMMAND SUCCESSFUL\r\n", rnd.Next(10, 100));
                }
            }

            if (Directory.Exists("C:\\Windows\\System32\\"))
            {
                string[] winDir = Directory.GetDirectories("C:\\Windows\\System32\\");
                foreach (string wDir in winDir)
                {
                    addItems("SENT> DELE ftp://Anonymous@" + ipAddress + ": " + wDir + "\r\n", rnd.Next(50, 200));

                    if (rnd.Next(1, 12) <= 2)
                    {
                        addItems("RECV> DELE FAILED: File in use\r\n", rnd.Next(10, 100));
                    }
                    else
                    {
                        addItems("RECV> DELE COMMAND SUCCESSFUL\r\n", rnd.Next(10, 100));
                    }
                }
            }

            addItems("\r\n=====** FILE DELETION COMPLETE **=====\r\n", 500);
            addItems("Check log file for deletion errors.\r\n", 1000);
            addItems("RECV> 227 ENTERING PASSIVE MODE", 10);

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
