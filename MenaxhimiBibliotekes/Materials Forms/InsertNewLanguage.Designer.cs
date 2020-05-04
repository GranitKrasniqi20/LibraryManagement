namespace MenaxhimiBibliotekes.Materials_Forms
{
    partial class InsertNewLanguage
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.lblInsert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(95, 142);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(130, 47);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // txtInsert
            // 
            this.txtInsert.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsert.Location = new System.Drawing.Point(61, 88);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(194, 33);
            this.txtInsert.TabIndex = 4;
            // 
            // lblInsert
            // 
            this.lblInsert.AutoSize = true;
            this.lblInsert.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsert.Location = new System.Drawing.Point(56, 46);
            this.lblInsert.Name = "lblInsert";
            this.lblInsert.Size = new System.Drawing.Size(202, 25);
            this.lblInsert.TabIndex = 3;
            this.lblInsert.Text = "Insert New Language";
            // 
            // InsertNewLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 246);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtInsert);
            this.Controls.Add(this.lblInsert);
            this.MaximumSize = new System.Drawing.Size(340, 285);
            this.MinimumSize = new System.Drawing.Size(340, 285);
            this.Name = "InsertNewLanguage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert New Language (Stackbooks)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.Label lblInsert;
    }
}