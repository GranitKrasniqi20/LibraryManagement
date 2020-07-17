namespace MenaxhimiBibliotekes.Notifications_Forms
{
    partial class NotificationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationsForm));
            this.tableHeader = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSubHeader = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.comboNotificationType = new System.Windows.Forms.ComboBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFooterTitleCreate = new System.Windows.Forms.Label();
            this.flowpanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.tableHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelSubHeader.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // tableHeader
            // 
            resources.ApplyResources(this.tableHeader, "tableHeader");
            this.tableHeader.BackColor = System.Drawing.Color.Teal;
            this.tableHeader.Controls.Add(this.panel1, 1, 0);
            this.tableHeader.Name = "tableHeader";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.picTitle);
            this.panel1.Name = "panel1";
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Name = "lblTitle";
            // 
            // panelSubHeader
            // 
            resources.ApplyResources(this.panelSubHeader, "panelSubHeader");
            this.panelSubHeader.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelSubHeader.Controls.Add(this.lblInfo);
            this.panelSubHeader.Controls.Add(this.btnDisplay);
            this.panelSubHeader.Controls.Add(this.comboNotificationType);
            this.panelSubHeader.Name = "panelSubHeader";
            // 
            // lblInfo
            // 
            resources.ApplyResources(this.lblInfo, "lblInfo");
            this.lblInfo.Name = "lblInfo";
            // 
            // btnDisplay
            // 
            resources.ApplyResources(this.btnDisplay, "btnDisplay");
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.btnDisplay.ForeColor = System.Drawing.Color.White;
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // comboNotificationType
            // 
            resources.ApplyResources(this.comboNotificationType, "comboNotificationType");
            this.comboNotificationType.FormattingEnabled = true;
            this.comboNotificationType.Items.AddRange(new object[] {
            resources.GetString("comboNotificationType.Items"),
            resources.GetString("comboNotificationType.Items1"),
            resources.GetString("comboNotificationType.Items2")});
            this.comboNotificationType.Name = "comboNotificationType";
            // 
            // panelBottom
            // 
            resources.ApplyResources(this.panelBottom, "panelBottom");
            this.panelBottom.Controls.Add(this.tableLayoutPanel1);
            this.panelBottom.Name = "panelBottom";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.Controls.Add(this.lblFooterTitleCreate, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // lblFooterTitleCreate
            // 
            resources.ApplyResources(this.lblFooterTitleCreate, "lblFooterTitleCreate");
            this.lblFooterTitleCreate.Name = "lblFooterTitleCreate";
            // 
            // flowpanelMain
            // 
            resources.ApplyResources(this.flowpanelMain, "flowpanelMain");
            this.flowpanelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowpanelMain.Name = "flowpanelMain";
            // 
            // picTitle
            // 
            resources.ApplyResources(this.picTitle, "picTitle");
            this.picTitle.Name = "picTitle";
            this.picTitle.TabStop = false;
            // 
            // NotificationsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowpanelMain);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelSubHeader);
            this.Controls.Add(this.tableHeader);
            this.Name = "NotificationsForm";
            this.Activated += new System.EventHandler(this.NotificationsForm_Activated);
            this.Load += new System.EventHandler(this.NotificationsForm_Load);
            this.tableHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSubHeader.ResumeLayout(false);
            this.panelSubHeader.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Panel panelSubHeader;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.FlowLayoutPanel flowpanelMain;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.ComboBox comboNotificationType;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFooterTitleCreate;
    }
}