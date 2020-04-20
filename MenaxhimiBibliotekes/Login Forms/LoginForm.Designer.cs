namespace MenaxhimiBibliotekes.Login_Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panelHeaderLogin = new System.Windows.Forms.Panel();
            this.picLogoLogin = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUsernameLogin = new System.Windows.Forms.TextBox();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.lblUsernameLogin = new System.Windows.Forms.Label();
            this.lblPasswordLogin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblRightsReservedLogin = new System.Windows.Forms.Label();
            this.panelHeaderLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeaderLogin
            // 
            this.panelHeaderLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelHeaderLogin.BackgroundImage")));
            this.panelHeaderLogin.Controls.Add(this.picLogoLogin);
            this.panelHeaderLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderLogin.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderLogin.Name = "panelHeaderLogin";
            this.panelHeaderLogin.Size = new System.Drawing.Size(828, 474);
            this.panelHeaderLogin.TabIndex = 1;
            // 
            // picLogoLogin
            // 
            this.picLogoLogin.BackColor = System.Drawing.Color.Transparent;
            this.picLogoLogin.Image = ((System.Drawing.Image)(resources.GetObject("picLogoLogin.Image")));
            this.picLogoLogin.Location = new System.Drawing.Point(53, 188);
            this.picLogoLogin.Name = "picLogoLogin";
            this.picLogoLogin.Size = new System.Drawing.Size(718, 104);
            this.picLogoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoLogin.TabIndex = 1;
            this.picLogoLogin.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(102, 706);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 1);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(102, 922);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(618, 1);
            this.panel3.TabIndex = 3;
            // 
            // txtUsernameLogin
            // 
            this.txtUsernameLogin.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsernameLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsernameLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameLogin.Location = new System.Drawing.Point(102, 650);
            this.txtUsernameLogin.Name = "txtUsernameLogin";
            this.txtUsernameLogin.Size = new System.Drawing.Size(618, 43);
            this.txtUsernameLogin.TabIndex = 4;
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.BackColor = System.Drawing.SystemColors.Control;
            this.txtPasswordLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswordLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordLogin.Location = new System.Drawing.Point(102, 873);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.PasswordChar = '*';
            this.txtPasswordLogin.Size = new System.Drawing.Size(618, 43);
            this.txtPasswordLogin.TabIndex = 4;
            // 
            // lblUsernameLogin
            // 
            this.lblUsernameLogin.AutoSize = true;
            this.lblUsernameLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUsernameLogin.Location = new System.Drawing.Point(94, 590);
            this.lblUsernameLogin.Name = "lblUsernameLogin";
            this.lblUsernameLogin.Size = new System.Drawing.Size(163, 45);
            this.lblUsernameLogin.TabIndex = 5;
            this.lblUsernameLogin.Text = "Username";
            // 
            // lblPasswordLogin
            // 
            this.lblPasswordLogin.AutoSize = true;
            this.lblPasswordLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPasswordLogin.Location = new System.Drawing.Point(94, 804);
            this.lblPasswordLogin.Name = "lblPasswordLogin";
            this.lblPasswordLogin.Size = new System.Drawing.Size(153, 45);
            this.lblPasswordLogin.TabIndex = 5;
            this.lblPasswordLogin.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(248, 1016);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(281, 81);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblRightsReservedLogin
            // 
            this.lblRightsReservedLogin.AutoSize = true;
            this.lblRightsReservedLogin.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightsReservedLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRightsReservedLogin.Location = new System.Drawing.Point(228, 1214);
            this.lblRightsReservedLogin.Name = "lblRightsReservedLogin";
            this.lblRightsReservedLogin.Size = new System.Drawing.Size(318, 30);
            this.lblRightsReservedLogin.TabIndex = 5;
            this.lblRightsReservedLogin.Text = "All Rights Reserved ©Stackbooks";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 1284);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPasswordLogin);
            this.Controls.Add(this.lblRightsReservedLogin);
            this.Controls.Add(this.lblUsernameLogin);
            this.Controls.Add(this.txtPasswordLogin);
            this.Controls.Add(this.txtUsernameLogin);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeaderLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panelHeaderLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeaderLogin;
        private System.Windows.Forms.PictureBox picLogoLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtUsernameLogin;
        private System.Windows.Forms.Label lblUsernameLogin;
        private System.Windows.Forms.Label lblPasswordLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblRightsReservedLogin;
        private System.Windows.Forms.TextBox txtPasswordLogin;
    }
}