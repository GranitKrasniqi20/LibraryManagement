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
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView2 = new DevExpress.XtraCharts.PieSeriesView();
            this.tableHeader = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.tableSpace1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFooterTitleCreate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableSpace2 = new System.Windows.Forms.TableLayoutPanel();
            this.chartMaterials = new DevExpress.XtraCharts.ChartControl();
            this.lblMonthlyMostBorrowed = new System.Windows.Forms.Label();
            this.lblTopSubscribersBorrowing = new System.Windows.Forms.Label();
            this.chartMostBorrowedMaterials = new DevExpress.XtraCharts.ChartControl();
            this.label1 = new System.Windows.Forms.Label();
            this.piechart = new DevExpress.XtraCharts.ChartControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDisplayTable = new System.Windows.Forms.Button();
            this.comboMembers = new System.Windows.Forms.ComboBox();
            this.lblStatisticsForMembers = new System.Windows.Forms.Label();
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
            this.tableHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableSpace2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMostBorrowedMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piechart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMembers)).BeginInit();
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
            this.panel2.Controls.Add(this.tableSpace2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 530);
            this.panel2.TabIndex = 5;
            // 
            // tableSpace2
            // 
            this.tableSpace2.AutoScroll = true;
            this.tableSpace2.ColumnCount = 3;
            this.tableSpace2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSpace2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSpace2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSpace2.Controls.Add(this.chartMaterials, 1, 1);
            this.tableSpace2.Controls.Add(this.lblMonthlyMostBorrowed, 1, 0);
            this.tableSpace2.Controls.Add(this.lblTopSubscribersBorrowing, 1, 3);
            this.tableSpace2.Controls.Add(this.chartMostBorrowedMaterials, 1, 4);
            this.tableSpace2.Controls.Add(this.label1, 1, 6);
            this.tableSpace2.Controls.Add(this.piechart, 1, 7);
            this.tableSpace2.Controls.Add(this.panel3, 1, 9);
            this.tableSpace2.Controls.Add(this.gridMembers, 1, 10);
            this.tableSpace2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableSpace2.Location = new System.Drawing.Point(0, 0);
            this.tableSpace2.Name = "tableSpace2";
            this.tableSpace2.RowCount = 12;
            this.tableSpace2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableSpace2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableSpace2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSpace2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableSpace2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableSpace2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSpace2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableSpace2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableSpace2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSpace2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableSpace2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableSpace2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSpace2.Size = new System.Drawing.Size(802, 1966);
            this.tableSpace2.TabIndex = 6;
            // 
            // chartMaterials
            // 
            this.chartMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartMaterials.Legend.Name = "Default Legend";
            this.chartMaterials.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartMaterials.Location = new System.Drawing.Point(23, 63);
            this.chartMaterials.Name = "chartMaterials";
            this.chartMaterials.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartMaterials.Size = new System.Drawing.Size(756, 395);
            this.chartMaterials.TabIndex = 2;
            // 
            // lblMonthlyMostBorrowed
            // 
            this.lblMonthlyMostBorrowed.AutoSize = true;
            this.lblMonthlyMostBorrowed.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyMostBorrowed.Location = new System.Drawing.Point(23, 0);
            this.lblMonthlyMostBorrowed.Name = "lblMonthlyMostBorrowed";
            this.lblMonthlyMostBorrowed.Size = new System.Drawing.Size(593, 30);
            this.lblMonthlyMostBorrowed.TabIndex = 3;
            this.lblMonthlyMostBorrowed.Text = "Monthly Statistics of Most Borrowed Materials (Line Chart)";
            // 
            // lblTopSubscribersBorrowing
            // 
            this.lblTopSubscribersBorrowing.AutoSize = true;
            this.lblTopSubscribersBorrowing.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopSubscribersBorrowing.Location = new System.Drawing.Point(23, 481);
            this.lblTopSubscribersBorrowing.Name = "lblTopSubscribersBorrowing";
            this.lblTopSubscribersBorrowing.Size = new System.Drawing.Size(447, 30);
            this.lblTopSubscribersBorrowing.TabIndex = 4;
            this.lblTopSubscribersBorrowing.Text = "Top 10 Most Borrowed Materials (Bar Chart)";
            // 
            // chartMostBorrowedMaterials
            // 
            this.chartMostBorrowedMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartMostBorrowedMaterials.Legend.Name = "Default Legend";
            this.chartMostBorrowedMaterials.Location = new System.Drawing.Point(23, 544);
            this.chartMostBorrowedMaterials.Name = "chartMostBorrowedMaterials";
            this.chartMostBorrowedMaterials.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartMostBorrowedMaterials.Size = new System.Drawing.Size(756, 395);
            this.chartMostBorrowedMaterials.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 962);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Most Borrowed Material Types (Pie Chart)";
            // 
            // piechart
            // 
            this.piechart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.piechart.Legend.Name = "Default Legend";
            this.piechart.Location = new System.Drawing.Point(23, 1025);
            this.piechart.Name = "piechart";
            series2.Name = "s1";
            series2.View = pieSeriesView2;
            this.piechart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.piechart.Size = new System.Drawing.Size(756, 395);
            this.piechart.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDisplayTable);
            this.panel3.Controls.Add(this.comboMembers);
            this.panel3.Controls.Add(this.lblStatisticsForMembers);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(23, 1446);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(756, 94);
            this.panel3.TabIndex = 11;
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
            this.btnDisplayTable.Click += new System.EventHandler(this.btnDisplayTable_Click);
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
            this.lblStatisticsForMembers.Location = new System.Drawing.Point(0, 4);
            this.lblStatisticsForMembers.Name = "lblStatisticsForMembers";
            this.lblStatisticsForMembers.Size = new System.Drawing.Size(385, 30);
            this.lblStatisticsForMembers.TabIndex = 4;
            this.lblStatisticsForMembers.Text = "Top Statistics For Registered Members";
            // 
            // gridMembers
            // 
            this.gridMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMembers.Location = new System.Drawing.Point(23, 1546);
            this.gridMembers.MainView = this.gridViewMembers;
            this.gridMembers.Name = "gridMembers";
            this.gridMembers.Size = new System.Drawing.Size(756, 395);
            this.gridMembers.TabIndex = 12;
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
            this.tableSpace2.ResumeLayout(false);
            this.tableSpace2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMostBorrowedMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piechart)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMembers)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tableSpace2;
        private DevExpress.XtraCharts.ChartControl chartMaterials;
        private System.Windows.Forms.Label lblMonthlyMostBorrowed;
        private System.Windows.Forms.Label lblTopSubscribersBorrowing;
        private DevExpress.XtraCharts.ChartControl chartMostBorrowedMaterials;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraCharts.ChartControl piechart;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDisplayTable;
        private System.Windows.Forms.ComboBox comboMembers;
        private System.Windows.Forms.Label lblStatisticsForMembers;
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
    }
}