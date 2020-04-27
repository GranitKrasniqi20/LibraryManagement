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
            this.tableHeader = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.tabControlMaterialsForm = new System.Windows.Forms.TabControl();
            this.tabMainPage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableSpace1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableSpace2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddMaterial = new System.Windows.Forms.Button();
            this.btnUpdateMaterial = new System.Windows.Forms.Button();
            this.btnDeleteMaterial = new System.Windows.Forms.Button();
            this.tableButtons = new System.Windows.Forms.TableLayoutPanel();
            this.tableComboboxes = new System.Windows.Forms.TableLayoutPanel();
            this.comboSortMaterial = new System.Windows.Forms.ComboBox();
            this.comboMaterialType = new System.Windows.Forms.ComboBox();
            this.tableSearch = new System.Windows.Forms.TableLayoutPanel();
            this.textSearchMaterial = new System.Windows.Forms.TextBox();
            this.tableBottomSpace = new System.Windows.Forms.TableLayoutPanel();
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
            this.btnSearchMaterial = new System.Windows.Forms.Button();
            this.tableHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.tabControlMaterialsForm.SuspendLayout();
            this.tabMainPage.SuspendLayout();
            this.tableSpace2.SuspendLayout();
            this.tableComboboxes.SuspendLayout();
            this.tableSearch.SuspendLayout();
            this.tableDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.SuspendLayout();
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
            this.lblTitle.Location = new System.Drawing.Point(140, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(224, 50);
            this.lblTitle.TabIndex = 1;
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
            // tabControlMaterialsForm
            // 
            this.tabControlMaterialsForm.Controls.Add(this.tabMainPage);
            this.tabControlMaterialsForm.Controls.Add(this.tabPage2);
            this.tabControlMaterialsForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMaterialsForm.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMaterialsForm.Location = new System.Drawing.Point(0, 88);
            this.tabControlMaterialsForm.Name = "tabControlMaterialsForm";
            this.tabControlMaterialsForm.Padding = new System.Drawing.Point(12, 8);
            this.tabControlMaterialsForm.SelectedIndex = 0;
            this.tabControlMaterialsForm.Size = new System.Drawing.Size(740, 529);
            this.tabControlMaterialsForm.TabIndex = 3;
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(732, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Other Tab";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.tableSpace1.TabIndex = 3;
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
            this.btnAddMaterial.TabIndex = 0;
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
            this.btnUpdateMaterial.TabIndex = 1;
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
            this.btnDeleteMaterial.TabIndex = 2;
            this.btnDeleteMaterial.Text = "Delete Material";
            this.btnDeleteMaterial.UseVisualStyleBackColor = false;
            this.btnDeleteMaterial.Click += new System.EventHandler(this.btnDeleteMaterial_Click);
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
            this.tableButtons.TabIndex = 6;
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
            this.tableComboboxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableComboboxes.Size = new System.Drawing.Size(726, 53);
            this.tableComboboxes.TabIndex = 7;
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
            this.comboSortMaterial.TabIndex = 1;
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
            this.comboMaterialType.TabIndex = 2;
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
            this.tableSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSearch.Size = new System.Drawing.Size(726, 53);
            this.tableSearch.TabIndex = 8;
            // 
            // textSearchMaterial
            // 
            this.textSearchMaterial.Dock = System.Windows.Forms.DockStyle.Top;
            this.textSearchMaterial.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchMaterial.Location = new System.Drawing.Point(23, 3);
            this.textSearchMaterial.Name = "textSearchMaterial";
            this.textSearchMaterial.Size = new System.Drawing.Size(431, 39);
            this.textSearchMaterial.TabIndex = 0;
            // 
            // tableBottomSpace
            // 
            this.tableBottomSpace.ColumnCount = 1;
            this.tableBottomSpace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBottomSpace.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableBottomSpace.Location = new System.Drawing.Point(3, 468);
            this.tableBottomSpace.Name = "tableBottomSpace";
            this.tableBottomSpace.RowCount = 1;
            this.tableBottomSpace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBottomSpace.Size = new System.Drawing.Size(726, 22);
            this.tableBottomSpace.TabIndex = 9;
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
            this.tableDataGridView.TabIndex = 10;
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
            this.dgvMembers.TabIndex = 0;
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
            // btnSearchMaterial
            // 
            this.btnSearchMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.btnSearchMaterial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchMaterial.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMaterial.ForeColor = System.Drawing.Color.White;
            this.btnSearchMaterial.Location = new System.Drawing.Point(472, 3);
            this.btnSearchMaterial.Name = "btnSearchMaterial";
            this.btnSearchMaterial.Size = new System.Drawing.Size(229, 40);
            this.btnSearchMaterial.TabIndex = 2;
            this.btnSearchMaterial.Text = "Search";
            this.btnSearchMaterial.UseVisualStyleBackColor = false;
            // 
            // MaterialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 617);
            this.Controls.Add(this.tabControlMaterialsForm);
            this.Controls.Add(this.tableHeader);
            this.Name = "MaterialsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaterialsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.tabControlMaterialsForm.ResumeLayout(false);
            this.tabMainPage.ResumeLayout(false);
            this.tableSpace2.ResumeLayout(false);
            this.tableComboboxes.ResumeLayout(false);
            this.tableSearch.ResumeLayout(false);
            this.tableSearch.PerformLayout();
            this.tableDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.TabControl tabControlMaterialsForm;
        private System.Windows.Forms.TabPage tabMainPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableSpace1;
        private System.Windows.Forms.TableLayoutPanel tableSpace2;
        private System.Windows.Forms.Button btnAddMaterial;
        private System.Windows.Forms.Button btnUpdateMaterial;
        private System.Windows.Forms.Button btnDeleteMaterial;
        private System.Windows.Forms.TableLayoutPanel tableButtons;
        private System.Windows.Forms.TableLayoutPanel tableComboboxes;
        private System.Windows.Forms.ComboBox comboSortMaterial;
        private System.Windows.Forms.ComboBox comboMaterialType;
        private System.Windows.Forms.TableLayoutPanel tableSearch;
        private System.Windows.Forms.TextBox textSearchMaterial;
        private System.Windows.Forms.TableLayoutPanel tableBottomSpace;
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
        private System.Windows.Forms.Button btnSearchMaterial;
    }
}