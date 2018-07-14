namespace WellInfoManagement
{
    partial class searchItems_Form
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
            this.sendRequest_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sendRequest_btn
            // 
            this.sendRequest_btn.Location = new System.Drawing.Point(142, 256);
            this.sendRequest_btn.Name = "sendRequest_btn";
            this.sendRequest_btn.Size = new System.Drawing.Size(134, 23);
            this.sendRequest_btn.TabIndex = 0;
            this.sendRequest_btn.Text = "Send Request";
            this.sendRequest_btn.UseVisualStyleBackColor = true;
            this.sendRequest_btn.Click += new System.EventHandler(this.sendRequest_btn_Click);
            // 
            // searchItems_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 289);
            this.Controls.Add(this.sendRequest_btn);
            this.Name = "searchItems_Form";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sendRequest_btn;
    }
}