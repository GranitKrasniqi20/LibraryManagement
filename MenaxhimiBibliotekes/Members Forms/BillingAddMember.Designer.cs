namespace MenaxhimiBibliotekes.Members_Forms
{
    partial class BillingAddMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingAddMember));
            this.panelTopCreate = new System.Windows.Forms.Panel();
            this.lblTitleCreate = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.Label();
            this.lblPersonalNumber = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblSubscriptionPlan = new System.Windows.Forms.Label();
            this.lblRegistrationDate = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblCashier = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.Label();
            this.txtPersonalNumber = new System.Windows.Forms.Label();
            this.txtSubscriptionPlan = new System.Windows.Forms.Label();
            this.txtBillingDate = new System.Windows.Forms.Label();
            this.txtExpirationDate = new System.Windows.Forms.Label();
            this.txtCashier = new System.Windows.Forms.Label();
            this.panelBottomCreate = new System.Windows.Forms.Panel();
            this.lblFooterTitleCreate = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.Label();
            this.panelTopCreate.SuspendLayout();
            this.panelBottomCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopCreate
            // 
            this.panelTopCreate.BackColor = System.Drawing.SystemColors.Control;
            this.panelTopCreate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTopCreate.Controls.Add(this.lblTitleCreate);
            this.panelTopCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopCreate.Location = new System.Drawing.Point(0, 0);
            this.panelTopCreate.Margin = new System.Windows.Forms.Padding(2);
            this.panelTopCreate.Name = "panelTopCreate";
            this.panelTopCreate.Size = new System.Drawing.Size(718, 100);
            this.panelTopCreate.TabIndex = 13;
            // 
            // lblTitleCreate
            // 
            this.lblTitleCreate.AutoSize = true;
            this.lblTitleCreate.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCreate.Location = new System.Drawing.Point(25, 27);
            this.lblTitleCreate.Name = "lblTitleCreate";
            this.lblTitleCreate.Size = new System.Drawing.Size(314, 45);
            this.lblTitleCreate.TabIndex = 6;
            this.lblTitleCreate.Text = "Membership Billing";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(227, 207);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(105, 25);
            this.lblFullName.TabIndex = 14;
            this.lblFullName.Text = "Full Name:";
            // 
            // txtMemberID
            // 
            this.txtMemberID.AutoSize = true;
            this.txtMemberID.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberID.Location = new System.Drawing.Point(352, 172);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(36, 25);
            this.txtMemberID.TabIndex = 14;
            this.txtMemberID.Text = "---";
            // 
            // lblPersonalNumber
            // 
            this.lblPersonalNumber.AutoSize = true;
            this.lblPersonalNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalNumber.Location = new System.Drawing.Point(212, 244);
            this.lblPersonalNumber.Name = "lblPersonalNumber";
            this.lblPersonalNumber.Size = new System.Drawing.Size(120, 25);
            this.lblPersonalNumber.TabIndex = 14;
            this.lblPersonalNumber.Text = "Personal No:";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.Location = new System.Drawing.Point(217, 172);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(115, 25);
            this.lblMemberID.TabIndex = 14;
            this.lblMemberID.Text = "Member ID:";
            // 
            // lblSubscriptionPlan
            // 
            this.lblSubscriptionPlan.AutoSize = true;
            this.lblSubscriptionPlan.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubscriptionPlan.Location = new System.Drawing.Point(167, 283);
            this.lblSubscriptionPlan.Name = "lblSubscriptionPlan";
            this.lblSubscriptionPlan.Size = new System.Drawing.Size(165, 25);
            this.lblSubscriptionPlan.TabIndex = 14;
            this.lblSubscriptionPlan.Text = "Subscription Plan:";
            // 
            // lblRegistrationDate
            // 
            this.lblRegistrationDate.AutoSize = true;
            this.lblRegistrationDate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationDate.Location = new System.Drawing.Point(112, 322);
            this.lblRegistrationDate.Name = "lblRegistrationDate";
            this.lblRegistrationDate.Size = new System.Drawing.Size(220, 25);
            this.lblRegistrationDate.TabIndex = 14;
            this.lblRegistrationDate.Text = "Regisration/Billing Date:";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDate.Location = new System.Drawing.Point(182, 359);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(150, 25);
            this.lblExpirationDate.TabIndex = 14;
            this.lblExpirationDate.Text = "Expiration Date:";
            // 
            // lblCashier
            // 
            this.lblCashier.AutoSize = true;
            this.lblCashier.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashier.Location = new System.Drawing.Point(251, 430);
            this.lblCashier.Name = "lblCashier";
            this.lblCashier.Size = new System.Drawing.Size(81, 25);
            this.lblCashier.TabIndex = 14;
            this.lblCashier.Text = "Cashier:";
            // 
            // txtFullName
            // 
            this.txtFullName.AutoSize = true;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(352, 207);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(36, 25);
            this.txtFullName.TabIndex = 14;
            this.txtFullName.Text = "---";
            // 
            // txtPersonalNumber
            // 
            this.txtPersonalNumber.AutoSize = true;
            this.txtPersonalNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonalNumber.Location = new System.Drawing.Point(352, 244);
            this.txtPersonalNumber.Name = "txtPersonalNumber";
            this.txtPersonalNumber.Size = new System.Drawing.Size(36, 25);
            this.txtPersonalNumber.TabIndex = 14;
            this.txtPersonalNumber.Text = "---";
            // 
            // txtSubscriptionPlan
            // 
            this.txtSubscriptionPlan.AutoSize = true;
            this.txtSubscriptionPlan.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubscriptionPlan.Location = new System.Drawing.Point(352, 283);
            this.txtSubscriptionPlan.Name = "txtSubscriptionPlan";
            this.txtSubscriptionPlan.Size = new System.Drawing.Size(36, 25);
            this.txtSubscriptionPlan.TabIndex = 14;
            this.txtSubscriptionPlan.Text = "---";
            // 
            // txtBillingDate
            // 
            this.txtBillingDate.AutoSize = true;
            this.txtBillingDate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillingDate.Location = new System.Drawing.Point(352, 322);
            this.txtBillingDate.Name = "txtBillingDate";
            this.txtBillingDate.Size = new System.Drawing.Size(36, 25);
            this.txtBillingDate.TabIndex = 14;
            this.txtBillingDate.Text = "---";
            // 
            // txtExpirationDate
            // 
            this.txtExpirationDate.AutoSize = true;
            this.txtExpirationDate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpirationDate.Location = new System.Drawing.Point(352, 359);
            this.txtExpirationDate.Name = "txtExpirationDate";
            this.txtExpirationDate.Size = new System.Drawing.Size(36, 25);
            this.txtExpirationDate.TabIndex = 14;
            this.txtExpirationDate.Text = "---";
            // 
            // txtCashier
            // 
            this.txtCashier.AutoSize = true;
            this.txtCashier.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashier.Location = new System.Drawing.Point(352, 430);
            this.txtCashier.Name = "txtCashier";
            this.txtCashier.Size = new System.Drawing.Size(36, 25);
            this.txtCashier.TabIndex = 14;
            this.txtCashier.Text = "---";
            // 
            // panelBottomCreate
            // 
            this.panelBottomCreate.BackColor = System.Drawing.SystemColors.Control;
            this.panelBottomCreate.Controls.Add(this.lblFooterTitleCreate);
            this.panelBottomCreate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomCreate.Location = new System.Drawing.Point(0, 653);
            this.panelBottomCreate.Margin = new System.Windows.Forms.Padding(2);
            this.panelBottomCreate.Name = "panelBottomCreate";
            this.panelBottomCreate.Size = new System.Drawing.Size(718, 28);
            this.panelBottomCreate.TabIndex = 15;
            // 
            // lblFooterTitleCreate
            // 
            this.lblFooterTitleCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFooterTitleCreate.AutoSize = true;
            this.lblFooterTitleCreate.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooterTitleCreate.Location = new System.Drawing.Point(239, 5);
            this.lblFooterTitleCreate.Name = "lblFooterTitleCreate";
            this.lblFooterTitleCreate.Size = new System.Drawing.Size(251, 17);
            this.lblFooterTitleCreate.TabIndex = 10;
            this.lblFooterTitleCreate.Text = "All Rights, Stackbooks Management System";
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnPreview.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.Location = new System.Drawing.Point(117, 537);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(215, 66);
            this.btnPreview.TabIndex = 16;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(357, 537);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(215, 66);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printPreview
            // 
            this.printPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreview.Enabled = true;
            this.printPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreview.Icon")));
            this.printPreview.Name = "printPreview";
            this.printPreview.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(273, 397);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(59, 25);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.AutoSize = true;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(352, 397);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(36, 25);
            this.txtPrice.TabIndex = 14;
            this.txtPrice.Text = "---";
            // 
            // BillingAddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 681);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.panelBottomCreate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCashier);
            this.Controls.Add(this.txtExpirationDate);
            this.Controls.Add(this.txtBillingDate);
            this.Controls.Add(this.txtSubscriptionPlan);
            this.Controls.Add(this.txtPersonalNumber);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCashier);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.lblRegistrationDate);
            this.Controls.Add(this.lblSubscriptionPlan);
            this.Controls.Add(this.lblPersonalNumber);
            this.Controls.Add(this.lblMemberID);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.panelTopCreate);
            this.MaximumSize = new System.Drawing.Size(734, 720);
            this.MinimumSize = new System.Drawing.Size(734, 720);
            this.Name = "BillingAddMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Membership Billing (Stackbooks)";
            this.Load += new System.EventHandler(this.BillingAddMember_Load);
            this.panelTopCreate.ResumeLayout(false);
            this.panelTopCreate.PerformLayout();
            this.panelBottomCreate.ResumeLayout(false);
            this.panelBottomCreate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTopCreate;
        private System.Windows.Forms.Label lblTitleCreate;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label txtMemberID;
        private System.Windows.Forms.Label lblPersonalNumber;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblSubscriptionPlan;
        private System.Windows.Forms.Label lblRegistrationDate;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblCashier;
        private System.Windows.Forms.Label txtFullName;
        private System.Windows.Forms.Label txtPersonalNumber;
        private System.Windows.Forms.Label txtSubscriptionPlan;
        private System.Windows.Forms.Label txtBillingDate;
        private System.Windows.Forms.Label txtExpirationDate;
        private System.Windows.Forms.Label txtCashier;
        private System.Windows.Forms.Panel panelBottomCreate;
        private System.Windows.Forms.Label lblFooterTitleCreate;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreview;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label txtPrice;
    }
}