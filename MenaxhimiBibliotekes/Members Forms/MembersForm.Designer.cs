namespace MenaxhimiBibliotekes.Members_Forms
{
    partial class MembersForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MembersForm));
            this.panelFullBody = new System.Windows.Forms.Panel();
            this.tabControlMembersForm = new System.Windows.Forms.TabControl();
            this.tabMainPage = new System.Windows.Forms.TabPage();
            this.tableDataGridView = new System.Windows.Forms.TableLayoutPanel();
            this.gridMembers = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonalNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInsDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpirationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableBottomSpace = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFooterTitleCreate = new System.Windows.Forms.Label();
            this.tableSearch = new System.Windows.Forms.TableLayoutPanel();
            this.comboSortMember = new System.Windows.Forms.ComboBox();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.txtSearchMember = new System.Windows.Forms.TextBox();
            this.tableButtons = new System.Windows.Forms.TableLayoutPanel();
            this.tableSpace2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.tableSpace1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabExpiredMembers = new System.Windows.Forms.TabPage();
            this.tableDataGridViewExpired = new System.Windows.Forms.TableLayoutPanel();
            this.dgvExpiredMembers = new System.Windows.Forms.DataGridView();
            this.columnIDExpired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFirstNameExpired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLastNameExpired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAddressExpired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBirthdateExpired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGenderExpired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPersonalNoExpired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEmailExpired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPhoneNumberExpired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSubscriptionPlanExpired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFromExpired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTillExpired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableFooterExpired = new System.Windows.Forms.TableLayoutPanel();
            this.lblFooterExpired = new System.Windows.Forms.Label();
            this.tableSpaceExpiredInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitleCreate = new System.Windows.Forms.Label();
            this.tableSpace3 = new System.Windows.Forms.TableLayoutPanel();
            this.tabBills = new System.Windows.Forms.TabPage();
            this.tableDataGridViewBills = new System.Windows.Forms.TableLayoutPanel();
            this.dgvBills = new System.Windows.Forms.DataGridView();
            this.columnIDBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMemberIDBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFirstNameBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLastNameBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPersonalNoBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEmailBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPhoneNumberBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSubscriptionPlanBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPriceBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFromBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTillBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBottom3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFooter3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearchBills = new System.Windows.Forms.TextBox();
            this.comboSortBills = new System.Windows.Forms.ComboBox();
            this.btnSearchBills = new System.Windows.Forms.Button();
            this.tableSpaceInfoBills = new System.Windows.Forms.TableLayoutPanel();
            this.lblInfoBills = new System.Windows.Forms.Label();
            this.tableSpace4 = new System.Windows.Forms.TableLayoutPanel();
            this.subscribersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementDataSet1 = new MenaxhimiBibliotekes.LibraryManagementDataSet1();
            this.subscribersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementDataSet = new MenaxhimiBibliotekes.LibraryManagementDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.tableHeader = new System.Windows.Forms.TableLayoutPanel();
            this.subscribersTableAdapter = new MenaxhimiBibliotekes.LibraryManagementDataSetTableAdapters.SubscribersTableAdapter();
            this.subscribersTableAdapter1 = new MenaxhimiBibliotekes.LibraryManagementDataSet1TableAdapters.SubscribersTableAdapter();
            this.panelFullBody.SuspendLayout();
            this.tabControlMembersForm.SuspendLayout();
            this.tabMainPage.SuspendLayout();
            this.tableDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.tableBottomSpace.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableSearch.SuspendLayout();
            this.tableSpace2.SuspendLayout();
            this.tabExpiredMembers.SuspendLayout();
            this.tableDataGridViewExpired.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpiredMembers)).BeginInit();
            this.tableFooterExpired.SuspendLayout();
            this.tableSpaceExpiredInfo.SuspendLayout();
            this.tabBills.SuspendLayout();
            this.tableDataGridViewBills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            this.tableBottom3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableSpaceInfoBills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subscribersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscribersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.tableHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFullBody
            // 
            this.panelFullBody.Controls.Add(this.tabControlMembersForm);
            this.panelFullBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFullBody.Location = new System.Drawing.Point(0, 88);
            this.panelFullBody.Name = "panelFullBody";
            this.panelFullBody.Size = new System.Drawing.Size(740, 529);
            this.panelFullBody.TabIndex = 2;
            // 
            // tabControlMembersForm
            // 
            this.tabControlMembersForm.Controls.Add(this.tabMainPage);
            this.tabControlMembersForm.Controls.Add(this.tabExpiredMembers);
            this.tabControlMembersForm.Controls.Add(this.tabBills);
            this.tabControlMembersForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMembersForm.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMembersForm.Location = new System.Drawing.Point(0, 0);
            this.tabControlMembersForm.Name = "tabControlMembersForm";
            this.tabControlMembersForm.Padding = new System.Drawing.Point(12, 8);
            this.tabControlMembersForm.SelectedIndex = 0;
            this.tabControlMembersForm.Size = new System.Drawing.Size(740, 529);
            this.tabControlMembersForm.TabIndex = 0;
            // 
            // tabMainPage
            // 
            this.tabMainPage.Controls.Add(this.tableDataGridView);
            this.tabMainPage.Controls.Add(this.tableBottomSpace);
            this.tabMainPage.Controls.Add(this.tableSearch);
            this.tabMainPage.Controls.Add(this.tableButtons);
            this.tabMainPage.Controls.Add(this.tableSpace2);
            this.tabMainPage.Controls.Add(this.tableSpace1);
            this.tabMainPage.Location = new System.Drawing.Point(4, 32);
            this.tabMainPage.Name = "tabMainPage";
            this.tabMainPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainPage.Size = new System.Drawing.Size(732, 493);
            this.tabMainPage.TabIndex = 0;
            this.tabMainPage.Text = "Main Page";
            this.tabMainPage.UseVisualStyleBackColor = true;
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.ColumnCount = 3;
            this.tableDataGridView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDataGridView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDataGridView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDataGridView.Controls.Add(this.gridMembers, 1, 0);
            this.tableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDataGridView.Location = new System.Drawing.Point(3, 150);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.RowCount = 1;
            this.tableDataGridView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDataGridView.Size = new System.Drawing.Size(726, 318);
            this.tableDataGridView.TabIndex = 0;
            // 
            // gridMembers
            // 
            this.gridMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMembers.Location = new System.Drawing.Point(23, 3);
            this.gridMembers.MainView = this.gridView;
            this.gridMembers.Name = "gridMembers";
            this.gridMembers.Size = new System.Drawing.Size(680, 312);
            this.gridMembers.TabIndex = 0;
            this.gridMembers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colLastName,
            this.colAddress,
            this.colBirthday,
            this.colPersonalNo,
            this.colPhoneNo,
            this.colEmail,
            this.colGender,
            this.colInsDate,
            this.colExpirationDate});
            this.gridView.GridControl = this.gridMembers;
            this.gridView.Name = "gridView";
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "SubscriberId";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.Caption = "First Name";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Last Name";
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Full Address";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 3;
            // 
            // colBirthday
            // 
            this.colBirthday.Caption = "Birthdate";
            this.colBirthday.FieldName = "Birthday";
            this.colBirthday.Name = "colBirthday";
            this.colBirthday.Visible = true;
            this.colBirthday.VisibleIndex = 4;
            // 
            // colPersonalNo
            // 
            this.colPersonalNo.Caption = "Personal Number";
            this.colPersonalNo.FieldName = "PersonalNo";
            this.colPersonalNo.Name = "colPersonalNo";
            this.colPersonalNo.Visible = true;
            this.colPersonalNo.VisibleIndex = 5;
            // 
            // colPhoneNo
            // 
            this.colPhoneNo.Caption = "Phone Number";
            this.colPhoneNo.FieldName = "PhoneNo";
            this.colPhoneNo.Name = "colPhoneNo";
            this.colPhoneNo.Visible = true;
            this.colPhoneNo.VisibleIndex = 6;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "E-Mail";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 7;
            // 
            // colGender
            // 
            this.colGender.Caption = "Gender";
            this.colGender.FieldName = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.Visible = true;
            this.colGender.VisibleIndex = 8;
            // 
            // colInsDate
            // 
            this.colInsDate.Caption = "Registration Date";
            this.colInsDate.FieldName = "InsDate";
            this.colInsDate.Name = "colInsDate";
            this.colInsDate.Visible = true;
            this.colInsDate.VisibleIndex = 9;
            // 
            // colExpirationDate
            // 
            this.colExpirationDate.Caption = "Expiration Date";
            this.colExpirationDate.FieldName = "ExpirationDate";
            this.colExpirationDate.Name = "colExpirationDate";
            this.colExpirationDate.Visible = true;
            this.colExpirationDate.VisibleIndex = 10;
            // 
            // tableBottomSpace
            // 
            this.tableBottomSpace.ColumnCount = 1;
            this.tableBottomSpace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBottomSpace.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableBottomSpace.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableBottomSpace.Location = new System.Drawing.Point(3, 468);
            this.tableBottomSpace.Name = "tableBottomSpace";
            this.tableBottomSpace.RowCount = 1;
            this.tableBottomSpace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBottomSpace.Size = new System.Drawing.Size(726, 22);
            this.tableBottomSpace.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblFooterTitleCreate, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(720, 16);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblFooterTitleCreate
            // 
            this.lblFooterTitleCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFooterTitleCreate.AutoSize = true;
            this.lblFooterTitleCreate.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooterTitleCreate.Location = new System.Drawing.Point(234, 0);
            this.lblFooterTitleCreate.Name = "lblFooterTitleCreate";
            this.lblFooterTitleCreate.Size = new System.Drawing.Size(251, 16);
            this.lblFooterTitleCreate.TabIndex = 11;
            this.lblFooterTitleCreate.Text = "All Rights, Stackbooks Management System";
            // 
            // tableSearch
            // 
            this.tableSearch.ColumnCount = 7;
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableSearch.Controls.Add(this.comboSortMember, 1, 0);
            this.tableSearch.Controls.Add(this.btnSearchMember, 5, 0);
            this.tableSearch.Controls.Add(this.txtSearchMember, 3, 0);
            this.tableSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableSearch.Location = new System.Drawing.Point(3, 97);
            this.tableSearch.Name = "tableSearch";
            this.tableSearch.RowCount = 1;
            this.tableSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSearch.Size = new System.Drawing.Size(726, 53);
            this.tableSearch.TabIndex = 0;
            // 
            // comboSortMember
            // 
            this.comboSortMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboSortMember.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSortMember.FormattingEnabled = true;
            this.comboSortMember.Items.AddRange(new object[] {
            "Ascending Order",
            "Descending Order"});
            this.comboSortMember.Location = new System.Drawing.Point(23, 3);
            this.comboSortMember.Name = "comboSortMember";
            this.comboSortMember.Size = new System.Drawing.Size(213, 40);
            this.comboSortMember.TabIndex = 5;
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.btnSearchMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchMember.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMember.ForeColor = System.Drawing.Color.White;
            this.btnSearchMember.Location = new System.Drawing.Point(493, 3);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(209, 40);
            this.btnSearchMember.TabIndex = 6;
            this.btnSearchMember.Text = "Search";
            this.btnSearchMember.UseVisualStyleBackColor = false;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // txtSearchMember
            // 
            this.txtSearchMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchMember.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMember.Location = new System.Drawing.Point(262, 3);
            this.txtSearchMember.Name = "txtSearchMember";
            this.txtSearchMember.Size = new System.Drawing.Size(213, 39);
            this.txtSearchMember.TabIndex = 4;
            // 
            // tableButtons
            // 
            this.tableButtons.ColumnCount = 1;
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableButtons.Location = new System.Drawing.Point(3, 81);
            this.tableButtons.Name = "tableButtons";
            this.tableButtons.RowCount = 1;
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableButtons.Size = new System.Drawing.Size(726, 16);
            this.tableButtons.TabIndex = 0;
            // 
            // tableSpace2
            // 
            this.tableSpace2.ColumnCount = 7;
            this.tableSpace2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSpace2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableSpace2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSpace2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableSpace2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSpace2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableSpace2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableSpace2.Controls.Add(this.btnAddMember, 1, 0);
            this.tableSpace2.Controls.Add(this.btnUpdateMember, 3, 0);
            this.tableSpace2.Controls.Add(this.btnDeleteMember, 5, 0);
            this.tableSpace2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableSpace2.Location = new System.Drawing.Point(3, 19);
            this.tableSpace2.Name = "tableSpace2";
            this.tableSpace2.RowCount = 1;
            this.tableSpace2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSpace2.Size = new System.Drawing.Size(726, 62);
            this.tableSpace2.TabIndex = 0;
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.btnAddMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddMember.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.ForeColor = System.Drawing.Color.White;
            this.btnAddMember.Location = new System.Drawing.Point(23, 3);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(209, 56);
            this.btnAddMember.TabIndex = 1;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btnUpdateMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateMember.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMember.ForeColor = System.Drawing.Color.White;
            this.btnUpdateMember.Location = new System.Drawing.Point(258, 3);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(209, 56);
            this.btnUpdateMember.TabIndex = 2;
            this.btnUpdateMember.Text = "Update Member";
            this.btnUpdateMember.UseVisualStyleBackColor = false;
            this.btnUpdateMember.Click += new System.EventHandler(this.btnUpdateMember_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(68)))), ((int)(((byte)(55)))));
            this.btnDeleteMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteMember.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMember.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMember.Location = new System.Drawing.Point(493, 3);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(209, 56);
            this.btnDeleteMember.TabIndex = 3;
            this.btnDeleteMember.Text = "Delete Member";
            this.btnDeleteMember.UseVisualStyleBackColor = false;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // tableSpace1
            // 
            this.tableSpace1.ColumnCount = 1;
            this.tableSpace1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSpace1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableSpace1.Location = new System.Drawing.Point(3, 3);
            this.tableSpace1.Name = "tableSpace1";
            this.tableSpace1.RowCount = 1;
            this.tableSpace1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSpace1.Size = new System.Drawing.Size(726, 16);
            this.tableSpace1.TabIndex = 0;
            // 
            // tabExpiredMembers
            // 
            this.tabExpiredMembers.Controls.Add(this.tableDataGridViewExpired);
            this.tabExpiredMembers.Controls.Add(this.tableFooterExpired);
            this.tabExpiredMembers.Controls.Add(this.tableSpaceExpiredInfo);
            this.tabExpiredMembers.Controls.Add(this.tableSpace3);
            this.tabExpiredMembers.Location = new System.Drawing.Point(4, 32);
            this.tabExpiredMembers.Name = "tabExpiredMembers";
            this.tabExpiredMembers.Padding = new System.Windows.Forms.Padding(3);
            this.tabExpiredMembers.Size = new System.Drawing.Size(732, 493);
            this.tabExpiredMembers.TabIndex = 1;
            this.tabExpiredMembers.Text = "Expired Members";
            this.tabExpiredMembers.UseVisualStyleBackColor = true;
            // 
            // tableDataGridViewExpired
            // 
            this.tableDataGridViewExpired.ColumnCount = 3;
            this.tableDataGridViewExpired.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDataGridViewExpired.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDataGridViewExpired.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDataGridViewExpired.Controls.Add(this.dgvExpiredMembers, 1, 0);
            this.tableDataGridViewExpired.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDataGridViewExpired.Location = new System.Drawing.Point(3, 81);
            this.tableDataGridViewExpired.Name = "tableDataGridViewExpired";
            this.tableDataGridViewExpired.RowCount = 1;
            this.tableDataGridViewExpired.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDataGridViewExpired.Size = new System.Drawing.Size(726, 393);
            this.tableDataGridViewExpired.TabIndex = 4;
            // 
            // dgvExpiredMembers
            // 
            this.dgvExpiredMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpiredMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpiredMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIDExpired,
            this.columnFirstNameExpired,
            this.columnLastNameExpired,
            this.columnAddressExpired,
            this.columnBirthdateExpired,
            this.columnGenderExpired,
            this.columnPersonalNoExpired,
            this.columnEmailExpired,
            this.columnPhoneNumberExpired,
            this.columnSubscriptionPlanExpired,
            this.columnFromExpired,
            this.columnTillExpired});
            this.dgvExpiredMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExpiredMembers.Location = new System.Drawing.Point(23, 3);
            this.dgvExpiredMembers.Name = "dgvExpiredMembers";
            this.dgvExpiredMembers.Size = new System.Drawing.Size(680, 387);
            this.dgvExpiredMembers.TabIndex = 7;
            // 
            // columnIDExpired
            // 
            this.columnIDExpired.HeaderText = "ID";
            this.columnIDExpired.Name = "columnIDExpired";
            // 
            // columnFirstNameExpired
            // 
            this.columnFirstNameExpired.HeaderText = "First Name";
            this.columnFirstNameExpired.Name = "columnFirstNameExpired";
            // 
            // columnLastNameExpired
            // 
            this.columnLastNameExpired.HeaderText = "Last Name";
            this.columnLastNameExpired.Name = "columnLastNameExpired";
            // 
            // columnAddressExpired
            // 
            this.columnAddressExpired.HeaderText = "Address";
            this.columnAddressExpired.Name = "columnAddressExpired";
            // 
            // columnBirthdateExpired
            // 
            this.columnBirthdateExpired.HeaderText = "Birthdate";
            this.columnBirthdateExpired.Name = "columnBirthdateExpired";
            // 
            // columnGenderExpired
            // 
            this.columnGenderExpired.HeaderText = "Gender";
            this.columnGenderExpired.Name = "columnGenderExpired";
            // 
            // columnPersonalNoExpired
            // 
            this.columnPersonalNoExpired.HeaderText = "Personal Number";
            this.columnPersonalNoExpired.Name = "columnPersonalNoExpired";
            // 
            // columnEmailExpired
            // 
            this.columnEmailExpired.HeaderText = "Email";
            this.columnEmailExpired.Name = "columnEmailExpired";
            // 
            // columnPhoneNumberExpired
            // 
            this.columnPhoneNumberExpired.HeaderText = "Phone Number";
            this.columnPhoneNumberExpired.Name = "columnPhoneNumberExpired";
            // 
            // columnSubscriptionPlanExpired
            // 
            this.columnSubscriptionPlanExpired.HeaderText = "Subscription Plan";
            this.columnSubscriptionPlanExpired.Name = "columnSubscriptionPlanExpired";
            // 
            // columnFromExpired
            // 
            this.columnFromExpired.HeaderText = "From:";
            this.columnFromExpired.Name = "columnFromExpired";
            // 
            // columnTillExpired
            // 
            this.columnTillExpired.HeaderText = "Till:";
            this.columnTillExpired.Name = "columnTillExpired";
            // 
            // tableFooterExpired
            // 
            this.tableFooterExpired.ColumnCount = 3;
            this.tableFooterExpired.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableFooterExpired.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableFooterExpired.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableFooterExpired.Controls.Add(this.lblFooterExpired, 1, 0);
            this.tableFooterExpired.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableFooterExpired.Location = new System.Drawing.Point(3, 474);
            this.tableFooterExpired.Name = "tableFooterExpired";
            this.tableFooterExpired.RowCount = 1;
            this.tableFooterExpired.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableFooterExpired.Size = new System.Drawing.Size(726, 16);
            this.tableFooterExpired.TabIndex = 3;
            // 
            // lblFooterExpired
            // 
            this.lblFooterExpired.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFooterExpired.AutoSize = true;
            this.lblFooterExpired.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooterExpired.Location = new System.Drawing.Point(237, 0);
            this.lblFooterExpired.Name = "lblFooterExpired";
            this.lblFooterExpired.Size = new System.Drawing.Size(251, 16);
            this.lblFooterExpired.TabIndex = 11;
            this.lblFooterExpired.Text = "All Rights, Stackbooks Management System";
            // 
            // tableSpaceExpiredInfo
            // 
            this.tableSpaceExpiredInfo.ColumnCount = 3;
            this.tableSpaceExpiredInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSpaceExpiredInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSpaceExpiredInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSpaceExpiredInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSpaceExpiredInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSpaceExpiredInfo.Controls.Add(this.lblTitleCreate, 1, 0);
            this.tableSpaceExpiredInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableSpaceExpiredInfo.Location = new System.Drawing.Point(3, 19);
            this.tableSpaceExpiredInfo.Name = "tableSpaceExpiredInfo";
            this.tableSpaceExpiredInfo.RowCount = 1;
            this.tableSpaceExpiredInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSpaceExpiredInfo.Size = new System.Drawing.Size(726, 62);
            this.tableSpaceExpiredInfo.TabIndex = 2;
            // 
            // lblTitleCreate
            // 
            this.lblTitleCreate.AutoSize = true;
            this.lblTitleCreate.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCreate.Location = new System.Drawing.Point(23, 0);
            this.lblTitleCreate.Name = "lblTitleCreate";
            this.lblTitleCreate.Size = new System.Drawing.Size(501, 37);
            this.lblTitleCreate.TabIndex = 8;
            this.lblTitleCreate.Text = "This Displays List of Expired Members";
            // 
            // tableSpace3
            // 
            this.tableSpace3.ColumnCount = 1;
            this.tableSpace3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSpace3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableSpace3.Location = new System.Drawing.Point(3, 3);
            this.tableSpace3.Name = "tableSpace3";
            this.tableSpace3.RowCount = 1;
            this.tableSpace3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSpace3.Size = new System.Drawing.Size(726, 16);
            this.tableSpace3.TabIndex = 1;
            // 
            // tabBills
            // 
            this.tabBills.Controls.Add(this.tableDataGridViewBills);
            this.tabBills.Controls.Add(this.tableBottom3);
            this.tabBills.Controls.Add(this.tableLayoutPanel3);
            this.tabBills.Controls.Add(this.tableSpaceInfoBills);
            this.tabBills.Controls.Add(this.tableSpace4);
            this.tabBills.Location = new System.Drawing.Point(4, 32);
            this.tabBills.Name = "tabBills";
            this.tabBills.Padding = new System.Windows.Forms.Padding(3);
            this.tabBills.Size = new System.Drawing.Size(732, 493);
            this.tabBills.TabIndex = 2;
            this.tabBills.Text = "All Bills";
            this.tabBills.UseVisualStyleBackColor = true;
            // 
            // tableDataGridViewBills
            // 
            this.tableDataGridViewBills.ColumnCount = 3;
            this.tableDataGridViewBills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDataGridViewBills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDataGridViewBills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDataGridViewBills.Controls.Add(this.dgvBills, 1, 0);
            this.tableDataGridViewBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDataGridViewBills.Location = new System.Drawing.Point(3, 127);
            this.tableDataGridViewBills.Name = "tableDataGridViewBills";
            this.tableDataGridViewBills.RowCount = 1;
            this.tableDataGridViewBills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDataGridViewBills.Size = new System.Drawing.Size(726, 347);
            this.tableDataGridViewBills.TabIndex = 6;
            // 
            // dgvBills
            // 
            this.dgvBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIDBill,
            this.columnMemberIDBill,
            this.columnFirstNameBill,
            this.columnLastNameBill,
            this.columnPersonalNoBill,
            this.columnEmailBill,
            this.columnPhoneNumberBill,
            this.columnSubscriptionPlanBill,
            this.columnPriceBill,
            this.columnFromBill,
            this.columnTillBill});
            this.dgvBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBills.Location = new System.Drawing.Point(23, 3);
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.Size = new System.Drawing.Size(680, 341);
            this.dgvBills.TabIndex = 7;
            // 
            // columnIDBill
            // 
            this.columnIDBill.HeaderText = "Bill ID";
            this.columnIDBill.Name = "columnIDBill";
            // 
            // columnMemberIDBill
            // 
            this.columnMemberIDBill.HeaderText = "Member ID";
            this.columnMemberIDBill.Name = "columnMemberIDBill";
            // 
            // columnFirstNameBill
            // 
            this.columnFirstNameBill.HeaderText = "First Name";
            this.columnFirstNameBill.Name = "columnFirstNameBill";
            // 
            // columnLastNameBill
            // 
            this.columnLastNameBill.HeaderText = "Last Name";
            this.columnLastNameBill.Name = "columnLastNameBill";
            // 
            // columnPersonalNoBill
            // 
            this.columnPersonalNoBill.HeaderText = "Personal Number";
            this.columnPersonalNoBill.Name = "columnPersonalNoBill";
            // 
            // columnEmailBill
            // 
            this.columnEmailBill.HeaderText = "Email";
            this.columnEmailBill.Name = "columnEmailBill";
            // 
            // columnPhoneNumberBill
            // 
            this.columnPhoneNumberBill.HeaderText = "Phone Number";
            this.columnPhoneNumberBill.Name = "columnPhoneNumberBill";
            // 
            // columnSubscriptionPlanBill
            // 
            this.columnSubscriptionPlanBill.HeaderText = "Subscription Plan";
            this.columnSubscriptionPlanBill.Name = "columnSubscriptionPlanBill";
            // 
            // columnPriceBill
            // 
            this.columnPriceBill.HeaderText = "Price";
            this.columnPriceBill.Name = "columnPriceBill";
            // 
            // columnFromBill
            // 
            this.columnFromBill.HeaderText = "From:";
            this.columnFromBill.Name = "columnFromBill";
            // 
            // columnTillBill
            // 
            this.columnTillBill.HeaderText = "Till:";
            this.columnTillBill.Name = "columnTillBill";
            // 
            // tableBottom3
            // 
            this.tableBottom3.ColumnCount = 3;
            this.tableBottom3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableBottom3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableBottom3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableBottom3.Controls.Add(this.lblFooter3, 1, 0);
            this.tableBottom3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableBottom3.Location = new System.Drawing.Point(3, 474);
            this.tableBottom3.Name = "tableBottom3";
            this.tableBottom3.RowCount = 1;
            this.tableBottom3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableBottom3.Size = new System.Drawing.Size(726, 16);
            this.tableBottom3.TabIndex = 5;
            // 
            // lblFooter3
            // 
            this.lblFooter3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFooter3.AutoSize = true;
            this.lblFooter3.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter3.Location = new System.Drawing.Point(237, 0);
            this.lblFooter3.Name = "lblFooter3";
            this.lblFooter3.Size = new System.Drawing.Size(251, 16);
            this.lblFooter3.TabIndex = 11;
            this.lblFooter3.Text = "All Rights, Stackbooks Management System";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.6864F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.3136F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel3.Controls.Add(this.txtSearchBills, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboSortBills, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSearchBills, 5, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 74);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(726, 53);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // txtSearchBills
            // 
            this.txtSearchBills.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearchBills.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBills.Location = new System.Drawing.Point(23, 3);
            this.txtSearchBills.Name = "txtSearchBills";
            this.txtSearchBills.Size = new System.Drawing.Size(255, 39);
            this.txtSearchBills.TabIndex = 4;
            // 
            // comboSortBills
            // 
            this.comboSortBills.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboSortBills.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSortBills.FormattingEnabled = true;
            this.comboSortBills.Items.AddRange(new object[] {
            "Ascending Order",
            "Descending Order"});
            this.comboSortBills.Location = new System.Drawing.Point(297, 3);
            this.comboSortBills.Name = "comboSortBills";
            this.comboSortBills.Size = new System.Drawing.Size(137, 40);
            this.comboSortBills.TabIndex = 5;
            // 
            // btnSearchBills
            // 
            this.btnSearchBills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.btnSearchBills.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchBills.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBills.ForeColor = System.Drawing.Color.White;
            this.btnSearchBills.Location = new System.Drawing.Point(452, 3);
            this.btnSearchBills.Name = "btnSearchBills";
            this.btnSearchBills.Size = new System.Drawing.Size(229, 40);
            this.btnSearchBills.TabIndex = 6;
            this.btnSearchBills.Text = "Search";
            this.btnSearchBills.UseVisualStyleBackColor = false;
            // 
            // tableSpaceInfoBills
            // 
            this.tableSpaceInfoBills.ColumnCount = 3;
            this.tableSpaceInfoBills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSpaceInfoBills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSpaceInfoBills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSpaceInfoBills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSpaceInfoBills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSpaceInfoBills.Controls.Add(this.lblInfoBills, 1, 0);
            this.tableSpaceInfoBills.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableSpaceInfoBills.Location = new System.Drawing.Point(3, 19);
            this.tableSpaceInfoBills.Name = "tableSpaceInfoBills";
            this.tableSpaceInfoBills.RowCount = 1;
            this.tableSpaceInfoBills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSpaceInfoBills.Size = new System.Drawing.Size(726, 55);
            this.tableSpaceInfoBills.TabIndex = 3;
            // 
            // lblInfoBills
            // 
            this.lblInfoBills.AutoSize = true;
            this.lblInfoBills.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoBills.Location = new System.Drawing.Point(23, 0);
            this.lblInfoBills.Name = "lblInfoBills";
            this.lblInfoBills.Size = new System.Drawing.Size(474, 37);
            this.lblInfoBills.TabIndex = 8;
            this.lblInfoBills.Text = "This Displays List of Registered Bills";
            // 
            // tableSpace4
            // 
            this.tableSpace4.ColumnCount = 1;
            this.tableSpace4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSpace4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableSpace4.Location = new System.Drawing.Point(3, 3);
            this.tableSpace4.Name = "tableSpace4";
            this.tableSpace4.RowCount = 1;
            this.tableSpace4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSpace4.Size = new System.Drawing.Size(726, 16);
            this.tableSpace4.TabIndex = 2;
            // 
            // subscribersBindingSource1
            // 
            this.subscribersBindingSource1.DataMember = "Subscribers";
            this.subscribersBindingSource1.DataSource = this.libraryManagementDataSet1;
            // 
            // libraryManagementDataSet1
            // 
            this.libraryManagementDataSet1.DataSetName = "LibraryManagementDataSet1";
            this.libraryManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subscribersBindingSource
            // 
            this.subscribersBindingSource.DataMember = "Subscribers";
            this.subscribersBindingSource.DataSource = this.libraryManagementDataSet;
            // 
            // libraryManagementDataSet
            // 
            this.libraryManagementDataSet.DataSetName = "LibraryManagementDataSet";
            this.libraryManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.lblTitle.Location = new System.Drawing.Point(151, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(201, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MEMBERS";
            // 
            // picTitle
            // 
            this.picTitle.Image = ((System.Drawing.Image)(resources.GetObject("picTitle.Image")));
            this.picTitle.Location = new System.Drawing.Point(99, 17);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(58, 50);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTitle.TabIndex = 0;
            this.picTitle.TabStop = false;
            // 
            // tableHeader
            // 
            this.tableHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.tableHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableHeader.BackgroundImage")));
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
            // subscribersTableAdapter
            // 
            this.subscribersTableAdapter.ClearBeforeFill = true;
            // 
            // subscribersTableAdapter1
            // 
            this.subscribersTableAdapter1.ClearBeforeFill = true;
            // 
            // MembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 617);
            this.Controls.Add(this.panelFullBody);
            this.Controls.Add(this.tableHeader);
            this.Name = "MembersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Members (Stackbooks)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MembersForm_Load);
            this.panelFullBody.ResumeLayout(false);
            this.tabControlMembersForm.ResumeLayout(false);
            this.tabMainPage.ResumeLayout(false);
            this.tableDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.tableBottomSpace.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableSearch.ResumeLayout(false);
            this.tableSearch.PerformLayout();
            this.tableSpace2.ResumeLayout(false);
            this.tabExpiredMembers.ResumeLayout(false);
            this.tableDataGridViewExpired.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpiredMembers)).EndInit();
            this.tableFooterExpired.ResumeLayout(false);
            this.tableFooterExpired.PerformLayout();
            this.tableSpaceExpiredInfo.ResumeLayout(false);
            this.tableSpaceExpiredInfo.PerformLayout();
            this.tabBills.ResumeLayout(false);
            this.tableDataGridViewBills.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            this.tableBottom3.ResumeLayout(false);
            this.tableBottom3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableSpaceInfoBills.ResumeLayout(false);
            this.tableSpaceInfoBills.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subscribersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscribersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.tableHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelFullBody;
        private System.Windows.Forms.TabControl tabControlMembersForm;
        private System.Windows.Forms.TabPage tabMainPage;
        private System.Windows.Forms.TabPage tabExpiredMembers;
        private System.Windows.Forms.TableLayoutPanel tableSpace1;
        private System.Windows.Forms.TableLayoutPanel tableSpace2;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnUpdateMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.TableLayoutPanel tableButtons;
        private System.Windows.Forms.TableLayoutPanel tableSearch;
        private System.Windows.Forms.TextBox txtSearchMember;
        private System.Windows.Forms.ComboBox comboSortMember;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.TableLayoutPanel tableBottomSpace;
        private System.Windows.Forms.TableLayoutPanel tableDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.TableLayoutPanel tableHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFooterTitleCreate;
        private System.Windows.Forms.TableLayoutPanel tableSpaceExpiredInfo;
        private System.Windows.Forms.TableLayoutPanel tableSpace3;
        private System.Windows.Forms.Label lblTitleCreate;
        private System.Windows.Forms.TableLayoutPanel tableDataGridViewExpired;
        private System.Windows.Forms.DataGridView dgvExpiredMembers;
        private System.Windows.Forms.TableLayoutPanel tableFooterExpired;
        private System.Windows.Forms.Label lblFooterExpired;
        private System.Windows.Forms.TabPage tabBills;
        private System.Windows.Forms.TableLayoutPanel tableDataGridViewBills;
        private System.Windows.Forms.DataGridView dgvBills;
        private System.Windows.Forms.TableLayoutPanel tableBottom3;
        private System.Windows.Forms.Label lblFooter3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtSearchBills;
        private System.Windows.Forms.ComboBox comboSortBills;
        private System.Windows.Forms.Button btnSearchBills;
        private System.Windows.Forms.TableLayoutPanel tableSpaceInfoBills;
        private System.Windows.Forms.Label lblInfoBills;
        private System.Windows.Forms.TableLayoutPanel tableSpace4;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIDBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMemberIDBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFirstNameBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLastNameBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPersonalNoBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEmailBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPhoneNumberBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSubscriptionPlanBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPriceBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFromBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTillBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIDExpired;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFirstNameExpired;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLastNameExpired;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAddressExpired;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBirthdateExpired;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGenderExpired;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPersonalNoExpired;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEmailExpired;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPhoneNumberExpired;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSubscriptionPlanExpired;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFromExpired;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTillExpired;
        private LibraryManagementDataSet libraryManagementDataSet;
        private System.Windows.Forms.BindingSource subscribersBindingSource;
        private LibraryManagementDataSetTableAdapters.SubscribersTableAdapter subscribersTableAdapter;
        private LibraryManagementDataSet1 libraryManagementDataSet1;
        private System.Windows.Forms.BindingSource subscribersBindingSource1;
        private LibraryManagementDataSet1TableAdapters.SubscribersTableAdapter subscribersTableAdapter1;
        private DevExpress.XtraGrid.GridControl gridMembers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthday;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonalNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNo;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colGender;
        private DevExpress.XtraGrid.Columns.GridColumn colInsDate;
        private DevExpress.XtraGrid.Columns.GridColumn colExpirationDate;
    }
}