namespace WellInfoManagement
{
    partial class Import_Form
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
            this.tbFilePathName = new System.Windows.Forms.TextBox();
            this.importTip = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFilePathName
            // 
            this.tbFilePathName.Location = new System.Drawing.Point(95, 123);
            this.tbFilePathName.Name = "tbFilePathName";
            this.tbFilePathName.Size = new System.Drawing.Size(353, 28);
            this.tbFilePathName.TabIndex = 0;
            // 
            // importTip
            // 
            this.importTip.AutoSize = true;
            this.importTip.Location = new System.Drawing.Point(130, 71);
            this.importTip.Name = "importTip";
            this.importTip.Size = new System.Drawing.Size(287, 18);
            this.importTip.TabIndex = 1;
            this.importTip.Text = "Please enter the path of data :";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(214, 190);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 33);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Import_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 296);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.importTip);
            this.Controls.Add(this.tbFilePathName);
            this.Name = "Import_Form";
            this.Text = "Import_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFilePathName;
        private System.Windows.Forms.Label importTip;
        private System.Windows.Forms.Button btnSubmit;
    }
}