namespace MenaxhimiBibliotekes.Materials_Forms
{
    partial class MaterialsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialsForm));
            this.tabMainPage = new System.Windows.Forms.TabPage();
            this.tableDataGridView = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.IDCOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishHouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBottomSpace = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFooterTitleCreate = new System.Windows.Forms.Label();
            this.tableSearch = new System.Windows.Forms.TableLayoutPanel();
            this.textSearchMaterial = new System.Windows.Forms.TextBox();
            this.btnSearchMaterial = new System.Windows.Forms.Button();
            this.tableComboboxes = new System.Windows.Forms.TableLayoutPanel();
            this.comboSortMaterial = new System.Windows.Forms.ComboBox();
            this.comboMaterialType = new System.Windows.Forms.ComboBox();
            this.tableButtons = new System.Windows.Forms.TableLayoutPanel();
            this.tableSpace2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddMaterial = new System.Windows.Forms.Button();
            this.btnUpdateMaterial = new System.Windows.Forms.Button();
            this.btnDeleteMaterial = new System.Windows.Forms.Button();
            this.tableSpace1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabReservationsBorrowings = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.label22 = new System.Windows.Forms.Label();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBorrowings = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.btnReturns = new System.Windows.Forms.Button();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.tableHeader = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.tabMainPage.SuspendLayout();
            this.tableDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.tableBottomSpace.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableSearch.SuspendLayout();
            this.tableComboboxes.SuspendLayout();
            this.tableSpace2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabReservationsBorrowings.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMainPage
            // 
            this.tabMainPage.Controls.Add(this.tableDataGridView);
            this.tabMainPage.Controls.Add(this.tableBottomSpace);
            this.tabMainPage.Controls.Add(this.tableSearch);
            this.tabMainPage.Controls.Add(this.tableComboboxes);
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
            this.tableDataGridView.Controls.Add(this.dgvMembers, 1, 0);
            this.tableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDataGridView.Location = new System.Drawing.Point(3, 203);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.RowCount = 1;
            this.tableDataGridView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDataGridView.Size = new System.Drawing.Size(726, 265);
            this.tableDataGridView.TabIndex = 0;
            // 
            // dgvMembers
            // 
            this.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCOL,
            this.Title,
            this.Author,
            this.MaterialType,
            this.Genre,
            this.Language,
            this.ISBN,
            this.PublishHouse,
            this.PublishDate,
            this.PublishPlace,
            this.Quantity,
            this.Pages});
            this.dgvMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMembers.Location = new System.Drawing.Point(23, 3);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.Size = new System.Drawing.Size(680, 259);
            this.dgvMembers.TabIndex = 8;
            // 
            // IDCOL
            // 
            this.IDCOL.HeaderText = "ID";
            this.IDCOL.Name = "IDCOL";
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            // 
            // MaterialType
            // 
            this.MaterialType.HeaderText = "Material Type";
            this.MaterialType.Name = "MaterialType";
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            // 
            // Language
            // 
            this.Language.HeaderText = "Language";
            this.Language.Name = "Language";
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            // 
            // PublishHouse
            // 
            this.PublishHouse.HeaderText = "Publish House";
            this.PublishHouse.Name = "PublishHouse";
            // 
            // PublishDate
            // 
            this.PublishDate.HeaderText = "Publish Date";
            this.PublishDate.Name = "PublishDate";
            // 
            // PublishPlace
            // 
            this.PublishPlace.HeaderText = "Publish Place";
            this.PublishPlace.Name = "PublishPlace";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Pages
            // 
            this.Pages.HeaderText = "No. of Pages";
            this.Pages.Name = "Pages";
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(720, 16);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.tableSearch.ColumnCount = 5;
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSearch.Controls.Add(this.textSearchMaterial, 1, 0);
            this.tableSearch.Controls.Add(this.btnSearchMaterial, 3, 0);
            this.tableSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableSearch.Location = new System.Drawing.Point(3, 150);
            this.tableSearch.Name = "tableSearch";
            this.tableSearch.RowCount = 1;
            this.tableSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableSearch.Size = new System.Drawing.Size(726, 53);
            this.tableSearch.TabIndex = 0;
            // 
            // textSearchMaterial
            // 
            this.textSearchMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textSearchMaterial.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchMaterial.Location = new System.Drawing.Point(23, 3);
            this.textSearchMaterial.Name = "textSearchMaterial";
            this.textSearchMaterial.Size = new System.Drawing.Size(431, 39);
            this.textSearchMaterial.TabIndex = 6;
            // 
            // btnSearchMaterial
            // 
            this.btnSearchMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(185)))));
            this.btnSearchMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchMaterial.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMaterial.ForeColor = System.Drawing.Color.White;
            this.btnSearchMaterial.Location = new System.Drawing.Point(472, 3);
            this.btnSearchMaterial.Name = "btnSearchMaterial";
            this.btnSearchMaterial.Size = new System.Drawing.Size(229, 47);
            this.btnSearchMaterial.TabIndex = 7;
            this.btnSearchMaterial.Text = "Search";
            this.btnSearchMaterial.UseVisualStyleBackColor = false;
            // 
            // tableComboboxes
            // 
            this.tableComboboxes.ColumnCount = 7;
            this.tableComboboxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableComboboxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableComboboxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableComboboxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableComboboxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableComboboxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tableComboboxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableComboboxes.Controls.Add(this.comboSortMaterial, 3, 0);
            this.tableComboboxes.Controls.Add(this.comboMaterialType, 1, 0);
            this.tableComboboxes.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableComboboxes.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableComboboxes.Location = new System.Drawing.Point(3, 97);
            this.tableComboboxes.Name = "tableComboboxes";
            this.tableComboboxes.RowCount = 1;
            this.tableComboboxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableComboboxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableComboboxes.Size = new System.Drawing.Size(726, 53);
            this.tableComboboxes.TabIndex = 0;
            // 
            // comboSortMaterial
            // 
            this.comboSortMaterial.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboSortMaterial.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSortMaterial.FormattingEnabled = true;
            this.comboSortMaterial.Items.AddRange(new object[] {
            "Sort By Asceding",
            "Sort By Descending"});
            this.comboSortMaterial.Location = new System.Drawing.Point(286, 3);
            this.comboSortMaterial.Name = "comboSortMaterial";
            this.comboSortMaterial.Size = new System.Drawing.Size(168, 40);
            this.comboSortMaterial.TabIndex = 5;
            // 
            // comboMaterialType
            // 
            this.comboMaterialType.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMaterialType.FormattingEnabled = true;
            this.comboMaterialType.Items.AddRange(new object[] {
            "Search All Materials",
            "Search Books",
            "Search Journals"});
            this.comboMaterialType.Location = new System.Drawing.Point(23, 3);
            this.comboMaterialType.Name = "comboMaterialType";
            this.comboMaterialType.Size = new System.Drawing.Size(244, 40);
            this.comboMaterialType.TabIndex = 4;
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
            this.tableSpace2.Controls.Add(this.btnAddMaterial, 1, 0);
            this.tableSpace2.Controls.Add(this.btnUpdateMaterial, 3, 0);
            this.tableSpace2.Controls.Add(this.btnDeleteMaterial, 5, 0);
            this.tableSpace2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableSpace2.Location = new System.Drawing.Point(3, 19);
            this.tableSpace2.Name = "tableSpace2";
            this.tableSpace2.RowCount = 1;
            this.tableSpace2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSpace2.Size = new System.Drawing.Size(726, 62);
            this.tableSpace2.TabIndex = 5;
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.btnAddMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddMaterial.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMaterial.ForeColor = System.Drawing.Color.White;
            this.btnAddMaterial.Location = new System.Drawing.Point(23, 3);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(209, 56);
            this.btnAddMaterial.TabIndex = 1;
            this.btnAddMaterial.Text = "Add Material";
            this.btnAddMaterial.UseVisualStyleBackColor = false;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // btnUpdateMaterial
            // 
            this.btnUpdateMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btnUpdateMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateMaterial.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMaterial.ForeColor = System.Drawing.Color.White;
            this.btnUpdateMaterial.Location = new System.Drawing.Point(258, 3);
            this.btnUpdateMaterial.Name = "btnUpdateMaterial";
            this.btnUpdateMaterial.Size = new System.Drawing.Size(209, 56);
            this.btnUpdateMaterial.TabIndex = 2;
            this.btnUpdateMaterial.Text = "Update Material";
            this.btnUpdateMaterial.UseVisualStyleBackColor = false;
            this.btnUpdateMaterial.Click += new System.EventHandler(this.btnUpdateMaterial_Click);
            // 
            // btnDeleteMaterial
            // 
            this.btnDeleteMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(68)))), ((int)(((byte)(55)))));
            this.btnDeleteMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteMaterial.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMaterial.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMaterial.Location = new System.Drawing.Point(493, 3);
            this.btnDeleteMaterial.Name = "btnDeleteMaterial";
            this.btnDeleteMaterial.Size = new System.Drawing.Size(209, 56);
            this.btnDeleteMaterial.TabIndex = 3;
            this.btnDeleteMaterial.Text = "Delete Material";
            this.btnDeleteMaterial.UseVisualStyleBackColor = false;
            this.btnDeleteMaterial.Click += new System.EventHandler(this.btnDeleteMaterial_Click);
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMainPage);
            this.tabControl.Controls.Add(this.tabReservationsBorrowings);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 88);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(12, 8);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(740, 529);
            this.tabControl.TabIndex = 3;
            // 
            // tabReservationsBorrowings
            // 
            this.tabReservationsBorrowings.Controls.Add(this.tableLayoutPanel16);
            this.tabReservationsBorrowings.Controls.Add(this.tableLayoutPanel15);
            this.tabReservationsBorrowings.Controls.Add(this.tableLayoutPanel14);
            this.tabReservationsBorrowings.Controls.Add(this.tableLayoutPanel13);
            this.tabReservationsBorrowings.Controls.Add(this.tableLayoutPanel12);
            this.tabReservationsBorrowings.Controls.Add(this.tableLayoutPanel11);
            this.tabReservationsBorrowings.Location = new System.Drawing.Point(4, 32);
            this.tabReservationsBorrowings.Name = "tabReservationsBorrowings";
            this.tabReservationsBorrowings.Padding = new System.Windows.Forms.Padding(3);
            this.tabReservationsBorrowings.Size = new System.Drawing.Size(732, 493);
            this.tabReservationsBorrowings.TabIndex = 4;
            this.tabReservationsBorrowings.Text = "Reservations & Borrowings";
            this.tabReservationsBorrowings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 3;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel16.Controls.Add(this.dataGridView1, 1, 0);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(3, 155);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 1;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(726, 314);
            this.tableLayoutPanel16.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(23, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(680, 308);
            this.dataGridView1.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Author";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Material Type";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Language";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Publish House";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Publish Date";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Publish Place";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "No. of Pages";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 3;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel15.Controls.Add(this.label22, 1, 0);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(3, 469);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 1;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(726, 21);
            this.tableLayoutPanel15.TabIndex = 9;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(237, 2);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(251, 17);
            this.label22.TabIndex = 11;
            this.label22.Text = "All Rights, Stackbooks Management System";
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 7;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel14.Controls.Add(this.button4, 5, 0);
            this.tableLayoutPanel14.Controls.Add(this.textBox2, 3, 0);
            this.tableLayoutPanel14.Controls.Add(this.comboBox1, 1, 0);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel14.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel14.Location = new System.Drawing.Point(3, 97);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 1;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(726, 58);
            this.tableLayoutPanel14.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(185)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(493, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(209, 52);
            this.button4.TabIndex = 7;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(258, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 39);
            this.textBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Search All Materials",
            "Search Books",
            "Search Journals"});
            this.comboBox1.Location = new System.Drawing.Point(23, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 40);
            this.comboBox1.TabIndex = 8;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(3, 81);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(726, 16);
            this.tableLayoutPanel13.TabIndex = 7;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 7;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel12.Controls.Add(this.btnBorrowings, 3, 0);
            this.tableLayoutPanel12.Controls.Add(this.btnReservations, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.btnReturns, 5, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(726, 62);
            this.tableLayoutPanel12.TabIndex = 6;
            // 
            // btnBorrowings
            // 
            this.btnBorrowings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.btnBorrowings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBorrowings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowings.ForeColor = System.Drawing.Color.White;
            this.btnBorrowings.Location = new System.Drawing.Point(258, 3);
            this.btnBorrowings.Name = "btnBorrowings";
            this.btnBorrowings.Size = new System.Drawing.Size(209, 56);
            this.btnBorrowings.TabIndex = 3;
            this.btnBorrowings.Text = "Borrowings";
            this.btnBorrowings.UseVisualStyleBackColor = false;
            this.btnBorrowings.Click += new System.EventHandler(this.btnBorrowings_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.btnReservations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReservations.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservations.ForeColor = System.Drawing.Color.White;
            this.btnReservations.Location = new System.Drawing.Point(23, 3);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(209, 56);
            this.btnReservations.TabIndex = 3;
            this.btnReservations.Text = "Reservations";
            this.btnReservations.UseVisualStyleBackColor = false;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // btnReturns
            // 
            this.btnReturns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.btnReturns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReturns.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturns.ForeColor = System.Drawing.Color.White;
            this.btnReturns.Location = new System.Drawing.Point(493, 3);
            this.btnReturns.Name = "btnReturns";
            this.btnReturns.Size = new System.Drawing.Size(209, 56);
            this.btnReturns.TabIndex = 3;
            this.btnReturns.Text = "Returns";
            this.btnReturns.UseVisualStyleBackColor = false;
            this.btnReturns.Click += new System.EventHandler(this.btnReturns_Click);
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(726, 16);
            this.tableLayoutPanel11.TabIndex = 1;
            // 
            // tableHeader
            // 
            this.tableHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.tableHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableHeader.BackgroundImage")));
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
            this.tableHeader.TabIndex = 0;
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
            this.lblTitle.Location = new System.Drawing.Point(140, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(224, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MATERIALS";
            // 
            // picTitle
            // 
            this.picTitle.Image = ((System.Drawing.Image)(resources.GetObject("picTitle.Image")));
            this.picTitle.Location = new System.Drawing.Point(88, 17);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(58, 50);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTitle.TabIndex = 0;
            this.picTitle.TabStop = false;
            // 
            // MaterialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 617);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.tableHeader);
            this.MinimumSize = new System.Drawing.Size(756, 656);
            this.Name = "MaterialsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materials (Stackbooks)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabMainPage.ResumeLayout(false);
            this.tableDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.tableBottomSpace.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableSearch.ResumeLayout(false);
            this.tableSearch.PerformLayout();
            this.tableComboboxes.ResumeLayout(false);
            this.tableSpace2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabReservationsBorrowings.ResumeLayout(false);
            this.tableLayoutPanel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabMainPage;
        private System.Windows.Forms.TableLayoutPanel tableDataGridView;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishHouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pages;
        private System.Windows.Forms.TableLayoutPanel tableBottomSpace;
        private System.Windows.Forms.TableLayoutPanel tableSearch;
        private System.Windows.Forms.TextBox textSearchMaterial;
        private System.Windows.Forms.Button btnSearchMaterial;
        private System.Windows.Forms.TableLayoutPanel tableComboboxes;
        private System.Windows.Forms.ComboBox comboSortMaterial;
        private System.Windows.Forms.ComboBox comboMaterialType;
        private System.Windows.Forms.TableLayoutPanel tableButtons;
        private System.Windows.Forms.TableLayoutPanel tableSpace2;
        private System.Windows.Forms.Button btnAddMaterial;
        private System.Windows.Forms.Button btnUpdateMaterial;
        private System.Windows.Forms.Button btnDeleteMaterial;
        private System.Windows.Forms.TableLayoutPanel tableSpace1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.TableLayoutPanel tableHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFooterTitleCreate;
        private System.Windows.Forms.TabPage tabReservationsBorrowings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Button btnBorrowings;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.Button btnReturns;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.Label label22;
    }
}