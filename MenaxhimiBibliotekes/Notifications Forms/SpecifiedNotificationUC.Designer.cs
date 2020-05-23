namespace MenaxhimiBibliotekes.Notifications_Forms
{
    partial class SpecifiedNotificationUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSquare = new System.Windows.Forms.Panel();
            this.pictureCategory = new System.Windows.Forms.PictureBox();
            this.txtNotificationMessage = new System.Windows.Forms.Label();
            this.txtNotificationDate = new System.Windows.Forms.Label();
            this.txtNotificationCategory = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelBorder = new System.Windows.Forms.Panel();
            this.panelSquare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSquare
            // 
            this.panelSquare.Controls.Add(this.pictureCategory);
            this.panelSquare.Location = new System.Drawing.Point(0, 0);
            this.panelSquare.Name = "panelSquare";
            this.panelSquare.Size = new System.Drawing.Size(87, 87);
            this.panelSquare.TabIndex = 0;
            // 
            // pictureCategory
            // 
            this.pictureCategory.Location = new System.Drawing.Point(18, 19);
            this.pictureCategory.Name = "pictureCategory";
            this.pictureCategory.Size = new System.Drawing.Size(50, 50);
            this.pictureCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCategory.TabIndex = 0;
            this.pictureCategory.TabStop = false;
            // 
            // txtNotificationMessage
            // 
            this.txtNotificationMessage.AutoSize = true;
            this.txtNotificationMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotificationMessage.Location = new System.Drawing.Point(89, 19);
            this.txtNotificationMessage.Name = "txtNotificationMessage";
            this.txtNotificationMessage.Size = new System.Drawing.Size(323, 21);
            this.txtNotificationMessage.TabIndex = 1;
            this.txtNotificationMessage.Text = "Notification Message is written in this part!";
            // 
            // txtNotificationDate
            // 
            this.txtNotificationDate.AutoSize = true;
            this.txtNotificationDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotificationDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNotificationDate.Location = new System.Drawing.Point(90, 52);
            this.txtNotificationDate.Name = "txtNotificationDate";
            this.txtNotificationDate.Size = new System.Drawing.Size(76, 17);
            this.txtNotificationDate.TabIndex = 1;
            this.txtNotificationDate.Text = "01/01/2020";
            // 
            // txtNotificationCategory
            // 
            this.txtNotificationCategory.AutoSize = true;
            this.txtNotificationCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotificationCategory.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNotificationCategory.Location = new System.Drawing.Point(212, 52);
            this.txtNotificationCategory.Name = "txtNotificationCategory";
            this.txtNotificationCategory.Size = new System.Drawing.Size(142, 17);
            this.txtNotificationCategory.TabIndex = 1;
            this.txtNotificationCategory.Text = "Notification Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(177, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "||";
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBorder.Location = new System.Drawing.Point(0, 0);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(862, 3);
            this.panelBorder.TabIndex = 2;
            // 
            // SpecifiedNotificationUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBorder);
            this.Controls.Add(this.txtNotificationCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNotificationDate);
            this.Controls.Add(this.txtNotificationMessage);
            this.Controls.Add(this.panelSquare);
            this.Name = "SpecifiedNotificationUC";
            this.Size = new System.Drawing.Size(862, 87);
            this.panelSquare.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSquare;
        private System.Windows.Forms.PictureBox pictureCategory;
        private System.Windows.Forms.Label txtNotificationMessage;
        private System.Windows.Forms.Label txtNotificationDate;
        private System.Windows.Forms.Label txtNotificationCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelBorder;
    }
}
