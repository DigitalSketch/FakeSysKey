namespace FakeSysKey
{
    partial class frmStartupKey
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBoxPassStartup = new System.Windows.Forms.GroupBox();
            this.grpBoxSystemGenPass = new System.Windows.Forms.GroupBox();
            this.rdButA01 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radButSysGenPass = new System.Windows.Forms.RadioButton();
            this.radButPassStartup = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass1 = new System.Windows.Forms.TextBox();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.butOK = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.grpBoxPassStartup.SuspendLayout();
            this.grpBoxSystemGenPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxPassStartup
            // 
            this.grpBoxPassStartup.Controls.Add(this.label5);
            this.grpBoxPassStartup.Controls.Add(this.label4);
            this.grpBoxPassStartup.Controls.Add(this.txtPass2);
            this.grpBoxPassStartup.Controls.Add(this.txtPass1);
            this.grpBoxPassStartup.Controls.Add(this.label3);
            this.grpBoxPassStartup.Enabled = false;
            this.grpBoxPassStartup.Location = new System.Drawing.Point(20, 20);
            this.grpBoxPassStartup.Name = "grpBoxPassStartup";
            this.grpBoxPassStartup.Size = new System.Drawing.Size(569, 225);
            this.grpBoxPassStartup.TabIndex = 0;
            this.grpBoxPassStartup.TabStop = false;
            // 
            // grpBoxSystemGenPass
            // 
            this.grpBoxSystemGenPass.Controls.Add(this.label2);
            this.grpBoxSystemGenPass.Controls.Add(this.label1);
            this.grpBoxSystemGenPass.Controls.Add(this.radioButton1);
            this.grpBoxSystemGenPass.Controls.Add(this.rdButA01);
            this.grpBoxSystemGenPass.Location = new System.Drawing.Point(20, 264);
            this.grpBoxSystemGenPass.Name = "grpBoxSystemGenPass";
            this.grpBoxSystemGenPass.Size = new System.Drawing.Size(569, 284);
            this.grpBoxSystemGenPass.TabIndex = 2;
            this.grpBoxSystemGenPass.TabStop = false;
            // 
            // rdButA01
            // 
            this.rdButA01.AutoSize = true;
            this.rdButA01.Location = new System.Drawing.Point(54, 51);
            this.rdButA01.Name = "rdButA01";
            this.rdButA01.Size = new System.Drawing.Size(361, 29);
            this.rdButA01.TabIndex = 1;
            this.rdButA01.Text = "Store Startup Key on Floppy Disk";
            this.rdButA01.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(54, 153);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(286, 29);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Store Startup Key Locally";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(88, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 60);
            this.label1.TabIndex = 4;
            this.label1.Text = "Requires a floppy disk to be inserted during system start.";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(88, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 85);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stores a key as part of the operating system, and no interaction is required duri" +
    "ng system farting.";
            // 
            // radButSysGenPass
            // 
            this.radButSysGenPass.AutoSize = true;
            this.radButSysGenPass.Checked = true;
            this.radButSysGenPass.Location = new System.Drawing.Point(40, 264);
            this.radButSysGenPass.Name = "radButSysGenPass";
            this.radButSysGenPass.Size = new System.Drawing.Size(321, 29);
            this.radButSysGenPass.TabIndex = 2;
            this.radButSysGenPass.TabStop = true;
            this.radButSysGenPass.Text = "System Generated Password";
            this.radButSysGenPass.UseVisualStyleBackColor = true;
            this.radButSysGenPass.CheckedChanged += new System.EventHandler(this.radButSysGenPass_CheckedChanged);
            // 
            // radButPassStartup
            // 
            this.radButPassStartup.AutoSize = true;
            this.radButPassStartup.Location = new System.Drawing.Point(40, 20);
            this.radButPassStartup.Name = "radButPassStartup";
            this.radButPassStartup.Size = new System.Drawing.Size(212, 29);
            this.radButPassStartup.TabIndex = 30;
            this.radButPassStartup.TabStop = true;
            this.radButPassStartup.Text = "Password Startup";
            this.radButPassStartup.UseVisualStyleBackColor = true;
            this.radButPassStartup.CheckedChanged += new System.EventHandler(this.radButPassStartup_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(50, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(500, 55);
            this.label3.TabIndex = 0;
            this.label3.Text = "Requires a password to be entered during system start.";
            // 
            // txtPass1
            // 
            this.txtPass1.Location = new System.Drawing.Point(190, 110);
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.PasswordChar = '•';
            this.txtPass1.Size = new System.Drawing.Size(350, 31);
            this.txtPass1.TabIndex = 20;
            // 
            // txtPass2
            // 
            this.txtPass2.Location = new System.Drawing.Point(190, 160);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.PasswordChar = '•';
            this.txtPass2.Size = new System.Drawing.Size(350, 31);
            this.txtPass2.TabIndex = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirm:";
            // 
            // butOK
            // 
            this.butOK.AccessibleDescription = "Click this button if you are a crappy scammer!";
            this.butOK.Location = new System.Drawing.Point(146, 571);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(142, 46);
            this.butOK.TabIndex = 5;
            this.butOK.Text = "OK";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // butCancel
            // 
            this.butCancel.AccessibleDescription = "Click this button if you want to change your scamming ways.";
            this.butCancel.Location = new System.Drawing.Point(308, 571);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(142, 46);
            this.butCancel.TabIndex = 0;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // frmStartupKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 651);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butOK);
            this.Controls.Add(this.radButPassStartup);
            this.Controls.Add(this.radButSysGenPass);
            this.Controls.Add(this.grpBoxSystemGenPass);
            this.Controls.Add(this.grpBoxPassStartup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStartupKey";
            this.Text = "Startup Key";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStartupKey_FormClosing);
            this.Load += new System.EventHandler(this.frmStartupKey_Load);
            this.grpBoxPassStartup.ResumeLayout(false);
            this.grpBoxPassStartup.PerformLayout();
            this.grpBoxSystemGenPass.ResumeLayout(false);
            this.grpBoxSystemGenPass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxPassStartup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPass2;
        private System.Windows.Forms.TextBox txtPass1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpBoxSystemGenPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdButA01;
        private System.Windows.Forms.RadioButton radButSysGenPass;
        private System.Windows.Forms.RadioButton radButPassStartup;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Button butCancel;
    }
}