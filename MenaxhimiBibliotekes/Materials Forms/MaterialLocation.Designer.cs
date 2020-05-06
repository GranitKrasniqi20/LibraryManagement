namespace MenaxhimiBibliotekes.Materials_Forms
{
    partial class MaterialLocation
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCreateLocation = new System.Windows.Forms.TabPage();
            this.btnInsert = new System.Windows.Forms.Button();
            this.richCreateDescription = new System.Windows.Forms.RichTextBox();
            this.txtCreateMaterialLocation = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblUnique = new System.Windows.Forms.Label();
            this.lblMaterialLocationCreate = new System.Windows.Forms.Label();
            this.tabUpdateLocation = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUpdateSearch = new System.Windows.Forms.Label();
            this.btnUpdateSearchLocation = new System.Windows.Forms.Button();
            this.txtUpdateSearch = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.richUpdateDescription = new System.Windows.Forms.RichTextBox();
            this.txtUpdateMaterialLocation = new System.Windows.Forms.TextBox();
            this.lblUpdateMaterialLocationNaem = new System.Windows.Forms.Label();
            this.lblUpdateMaterialDescription = new System.Windows.Forms.Label();
            this.tabDeleteLocation = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDeleteMaterialLocation = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDeleteSearch = new System.Windows.Forms.Label();
            this.btnDeleteSearch = new System.Windows.Forms.Button();
            this.txtDeleteSearch = new System.Windows.Forms.TextBox();
            this.txtDeleteMaterialLocation = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabCreateLocation.SuspendLayout();
            this.tabUpdateLocation.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabDeleteLocation.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCreateLocation);
            this.tabControl.Controls.Add(this.tabUpdateLocation);
            this.tabControl.Controls.Add(this.tabDeleteLocation);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(586, 686);
            this.tabControl.TabIndex = 0;
            // 
            // tabCreateLocation
            // 
            this.tabCreateLocation.Controls.Add(this.btnInsert);
            this.tabCreateLocation.Controls.Add(this.richCreateDescription);
            this.tabCreateLocation.Controls.Add(this.txtCreateMaterialLocation);
            this.tabCreateLocation.Controls.Add(this.lblDescription);
            this.tabCreateLocation.Controls.Add(this.lblUnique);
            this.tabCreateLocation.Controls.Add(this.lblMaterialLocationCreate);
            this.tabCreateLocation.Location = new System.Drawing.Point(4, 26);
            this.tabCreateLocation.Name = "tabCreateLocation";
            this.tabCreateLocation.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreateLocation.Size = new System.Drawing.Size(578, 656);
            this.tabCreateLocation.TabIndex = 0;
            this.tabCreateLocation.Text = "Create Location";
            this.tabCreateLocation.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(167, 456);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(231, 58);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Insert Location";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // richCreateDescription
            // 
            this.richCreateDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richCreateDescription.Location = new System.Drawing.Point(120, 284);
            this.richCreateDescription.Name = "richCreateDescription";
            this.richCreateDescription.Size = new System.Drawing.Size(315, 131);
            this.richCreateDescription.TabIndex = 8;
            this.richCreateDescription.Text = "";
            // 
            // txtCreateMaterialLocation
            // 
            this.txtCreateMaterialLocation.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateMaterialLocation.Location = new System.Drawing.Point(120, 168);
            this.txtCreateMaterialLocation.Name = "txtCreateMaterialLocation";
            this.txtCreateMaterialLocation.Size = new System.Drawing.Size(315, 35);
            this.txtCreateMaterialLocation.TabIndex = 7;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(181, 256);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(201, 25);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Location Description:";
            // 
            // lblUnique
            // 
            this.lblUnique.AutoSize = true;
            this.lblUnique.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnique.Location = new System.Drawing.Point(200, 115);
            this.lblUnique.Name = "lblUnique";
            this.lblUnique.Size = new System.Drawing.Size(161, 25);
            this.lblUnique.TabIndex = 5;
            this.lblUnique.Text = "(Must be unique!)";
            // 
            // lblMaterialLocationCreate
            // 
            this.lblMaterialLocationCreate.AutoSize = true;
            this.lblMaterialLocationCreate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialLocationCreate.Location = new System.Drawing.Point(169, 140);
            this.lblMaterialLocationCreate.Name = "lblMaterialLocationCreate";
            this.lblMaterialLocationCreate.Size = new System.Drawing.Size(229, 25);
            this.lblMaterialLocationCreate.TabIndex = 6;
            this.lblMaterialLocationCreate.Text = "Material Location Name:";
            // 
            // tabUpdateLocation
            // 
            this.tabUpdateLocation.Controls.Add(this.panel1);
            this.tabUpdateLocation.Controls.Add(this.btnUpdate);
            this.tabUpdateLocation.Controls.Add(this.richUpdateDescription);
            this.tabUpdateLocation.Controls.Add(this.txtUpdateMaterialLocation);
            this.tabUpdateLocation.Controls.Add(this.lblUpdateMaterialLocationNaem);
            this.tabUpdateLocation.Controls.Add(this.lblUpdateMaterialDescription);
            this.tabUpdateLocation.Location = new System.Drawing.Point(4, 26);
            this.tabUpdateLocation.Name = "tabUpdateLocation";
            this.tabUpdateLocation.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdateLocation.Size = new System.Drawing.Size(578, 656);
            this.tabUpdateLocation.TabIndex = 1;
            this.tabUpdateLocation.Text = "Update Location";
            this.tabUpdateLocation.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblUpdateSearch);
            this.panel1.Controls.Add(this.btnUpdateSearchLocation);
            this.panel1.Controls.Add(this.txtUpdateSearch);
            this.panel1.Location = new System.Drawing.Point(8, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 100);
            this.panel1.TabIndex = 15;
            // 
            // lblUpdateSearch
            // 
            this.lblUpdateSearch.AutoSize = true;
            this.lblUpdateSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateSearch.Location = new System.Drawing.Point(41, 16);
            this.lblUpdateSearch.Name = "lblUpdateSearch";
            this.lblUpdateSearch.Size = new System.Drawing.Size(158, 25);
            this.lblUpdateSearch.TabIndex = 11;
            this.lblUpdateSearch.Text = "Search Location:";
            // 
            // btnUpdateSearchLocation
            // 
            this.btnUpdateSearchLocation.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSearchLocation.Location = new System.Drawing.Point(313, 21);
            this.btnUpdateSearchLocation.Name = "btnUpdateSearchLocation";
            this.btnUpdateSearchLocation.Size = new System.Drawing.Size(191, 58);
            this.btnUpdateSearchLocation.TabIndex = 14;
            this.btnUpdateSearchLocation.Text = "Search";
            this.btnUpdateSearchLocation.UseVisualStyleBackColor = true;
            // 
            // txtUpdateSearch
            // 
            this.txtUpdateSearch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateSearch.Location = new System.Drawing.Point(46, 44);
            this.txtUpdateSearch.Name = "txtUpdateSearch";
            this.txtUpdateSearch.Size = new System.Drawing.Size(224, 35);
            this.txtUpdateSearch.TabIndex = 12;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(129, 516);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(316, 58);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update Location";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // richUpdateDescription
            // 
            this.richUpdateDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richUpdateDescription.Location = new System.Drawing.Point(129, 298);
            this.richUpdateDescription.Name = "richUpdateDescription";
            this.richUpdateDescription.Size = new System.Drawing.Size(316, 185);
            this.richUpdateDescription.TabIndex = 13;
            this.richUpdateDescription.Text = "";
            // 
            // txtUpdateMaterialLocation
            // 
            this.txtUpdateMaterialLocation.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateMaterialLocation.Location = new System.Drawing.Point(177, 203);
            this.txtUpdateMaterialLocation.Name = "txtUpdateMaterialLocation";
            this.txtUpdateMaterialLocation.Size = new System.Drawing.Size(224, 35);
            this.txtUpdateMaterialLocation.TabIndex = 12;
            // 
            // lblUpdateMaterialLocationNaem
            // 
            this.lblUpdateMaterialLocationNaem.AutoSize = true;
            this.lblUpdateMaterialLocationNaem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateMaterialLocationNaem.Location = new System.Drawing.Point(172, 175);
            this.lblUpdateMaterialLocationNaem.Name = "lblUpdateMaterialLocationNaem";
            this.lblUpdateMaterialLocationNaem.Size = new System.Drawing.Size(229, 25);
            this.lblUpdateMaterialLocationNaem.TabIndex = 11;
            this.lblUpdateMaterialLocationNaem.Text = "Material Location Name:";
            // 
            // lblUpdateMaterialDescription
            // 
            this.lblUpdateMaterialDescription.AutoSize = true;
            this.lblUpdateMaterialDescription.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateMaterialDescription.Location = new System.Drawing.Point(172, 270);
            this.lblUpdateMaterialDescription.Name = "lblUpdateMaterialDescription";
            this.lblUpdateMaterialDescription.Size = new System.Drawing.Size(229, 25);
            this.lblUpdateMaterialDescription.TabIndex = 10;
            this.lblUpdateMaterialDescription.Text = "Material Location Name:";
            // 
            // tabDeleteLocation
            // 
            this.tabDeleteLocation.Controls.Add(this.btnDelete);
            this.tabDeleteLocation.Controls.Add(this.lblDeleteMaterialLocation);
            this.tabDeleteLocation.Controls.Add(this.panel2);
            this.tabDeleteLocation.Controls.Add(this.txtDeleteMaterialLocation);
            this.tabDeleteLocation.Location = new System.Drawing.Point(4, 26);
            this.tabDeleteLocation.Name = "tabDeleteLocation";
            this.tabDeleteLocation.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeleteLocation.Size = new System.Drawing.Size(578, 656);
            this.tabDeleteLocation.TabIndex = 2;
            this.tabDeleteLocation.Text = "Delete Location";
            this.tabDeleteLocation.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(62, 338);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(458, 58);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Update Location";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblDeleteMaterialLocation
            // 
            this.lblDeleteMaterialLocation.AutoSize = true;
            this.lblDeleteMaterialLocation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteMaterialLocation.Location = new System.Drawing.Point(57, 263);
            this.lblDeleteMaterialLocation.Name = "lblDeleteMaterialLocation";
            this.lblDeleteMaterialLocation.Size = new System.Drawing.Size(229, 25);
            this.lblDeleteMaterialLocation.TabIndex = 17;
            this.lblDeleteMaterialLocation.Text = "Material Location Name:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblDeleteSearch);
            this.panel2.Controls.Add(this.btnDeleteSearch);
            this.panel2.Controls.Add(this.txtDeleteSearch);
            this.panel2.Location = new System.Drawing.Point(14, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 100);
            this.panel2.TabIndex = 16;
            // 
            // lblDeleteSearch
            // 
            this.lblDeleteSearch.AutoSize = true;
            this.lblDeleteSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteSearch.Location = new System.Drawing.Point(41, 16);
            this.lblDeleteSearch.Name = "lblDeleteSearch";
            this.lblDeleteSearch.Size = new System.Drawing.Size(158, 25);
            this.lblDeleteSearch.TabIndex = 11;
            this.lblDeleteSearch.Text = "Search Location:";
            // 
            // btnDeleteSearch
            // 
            this.btnDeleteSearch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSearch.Location = new System.Drawing.Point(313, 21);
            this.btnDeleteSearch.Name = "btnDeleteSearch";
            this.btnDeleteSearch.Size = new System.Drawing.Size(191, 58);
            this.btnDeleteSearch.TabIndex = 14;
            this.btnDeleteSearch.Text = "Search";
            this.btnDeleteSearch.UseVisualStyleBackColor = true;
            // 
            // txtDeleteSearch
            // 
            this.txtDeleteSearch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeleteSearch.Location = new System.Drawing.Point(46, 44);
            this.txtDeleteSearch.Name = "txtDeleteSearch";
            this.txtDeleteSearch.Size = new System.Drawing.Size(224, 35);
            this.txtDeleteSearch.TabIndex = 12;
            // 
            // txtDeleteMaterialLocation
            // 
            this.txtDeleteMaterialLocation.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeleteMaterialLocation.Location = new System.Drawing.Point(329, 253);
            this.txtDeleteMaterialLocation.Name = "txtDeleteMaterialLocation";
            this.txtDeleteMaterialLocation.Size = new System.Drawing.Size(191, 35);
            this.txtDeleteMaterialLocation.TabIndex = 12;
            // 
            // MaterialLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 686);
            this.Controls.Add(this.tabControl);
            this.Name = "MaterialLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Material Location";
            this.tabControl.ResumeLayout(false);
            this.tabCreateLocation.ResumeLayout(false);
            this.tabCreateLocation.PerformLayout();
            this.tabUpdateLocation.ResumeLayout(false);
            this.tabUpdateLocation.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabDeleteLocation.ResumeLayout(false);
            this.tabDeleteLocation.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCreateLocation;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.RichTextBox richCreateDescription;
        private System.Windows.Forms.TextBox txtCreateMaterialLocation;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblUnique;
        private System.Windows.Forms.Label lblMaterialLocationCreate;
        private System.Windows.Forms.TabPage tabUpdateLocation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUpdateSearch;
        private System.Windows.Forms.Button btnUpdateSearchLocation;
        private System.Windows.Forms.TextBox txtUpdateSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RichTextBox richUpdateDescription;
        private System.Windows.Forms.TextBox txtUpdateMaterialLocation;
        private System.Windows.Forms.Label lblUpdateMaterialLocationNaem;
        private System.Windows.Forms.Label lblUpdateMaterialDescription;
        private System.Windows.Forms.TabPage tabDeleteLocation;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDeleteMaterialLocation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDeleteSearch;
        private System.Windows.Forms.Button btnDeleteSearch;
        private System.Windows.Forms.TextBox txtDeleteSearch;
        private System.Windows.Forms.TextBox txtDeleteMaterialLocation;
    }
}