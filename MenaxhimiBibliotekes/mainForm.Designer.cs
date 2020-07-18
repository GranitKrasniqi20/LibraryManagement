namespace MenaxhimiBibliotekes
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.btnMaterials = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelUser = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLoggedUser = new System.Windows.Forms.Button();
            this.appLogo = new System.Windows.Forms.PictureBox();
            this.appName = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMyProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterMaterialTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterMaterialLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterGenresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterLanguagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenu.SuspendLayout();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appName)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnNotifications);
            this.panelMenu.Controls.Add(this.btnMaterials);
            this.panelMenu.Controls.Add(this.btnMembers);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelUser);
            this.panelMenu.Controls.Add(this.appLogo);
            this.panelMenu.Controls.Add(this.appName);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Name = "panelMenu";
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnNotifications
            // 
            this.btnNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnNotifications.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnNotifications, "btnNotifications");
            this.btnNotifications.ForeColor = System.Drawing.Color.White;
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.UseVisualStyleBackColor = false;
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
            // 
            // btnMaterials
            // 
            this.btnMaterials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnMaterials.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnMaterials, "btnMaterials");
            this.btnMaterials.ForeColor = System.Drawing.Color.White;
            this.btnMaterials.Name = "btnMaterials";
            this.btnMaterials.UseVisualStyleBackColor = false;
            this.btnMaterials.Click += new System.EventHandler(this.btnMaterials_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnMembers.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnMembers, "btnMembers");
            this.btnMembers.ForeColor = System.Drawing.Color.White;
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.UseVisualStyleBackColor = false;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnDashboard, "btnDashboard");
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.panelUser.Controls.Add(this.btnLogout);
            this.panelUser.Controls.Add(this.btnLoggedUser);
            resources.ApplyResources(this.panelUser, "panelUser");
            this.panelUser.Name = "panelUser";
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnLogout, "btnLogout");
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLoggedUser
            // 
            this.btnLoggedUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.btnLoggedUser.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnLoggedUser, "btnLoggedUser");
            this.btnLoggedUser.ForeColor = System.Drawing.Color.White;
            this.btnLoggedUser.Name = "btnLoggedUser";
            this.btnLoggedUser.UseVisualStyleBackColor = false;
            this.btnLoggedUser.Click += new System.EventHandler(this.btnLoggedUser_Click);
            // 
            // appLogo
            // 
            resources.ApplyResources(this.appLogo, "appLogo");
            this.appLogo.Name = "appLogo";
            this.appLogo.TabStop = false;
            this.appLogo.Click += new System.EventHandler(this.appLogo_Click);
            // 
            // appName
            // 
            resources.ApplyResources(this.appName, "appName");
            this.appName.Name = "appName";
            this.appName.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.editToolStripMenuItem,
            this.extrasToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMyProfileToolStripMenuItem,
            this.editUserAccountsToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            resources.ApplyResources(this.preferencesToolStripMenuItem, "preferencesToolStripMenuItem");
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.PreferencesToolStripMenuItem_Click);
            // 
            // openMyProfileToolStripMenuItem
            // 
            this.openMyProfileToolStripMenuItem.Name = "openMyProfileToolStripMenuItem";
            resources.ApplyResources(this.openMyProfileToolStripMenuItem, "openMyProfileToolStripMenuItem");
            this.openMyProfileToolStripMenuItem.Click += new System.EventHandler(this.openMyProfileToolStripMenuItem_Click);
            // 
            // editUserAccountsToolStripMenuItem
            // 
            this.editUserAccountsToolStripMenuItem.Name = "editUserAccountsToolStripMenuItem";
            resources.ApplyResources(this.editUserAccountsToolStripMenuItem, "editUserAccountsToolStripMenuItem");
            this.editUserAccountsToolStripMenuItem.Click += new System.EventHandler(this.editUserAccountsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createMemberToolStripMenuItem,
            this.updateMemberToolStripMenuItem,
            this.deleteMemberToolStripMenuItem,
            this.createMaterialToolStripMenuItem,
            this.updateMaterialToolStripMenuItem,
            this.deleteMaterialToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            // 
            // createMemberToolStripMenuItem
            // 
            this.createMemberToolStripMenuItem.Name = "createMemberToolStripMenuItem";
            resources.ApplyResources(this.createMemberToolStripMenuItem, "createMemberToolStripMenuItem");
            this.createMemberToolStripMenuItem.Click += new System.EventHandler(this.createMemberToolStripMenuItem_Click);
            // 
            // updateMemberToolStripMenuItem
            // 
            this.updateMemberToolStripMenuItem.Name = "updateMemberToolStripMenuItem";
            resources.ApplyResources(this.updateMemberToolStripMenuItem, "updateMemberToolStripMenuItem");
            this.updateMemberToolStripMenuItem.Click += new System.EventHandler(this.updateMemberToolStripMenuItem_Click);
            // 
            // deleteMemberToolStripMenuItem
            // 
            this.deleteMemberToolStripMenuItem.Name = "deleteMemberToolStripMenuItem";
            resources.ApplyResources(this.deleteMemberToolStripMenuItem, "deleteMemberToolStripMenuItem");
            this.deleteMemberToolStripMenuItem.Click += new System.EventHandler(this.deleteMemberToolStripMenuItem_Click);
            // 
            // createMaterialToolStripMenuItem
            // 
            this.createMaterialToolStripMenuItem.Name = "createMaterialToolStripMenuItem";
            resources.ApplyResources(this.createMaterialToolStripMenuItem, "createMaterialToolStripMenuItem");
            this.createMaterialToolStripMenuItem.Click += new System.EventHandler(this.createMaterialToolStripMenuItem_Click);
            // 
            // updateMaterialToolStripMenuItem
            // 
            this.updateMaterialToolStripMenuItem.Name = "updateMaterialToolStripMenuItem";
            resources.ApplyResources(this.updateMaterialToolStripMenuItem, "updateMaterialToolStripMenuItem");
            this.updateMaterialToolStripMenuItem.Click += new System.EventHandler(this.updateMaterialToolStripMenuItem_Click);
            // 
            // deleteMaterialToolStripMenuItem
            // 
            this.deleteMaterialToolStripMenuItem.Name = "deleteMaterialToolStripMenuItem";
            resources.ApplyResources(this.deleteMaterialToolStripMenuItem, "deleteMaterialToolStripMenuItem");
            this.deleteMaterialToolStripMenuItem.Click += new System.EventHandler(this.deleteMaterialToolStripMenuItem_Click);
            // 
            // extrasToolStripMenuItem
            // 
            this.extrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterMaterialTypesToolStripMenuItem,
            this.alterMaterialLocationToolStripMenuItem,
            this.alterGenresToolStripMenuItem,
            this.alterLanguagesToolStripMenuItem});
            this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            resources.ApplyResources(this.extrasToolStripMenuItem, "extrasToolStripMenuItem");
            // 
            // alterMaterialTypesToolStripMenuItem
            // 
            this.alterMaterialTypesToolStripMenuItem.Name = "alterMaterialTypesToolStripMenuItem";
            resources.ApplyResources(this.alterMaterialTypesToolStripMenuItem, "alterMaterialTypesToolStripMenuItem");
            this.alterMaterialTypesToolStripMenuItem.Click += new System.EventHandler(this.alterMaterialTypesToolStripMenuItem_Click);
            // 
            // alterMaterialLocationToolStripMenuItem
            // 
            this.alterMaterialLocationToolStripMenuItem.Name = "alterMaterialLocationToolStripMenuItem";
            resources.ApplyResources(this.alterMaterialLocationToolStripMenuItem, "alterMaterialLocationToolStripMenuItem");
            this.alterMaterialLocationToolStripMenuItem.Click += new System.EventHandler(this.alterMaterialLocationToolStripMenuItem_Click);
            // 
            // alterGenresToolStripMenuItem
            // 
            this.alterGenresToolStripMenuItem.Name = "alterGenresToolStripMenuItem";
            resources.ApplyResources(this.alterGenresToolStripMenuItem, "alterGenresToolStripMenuItem");
            this.alterGenresToolStripMenuItem.Click += new System.EventHandler(this.alterGenresToolStripMenuItem_Click);
            // 
            // alterLanguagesToolStripMenuItem
            // 
            this.alterLanguagesToolStripMenuItem.Name = "alterLanguagesToolStripMenuItem";
            resources.ApplyResources(this.alterLanguagesToolStripMenuItem, "alterLanguagesToolStripMenuItem");
            this.alterLanguagesToolStripMenuItem.Click += new System.EventHandler(this.alterLanguagesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "mainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.mainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.mainForm_Shown);
            this.panelMenu.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appName)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox appLogo;
        private System.Windows.Forms.PictureBox appName;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnMaterials;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLoggedUser;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMyProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUserAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterMaterialTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterMaterialLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterGenresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterLanguagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

