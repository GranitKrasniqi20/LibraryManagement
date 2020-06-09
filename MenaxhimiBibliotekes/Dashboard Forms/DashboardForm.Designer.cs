namespace MenaxhimiBibliotekes.Dashboard_Forms
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            this.tableHeader = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.tableSpace1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFooterTitleCreate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableContents = new System.Windows.Forms.TableLayoutPanel();
            this.lblOverallTotalStatistics = new System.Windows.Forms.Label();
            this.lblMonthlyBorrowedStatistics = new System.Windows.Forms.Label();
            this.lblTop10BorrowedStatistics = new System.Windows.Forms.Label();
            this.gridMembers = new DevExpress.XtraGrid.GridControl();
            this.gridViewMembers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSubscriberId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonalNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInsDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDisplayTable = new System.Windows.Forms.Button();
            this.comboMembers = new System.Windows.Forms.ComboBox();
            this.lblStatisticsForMembers = new System.Windows.Forms.Label();
            this.lblMostBorrowedTypesStatistics = new System.Windows.Forms.Label();
            this.tableOverallTotalStatistics = new System.Windows.Forms.TableLayoutPanel();
            this.panelSubscribersCount = new System.Windows.Forms.Panel();
            this.txtTotalMembers = new System.Windows.Forms.Label();
            this.lblTotalMembers = new System.Windows.Forms.Label();
            this.panelMaterialsCount = new System.Windows.Forms.Panel();
            this.txtTotalMaterials = new System.Windows.Forms.Label();
            this.lblTotalMaterials = new System.Windows.Forms.Label();
            this.panelBorrowingsCount = new System.Windows.Forms.Panel();
            this.txtTotalBorrowings = new System.Windows.Forms.Label();
            this.lblTotalBorrowings = new System.Windows.Forms.Label();
            this.piechart = new DevExpress.XtraCharts.ChartControl();
            this.chartMostBorrowedMaterials = new DevExpress.XtraCharts.ChartControl();
            this.chartMaterials = new DevExpress.XtraCharts.ChartControl();
            this.tableHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableContents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMembers)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableOverallTotalStatistics.SuspendLayout();
            this.panelSubscribersCount.SuspendLayout();
            this.panelMaterialsCount.SuspendLayout();
            this.panelBorrowingsCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piechart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMostBorrowedMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // tableHeader
            // 
            this.tableHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
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
            this.tableHeader.Size = new System.Drawing.Size(819, 88);
            this.tableHeader.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.picTitle);
            this.panel1.Location = new System.Drawing.Point(182, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 82);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(131, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(251, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DASHBOARD";
            // 
            // picTitle
            // 
            this.picTitle.Image = ((System.Drawing.Image)(resources.GetObject("picTitle.Image")));
            this.picTitle.Location = new System.Drawing.Point(79, 17);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(58, 50);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTitle.TabIndex = 0;
            this.picTitle.TabStop = false;
            // 
            // tableSpace1
            // 
            this.tableSpace1.ColumnCount = 1;
            this.tableSpace1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSpace1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableSpace1.Location = new System.Drawing.Point(0, 88);
            this.tableSpace1.Name = "tableSpace1";
            this.tableSpace1.RowCount = 1;
            this.tableSpace1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSpace1.Size = new System.Drawing.Size(819, 16);
            this.tableSpace1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblFooterTitleCreate, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 634);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(819, 25);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lblFooterTitleCreate
            // 
            this.lblFooterTitleCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFooterTitleCreate.AutoSize = true;
            this.lblFooterTitleCreate.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooterTitleCreate.Location = new System.Drawing.Point(284, 4);
            this.lblFooterTitleCreate.Name = "lblFooterTitleCreate";
            this.lblFooterTitleCreate.Size = new System.Drawing.Size(251, 17);
            this.lblFooterTitleCreate.TabIndex = 11;
            this.lblFooterTitleCreate.Text = "All Rights, Stackbooks Management System";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.tableContents);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 530);
            this.panel2.TabIndex = 5;
            // 
            // tableContents
            // 
            this.tableContents.AutoScroll = true;
            this.tableContents.ColumnCount = 3;
            this.tableContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableContents.Controls.Add(this.lblOverallTotalStatistics, 1, 0);
            this.tableContents.Controls.Add(this.lblMonthlyBorrowedStatistics, 1, 3);
            this.tableContents.Controls.Add(this.lblTop10BorrowedStatistics, 1, 6);
            this.tableContents.Controls.Add(this.gridMembers, 1, 13);
            this.tableContents.Controls.Add(this.panel3, 1, 12);
            this.tableContents.Controls.Add(this.lblMostBorrowedTypesStatistics, 1, 9);
            this.tableContents.Controls.Add(this.piechart, 1, 10);
            this.tableContents.Controls.Add(this.chartMostBorrowedMaterials, 1, 7);
            this.tableContents.Controls.Add(this.chartMaterials, 1, 4);
            this.tableContents.Controls.Add(this.tableOverallTotalStatistics, 1, 1);
            this.tableContents.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableContents.Location = new System.Drawing.Point(0, 0);
            this.tableContents.Name = "tableContents";
            this.tableContents.RowCount = 14;
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableContents.Size = new System.Drawing.Size(802, 2161);
            this.tableContents.TabIndex = 6;
            // 
            // lblOverallTotalStatistics
            // 
            this.lblOverallTotalStatistics.AutoSize = true;
            this.lblOverallTotalStatistics.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverallTotalStatistics.Location = new System.Drawing.Point(23, 0);
            this.lblOverallTotalStatistics.Name = "lblOverallTotalStatistics";
            this.lblOverallTotalStatistics.Size = new System.Drawing.Size(324, 30);
            this.lblOverallTotalStatistics.TabIndex = 3;
            this.lblOverallTotalStatistics.Text = "Overall Total Numbers Statistics";
            // 
            // lblMonthlyBorrowedStatistics
            // 
            this.lblMonthlyBorrowedStatistics.AutoSize = true;
            this.lblMonthlyBorrowedStatistics.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyBorrowedStatistics.Location = new System.Drawing.Point(23, 300);
            this.lblMonthlyBorrowedStatistics.Name = "lblMonthlyBorrowedStatistics";
            this.lblMonthlyBorrowedStatistics.Size = new System.Drawing.Size(593, 30);
            this.lblMonthlyBorrowedStatistics.TabIndex = 4;
            this.lblMonthlyBorrowedStatistics.Text = "Monthly Statistics of Most Borrowed Materials (Line Chart)";
            // 
            // lblTop10BorrowedStatistics
            // 
            this.lblTop10BorrowedStatistics.AutoSize = true;
            this.lblTop10BorrowedStatistics.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop10BorrowedStatistics.Location = new System.Drawing.Point(23, 765);
            this.lblTop10BorrowedStatistics.Name = "lblTop10BorrowedStatistics";
            this.lblTop10BorrowedStatistics.Size = new System.Drawing.Size(447, 30);
            this.lblTop10BorrowedStatistics.TabIndex = 4;
            this.lblTop10BorrowedStatistics.Text = "Top 10 Most Borrowed Materials (Bar Chart)";
            // 
            // gridMembers
            // 
            this.gridMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMembers.Location = new System.Drawing.Point(23, 1798);
            this.gridMembers.MainView = this.gridViewMembers;
            this.gridMembers.Name = "gridMembers";
            this.gridMembers.Size = new System.Drawing.Size(756, 360);
            this.gridMembers.TabIndex = 13;
            this.gridMembers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMembers});
            // 
            // gridViewMembers
            // 
            this.gridViewMembers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSubscriberId,
            this.colName,
            this.colLastName,
            this.colPersonalNumber,
            this.colPhoneNumber,
            this.colEmail,
            this.colInsDate,
            this.colEndDate});
            this.gridViewMembers.GridControl = this.gridMembers;
            this.gridViewMembers.Name = "gridViewMembers";
            // 
            // colSubscriberId
            // 
            this.colSubscriberId.Caption = "ID";
            this.colSubscriberId.FieldName = "SubscriberId";
            this.colSubscriberId.Name = "colSubscriberId";
            this.colSubscriberId.Visible = true;
            this.colSubscriberId.VisibleIndex = 0;
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
            // colPersonalNumber
            // 
            this.colPersonalNumber.Caption = "Personal Number";
            this.colPersonalNumber.FieldName = "PersonalNo";
            this.colPersonalNumber.Name = "colPersonalNumber";
            this.colPersonalNumber.Visible = true;
            this.colPersonalNumber.VisibleIndex = 3;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.Caption = "Phone Number";
            this.colPhoneNumber.FieldName = "PhoneNo";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.Visible = true;
            this.colPhoneNumber.VisibleIndex = 4;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "E-Mail";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 5;
            // 
            // colInsDate
            // 
            this.colInsDate.Caption = "Registration Date";
            this.colInsDate.FieldName = "InsDate";
            this.colInsDate.Name = "colInsDate";
            this.colInsDate.Visible = true;
            this.colInsDate.VisibleIndex = 6;
            // 
            // colEndDate
            // 
            this.colEndDate.Caption = "Expiration Date";
            this.colEndDate.FieldName = "ExpirationDate";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.Visible = true;
            this.colEndDate.VisibleIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDisplayTable);
            this.panel3.Controls.Add(this.comboMembers);
            this.panel3.Controls.Add(this.lblStatisticsForMembers);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(23, 1698);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(756, 94);
            this.panel3.TabIndex = 14;
            // 
            // btnDisplayTable
            // 
            this.btnDisplayTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.btnDisplayTable.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayTable.ForeColor = System.Drawing.Color.White;
            this.btnDisplayTable.Location = new System.Drawing.Point(426, 44);
            this.btnDisplayTable.Name = "btnDisplayTable";
            this.btnDisplayTable.Size = new System.Drawing.Size(220, 46);
            this.btnDisplayTable.TabIndex = 6;
            this.btnDisplayTable.Text = "Display";
            this.btnDisplayTable.UseVisualStyleBackColor = false;
            this.btnDisplayTable.Click += new System.EventHandler(this.btnDisplayTable_Click_1);
            // 
            // comboMembers
            // 
            this.comboMembers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMembers.FormattingEnabled = true;
            this.comboMembers.Items.AddRange(new object[] {
            "Get All Active Members",
            "Get Top 5 Latest Registered Members",
            "Get Top 10 Latest Registered Members"});
            this.comboMembers.Location = new System.Drawing.Point(0, 48);
            this.comboMembers.Name = "comboMembers";
            this.comboMembers.Size = new System.Drawing.Size(420, 38);
            this.comboMembers.TabIndex = 5;
            // 
            // lblStatisticsForMembers
            // 
            this.lblStatisticsForMembers.AutoSize = true;
            this.lblStatisticsForMembers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatisticsForMembers.Location = new System.Drawing.Point(3, 0);
            this.lblStatisticsForMembers.Name = "lblStatisticsForMembers";
            this.lblStatisticsForMembers.Size = new System.Drawing.Size(385, 30);
            this.lblStatisticsForMembers.TabIndex = 4;
            this.lblStatisticsForMembers.Text = "Top Statistics For Registered Members";
            // 
            // lblMostBorrowedTypesStatistics
            // 
            this.lblMostBorrowedTypesStatistics.AutoSize = true;
            this.lblMostBorrowedTypesStatistics.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostBorrowedTypesStatistics.Location = new System.Drawing.Point(23, 1230);
            this.lblMostBorrowedTypesStatistics.Name = "lblMostBorrowedTypesStatistics";
            this.lblMostBorrowedTypesStatistics.Size = new System.Drawing.Size(425, 30);
            this.lblMostBorrowedTypesStatistics.TabIndex = 15;
            this.lblMostBorrowedTypesStatistics.Text = "Most Borrowed Material Types (Pie Chart)";
            // 
            // tableOverallTotalStatistics
            // 
            this.tableOverallTotalStatistics.ColumnCount = 5;
            this.tableOverallTotalStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableOverallTotalStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableOverallTotalStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableOverallTotalStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableOverallTotalStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableOverallTotalStatistics.Controls.Add(this.panelSubscribersCount, 0, 0);
            this.tableOverallTotalStatistics.Controls.Add(this.panelMaterialsCount, 2, 0);
            this.tableOverallTotalStatistics.Controls.Add(this.panelBorrowingsCount, 4, 0);
            this.tableOverallTotalStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableOverallTotalStatistics.Location = new System.Drawing.Point(23, 63);
            this.tableOverallTotalStatistics.Name = "tableOverallTotalStatistics";
            this.tableOverallTotalStatistics.RowCount = 1;
            this.tableOverallTotalStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableOverallTotalStatistics.Size = new System.Drawing.Size(756, 194);
            this.tableOverallTotalStatistics.TabIndex = 17;
            // 
            // panelSubscribersCount
            // 
            this.panelSubscribersCount.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelSubscribersCount.Controls.Add(this.txtTotalMembers);
            this.panelSubscribersCount.Controls.Add(this.lblTotalMembers);
            this.panelSubscribersCount.Location = new System.Drawing.Point(3, 3);
            this.panelSubscribersCount.Name = "panelSubscribersCount";
            this.panelSubscribersCount.Size = new System.Drawing.Size(232, 188);
            this.panelSubscribersCount.TabIndex = 0;
            // 
            // txtTotalMembers
            // 
            this.txtTotalMembers.AutoSize = true;
            this.txtTotalMembers.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalMembers.ForeColor = System.Drawing.Color.White;
            this.txtTotalMembers.Location = new System.Drawing.Point(16, 68);
            this.txtTotalMembers.Name = "txtTotalMembers";
            this.txtTotalMembers.Size = new System.Drawing.Size(67, 50);
            this.txtTotalMembers.TabIndex = 0;
            this.txtTotalMembers.Text = "---";
            // 
            // lblTotalMembers
            // 
            this.lblTotalMembers.AutoSize = true;
            this.lblTotalMembers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMembers.ForeColor = System.Drawing.Color.White;
            this.lblTotalMembers.Location = new System.Drawing.Point(20, 23);
            this.lblTotalMembers.Name = "lblTotalMembers";
            this.lblTotalMembers.Size = new System.Drawing.Size(150, 30);
            this.lblTotalMembers.TabIndex = 0;
            this.lblTotalMembers.Text = "Total Members";
            // 
            // panelMaterialsCount
            // 
            this.panelMaterialsCount.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMaterialsCount.Controls.Add(this.txtTotalMaterials);
            this.panelMaterialsCount.Controls.Add(this.lblTotalMaterials);
            this.panelMaterialsCount.Location = new System.Drawing.Point(261, 3);
            this.panelMaterialsCount.Name = "panelMaterialsCount";
            this.panelMaterialsCount.Size = new System.Drawing.Size(232, 188);
            this.panelMaterialsCount.TabIndex = 1;
            // 
            // txtTotalMaterials
            // 
            this.txtTotalMaterials.AutoSize = true;
            this.txtTotalMaterials.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalMaterials.ForeColor = System.Drawing.Color.White;
            this.txtTotalMaterials.Location = new System.Drawing.Point(20, 68);
            this.txtTotalMaterials.Name = "txtTotalMaterials";
            this.txtTotalMaterials.Size = new System.Drawing.Size(67, 50);
            this.txtTotalMaterials.TabIndex = 0;
            this.txtTotalMaterials.Text = "---";
            // 
            // lblTotalMaterials
            // 
            this.lblTotalMaterials.AutoSize = true;
            this.lblTotalMaterials.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMaterials.ForeColor = System.Drawing.Color.White;
            this.lblTotalMaterials.Location = new System.Drawing.Point(24, 23);
            this.lblTotalMaterials.Name = "lblTotalMaterials";
            this.lblTotalMaterials.Size = new System.Drawing.Size(148, 30);
            this.lblTotalMaterials.TabIndex = 0;
            this.lblTotalMaterials.Text = "Total Materials";
            // 
            // panelBorrowingsCount
            // 
            this.panelBorrowingsCount.BackColor = System.Drawing.Color.Peru;
            this.panelBorrowingsCount.Controls.Add(this.txtTotalBorrowings);
            this.panelBorrowingsCount.Controls.Add(this.lblTotalBorrowings);
            this.panelBorrowingsCount.Location = new System.Drawing.Point(519, 3);
            this.panelBorrowingsCount.Name = "panelBorrowingsCount";
            this.panelBorrowingsCount.Size = new System.Drawing.Size(234, 188);
            this.panelBorrowingsCount.TabIndex = 2;
            // 
            // txtTotalBorrowings
            // 
            this.txtTotalBorrowings.AutoSize = true;
            this.txtTotalBorrowings.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBorrowings.ForeColor = System.Drawing.Color.White;
            this.txtTotalBorrowings.Location = new System.Drawing.Point(24, 68);
            this.txtTotalBorrowings.Name = "txtTotalBorrowings";
            this.txtTotalBorrowings.Size = new System.Drawing.Size(67, 50);
            this.txtTotalBorrowings.TabIndex = 0;
            this.txtTotalBorrowings.Text = "---";
            // 
            // lblTotalBorrowings
            // 
            this.lblTotalBorrowings.AutoSize = true;
            this.lblTotalBorrowings.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBorrowings.ForeColor = System.Drawing.Color.White;
            this.lblTotalBorrowings.Location = new System.Drawing.Point(28, 23);
            this.lblTotalBorrowings.Name = "lblTotalBorrowings";
            this.lblTotalBorrowings.Size = new System.Drawing.Size(166, 30);
            this.lblTotalBorrowings.TabIndex = 0;
            this.lblTotalBorrowings.Text = "Total Borrowings";
            // 
            // piechart
            // 
            this.piechart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.piechart.Legend.Name = "Default Legend";
            this.piechart.Location = new System.Drawing.Point(23, 1293);
            this.piechart.Name = "piechart";
            series1.Name = "s1";
            series1.View = pieSeriesView1;
            this.piechart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.piechart.Size = new System.Drawing.Size(756, 359);
            this.piechart.TabIndex = 10;
            // 
            // chartMostBorrowedMaterials
            // 
            this.chartMostBorrowedMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartMostBorrowedMaterials.Legend.Name = "Default Legend";
            this.chartMostBorrowedMaterials.Location = new System.Drawing.Point(23, 828);
            this.chartMostBorrowedMaterials.Name = "chartMostBorrowedMaterials";
            this.chartMostBorrowedMaterials.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartMostBorrowedMaterials.Size = new System.Drawing.Size(756, 359);
            this.chartMostBorrowedMaterials.TabIndex = 9;
            // 
            // chartMaterials
            // 
            this.chartMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartMaterials.Legend.Name = "Default Legend";
            this.chartMaterials.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartMaterials.Location = new System.Drawing.Point(23, 363);
            this.chartMaterials.Name = "chartMaterials";
            this.chartMaterials.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartMaterials.Size = new System.Drawing.Size(756, 359);
            this.chartMaterials.TabIndex = 18;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(819, 659);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableSpace1);
            this.Controls.Add(this.tableHeader);
            this.MinimumSize = new System.Drawing.Size(756, 656);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard (Stackbooks)";
            this.Activated += new System.EventHandler(this.DashboardForm_Activated);
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.tableHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableContents.ResumeLayout(false);
            this.tableContents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMembers)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableOverallTotalStatistics.ResumeLayout(false);
            this.panelSubscribersCount.ResumeLayout(false);
            this.panelSubscribersCount.PerformLayout();
            this.panelMaterialsCount.ResumeLayout(false);
            this.panelMaterialsCount.PerformLayout();
            this.panelBorrowingsCount.ResumeLayout(false);
            this.panelBorrowingsCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piechart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMostBorrowedMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaterials)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.TableLayoutPanel tableSpace1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFooterTitleCreate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableContents;
        private System.Windows.Forms.Label lblOverallTotalStatistics;
        private System.Windows.Forms.Label lblMonthlyBorrowedStatistics;
        private DevExpress.XtraCharts.ChartControl chartMostBorrowedMaterials;
        private System.Windows.Forms.Label lblTop10BorrowedStatistics;
        private DevExpress.XtraCharts.ChartControl piechart;
        private DevExpress.XtraGrid.GridControl gridMembers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMembers;
        private DevExpress.XtraGrid.Columns.GridColumn colSubscriberId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonalNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colInsDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEndDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDisplayTable;
        private System.Windows.Forms.ComboBox comboMembers;
        private System.Windows.Forms.Label lblStatisticsForMembers;
        private System.Windows.Forms.Label lblMostBorrowedTypesStatistics;
        private System.Windows.Forms.TableLayoutPanel tableOverallTotalStatistics;
        private System.Windows.Forms.Panel panelSubscribersCount;
        private System.Windows.Forms.Label txtTotalMembers;
        private System.Windows.Forms.Label lblTotalMembers;
        private System.Windows.Forms.Panel panelMaterialsCount;
        private System.Windows.Forms.Label txtTotalMaterials;
        private System.Windows.Forms.Label lblTotalMaterials;
        private System.Windows.Forms.Panel panelBorrowingsCount;
        private System.Windows.Forms.Label txtTotalBorrowings;
        private System.Windows.Forms.Label lblTotalBorrowings;
        private DevExpress.XtraCharts.ChartControl chartMaterials;
    }
}