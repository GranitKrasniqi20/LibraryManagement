namespace MenaxhimiBibliotekes.Materials_Forms
{
    partial class BorrowingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowingsForm));
            this.tableHeader = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableSpace3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableInfoTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tableSpace4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSubscriberID = new System.Windows.Forms.Label();
            this.lblMaterialID = new System.Windows.Forms.Label();
            this.txtSubscriberID = new System.Windows.Forms.TextBox();
            this.txtMaterialID = new System.Windows.Forms.TextBox();
            this.tableButtons = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBorrowNow = new System.Windows.Forms.Button();
            this.tableBottom2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFooter2 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tableContents = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblPersonalNumber = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.Label();
            this.txtPersonalNumber = new System.Windows.Forms.Label();
            this.lblMaterialName = new System.Windows.Forms.Label();
            this.lblMaterialType = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblReserved = new System.Windows.Forms.Label();
            this.lblLocated = new System.Windows.Forms.Label();
            this.txtMaterialName = new System.Windows.Forms.Label();
            this.txtMaterialType = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.Label();
            this.txtReserved = new System.Windows.Forms.Label();
            this.txtLocated = new System.Windows.Forms.Label();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.txtAvailability = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTill = new System.Windows.Forms.DateTimePicker();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.tableHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableInfoTitle.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableButtons.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableBottom2.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.tableContents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
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
            this.tableHeader.Size = new System.Drawing.Size(849, 88);
            this.tableHeader.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.picTitle);
            this.panel1.Location = new System.Drawing.Point(197, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 82);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(113, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(275, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BORROWINGS";
            // 
            // tableSpace3
            // 
            this.tableSpace3.ColumnCount = 1;
            this.tableSpace3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSpace3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableSpace3.Location = new System.Drawing.Point(0, 88);
            this.tableSpace3.Name = "tableSpace3";
            this.tableSpace3.RowCount = 1;
            this.tableSpace3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSpace3.Size = new System.Drawing.Size(849, 16);
            this.tableSpace3.TabIndex = 3;
            // 
            // tableInfoTitle
            // 
            this.tableInfoTitle.ColumnCount = 3;
            this.tableInfoTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableInfoTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableInfoTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableInfoTitle.Controls.Add(this.lblInfo, 1, 0);
            this.tableInfoTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableInfoTitle.Location = new System.Drawing.Point(0, 104);
            this.tableInfoTitle.Name = "tableInfoTitle";
            this.tableInfoTitle.RowCount = 1;
            this.tableInfoTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableInfoTitle.Size = new System.Drawing.Size(849, 44);
            this.tableInfoTitle.TabIndex = 8;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(23, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(343, 37);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Borrow Specific Material!";
            // 
            // tableSpace4
            // 
            this.tableSpace4.ColumnCount = 1;
            this.tableSpace4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSpace4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableSpace4.Location = new System.Drawing.Point(0, 148);
            this.tableSpace4.Name = "tableSpace4";
            this.tableSpace4.RowCount = 1;
            this.tableSpace4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSpace4.Size = new System.Drawing.Size(849, 15);
            this.tableSpace4.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 238);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(849, 64);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(23, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(803, 58);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click_1);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 5;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel6.Controls.Add(this.lblSubscriberID, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblMaterialID, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.txtSubscriberID, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.txtMaterialID, 3, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 163);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(849, 75);
            this.tableLayoutPanel6.TabIndex = 11;
            // 
            // lblSubscriberID
            // 
            this.lblSubscriberID.AutoSize = true;
            this.lblSubscriberID.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubscriberID.Location = new System.Drawing.Point(23, 0);
            this.lblSubscriberID.Name = "lblSubscriberID";
            this.lblSubscriberID.Size = new System.Drawing.Size(131, 25);
            this.lblSubscriberID.TabIndex = 1;
            this.lblSubscriberID.Text = "Subscriber ID:";
            // 
            // lblMaterialID
            // 
            this.lblMaterialID.AutoSize = true;
            this.lblMaterialID.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialID.Location = new System.Drawing.Point(437, 0);
            this.lblMaterialID.Name = "lblMaterialID";
            this.lblMaterialID.Size = new System.Drawing.Size(114, 25);
            this.lblMaterialID.TabIndex = 1;
            this.lblMaterialID.Text = "Material ID:";
            // 
            // txtSubscriberID
            // 
            this.txtSubscriberID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSubscriberID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubscriberID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSubscriberID.Location = new System.Drawing.Point(23, 40);
            this.txtSubscriberID.Name = "txtSubscriberID";
            this.txtSubscriberID.Size = new System.Drawing.Size(388, 33);
            this.txtSubscriberID.TabIndex = 2;
            // 
            // txtMaterialID
            // 
            this.txtMaterialID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaterialID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterialID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMaterialID.Location = new System.Drawing.Point(437, 40);
            this.txtMaterialID.Name = "txtMaterialID";
            this.txtMaterialID.Size = new System.Drawing.Size(388, 33);
            this.txtMaterialID.TabIndex = 2;
            // 
            // tableButtons
            // 
            this.tableButtons.ColumnCount = 3;
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableButtons.Controls.Add(this.panel2, 1, 0);
            this.tableButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableButtons.Location = new System.Drawing.Point(0, 555);
            this.tableButtons.Name = "tableButtons";
            this.tableButtons.RowCount = 1;
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButtons.Size = new System.Drawing.Size(849, 102);
            this.tableButtons.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.btnBorrowNow);
            this.panel2.Location = new System.Drawing.Point(139, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 59);
            this.panel2.TabIndex = 0;
            // 
            // btnBorrowNow
            // 
            this.btnBorrowNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.btnBorrowNow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBorrowNow.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowNow.ForeColor = System.Drawing.Color.White;
            this.btnBorrowNow.Location = new System.Drawing.Point(0, 0);
            this.btnBorrowNow.Name = "btnBorrowNow";
            this.btnBorrowNow.Size = new System.Drawing.Size(571, 59);
            this.btnBorrowNow.TabIndex = 2;
            this.btnBorrowNow.Text = "Borrow Now";
            this.btnBorrowNow.UseVisualStyleBackColor = false;
            this.btnBorrowNow.Click += new System.EventHandler(this.BtnBorrowNow_Click_1);
            // 
            // tableBottom2
            // 
            this.tableBottom2.ColumnCount = 3;
            this.tableBottom2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableBottom2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableBottom2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableBottom2.Controls.Add(this.lblFooter2, 1, 0);
            this.tableBottom2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableBottom2.Location = new System.Drawing.Point(0, 657);
            this.tableBottom2.Name = "tableBottom2";
            this.tableBottom2.RowCount = 1;
            this.tableBottom2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableBottom2.Size = new System.Drawing.Size(849, 24);
            this.tableBottom2.TabIndex = 18;
            // 
            // lblFooter2
            // 
            this.lblFooter2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFooter2.AutoSize = true;
            this.lblFooter2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter2.Location = new System.Drawing.Point(299, 3);
            this.lblFooter2.Name = "lblFooter2";
            this.lblFooter2.Size = new System.Drawing.Size(251, 17);
            this.lblFooter2.TabIndex = 11;
            this.lblFooter2.Text = "All Rights, Stackbooks Management System";
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.tableContents);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 302);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(849, 253);
            this.panelMain.TabIndex = 20;
            // 
            // tableContents
            // 
            this.tableContents.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableContents.ColumnCount = 9;
            this.tableContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableContents.Controls.Add(this.lblName, 1, 0);
            this.tableContents.Controls.Add(this.lblAddress, 1, 1);
            this.tableContents.Controls.Add(this.lblEmail, 1, 2);
            this.tableContents.Controls.Add(this.lblPhoneNumber, 1, 3);
            this.tableContents.Controls.Add(this.lblPersonalNumber, 1, 4);
            this.tableContents.Controls.Add(this.txtName, 3, 0);
            this.tableContents.Controls.Add(this.txtAddress, 3, 1);
            this.tableContents.Controls.Add(this.txtEmail, 3, 2);
            this.tableContents.Controls.Add(this.txtPhoneNumber, 3, 3);
            this.tableContents.Controls.Add(this.txtPersonalNumber, 3, 4);
            this.tableContents.Controls.Add(this.lblMaterialName, 5, 0);
            this.tableContents.Controls.Add(this.lblMaterialType, 5, 1);
            this.tableContents.Controls.Add(this.lblAuthor, 5, 2);
            this.tableContents.Controls.Add(this.lblReserved, 5, 3);
            this.tableContents.Controls.Add(this.lblLocated, 5, 4);
            this.tableContents.Controls.Add(this.txtMaterialName, 7, 0);
            this.tableContents.Controls.Add(this.txtMaterialType, 7, 1);
            this.tableContents.Controls.Add(this.txtAuthor, 7, 2);
            this.tableContents.Controls.Add(this.txtReserved, 7, 3);
            this.tableContents.Controls.Add(this.txtLocated, 7, 4);
            this.tableContents.Controls.Add(this.lblAvailability, 5, 5);
            this.tableContents.Controls.Add(this.txtAvailability, 7, 5);
            this.tableContents.Controls.Add(this.lblComment, 1, 5);
            this.tableContents.Controls.Add(this.txtComment, 3, 5);
            this.tableContents.Controls.Add(this.label1, 1, 6);
            this.tableContents.Controls.Add(this.dateFrom, 3, 6);
            this.tableContents.Controls.Add(this.label2, 5, 6);
            this.tableContents.Controls.Add(this.dateTill, 7, 6);
            this.tableContents.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableContents.Location = new System.Drawing.Point(0, 26);
            this.tableContents.Name = "tableContents";
            this.tableContents.RowCount = 7;
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableContents.Size = new System.Drawing.Size(832, 279);
            this.tableContents.TabIndex = 17;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(131, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(115, 46);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(85, 25);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address:";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(136, 85);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(64, 25);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(52, 124);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(148, 25);
            this.lblPhoneNumber.TabIndex = 1;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblPersonalNumber
            // 
            this.lblPersonalNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPersonalNumber.AutoSize = true;
            this.lblPersonalNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalNumber.Location = new System.Drawing.Point(80, 163);
            this.lblPersonalNumber.Name = "lblPersonalNumber";
            this.lblPersonalNumber.Size = new System.Drawing.Size(120, 25);
            this.lblPersonalNumber.TabIndex = 1;
            this.lblPersonalNumber.Text = "Personal No:";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(218, 7);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(36, 25);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "---";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAddress.AutoSize = true;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(218, 46);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(36, 25);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.Text = "---";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEmail.AutoSize = true;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(218, 85);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(36, 25);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "---";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPhoneNumber.AutoSize = true;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(218, 124);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(36, 25);
            this.txtPhoneNumber.TabIndex = 1;
            this.txtPhoneNumber.Text = "---";
            // 
            // txtPersonalNumber
            // 
            this.txtPersonalNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPersonalNumber.AutoSize = true;
            this.txtPersonalNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonalNumber.Location = new System.Drawing.Point(218, 163);
            this.txtPersonalNumber.Name = "txtPersonalNumber";
            this.txtPersonalNumber.Size = new System.Drawing.Size(36, 25);
            this.txtPersonalNumber.TabIndex = 1;
            this.txtPersonalNumber.Text = "---";
            // 
            // lblMaterialName
            // 
            this.lblMaterialName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMaterialName.AutoSize = true;
            this.lblMaterialName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialName.Location = new System.Drawing.Point(454, 7);
            this.lblMaterialName.Name = "lblMaterialName";
            this.lblMaterialName.Size = new System.Drawing.Size(146, 25);
            this.lblMaterialName.TabIndex = 1;
            this.lblMaterialName.Text = "Material Name:";
            // 
            // lblMaterialType
            // 
            this.lblMaterialType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMaterialType.AutoSize = true;
            this.lblMaterialType.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialType.Location = new System.Drawing.Point(466, 46);
            this.lblMaterialType.Name = "lblMaterialType";
            this.lblMaterialType.Size = new System.Drawing.Size(134, 25);
            this.lblMaterialType.TabIndex = 1;
            this.lblMaterialType.Text = "Material Type:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(522, 85);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(78, 25);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Author:";
            // 
            // lblReserved
            // 
            this.lblReserved.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblReserved.AutoSize = true;
            this.lblReserved.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserved.Location = new System.Drawing.Point(502, 124);
            this.lblReserved.Name = "lblReserved";
            this.lblReserved.Size = new System.Drawing.Size(98, 25);
            this.lblReserved.TabIndex = 1;
            this.lblReserved.Text = "Reserved?";
            // 
            // lblLocated
            // 
            this.lblLocated.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLocated.AutoSize = true;
            this.lblLocated.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocated.Location = new System.Drawing.Point(516, 163);
            this.lblLocated.Name = "lblLocated";
            this.lblLocated.Size = new System.Drawing.Size(84, 25);
            this.lblLocated.TabIndex = 1;
            this.lblLocated.Text = "Located:";
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMaterialName.AutoSize = true;
            this.txtMaterialName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterialName.Location = new System.Drawing.Point(626, 7);
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
            this.txtMaterialType.Location = new System.Drawing.Point(626, 46);
            this.txtMaterialType.Name = "txtMaterialType";
            this.txtMaterialType.Size = new System.Drawing.Size(36, 25);
            this.txtMaterialType.TabIndex = 1;
            this.txtMaterialType.Text = "---";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAuthor.AutoSize = true;
            this.txtAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(626, 85);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(36, 25);
            this.txtAuthor.TabIndex = 1;
            this.txtAuthor.Text = "---";
            // 
            // txtReserved
            // 
            this.txtReserved.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtReserved.AutoSize = true;
            this.txtReserved.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReserved.Location = new System.Drawing.Point(626, 124);
            this.txtReserved.Name = "txtReserved";
            this.txtReserved.Size = new System.Drawing.Size(36, 25);
            this.txtReserved.TabIndex = 1;
            this.txtReserved.Text = "---";
            // 
            // txtLocated
            // 
            this.txtLocated.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLocated.AutoSize = true;
            this.txtLocated.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocated.Location = new System.Drawing.Point(626, 163);
            this.txtLocated.Name = "txtLocated";
            this.txtLocated.Size = new System.Drawing.Size(36, 25);
            this.txtLocated.TabIndex = 1;
            this.txtLocated.Text = "---";
            // 
            // lblAvailability
            // 
            this.lblAvailability.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailability.Location = new System.Drawing.Point(487, 202);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(113, 25);
            this.lblAvailability.TabIndex = 1;
            this.lblAvailability.Text = "Availability:";
            // 
            // txtAvailability
            // 
            this.txtAvailability.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAvailability.AutoSize = true;
            this.txtAvailability.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailability.Location = new System.Drawing.Point(626, 202);
            this.txtAvailability.Name = "txtAvailability";
            this.txtAvailability.Size = new System.Drawing.Size(36, 25);
            this.txtAvailability.TabIndex = 1;
            this.txtAvailability.Text = "---";
            // 
            // lblComment
            // 
            this.lblComment.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.Location = new System.Drawing.Point(46, 202);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(154, 25);
            this.lblComment.TabIndex = 1;
            this.lblComment.Text = "Short Comment:";
            // 
            // txtComment
            // 
            this.txtComment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtComment.AutoSize = true;
            this.txtComment.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.Location = new System.Drawing.Point(218, 202);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(36, 25);
            this.txtComment.TabIndex = 1;
            this.txtComment.Text = "---";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "From:";
            // 
            // dateFrom
            // 
            this.dateFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(218, 237);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(177, 33);
            this.dateFrom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(558, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Till:";
            // 
            // dateTill
            // 
            this.dateTill.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTill.Location = new System.Drawing.Point(626, 237);
            this.dateTill.Name = "dateTill";
            this.dateTill.Size = new System.Drawing.Size(177, 33);
            this.dateTill.TabIndex = 2;
            // 
            // picTitle
            // 
            this.picTitle.Image = ((System.Drawing.Image)(resources.GetObject("picTitle.Image")));
            this.picTitle.Location = new System.Drawing.Point(61, 17);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(58, 50);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTitle.TabIndex = 0;
            this.picTitle.TabStop = false;
            // 
            // BorrowingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 681);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.tableButtons);
            this.Controls.Add(this.tableBottom2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.tableSpace4);
            this.Controls.Add(this.tableInfoTitle);
            this.Controls.Add(this.tableSpace3);
            this.Controls.Add(this.tableHeader);
            this.MaximumSize = new System.Drawing.Size(865, 720);
            this.MinimumSize = new System.Drawing.Size(865, 720);
            this.Name = "BorrowingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrowings (Stackbooks)";
            this.tableHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableInfoTitle.ResumeLayout(false);
            this.tableInfoTitle.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableButtons.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableBottom2.ResumeLayout(false);
            this.tableBottom2.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.tableContents.ResumeLayout(false);
            this.tableContents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.TableLayoutPanel tableSpace3;
        private System.Windows.Forms.TableLayoutPanel tableInfoTitle;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TableLayoutPanel tableSpace4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lblSubscriberID;
        private System.Windows.Forms.Label lblMaterialID;
        private System.Windows.Forms.TextBox txtSubscriberID;
        private System.Windows.Forms.TextBox txtMaterialID;
        private System.Windows.Forms.TableLayoutPanel tableButtons;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBorrowNow;
        private System.Windows.Forms.TableLayoutPanel tableBottom2;
        private System.Windows.Forms.Label lblFooter2;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TableLayoutPanel tableContents;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblPersonalNumber;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtAddress;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtPhoneNumber;
        private System.Windows.Forms.Label txtPersonalNumber;
        private System.Windows.Forms.Label lblMaterialName;
        private System.Windows.Forms.Label lblMaterialType;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblReserved;
        private System.Windows.Forms.Label lblLocated;
        private System.Windows.Forms.Label txtMaterialName;
        private System.Windows.Forms.Label txtMaterialType;
        private System.Windows.Forms.Label txtAuthor;
        private System.Windows.Forms.Label txtReserved;
        private System.Windows.Forms.Label txtLocated;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Label txtAvailability;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label txtComment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTill;
        private System.Windows.Forms.Button btnSearch;
    }
}