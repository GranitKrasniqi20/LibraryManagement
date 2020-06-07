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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            this.tableHeader = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.tableSpace1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFooterTitleCreate = new System.Windows.Forms.Label();
            this.tableSpace2 = new System.Windows.Forms.TableLayoutPanel();
            this.chartMaterials = new DevExpress.XtraCharts.ChartControl();
            this.libraryManagementDataSet2 = new MenaxhimiBibliotekes.LibraryManagementDataSet2();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsTableAdapter = new MenaxhimiBibliotekes.LibraryManagementDataSet2TableAdapters.MaterialsTableAdapter();
            this.tableHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableSpace2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
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
            this.tableHeader.Size = new System.Drawing.Size(740, 88);
            this.tableHeader.TabIndex = 2;
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
            this.tableSpace1.Size = new System.Drawing.Size(740, 16);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 592);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(740, 25);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lblFooterTitleCreate
            // 
            this.lblFooterTitleCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFooterTitleCreate.AutoSize = true;
            this.lblFooterTitleCreate.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooterTitleCreate.Location = new System.Drawing.Point(244, 4);
            this.lblFooterTitleCreate.Name = "lblFooterTitleCreate";
            this.lblFooterTitleCreate.Size = new System.Drawing.Size(251, 17);
            this.lblFooterTitleCreate.TabIndex = 11;
            this.lblFooterTitleCreate.Text = "All Rights, Stackbooks Management System";
            // 
            // tableSpace2
            // 
            this.tableSpace2.ColumnCount = 3;
            this.tableSpace2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSpace2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSpace2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSpace2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSpace2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSpace2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSpace2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSpace2.Controls.Add(this.chartMaterials, 1, 0);
            this.tableSpace2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableSpace2.Location = new System.Drawing.Point(0, 104);
            this.tableSpace2.Name = "tableSpace2";
            this.tableSpace2.RowCount = 1;
            this.tableSpace2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSpace2.Size = new System.Drawing.Size(740, 224);
            this.tableSpace2.TabIndex = 5;
            // 
            // chartMaterials
            // 
            this.chartMaterials.DataAdapter = this.materialsTableAdapter;
            this.chartMaterials.DataSource = this.materialsBindingSource;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartMaterials.Diagram = xyDiagram1;
            this.chartMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartMaterials.Legend.Name = "Default Legend";
            this.chartMaterials.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartMaterials.Location = new System.Drawing.Point(23, 3);
            this.chartMaterials.Name = "chartMaterials";
            series1.ArgumentDataMember = "Title";
            series1.Name = "InStock";
            series1.ValueDataMembersSerializable = "AvailableCoppies";
            this.chartMaterials.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartMaterials.Size = new System.Drawing.Size(694, 218);
            this.chartMaterials.TabIndex = 0;
            // 
            // libraryManagementDataSet2
            // 
            this.libraryManagementDataSet2.DataSetName = "LibraryManagementDataSet2";
            this.libraryManagementDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "Materials";
            this.materialsBindingSource.DataSource = this.libraryManagementDataSet2;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 617);
            this.Controls.Add(this.tableSpace2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableSpace1);
            this.Controls.Add(this.tableHeader);
            this.MinimumSize = new System.Drawing.Size(756, 656);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard (Stackbooks)";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.tableHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableSpace2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tableSpace2;
        private DevExpress.XtraCharts.ChartControl chartMaterials;
        private LibraryManagementDataSet2TableAdapters.MaterialsTableAdapter materialsTableAdapter;
        private LibraryManagementDataSet2 libraryManagementDataSet2;
        private System.Windows.Forms.BindingSource materialsBindingSource;
    }
}