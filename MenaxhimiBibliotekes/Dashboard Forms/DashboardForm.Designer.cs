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
            this.piechart = new DevExpress.XtraCharts.ChartControl();
            this.chartMostBorrowedMaterials = new DevExpress.XtraCharts.ChartControl();
            this.chartMaterials = new DevExpress.XtraCharts.ChartControl();
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
            this.tableHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableContents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMembers)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piechart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMostBorrowedMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaterials)).BeginInit();
            this.tableOverallTotalStatistics.SuspendLayout();
            this.panelSubscribersCount.SuspendLayout();
            this.panelMaterialsCount.SuspendLayout();
            this.panelBorrowingsCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableHeader
            // 
            resources.ApplyResources(this.tableHeader, "tableHeader");
            this.tableHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
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
            // picTitle
            // 
            resources.ApplyResources(this.picTitle, "picTitle");
            this.picTitle.Name = "picTitle";
            this.picTitle.TabStop = false;
            // 
            // tableSpace1
            // 
            resources.ApplyResources(this.tableSpace1, "tableSpace1");
            this.tableSpace1.Name = "tableSpace1";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.lblFooterTitleCreate, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // lblFooterTitleCreate
            // 
            resources.ApplyResources(this.lblFooterTitleCreate, "lblFooterTitleCreate");
            this.lblFooterTitleCreate.Name = "lblFooterTitleCreate";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.tableContents);
            this.panel2.Name = "panel2";
            // 
            // tableContents
            // 
            resources.ApplyResources(this.tableContents, "tableContents");
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
            this.tableContents.Name = "tableContents";
            // 
            // lblOverallTotalStatistics
            // 
            resources.ApplyResources(this.lblOverallTotalStatistics, "lblOverallTotalStatistics");
            this.lblOverallTotalStatistics.Name = "lblOverallTotalStatistics";
            // 
            // lblMonthlyBorrowedStatistics
            // 
            resources.ApplyResources(this.lblMonthlyBorrowedStatistics, "lblMonthlyBorrowedStatistics");
            this.lblMonthlyBorrowedStatistics.Name = "lblMonthlyBorrowedStatistics";
            // 
            // lblTop10BorrowedStatistics
            // 
            resources.ApplyResources(this.lblTop10BorrowedStatistics, "lblTop10BorrowedStatistics");
            this.lblTop10BorrowedStatistics.Name = "lblTop10BorrowedStatistics";
            // 
            // gridMembers
            // 
            resources.ApplyResources(this.gridMembers, "gridMembers");
            this.gridMembers.EmbeddedNavigator.AccessibleDescription = resources.GetString("gridMembers.EmbeddedNavigator.AccessibleDescription");
            this.gridMembers.EmbeddedNavigator.AccessibleName = resources.GetString("gridMembers.EmbeddedNavigator.AccessibleName");
            this.gridMembers.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("gridMembers.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.gridMembers.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gridMembers.EmbeddedNavigator.Anchor")));
            this.gridMembers.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gridMembers.EmbeddedNavigator.BackgroundImage")));
            this.gridMembers.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("gridMembers.EmbeddedNavigator.BackgroundImageLayout")));
            this.gridMembers.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gridMembers.EmbeddedNavigator.ImeMode")));
            this.gridMembers.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("gridMembers.EmbeddedNavigator.MaximumSize")));
            this.gridMembers.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("gridMembers.EmbeddedNavigator.TextLocation")));
            this.gridMembers.EmbeddedNavigator.ToolTip = resources.GetString("gridMembers.EmbeddedNavigator.ToolTip");
            this.gridMembers.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("gridMembers.EmbeddedNavigator.ToolTipIconType")));
            this.gridMembers.EmbeddedNavigator.ToolTipTitle = resources.GetString("gridMembers.EmbeddedNavigator.ToolTipTitle");
            this.gridMembers.MainView = this.gridViewMembers;
            this.gridMembers.Name = "gridMembers";
            this.gridMembers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMembers});
            // 
            // gridViewMembers
            // 
            resources.ApplyResources(this.gridViewMembers, "gridViewMembers");
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
            resources.ApplyResources(this.colSubscriberId, "colSubscriberId");
            this.colSubscriberId.FieldName = "SubscriberId";
            this.colSubscriberId.ImageOptions.ImageIndex = ((int)(resources.GetObject("colSubscriberId.ImageOptions.ImageIndex")));
            this.colSubscriberId.Name = "colSubscriberId";
            // 
            // colName
            // 
            resources.ApplyResources(this.colName, "colName");
            this.colName.FieldName = "Name";
            this.colName.ImageOptions.ImageIndex = ((int)(resources.GetObject("colName.ImageOptions.ImageIndex")));
            this.colName.Name = "colName";
            // 
            // colLastName
            // 
            resources.ApplyResources(this.colLastName, "colLastName");
            this.colLastName.FieldName = "LastName";
            this.colLastName.ImageOptions.ImageIndex = ((int)(resources.GetObject("colLastName.ImageOptions.ImageIndex")));
            this.colLastName.Name = "colLastName";
            // 
            // colPersonalNumber
            // 
            resources.ApplyResources(this.colPersonalNumber, "colPersonalNumber");
            this.colPersonalNumber.FieldName = "PersonalNo";
            this.colPersonalNumber.ImageOptions.ImageIndex = ((int)(resources.GetObject("colPersonalNumber.ImageOptions.ImageIndex")));
            this.colPersonalNumber.Name = "colPersonalNumber";
            // 
            // colPhoneNumber
            // 
            resources.ApplyResources(this.colPhoneNumber, "colPhoneNumber");
            this.colPhoneNumber.FieldName = "PhoneNo";
            this.colPhoneNumber.ImageOptions.ImageIndex = ((int)(resources.GetObject("colPhoneNumber.ImageOptions.ImageIndex")));
            this.colPhoneNumber.Name = "colPhoneNumber";
            // 
            // colEmail
            // 
            resources.ApplyResources(this.colEmail, "colEmail");
            this.colEmail.FieldName = "Email";
            this.colEmail.ImageOptions.ImageIndex = ((int)(resources.GetObject("colEmail.ImageOptions.ImageIndex")));
            this.colEmail.Name = "colEmail";
            // 
            // colInsDate
            // 
            resources.ApplyResources(this.colInsDate, "colInsDate");
            this.colInsDate.FieldName = "InsDate";
            this.colInsDate.ImageOptions.ImageIndex = ((int)(resources.GetObject("colInsDate.ImageOptions.ImageIndex")));
            this.colInsDate.Name = "colInsDate";
            // 
            // colEndDate
            // 
            resources.ApplyResources(this.colEndDate, "colEndDate");
            this.colEndDate.FieldName = "ExpirationDate";
            this.colEndDate.ImageOptions.ImageIndex = ((int)(resources.GetObject("colEndDate.ImageOptions.ImageIndex")));
            this.colEndDate.Name = "colEndDate";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.btnDisplayTable);
            this.panel3.Controls.Add(this.comboMembers);
            this.panel3.Controls.Add(this.lblStatisticsForMembers);
            this.panel3.Name = "panel3";
            // 
            // btnDisplayTable
            // 
            resources.ApplyResources(this.btnDisplayTable, "btnDisplayTable");
            this.btnDisplayTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.btnDisplayTable.ForeColor = System.Drawing.Color.White;
            this.btnDisplayTable.Name = "btnDisplayTable";
            this.btnDisplayTable.UseVisualStyleBackColor = false;
            this.btnDisplayTable.Click += new System.EventHandler(this.btnDisplayTable_Click_1);
            // 
            // comboMembers
            // 
            resources.ApplyResources(this.comboMembers, "comboMembers");
            this.comboMembers.FormattingEnabled = true;
            this.comboMembers.Items.AddRange(new object[] {
            resources.GetString("comboMembers.Items"),
            resources.GetString("comboMembers.Items1"),
            resources.GetString("comboMembers.Items2")});
            this.comboMembers.Name = "comboMembers";
            // 
            // lblStatisticsForMembers
            // 
            resources.ApplyResources(this.lblStatisticsForMembers, "lblStatisticsForMembers");
            this.lblStatisticsForMembers.Name = "lblStatisticsForMembers";
            // 
            // lblMostBorrowedTypesStatistics
            // 
            resources.ApplyResources(this.lblMostBorrowedTypesStatistics, "lblMostBorrowedTypesStatistics");
            this.lblMostBorrowedTypesStatistics.Name = "lblMostBorrowedTypesStatistics";
            // 
            // piechart
            // 
            resources.ApplyResources(this.piechart, "piechart");
            this.piechart.Legend.Name = "Default Legend";
            this.piechart.Name = "piechart";
            resources.ApplyResources(series1, "series1");
            series1.View = pieSeriesView1;
            this.piechart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            // 
            // chartMostBorrowedMaterials
            // 
            resources.ApplyResources(this.chartMostBorrowedMaterials, "chartMostBorrowedMaterials");
            this.chartMostBorrowedMaterials.Legend.Name = "Default Legend";
            this.chartMostBorrowedMaterials.Name = "chartMostBorrowedMaterials";
            this.chartMostBorrowedMaterials.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            // 
            // chartMaterials
            // 
            resources.ApplyResources(this.chartMaterials, "chartMaterials");
            this.chartMaterials.Legend.Name = "Default Legend";
            this.chartMaterials.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartMaterials.Name = "chartMaterials";
            this.chartMaterials.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            // 
            // tableOverallTotalStatistics
            // 
            resources.ApplyResources(this.tableOverallTotalStatistics, "tableOverallTotalStatistics");
            this.tableOverallTotalStatistics.Controls.Add(this.panelSubscribersCount, 0, 0);
            this.tableOverallTotalStatistics.Controls.Add(this.panelMaterialsCount, 2, 0);
            this.tableOverallTotalStatistics.Controls.Add(this.panelBorrowingsCount, 4, 0);
            this.tableOverallTotalStatistics.Name = "tableOverallTotalStatistics";
            // 
            // panelSubscribersCount
            // 
            resources.ApplyResources(this.panelSubscribersCount, "panelSubscribersCount");
            this.panelSubscribersCount.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelSubscribersCount.Controls.Add(this.txtTotalMembers);
            this.panelSubscribersCount.Controls.Add(this.lblTotalMembers);
            this.panelSubscribersCount.Name = "panelSubscribersCount";
            // 
            // txtTotalMembers
            // 
            resources.ApplyResources(this.txtTotalMembers, "txtTotalMembers");
            this.txtTotalMembers.ForeColor = System.Drawing.Color.White;
            this.txtTotalMembers.Name = "txtTotalMembers";
            // 
            // lblTotalMembers
            // 
            resources.ApplyResources(this.lblTotalMembers, "lblTotalMembers");
            this.lblTotalMembers.ForeColor = System.Drawing.Color.White;
            this.lblTotalMembers.Name = "lblTotalMembers";
            // 
            // panelMaterialsCount
            // 
            resources.ApplyResources(this.panelMaterialsCount, "panelMaterialsCount");
            this.panelMaterialsCount.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMaterialsCount.Controls.Add(this.txtTotalMaterials);
            this.panelMaterialsCount.Controls.Add(this.lblTotalMaterials);
            this.panelMaterialsCount.Name = "panelMaterialsCount";
            // 
            // txtTotalMaterials
            // 
            resources.ApplyResources(this.txtTotalMaterials, "txtTotalMaterials");
            this.txtTotalMaterials.ForeColor = System.Drawing.Color.White;
            this.txtTotalMaterials.Name = "txtTotalMaterials";
            // 
            // lblTotalMaterials
            // 
            resources.ApplyResources(this.lblTotalMaterials, "lblTotalMaterials");
            this.lblTotalMaterials.ForeColor = System.Drawing.Color.White;
            this.lblTotalMaterials.Name = "lblTotalMaterials";
            // 
            // panelBorrowingsCount
            // 
            resources.ApplyResources(this.panelBorrowingsCount, "panelBorrowingsCount");
            this.panelBorrowingsCount.BackColor = System.Drawing.Color.Peru;
            this.panelBorrowingsCount.Controls.Add(this.txtTotalBorrowings);
            this.panelBorrowingsCount.Controls.Add(this.lblTotalBorrowings);
            this.panelBorrowingsCount.Name = "panelBorrowingsCount";
            // 
            // txtTotalBorrowings
            // 
            resources.ApplyResources(this.txtTotalBorrowings, "txtTotalBorrowings");
            this.txtTotalBorrowings.ForeColor = System.Drawing.Color.White;
            this.txtTotalBorrowings.Name = "txtTotalBorrowings";
            // 
            // lblTotalBorrowings
            // 
            resources.ApplyResources(this.lblTotalBorrowings, "lblTotalBorrowings");
            this.lblTotalBorrowings.ForeColor = System.Drawing.Color.White;
            this.lblTotalBorrowings.Name = "lblTotalBorrowings";
            // 
            // DashboardForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableSpace1);
            this.Controls.Add(this.tableHeader);
            this.Name = "DashboardForm";
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
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piechart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMostBorrowedMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaterials)).EndInit();
            this.tableOverallTotalStatistics.ResumeLayout(false);
            this.panelSubscribersCount.ResumeLayout(false);
            this.panelSubscribersCount.PerformLayout();
            this.panelMaterialsCount.ResumeLayout(false);
            this.panelMaterialsCount.PerformLayout();
            this.panelBorrowingsCount.ResumeLayout(false);
            this.panelBorrowingsCount.PerformLayout();
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