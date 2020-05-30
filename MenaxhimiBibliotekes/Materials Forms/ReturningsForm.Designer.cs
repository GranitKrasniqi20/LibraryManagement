namespace MenaxhimiBibliotekes.Materials_Forms
{
    partial class ReturningsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturningsForm));
            this.tableHeader = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRegisterReturn = new System.Windows.Forms.Button();
            this.btnCalculateMaterialDamage = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panelMainBody = new System.Windows.Forms.Panel();
            this.tableContents = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.txtMemberID = new System.Windows.Forms.Label();
            this.txtMemberFullName = new System.Windows.Forms.Label();
            this.txtMaterialName = new System.Windows.Forms.Label();
            this.txtMaterialType = new System.Windows.Forms.Label();
            this.txtLocated = new System.Windows.Forms.Label();
            this.lblLocated = new System.Windows.Forms.Label();
            this.lblMaterialType = new System.Windows.Forms.Label();
            this.lblMaterialName = new System.Windows.Forms.Label();
            this.lblMemberFullName = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblBorrowedDate = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblReturnedInTime = new System.Windows.Forms.Label();
            this.txtBorrowedDate = new System.Windows.Forms.Label();
            this.txtReturnDate = new System.Windows.Forms.Label();
            this.txtReturnedInTime = new System.Windows.Forms.Label();
            this.lblDelayFee = new System.Windows.Forms.Label();
            this.txtDelayFee = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBorrowedID = new System.Windows.Forms.Label();
            this.txtBorrowedID = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.tableHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panelMainBody.SuspendLayout();
            this.tableContents.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableHeader
            // 
            this.tableHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
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
            this.tableHeader.Size = new System.Drawing.Size(602, 88);
            this.tableHeader.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.picTitle);
            this.panel1.Location = new System.Drawing.Point(74, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 82);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(148, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "RETURNS";
            // 
            // picTitle
            // 
            this.picTitle.Image = ((System.Drawing.Image)(resources.GetObject("picTitle.Image")));
            this.picTitle.Location = new System.Drawing.Point(96, 17);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(58, 50);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTitle.TabIndex = 0;
            this.picTitle.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 88);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(602, 16);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.btnRegisterReturn, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnCalculateMaterialDamage, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 536);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(602, 82);
            this.tableLayoutPanel4.TabIndex = 26;
            // 
            // btnRegisterReturn
            // 
            this.btnRegisterReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.btnRegisterReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegisterReturn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterReturn.ForeColor = System.Drawing.Color.White;
            this.btnRegisterReturn.Location = new System.Drawing.Point(23, 3);
            this.btnRegisterReturn.Name = "btnRegisterReturn";
            this.btnRegisterReturn.Size = new System.Drawing.Size(263, 76);
            this.btnRegisterReturn.TabIndex = 1;
            this.btnRegisterReturn.Text = "Register Return";
            this.btnRegisterReturn.UseVisualStyleBackColor = false;
            this.btnRegisterReturn.Click += new System.EventHandler(this.BtnRegisterReturn_Click);
            // 
            // btnCalculateMaterialDamage
            // 
            this.btnCalculateMaterialDamage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.btnCalculateMaterialDamage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCalculateMaterialDamage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateMaterialDamage.ForeColor = System.Drawing.Color.White;
            this.btnCalculateMaterialDamage.Location = new System.Drawing.Point(312, 3);
            this.btnCalculateMaterialDamage.Name = "btnCalculateMaterialDamage";
            this.btnCalculateMaterialDamage.Size = new System.Drawing.Size(263, 76);
            this.btnCalculateMaterialDamage.TabIndex = 2;
            this.btnCalculateMaterialDamage.Text = "Calculate Material Damage";
            this.btnCalculateMaterialDamage.UseVisualStyleBackColor = false;
            this.btnCalculateMaterialDamage.Click += new System.EventHandler(this.BtnCalculateMaterialDamage_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.lblFooter, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 618);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(602, 33);
            this.tableLayoutPanel3.TabIndex = 25;
            // 
            // lblFooter
            // 
            this.lblFooter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.Location = new System.Drawing.Point(175, 8);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(251, 17);
            this.lblFooter.TabIndex = 11;
            this.lblFooter.Text = "All Rights, Stackbooks Management System";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.lblInfo, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 104);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(602, 50);
            this.tableLayoutPanel5.TabIndex = 27;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(23, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(334, 37);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Return Specific Material!";
            // 
            // panelMainBody
            // 
            this.panelMainBody.AutoScroll = true;
            this.panelMainBody.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMainBody.Controls.Add(this.tableContents);
            this.panelMainBody.Controls.Add(this.tableLayoutPanel9);
            this.panelMainBody.Controls.Add(this.tableLayoutPanel8);
            this.panelMainBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainBody.Location = new System.Drawing.Point(0, 154);
            this.panelMainBody.Name = "panelMainBody";
            this.panelMainBody.Size = new System.Drawing.Size(602, 382);
            this.panelMainBody.TabIndex = 28;
            // 
            // tableContents
            // 
            this.tableContents.ColumnCount = 5;
            this.tableContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableContents.Controls.Add(this.tableLayoutPanel18, 0, 8);
            this.tableContents.Controls.Add(this.txtMemberID, 3, 0);
            this.tableContents.Controls.Add(this.txtMemberFullName, 3, 1);
            this.tableContents.Controls.Add(this.txtMaterialName, 3, 2);
            this.tableContents.Controls.Add(this.txtMaterialType, 3, 3);
            this.tableContents.Controls.Add(this.txtLocated, 3, 4);
            this.tableContents.Controls.Add(this.lblLocated, 1, 4);
            this.tableContents.Controls.Add(this.lblMaterialType, 1, 3);
            this.tableContents.Controls.Add(this.lblMaterialName, 1, 2);
            this.tableContents.Controls.Add(this.lblMemberFullName, 1, 1);
            this.tableContents.Controls.Add(this.lblMemberID, 1, 0);
            this.tableContents.Controls.Add(this.lblBorrowedDate, 1, 5);
            this.tableContents.Controls.Add(this.lblReturnDate, 1, 6);
            this.tableContents.Controls.Add(this.lblReturnedInTime, 1, 7);
            this.tableContents.Controls.Add(this.txtBorrowedDate, 3, 5);
            this.tableContents.Controls.Add(this.txtReturnDate, 3, 6);
            this.tableContents.Controls.Add(this.txtReturnedInTime, 3, 7);
            this.tableContents.Controls.Add(this.lblDelayFee, 1, 8);
            this.tableContents.Controls.Add(this.txtDelayFee, 3, 8);
            this.tableContents.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableContents.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableContents.Location = new System.Drawing.Point(0, 201);
            this.tableContents.Name = "tableContents";
            this.tableContents.RowCount = 9;
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableContents.Size = new System.Drawing.Size(581, 407);
            this.tableContents.TabIndex = 22;
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.ColumnCount = 1;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel18.Location = new System.Drawing.Point(3, 363);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 1;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(14, 16);
            this.tableLayoutPanel18.TabIndex = 21;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMemberID.AutoSize = true;
            this.txtMemberID.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberID.Location = new System.Drawing.Point(297, 10);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(36, 25);
            this.txtMemberID.TabIndex = 1;
            this.txtMemberID.Text = "---";
            // 
            // txtMemberFullName
            // 
            this.txtMemberFullName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMemberFullName.AutoSize = true;
            this.txtMemberFullName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberFullName.Location = new System.Drawing.Point(297, 55);
            this.txtMemberFullName.Name = "txtMemberFullName";
            this.txtMemberFullName.Size = new System.Drawing.Size(36, 25);
            this.txtMemberFullName.TabIndex = 1;
            this.txtMemberFullName.Text = "---";
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMaterialName.AutoSize = true;
            this.txtMaterialName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterialName.Location = new System.Drawing.Point(297, 100);
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.Size = new System.Drawing.Size(36, 25);
            this.txtMaterialName.TabIndex = 1;
            this.txtMaterialName.Text = "---";
            // 
            // txtMaterialType
            // 
            this.txtMaterialType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMaterialType.AutoSize = true;
            this.txtMaterialType.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterialType.Location = new System.Drawing.Point(297, 145);
            this.txtMaterialType.Name = "txtMaterialType";
            this.txtMaterialType.Size = new System.Drawing.Size(36, 25);
            this.txtMaterialType.TabIndex = 1;
            this.txtMaterialType.Text = "---";
            // 
            // txtLocated
            // 
            this.txtLocated.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLocated.AutoSize = true;
            this.txtLocated.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocated.Location = new System.Drawing.Point(297, 190);
            this.txtLocated.Name = "txtLocated";
            this.txtLocated.Size = new System.Drawing.Size(36, 25);
            this.txtLocated.TabIndex = 1;
            this.txtLocated.Text = "---";
            // 
            // lblLocated
            // 
            this.lblLocated.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLocated.AutoSize = true;
            this.lblLocated.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocated.Location = new System.Drawing.Point(195, 190);
            this.lblLocated.Name = "lblLocated";
            this.lblLocated.Size = new System.Drawing.Size(84, 25);
            this.lblLocated.TabIndex = 1;
            this.lblLocated.Text = "Located:";
            // 
            // lblMaterialType
            // 
            this.lblMaterialType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMaterialType.AutoSize = true;
            this.lblMaterialType.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialType.Location = new System.Drawing.Point(145, 145);
            this.lblMaterialType.Name = "lblMaterialType";
            this.lblMaterialType.Size = new System.Drawing.Size(134, 25);
            this.lblMaterialType.TabIndex = 1;
            this.lblMaterialType.Text = "Material Type:";
            // 
            // lblMaterialName
            // 
            this.lblMaterialName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMaterialName.AutoSize = true;
            this.lblMaterialName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialName.Location = new System.Drawing.Point(133, 100);
            this.lblMaterialName.Name = "lblMaterialName";
            this.lblMaterialName.Size = new System.Drawing.Size(146, 25);
            this.lblMaterialName.TabIndex = 1;
            this.lblMaterialName.Text = "Material Name:";
            // 
            // lblMemberFullName
            // 
            this.lblMemberFullName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMemberFullName.AutoSize = true;
            this.lblMemberFullName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberFullName.Location = new System.Drawing.Point(132, 55);
            this.lblMemberFullName.Name = "lblMemberFullName";
            this.lblMemberFullName.Size = new System.Drawing.Size(147, 25);
            this.lblMemberFullName.TabIndex = 1;
            this.lblMemberFullName.Text = "Member Name:";
            // 
            // lblMemberID
            // 
            this.lblMemberID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.Location = new System.Drawing.Point(164, 10);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(115, 25);
            this.lblMemberID.TabIndex = 1;
            this.lblMemberID.Text = "Member ID:";
            // 
            // lblBorrowedDate
            // 
            this.lblBorrowedDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBorrowedDate.AutoSize = true;
            this.lblBorrowedDate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowedDate.Location = new System.Drawing.Point(134, 235);
            this.lblBorrowedDate.Name = "lblBorrowedDate";
            this.lblBorrowedDate.Size = new System.Drawing.Size(145, 25);
            this.lblBorrowedDate.TabIndex = 1;
            this.lblBorrowedDate.Text = "Borrowed Date:";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.Location = new System.Drawing.Point(159, 280);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(120, 25);
            this.lblReturnDate.TabIndex = 1;
            this.lblReturnDate.Text = "Return Date:";
            // 
            // lblReturnedInTime
            // 
            this.lblReturnedInTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblReturnedInTime.AutoSize = true;
            this.lblReturnedInTime.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnedInTime.Location = new System.Drawing.Point(116, 325);
            this.lblReturnedInTime.Name = "lblReturnedInTime";
            this.lblReturnedInTime.Size = new System.Drawing.Size(163, 25);
            this.lblReturnedInTime.TabIndex = 1;
            this.lblReturnedInTime.Text = "Returned in time?";
            // 
            // txtBorrowedDate
            // 
            this.txtBorrowedDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBorrowedDate.AutoSize = true;
            this.txtBorrowedDate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrowedDate.Location = new System.Drawing.Point(297, 235);
            this.txtBorrowedDate.Name = "txtBorrowedDate";
            this.txtBorrowedDate.Size = new System.Drawing.Size(36, 25);
            this.txtBorrowedDate.TabIndex = 1;
            this.txtBorrowedDate.Text = "---";
            // 
            // txtReturnDate
            // 
            this.txtReturnDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtReturnDate.AutoSize = true;
            this.txtReturnDate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnDate.Location = new System.Drawing.Point(297, 280);
            this.txtReturnDate.Name = "txtReturnDate";
            this.txtReturnDate.Size = new System.Drawing.Size(36, 25);
            this.txtReturnDate.TabIndex = 1;
            this.txtReturnDate.Text = "---";
            // 
            // txtReturnedInTime
            // 
            this.txtReturnedInTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtReturnedInTime.AutoSize = true;
            this.txtReturnedInTime.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnedInTime.Location = new System.Drawing.Point(297, 325);
            this.txtReturnedInTime.Name = "txtReturnedInTime";
            this.txtReturnedInTime.Size = new System.Drawing.Size(36, 25);
            this.txtReturnedInTime.TabIndex = 1;
            this.txtReturnedInTime.Text = "---";
            // 
            // lblDelayFee
            // 
            this.lblDelayFee.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDelayFee.AutoSize = true;
            this.lblDelayFee.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelayFee.Location = new System.Drawing.Point(178, 371);
            this.lblDelayFee.Name = "lblDelayFee";
            this.lblDelayFee.Size = new System.Drawing.Size(101, 25);
            this.lblDelayFee.TabIndex = 1;
            this.lblDelayFee.Text = "Delay Fee:";
            // 
            // txtDelayFee
            // 
            this.txtDelayFee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDelayFee.AutoSize = true;
            this.txtDelayFee.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelayFee.Location = new System.Drawing.Point(297, 371);
            this.txtDelayFee.Name = "txtDelayFee";
            this.txtDelayFee.Size = new System.Drawing.Size(36, 25);
            this.txtDelayFee.TabIndex = 1;
            this.txtDelayFee.Text = "---";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 185);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(581, 16);
            this.tableLayoutPanel9.TabIndex = 21;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Controls.Add(this.lblBorrowedID, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.txtBorrowedID, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.btnFind, 1, 2);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85715F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(581, 185);
            this.tableLayoutPanel8.TabIndex = 20;
            // 
            // lblBorrowedID
            // 
            this.lblBorrowedID.AutoSize = true;
            this.lblBorrowedID.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowedID.Location = new System.Drawing.Point(23, 0);
            this.lblBorrowedID.Name = "lblBorrowedID";
            this.lblBorrowedID.Size = new System.Drawing.Size(124, 25);
            this.lblBorrowedID.TabIndex = 1;
            this.lblBorrowedID.Text = "Borrowed ID:";
            // 
            // txtBorrowedID
            // 
            this.txtBorrowedID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBorrowedID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrowedID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBorrowedID.Location = new System.Drawing.Point(23, 55);
            this.txtBorrowedID.Name = "txtBorrowedID";
            this.txtBorrowedID.Size = new System.Drawing.Size(535, 33);
            this.txtBorrowedID.TabIndex = 2;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.btnFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(23, 107);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(535, 75);
            this.btnFind.TabIndex = 10;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // ReturningsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 651);
            this.Controls.Add(this.panelMainBody);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableHeader);
            this.MaximumSize = new System.Drawing.Size(618, 707);
            this.MinimumSize = new System.Drawing.Size(618, 632);
            this.Name = "ReturningsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Returns (Stackbooks)";
            this.tableHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.panelMainBody.ResumeLayout(false);
            this.tableContents.ResumeLayout(false);
            this.tableContents.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnRegisterReturn;
        private System.Windows.Forms.Button btnCalculateMaterialDamage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel panelMainBody;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label lblBorrowedID;
        private System.Windows.Forms.TextBox txtBorrowedID;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TableLayoutPanel tableContents;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
        private System.Windows.Forms.Label txtMemberID;
        private System.Windows.Forms.Label txtMemberFullName;
        private System.Windows.Forms.Label txtMaterialName;
        private System.Windows.Forms.Label txtMaterialType;
        private System.Windows.Forms.Label txtLocated;
        private System.Windows.Forms.Label lblLocated;
        private System.Windows.Forms.Label lblMaterialType;
        private System.Windows.Forms.Label lblMaterialName;
        private System.Windows.Forms.Label lblMemberFullName;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblBorrowedDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblReturnedInTime;
        private System.Windows.Forms.Label txtBorrowedDate;
        private System.Windows.Forms.Label txtReturnDate;
        private System.Windows.Forms.Label txtReturnedInTime;
        private System.Windows.Forms.Label lblDelayFee;
        private System.Windows.Forms.Label txtDelayFee;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
    }
}