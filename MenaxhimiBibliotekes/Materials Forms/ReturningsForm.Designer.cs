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
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.tableHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panelMainBody.SuspendLayout();
            this.tableContents.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // tableHeader
            // 
            this.tableHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            resources.ApplyResources(this.tableHeader, "tableHeader");
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
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.btnRegisterReturn, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnCalculateMaterialDamage, 3, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // btnRegisterReturn
            // 
            this.btnRegisterReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            resources.ApplyResources(this.btnRegisterReturn, "btnRegisterReturn");
            this.btnRegisterReturn.ForeColor = System.Drawing.Color.White;
            this.btnRegisterReturn.Name = "btnRegisterReturn";
            this.btnRegisterReturn.UseVisualStyleBackColor = false;
            this.btnRegisterReturn.Click += new System.EventHandler(this.BtnRegisterReturn_Click);
            // 
            // btnCalculateMaterialDamage
            // 
            this.btnCalculateMaterialDamage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            resources.ApplyResources(this.btnCalculateMaterialDamage, "btnCalculateMaterialDamage");
            this.btnCalculateMaterialDamage.ForeColor = System.Drawing.Color.White;
            this.btnCalculateMaterialDamage.Name = "btnCalculateMaterialDamage";
            this.btnCalculateMaterialDamage.UseVisualStyleBackColor = false;
            this.btnCalculateMaterialDamage.Click += new System.EventHandler(this.BtnCalculateMaterialDamage_Click);
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.lblFooter, 1, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // lblFooter
            // 
            resources.ApplyResources(this.lblFooter, "lblFooter");
            this.lblFooter.Name = "lblFooter";
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.lblInfo, 1, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // lblInfo
            // 
            resources.ApplyResources(this.lblInfo, "lblInfo");
            this.lblInfo.Name = "lblInfo";
            // 
            // panelMainBody
            // 
            resources.ApplyResources(this.panelMainBody, "panelMainBody");
            this.panelMainBody.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMainBody.Controls.Add(this.tableContents);
            this.panelMainBody.Controls.Add(this.tableLayoutPanel9);
            this.panelMainBody.Controls.Add(this.tableLayoutPanel8);
            this.panelMainBody.Name = "panelMainBody";
            // 
            // tableContents
            // 
            resources.ApplyResources(this.tableContents, "tableContents");
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
            this.tableContents.Name = "tableContents";
            // 
            // tableLayoutPanel18
            // 
            resources.ApplyResources(this.tableLayoutPanel18, "tableLayoutPanel18");
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            // 
            // txtMemberID
            // 
            resources.ApplyResources(this.txtMemberID, "txtMemberID");
            this.txtMemberID.Name = "txtMemberID";
            // 
            // txtMemberFullName
            // 
            resources.ApplyResources(this.txtMemberFullName, "txtMemberFullName");
            this.txtMemberFullName.Name = "txtMemberFullName";
            // 
            // txtMaterialName
            // 
            resources.ApplyResources(this.txtMaterialName, "txtMaterialName");
            this.txtMaterialName.Name = "txtMaterialName";
            // 
            // txtMaterialType
            // 
            resources.ApplyResources(this.txtMaterialType, "txtMaterialType");
            this.txtMaterialType.Name = "txtMaterialType";
            // 
            // txtLocated
            // 
            resources.ApplyResources(this.txtLocated, "txtLocated");
            this.txtLocated.Name = "txtLocated";
            // 
            // lblLocated
            // 
            resources.ApplyResources(this.lblLocated, "lblLocated");
            this.lblLocated.Name = "lblLocated";
            // 
            // lblMaterialType
            // 
            resources.ApplyResources(this.lblMaterialType, "lblMaterialType");
            this.lblMaterialType.Name = "lblMaterialType";
            // 
            // lblMaterialName
            // 
            resources.ApplyResources(this.lblMaterialName, "lblMaterialName");
            this.lblMaterialName.Name = "lblMaterialName";
            // 
            // lblMemberFullName
            // 
            resources.ApplyResources(this.lblMemberFullName, "lblMemberFullName");
            this.lblMemberFullName.Name = "lblMemberFullName";
            // 
            // lblMemberID
            // 
            resources.ApplyResources(this.lblMemberID, "lblMemberID");
            this.lblMemberID.Name = "lblMemberID";
            // 
            // lblBorrowedDate
            // 
            resources.ApplyResources(this.lblBorrowedDate, "lblBorrowedDate");
            this.lblBorrowedDate.Name = "lblBorrowedDate";
            // 
            // lblReturnDate
            // 
            resources.ApplyResources(this.lblReturnDate, "lblReturnDate");
            this.lblReturnDate.Name = "lblReturnDate";
            // 
            // lblReturnedInTime
            // 
            resources.ApplyResources(this.lblReturnedInTime, "lblReturnedInTime");
            this.lblReturnedInTime.Name = "lblReturnedInTime";
            // 
            // txtBorrowedDate
            // 
            resources.ApplyResources(this.txtBorrowedDate, "txtBorrowedDate");
            this.txtBorrowedDate.Name = "txtBorrowedDate";
            // 
            // txtReturnDate
            // 
            resources.ApplyResources(this.txtReturnDate, "txtReturnDate");
            this.txtReturnDate.Name = "txtReturnDate";
            // 
            // txtReturnedInTime
            // 
            resources.ApplyResources(this.txtReturnedInTime, "txtReturnedInTime");
            this.txtReturnedInTime.Name = "txtReturnedInTime";
            // 
            // lblDelayFee
            // 
            resources.ApplyResources(this.lblDelayFee, "lblDelayFee");
            this.lblDelayFee.Name = "lblDelayFee";
            // 
            // txtDelayFee
            // 
            resources.ApplyResources(this.txtDelayFee, "txtDelayFee");
            this.txtDelayFee.Name = "txtDelayFee";
            // 
            // tableLayoutPanel9
            // 
            resources.ApplyResources(this.tableLayoutPanel9, "tableLayoutPanel9");
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            // 
            // tableLayoutPanel8
            // 
            resources.ApplyResources(this.tableLayoutPanel8, "tableLayoutPanel8");
            this.tableLayoutPanel8.Controls.Add(this.lblBorrowedID, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.txtBorrowedID, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.btnFind, 1, 2);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel8_Paint);
            // 
            // lblBorrowedID
            // 
            resources.ApplyResources(this.lblBorrowedID, "lblBorrowedID");
            this.lblBorrowedID.Name = "lblBorrowedID";
            // 
            // txtBorrowedID
            // 
            resources.ApplyResources(this.txtBorrowedID, "txtBorrowedID");
            this.txtBorrowedID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBorrowedID.Name = "txtBorrowedID";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            resources.ApplyResources(this.btnFind, "btnFind");
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Name = "btnFind";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // picTitle
            // 
            resources.ApplyResources(this.picTitle, "picTitle");
            this.picTitle.Name = "picTitle";
            this.picTitle.TabStop = false;
            // 
            // ReturningsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMainBody);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableHeader);
            this.Name = "ReturningsForm";
            this.Load += new System.EventHandler(this.ReturningsForm_Load);
            this.tableHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
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