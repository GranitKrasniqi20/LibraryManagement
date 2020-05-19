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
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 24);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(273, 632);
            this.panelMenu.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 406);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(273, 67);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "  Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnNotifications
            // 
            this.btnNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnNotifications.FlatAppearance.BorderSize = 0;
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotifications.ForeColor = System.Drawing.Color.White;
            this.btnNotifications.Image = ((System.Drawing.Image)(resources.GetObject("btnNotifications.Image")));
            this.btnNotifications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotifications.Location = new System.Drawing.Point(0, 336);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNotifications.Size = new System.Drawing.Size(273, 67);
            this.btnNotifications.TabIndex = 4;
            this.btnNotifications.Text = "  Notifications";
            this.btnNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotifications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotifications.UseVisualStyleBackColor = false;
            // 
            // btnMaterials
            // 
            this.btnMaterials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnMaterials.FlatAppearance.BorderSize = 0;
            this.btnMaterials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterials.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterials.ForeColor = System.Drawing.Color.White;
            this.btnMaterials.Image = ((System.Drawing.Image)(resources.GetObject("btnMaterials.Image")));
            this.btnMaterials.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterials.Location = new System.Drawing.Point(0, 266);
            this.btnMaterials.Name = "btnMaterials";
            this.btnMaterials.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMaterials.Size = new System.Drawing.Size(273, 67);
            this.btnMaterials.TabIndex = 3;
            this.btnMaterials.Text = "  Materials";
            this.btnMaterials.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterials.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaterials.UseVisualStyleBackColor = false;
            this.btnMaterials.Click += new System.EventHandler(this.btnMaterials_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnMembers.FlatAppearance.BorderSize = 0;
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembers.ForeColor = System.Drawing.Color.White;
            this.btnMembers.Image = ((System.Drawing.Image)(resources.GetObject("btnMembers.Image")));
            this.btnMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.Location = new System.Drawing.Point(0, 196);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMembers.Size = new System.Drawing.Size(273, 67);
            this.btnMembers.TabIndex = 2;
            this.btnMembers.Text = "  Members";
            this.btnMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMembers.UseVisualStyleBackColor = false;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 126);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(273, 67);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "  Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.panelUser.Controls.Add(this.btnLogout);
            this.panelUser.Controls.Add(this.btnLoggedUser);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUser.Location = new System.Drawing.Point(0, 474);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(273, 158);
            this.panelUser.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 74);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(273, 84);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "  Log Out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLoggedUser
            // 
            this.btnLoggedUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.btnLoggedUser.FlatAppearance.BorderSize = 0;
            this.btnLoggedUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoggedUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoggedUser.ForeColor = System.Drawing.Color.White;
            this.btnLoggedUser.Image = ((System.Drawing.Image)(resources.GetObject("btnLoggedUser.Image")));
            this.btnLoggedUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoggedUser.Location = new System.Drawing.Point(0, 2);
            this.btnLoggedUser.Name = "btnLoggedUser";
            this.btnLoggedUser.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLoggedUser.Size = new System.Drawing.Size(273, 70);
            this.btnLoggedUser.TabIndex = 6;
            this.btnLoggedUser.Text = "  No Name";
            this.btnLoggedUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoggedUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoggedUser.UseVisualStyleBackColor = false;
            this.btnLoggedUser.Click += new System.EventHandler(this.btnLoggedUser_Click);
            // 
            // appLogo
            // 
            this.appLogo.Image = ((System.Drawing.Image)(resources.GetObject("appLogo.Image")));
            this.appLogo.Location = new System.Drawing.Point(21, 22);
            this.appLogo.Name = "appLogo";
            this.appLogo.Size = new System.Drawing.Size(46, 82);
            this.appLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appLogo.TabIndex = 0;
            this.appLogo.TabStop = false;
            this.appLogo.Click += new System.EventHandler(this.appLogo_Click);
            // 
            // appName
            // 
            this.appName.Image = ((System.Drawing.Image)(resources.GetObject("appName.Image")));
            this.appName.Location = new System.Drawing.Point(74, 22);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(188, 82);
            this.appName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appName.TabIndex = 0;
            this.appName.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.editToolStripMenuItem,
            this.extrasToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1026, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMyProfileToolStripMenuItem,
            this.editUserAccountsToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // openMyProfileToolStripMenuItem
            // 
            this.openMyProfileToolStripMenuItem.Name = "openMyProfileToolStripMenuItem";
            this.openMyProfileToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.openMyProfileToolStripMenuItem.Text = "Open My Profile";
            this.openMyProfileToolStripMenuItem.Click += new System.EventHandler(this.openMyProfileToolStripMenuItem_Click);
            // 
            // editUserAccountsToolStripMenuItem
            // 
            this.editUserAccountsToolStripMenuItem.Name = "editUserAccountsToolStripMenuItem";
            this.editUserAccountsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.editUserAccountsToolStripMenuItem.Text = "Manage User Accounts";
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
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // createMemberToolStripMenuItem
            // 
            this.createMemberToolStripMenuItem.Name = "createMemberToolStripMenuItem";
            this.createMemberToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createMemberToolStripMenuItem.Text = "Create Member";
            this.createMemberToolStripMenuItem.Click += new System.EventHandler(this.createMemberToolStripMenuItem_Click);
            // 
            // updateMemberToolStripMenuItem
            // 
            this.updateMemberToolStripMenuItem.Name = "updateMemberToolStripMenuItem";
            this.updateMemberToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateMemberToolStripMenuItem.Text = "Update Member";
            this.updateMemberToolStripMenuItem.Click += new System.EventHandler(this.updateMemberToolStripMenuItem_Click);
            // 
            // deleteMemberToolStripMenuItem
            // 
            this.deleteMemberToolStripMenuItem.Name = "deleteMemberToolStripMenuItem";
            this.deleteMemberToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteMemberToolStripMenuItem.Text = "Delete Member";
            this.deleteMemberToolStripMenuItem.Click += new System.EventHandler(this.deleteMemberToolStripMenuItem_Click);
            // 
            // createMaterialToolStripMenuItem
            // 
            this.createMaterialToolStripMenuItem.Name = "createMaterialToolStripMenuItem";
            this.createMaterialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createMaterialToolStripMenuItem.Text = "Create Material";
            this.createMaterialToolStripMenuItem.Click += new System.EventHandler(this.createMaterialToolStripMenuItem_Click);
            // 
            // updateMaterialToolStripMenuItem
            // 
            this.updateMaterialToolStripMenuItem.Name = "updateMaterialToolStripMenuItem";
            this.updateMaterialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateMaterialToolStripMenuItem.Text = "Update Material";
            this.updateMaterialToolStripMenuItem.Click += new System.EventHandler(this.updateMaterialToolStripMenuItem_Click);
            // 
            // deleteMaterialToolStripMenuItem
            // 
            this.deleteMaterialToolStripMenuItem.Name = "deleteMaterialToolStripMenuItem";
            this.deleteMaterialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteMaterialToolStripMenuItem.Text = "Delete Material";
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
            this.extrasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.extrasToolStripMenuItem.Text = "Extras";
            // 
            // alterMaterialTypesToolStripMenuItem
            // 
            this.alterMaterialTypesToolStripMenuItem.Name = "alterMaterialTypesToolStripMenuItem";
            this.alterMaterialTypesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.alterMaterialTypesToolStripMenuItem.Text = "Alter Material Types";
            this.alterMaterialTypesToolStripMenuItem.Click += new System.EventHandler(this.alterMaterialTypesToolStripMenuItem_Click);
            // 
            // alterMaterialLocationToolStripMenuItem
            // 
            this.alterMaterialLocationToolStripMenuItem.Name = "alterMaterialLocationToolStripMenuItem";
            this.alterMaterialLocationToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.alterMaterialLocationToolStripMenuItem.Text = "Alter Material Location";
            this.alterMaterialLocationToolStripMenuItem.Click += new System.EventHandler(this.alterMaterialLocationToolStripMenuItem_Click);
            // 
            // alterGenresToolStripMenuItem
            // 
            this.alterGenresToolStripMenuItem.Name = "alterGenresToolStripMenuItem";
            this.alterGenresToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.alterGenresToolStripMenuItem.Text = "Alter Genres";
            this.alterGenresToolStripMenuItem.Click += new System.EventHandler(this.alterGenresToolStripMenuItem_Click);
            // 
            // alterLanguagesToolStripMenuItem
            // 
            this.alterLanguagesToolStripMenuItem.Name = "alterLanguagesToolStripMenuItem";
            this.alterLanguagesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.alterLanguagesToolStripMenuItem.Text = "Alter Languages";
            this.alterLanguagesToolStripMenuItem.Click += new System.EventHandler(this.alterLanguagesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1026, 656);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1021, 632);
            this.Name = "mainForm";
            this.Text = "Stackbooks Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.mainForm_Activated);
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

