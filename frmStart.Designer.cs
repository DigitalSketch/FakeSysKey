namespace FakeSysKey
{
    partial class frmStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
            this.lblOne = new System.Windows.Forms.Label();
            this.lblTwo = new System.Windows.Forms.Label();
            this.radBut_Disabled = new System.Windows.Forms.RadioButton();
            this.radBut_Enabled = new System.Windows.Forms.RadioButton();
            this.butOK = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.butUpdate = new System.Windows.Forms.Button();
            this.picCompLockImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCompLockImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOne
            // 
            this.lblOne.Location = new System.Drawing.Point(149, 26);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(484, 82);
            this.lblOne.TabIndex = 0;
            this.lblOne.Text = "This tool will allow you to configure the Accounts Database to enable additional " +
    "encryption, further protecting the database from compromise.";
            // 
            // lblTwo
            // 
            this.lblTwo.Location = new System.Drawing.Point(149, 133);
            this.lblTwo.Name = "lblTwo";
            this.lblTwo.Size = new System.Drawing.Size(484, 57);
            this.lblTwo.TabIndex = 0;
            this.lblTwo.Text = "Once enabled, you\'re not even reading this you idiot.";
            // 
            // radBut_Disabled
            // 
            this.radBut_Disabled.AutoSize = true;
            this.radBut_Disabled.Enabled = false;
            this.radBut_Disabled.Location = new System.Drawing.Point(154, 208);
            this.radBut_Disabled.Name = "radBut_Disabled";
            this.radBut_Disabled.Size = new System.Drawing.Size(235, 29);
            this.radBut_Disabled.TabIndex = 1;
            this.radBut_Disabled.Text = "Encryption Disabled";
            this.radBut_Disabled.UseVisualStyleBackColor = true;
            // 
            // radBut_Enabled
            // 
            this.radBut_Enabled.AutoSize = true;
            this.radBut_Enabled.Checked = true;
            this.radBut_Enabled.Location = new System.Drawing.Point(154, 253);
            this.radBut_Enabled.Name = "radBut_Enabled";
            this.radBut_Enabled.Size = new System.Drawing.Size(230, 29);
            this.radBut_Enabled.TabIndex = 2;
            this.radBut_Enabled.TabStop = true;
            this.radBut_Enabled.Text = "Encryption Enabled";
            this.radBut_Enabled.UseVisualStyleBackColor = true;
            // 
            // butOK
            // 
            this.butOK.Location = new System.Drawing.Point(99, 310);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(142, 46);
            this.butOK.TabIndex = 3;
            this.butOK.Text = "OK";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(260, 310);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(142, 46);
            this.butCancel.TabIndex = 4;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butUpdate
            // 
            this.butUpdate.Location = new System.Drawing.Point(420, 310);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(142, 46);
            this.butUpdate.TabIndex = 500;
            this.butUpdate.Text = "Update";
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // picCompLockImg
            // 
            this.picCompLockImg.Image = global::FakeSysKey.Properties.Resources.complock;
            this.picCompLockImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("picCompLockImg.InitialImage")));
            this.picCompLockImg.Location = new System.Drawing.Point(21, 26);
            this.picCompLockImg.Name = "picCompLockImg";
            this.picCompLockImg.Size = new System.Drawing.Size(100, 74);
            this.picCompLockImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCompLockImg.TabIndex = 1;
            this.picCompLockImg.TabStop = false;
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 389);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butOK);
            this.Controls.Add(this.radBut_Enabled);
            this.Controls.Add(this.radBut_Disabled);
            this.Controls.Add(this.lblTwo);
            this.Controls.Add(this.picCompLockImg);
            this.Controls.Add(this.lblOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStart";
            this.Text = "Securing the Windows Account Database";
            ((System.ComponentModel.ISupportInitialize)(this.picCompLockImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.PictureBox picCompLockImg;
        private System.Windows.Forms.Label lblTwo;
        private System.Windows.Forms.RadioButton radBut_Disabled;
        private System.Windows.Forms.RadioButton radBut_Enabled;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butUpdate;
    }
}

