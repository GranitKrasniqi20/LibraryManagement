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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MembersForm));
            this.tableHeader = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.panelFullBody = new System.Windows.Forms.Panel();
            this.tabControlMembersForm = new System.Windows.Forms.TabControl();
            this.tabMainPage = new System.Windows.Forms.TabPage();
            this.tabExpiredMembers = new System.Windows.Forms.TabPage();
            this.tableSpace1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableSpace2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.tableButtons = new System.Windows.Forms.TableLayoutPanel();
            this.tableSearch = new System.Windows.Forms.TableLayoutPanel();
            this.textSearchMember = new System.Windows.Forms.TextBox();
            this.comboSortMember = new System.Windows.Forms.ComboBox();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.tableDataGridView = new System.Windows.Forms.TableLayoutPanel();
            this.tableSpaceBottom = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.IDCOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonalNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubscriptionPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoColBtn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.panelFullBody.SuspendLayout();
            this.tabControlMembersForm.SuspendLayout();
            this.tabMainPage.SuspendLayout();
            this.tableSpace2.SuspendLayout();
            this.tableSearch.SuspendLayout();
            this.tableSpaceBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
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
            this.tableHeader.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.lblTitle.TabIndex = 1;
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
            this.tabMainPage.Controls.Add(this.tableSpaceBottom);
            this.tabMainPage.Controls.Add(this.tableDataGridView);
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
            // tabExpiredMembers
            // 
            this.tabExpiredMembers.Location = new System.Drawing.Point(4, 32);
            this.tabExpiredMembers.Name = "tabExpiredMembers";
            this.tabExpiredMembers.Padding = new System.Windows.Forms.Padding(3);
            this.tabExpiredMembers.Size = new System.Drawing.Size(732, 493);
            this.tabExpiredMembers.TabIndex = 1;
            this.tabExpiredMembers.Text = "Expired Members";
            this.tabExpiredMembers.UseVisualStyleBackColor = true;
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
            this.tableSpace1.TabIndex = 2;
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
            this.tableSpace2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSpace2.Controls.Add(this.btnAddMember, 1, 0);
            this.tableSpace2.Controls.Add(this.btnUpdateMember, 3, 0);
            this.tableSpace2.Controls.Add(this.btnDeleteMember, 5, 0);
            this.tableSpace2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableSpace2.Location = new System.Drawing.Point(3, 19);
            this.tableSpace2.Name = "tableSpace2";
            this.tableSpace2.RowCount = 1;
            this.tableSpace2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSpace2.Size = new System.Drawing.Size(726, 62);
            this.tableSpace2.TabIndex = 4;
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
            this.btnAddMember.TabIndex = 0;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = false;
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
            this.btnUpdateMember.TabIndex = 1;
            this.btnUpdateMember.Text = "Update Member";
            this.btnUpdateMember.UseVisualStyleBackColor = false;
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
            this.btnDeleteMember.TabIndex = 2;
            this.btnDeleteMember.Text = "Delete Member";
            this.btnDeleteMember.UseVisualStyleBackColor = false;
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
            this.tableButtons.TabIndex = 5;
            // 
            // tableSearch
            // 
            this.tableSearch.ColumnCount = 7;
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.6864F));
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.3136F));
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tableSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableSearch.Controls.Add(this.textSearchMember, 1, 0);
            this.tableSearch.Controls.Add(this.comboSortMember, 3, 0);
            this.tableSearch.Controls.Add(this.btnSearchMember, 5, 0);
            this.tableSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableSearch.Location = new System.Drawing.Point(3, 97);
            this.tableSearch.Name = "tableSearch";
            this.tableSearch.RowCount = 1;
            this.tableSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSearch.Size = new System.Drawing.Size(726, 53);
            this.tableSearch.TabIndex = 6;
            // 
            // textSearchMember
            // 
            this.textSearchMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.textSearchMember.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchMember.Location = new System.Drawing.Point(23, 3);
            this.textSearchMember.Name = "textSearchMember";
            this.textSearchMember.Size = new System.Drawing.Size(268, 39);
            this.textSearchMember.TabIndex = 0;
            // 
            // comboSortMember
            // 
            this.comboSortMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboSortMember.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSortMember.FormattingEnabled = true;
            this.comboSortMember.Location = new System.Drawing.Point(310, 3);
            this.comboSortMember.Name = "comboSortMember";
            this.comboSortMember.Size = new System.Drawing.Size(144, 40);
            this.comboSortMember.TabIndex = 1;
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.btnSearchMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchMember.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMember.ForeColor = System.Drawing.Color.White;
            this.btnSearchMember.Location = new System.Drawing.Point(472, 3);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(229, 40);
            this.btnSearchMember.TabIndex = 2;
            this.btnSearchMember.Text = "Search";
            this.btnSearchMember.UseVisualStyleBackColor = false;
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.ColumnCount = 1;
            this.tableDataGridView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableDataGridView.Location = new System.Drawing.Point(3, 468);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.RowCount = 1;
            this.tableDataGridView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDataGridView.Size = new System.Drawing.Size(726, 22);
            this.tableDataGridView.TabIndex = 8;
            // 
            // tableSpaceBottom
            // 
            this.tableSpaceBottom.ColumnCount = 3;
            this.tableSpaceBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSpaceBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSpaceBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSpaceBottom.Controls.Add(this.dgvMembers, 1, 0);
            this.tableSpaceBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableSpaceBottom.Location = new System.Drawing.Point(3, 150);
            this.tableSpaceBottom.Name = "tableSpaceBottom";
            this.tableSpaceBottom.RowCount = 1;
            this.tableSpaceBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSpaceBottom.Size = new System.Drawing.Size(726, 318);
            this.tableSpaceBottom.TabIndex = 9;
            // 
            // dgvMembers
            // 
            this.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCOL,
            this.FirstName,
            this.LastName,
            this.Address,
            this.Birthdate,
            this.Gender,
            this.PersonalNumber,
            this.Email,
            this.PhoneNumber,
            this.SubscriptionPlan,
            this.FromDate,
            this.TillDate,
            this.InfoColBtn});
            this.dgvMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMembers.Location = new System.Drawing.Point(23, 3);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.Size = new System.Drawing.Size(680, 312);
            this.dgvMembers.TabIndex = 0;
            // 
            // IDCOL
            // 
            this.IDCOL.HeaderText = "ID";
            this.IDCOL.Name = "IDCOL";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // Birthdate
            // 
            this.Birthdate.HeaderText = "Birthdate";
            this.Birthdate.Name = "Birthdate";
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            // 
            // PersonalNumber
            // 
            this.PersonalNumber.HeaderText = "Personal Number";
            this.PersonalNumber.Name = "PersonalNumber";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // SubscriptionPlan
            // 
            this.SubscriptionPlan.HeaderText = "Subscription Plan";
            this.SubscriptionPlan.Name = "SubscriptionPlan";
            // 
            // FromDate
            // 
            this.FromDate.HeaderText = "From:";
            this.FromDate.Name = "FromDate";
            // 
            // TillDate
            // 
            this.TillDate.HeaderText = "Till:";
            this.TillDate.Name = "TillDate";
            // 
            // InfoColBtn
            // 
            this.InfoColBtn.HeaderText = "More Info";
            this.InfoColBtn.Name = "InfoColBtn";
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
            this.Text = "MembersForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.panelFullBody.ResumeLayout(false);
            this.tabControlMembersForm.ResumeLayout(false);
            this.tabMainPage.ResumeLayout(false);
            this.tableSpace2.ResumeLayout(false);
            this.tableSearch.ResumeLayout(false);
            this.tableSearch.PerformLayout();
            this.tableSpaceBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picTitle;
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
        private System.Windows.Forms.TextBox textSearchMember;
        private System.Windows.Forms.ComboBox comboSortMember;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.TableLayoutPanel tableDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableSpaceBottom;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonalNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubscriptionPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfoColBtn;
    }
}