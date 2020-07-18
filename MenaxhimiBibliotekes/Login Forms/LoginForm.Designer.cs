namespace MenaxhimiBibliotekes.Login_Forms
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.btnCloseLogin = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPasswordLogin = new System.Windows.Forms.Label();
            this.lblRightsReservedLogin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsernameLogin = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.txtUsernameLogin = new System.Windows.Forms.TextBox();
            this.panelHeaderLogin = new System.Windows.Forms.Panel();
            this.picLogoLogin = new System.Windows.Forms.PictureBox();
            this.panelHeaderLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseLogin
            // 
            resources.ApplyResources(this.btnCloseLogin, "btnCloseLogin");
            this.btnCloseLogin.BackColor = System.Drawing.Color.Maroon;
            this.btnCloseLogin.ForeColor = System.Drawing.Color.White;
            this.btnCloseLogin.Name = "btnCloseLogin";
            this.btnCloseLogin.UseVisualStyleBackColor = false;
            this.btnCloseLogin.Click += new System.EventHandler(this.btnCloseLogin_Click);
            // 
            // btnLogin
            // 
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPasswordLogin
            // 
            resources.ApplyResources(this.lblPasswordLogin, "lblPasswordLogin");
            this.lblPasswordLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPasswordLogin.Name = "lblPasswordLogin";
            // 
            // lblRightsReservedLogin
            // 
            resources.ApplyResources(this.lblRightsReservedLogin, "lblRightsReservedLogin");
            this.lblRightsReservedLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRightsReservedLogin.Name = "lblRightsReservedLogin";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Name = "panel1";
            // 
            // lblUsernameLogin
            // 
            resources.ApplyResources(this.lblUsernameLogin, "lblUsernameLogin");
            this.lblUsernameLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUsernameLogin.Name = "lblUsernameLogin";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Name = "panel3";
            // 
            // txtPasswordLogin
            // 
            resources.ApplyResources(this.txtPasswordLogin, "txtPasswordLogin");
            this.txtPasswordLogin.BackColor = System.Drawing.SystemColors.Control;
            this.txtPasswordLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            // 
            // txtUsernameLogin
            // 
            resources.ApplyResources(this.txtUsernameLogin, "txtUsernameLogin");
            this.txtUsernameLogin.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsernameLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsernameLogin.Name = "txtUsernameLogin";
            // 
            // panelHeaderLogin
            // 
            resources.ApplyResources(this.panelHeaderLogin, "panelHeaderLogin");
            this.panelHeaderLogin.Controls.Add(this.picLogoLogin);
            this.panelHeaderLogin.Name = "panelHeaderLogin";
            // 
            // picLogoLogin
            // 
            resources.ApplyResources(this.picLogoLogin, "picLogoLogin");
            this.picLogoLogin.BackColor = System.Drawing.Color.Transparent;
            this.picLogoLogin.Name = "picLogoLogin";
            this.picLogoLogin.TabStop = false;
            // 
            // loginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCloseLogin);
            this.Controls.Add(this.panelHeaderLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPasswordLogin);
            this.Controls.Add(this.txtUsernameLogin);
            this.Controls.Add(this.lblRightsReservedLogin);
            this.Controls.Add(this.txtPasswordLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblUsernameLogin);
            this.Name = "loginForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.loginForm_FormClosed);
            this.panelHeaderLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeaderLogin;
        private System.Windows.Forms.PictureBox picLogoLogin;
        private System.Windows.Forms.Button btnCloseLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPasswordLogin;
        private System.Windows.Forms.Label lblRightsReservedLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsernameLogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.TextBox txtUsernameLogin;
    }
}