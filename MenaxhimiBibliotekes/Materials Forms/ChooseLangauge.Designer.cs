namespace MenaxhimiBibliotekes.Materials_Forms
{
    partial class ChooseLangauge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseLangauge));
            this.rBAlbanish = new System.Windows.Forms.RadioButton();
            this.rBEnglish = new System.Windows.Forms.RadioButton();
            this.lblInsert = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rBAlbanish
            // 
            this.rBAlbanish.Checked = true;
            resources.ApplyResources(this.rBAlbanish, "rBAlbanish");
            this.rBAlbanish.Name = "rBAlbanish";
            this.rBAlbanish.TabStop = true;
            this.rBAlbanish.UseVisualStyleBackColor = true;
            // 
            // rBEnglish
            // 
            resources.ApplyResources(this.rBEnglish, "rBEnglish");
            this.rBEnglish.Name = "rBEnglish";
            this.rBEnglish.UseVisualStyleBackColor = true;
            // 
            // lblInsert
            // 
            resources.ApplyResources(this.lblInsert, "lblInsert");
            this.lblInsert.Name = "lblInsert";
            // 
            // btnInsert
            // 
            resources.ApplyResources(this.btnInsert, "btnInsert");
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // ChooseLangauge
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rBEnglish);
            this.Controls.Add(this.rBAlbanish);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblInsert);
            this.Name = "ChooseLangauge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rBAlbanish;
        private System.Windows.Forms.RadioButton rBEnglish;
        private System.Windows.Forms.Label lblInsert;
        private System.Windows.Forms.Button btnInsert;
    }
}