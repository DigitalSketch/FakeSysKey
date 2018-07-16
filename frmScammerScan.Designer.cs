namespace FakeSysKey
{
    partial class frmScammerScan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScammerScan));
            this.txtBoxMessage = new System.Windows.Forms.TextBox();
            this.lblOne = new System.Windows.Forms.Label();
            this.picCompLockImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCompLockImg)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxMessage
            // 
            this.txtBoxMessage.BackColor = System.Drawing.Color.Black;
            this.txtBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMessage.ForeColor = System.Drawing.Color.GreenYellow;
            this.txtBoxMessage.Location = new System.Drawing.Point(20, 100);
            this.txtBoxMessage.Multiline = true;
            this.txtBoxMessage.Name = "txtBoxMessage";
            this.txtBoxMessage.ReadOnly = true;
            this.txtBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxMessage.Size = new System.Drawing.Size(1740, 961);
            this.txtBoxMessage.TabIndex = 1;
            // 
            // lblOne
            // 
            this.lblOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOne.Location = new System.Drawing.Point(101, 20);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(1657, 69);
            this.lblOne.TabIndex = 2;
            this.lblOne.Text = "Suspicious activity has been detected on your computer. Microsoft Defending Sub S" +
    "ystems will run a check against all incoming IPs and take appropriate action. ";
            // 
            // picCompLockImg
            // 
            this.picCompLockImg.Image = global::FakeSysKey.Properties.Resources.windows_defender1;
            this.picCompLockImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("picCompLockImg.InitialImage")));
            this.picCompLockImg.Location = new System.Drawing.Point(20, 20);
            this.picCompLockImg.Name = "picCompLockImg";
            this.picCompLockImg.Size = new System.Drawing.Size(60, 60);
            this.picCompLockImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCompLockImg.TabIndex = 3;
            this.picCompLockImg.TabStop = false;
            // 
            // frmScammerScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1788, 1073);
            this.Controls.Add(this.picCompLockImg);
            this.Controls.Add(this.lblOne);
            this.Controls.Add(this.txtBoxMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScammerScan";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Microsoft Scam Detection Assistant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmScammerScan_FormClosing);
            this.Load += new System.EventHandler(this.frmScammerScan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCompLockImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxMessage;
        private System.Windows.Forms.PictureBox picCompLockImg;
        private System.Windows.Forms.Label lblOne;
    }
}