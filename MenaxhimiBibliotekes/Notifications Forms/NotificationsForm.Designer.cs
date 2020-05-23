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
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.panelSubHeader = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboNotificationType = new System.Windows.Forms.ComboBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.flowpanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.ucNotificationMessages1 = new MenaxhimiBibliotekes.Notifications_Forms.ucNotificationMessages();
            this.lblTitleCreate = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFooterTitleCreate = new System.Windows.Forms.Label();
            this.tableHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.panelSubHeader.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.flowpanelMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableHeader
            // 
            this.tableHeader.BackColor = System.Drawing.Color.Teal;
            this.tableHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableHeader.ColumnCount = 3;
            this.tableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableHeader.Controls.Add(this.panel1, 1, 0);
            this.tableHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableHeader.Location = new System.Drawing.Point(0, 0);
            this.tableHeader.Name = "tableHeader";
            this.tableHeader.RowCount = 1;
            this.tableHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableHeader.Size = new System.Drawing.Size(740, 88);
            this.tableHeader.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.picTitle);
            this.panel1.Location = new System.Drawing.Point(143, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 82);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(99, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(301, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "NOTIFICATIONS";
            // 
            // picTitle
            // 
            this.picTitle.Image = ((System.Drawing.Image)(resources.GetObject("picTitle.Image")));
            this.picTitle.Location = new System.Drawing.Point(47, 17);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(58, 50);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTitle.TabIndex = 0;
            this.picTitle.TabStop = false;
            // 
            // panelSubHeader
            // 
            this.panelSubHeader.Controls.Add(this.lblTitleCreate);
            this.panelSubHeader.Controls.Add(this.button1);
            this.panelSubHeader.Controls.Add(this.comboNotificationType);
            this.panelSubHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubHeader.Location = new System.Drawing.Point(0, 88);
            this.panelSubHeader.Name = "panelSubHeader";
            this.panelSubHeader.Size = new System.Drawing.Size(740, 132);
            this.panelSubHeader.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(368, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Display";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboNotificationType
            // 
            this.comboNotificationType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboNotificationType.FormattingEnabled = true;
            this.comboNotificationType.Items.AddRange(new object[] {
            "All Notifications",
            "Subscribers Notification",
            "Borrowings Notification"});
            this.comboNotificationType.Location = new System.Drawing.Point(72, 79);
            this.comboNotificationType.Name = "comboNotificationType";
            this.comboNotificationType.Size = new System.Drawing.Size(250, 33);
            this.comboNotificationType.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.tableLayoutPanel1);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 589);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(740, 28);
            this.panelBottom.TabIndex = 3;
            // 
            // flowpanelMain
            // 
            this.flowpanelMain.AutoScroll = true;
            this.flowpanelMain.Controls.Add(this.ucNotificationMessages1);
            this.flowpanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowpanelMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowpanelMain.Location = new System.Drawing.Point(0, 220);
            this.flowpanelMain.Name = "flowpanelMain";
            this.flowpanelMain.Size = new System.Drawing.Size(740, 369);
            this.flowpanelMain.TabIndex = 4;
            // 
            // ucNotificationMessages1
            // 
            this.ucNotificationMessages1.Category = "Subscribers Notification";
            this.ucNotificationMessages1.Date = "01/01/2020";
            this.ucNotificationMessages1.Icon = ((System.Drawing.Image)(resources.GetObject("ucNotificationMessages1.Icon")));
            this.ucNotificationMessages1.Location = new System.Drawing.Point(3, 3);
            this.ucNotificationMessages1.Message = "Beis Presheva is registered in the system from 01/01/2020 till 01/01/2021!";
            this.ucNotificationMessages1.Name = "ucNotificationMessages1";
            this.ucNotificationMessages1.Size = new System.Drawing.Size(877, 87);
            this.ucNotificationMessages1.TabIndex = 0;
            // 
            // lblTitleCreate
            // 
            this.lblTitleCreate.AutoSize = true;
            this.lblTitleCreate.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCreate.Location = new System.Drawing.Point(64, 15);
            this.lblTitleCreate.Name = "lblTitleCreate";
            this.lblTitleCreate.Size = new System.Drawing.Size(537, 37);
            this.lblTitleCreate.TabIndex = 7;
            this.lblTitleCreate.Text = "Select Notifications you want to display!";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblFooterTitleCreate, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(740, 28);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblFooterTitleCreate
            // 
            this.lblFooterTitleCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFooterTitleCreate.AutoSize = true;
            this.lblFooterTitleCreate.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooterTitleCreate.Location = new System.Drawing.Point(244, 5);
            this.lblFooterTitleCreate.Name = "lblFooterTitleCreate";
            this.lblFooterTitleCreate.Size = new System.Drawing.Size(251, 17);
            this.lblFooterTitleCreate.TabIndex = 11;
            this.lblFooterTitleCreate.Text = "All Rights, Stackbooks Management System";
            // 
            // NotificationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 617);
            this.Controls.Add(this.flowpanelMain);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelSubHeader);
            this.Controls.Add(this.tableHeader);
            this.MinimumSize = new System.Drawing.Size(756, 656);
            this.Name = "NotificationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotificationsForm";
            this.Load += new System.EventHandler(this.NotificationsForm_Load);
            this.tableHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.panelSubHeader.ResumeLayout(false);
            this.panelSubHeader.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.flowpanelMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboNotificationType;
        private ucNotificationMessages ucNotificationMessages1;
        private System.Windows.Forms.Label lblTitleCreate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFooterTitleCreate;
    }
}