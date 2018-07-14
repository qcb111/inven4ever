namespace WellInfoManagement
{
    partial class connectServer_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serverIP_tb = new System.Windows.Forms.TextBox();
            this.user_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.connect_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.databaseName_tb = new System.Windows.Forms.TextBox();
            this.tableName_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "user";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "password";
            // 
            // serverIP_tb
            // 
            this.serverIP_tb.Location = new System.Drawing.Point(271, 79);
            this.serverIP_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.serverIP_tb.Name = "serverIP_tb";
            this.serverIP_tb.Size = new System.Drawing.Size(208, 26);
            this.serverIP_tb.TabIndex = 1;
            this.serverIP_tb.Text = "BGC-JWANG284-Y\\SQLEX";
            // 
            // user_tb
            // 
            this.user_tb.Location = new System.Drawing.Point(271, 131);
            this.user_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.user_tb.Name = "user_tb";
            this.user_tb.Size = new System.Drawing.Size(208, 26);
            this.user_tb.TabIndex = 2;
            this.user_tb.Text = "sa";
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(271, 186);
            this.password_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(208, 26);
            this.password_tb.TabIndex = 3;
            this.password_tb.Text = "123456";
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(226, 334);
            this.connect_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(112, 38);
            this.connect_btn.TabIndex = 5;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "database";
            // 
            // databaseName_tb
            // 
            this.databaseName_tb.Location = new System.Drawing.Point(271, 236);
            this.databaseName_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.databaseName_tb.Name = "databaseName_tb";
            this.databaseName_tb.Size = new System.Drawing.Size(208, 26);
            this.databaseName_tb.TabIndex = 4;
            this.databaseName_tb.Text = "Well_Info";
            // 
            // tableName_tb
            // 
            this.tableName_tb.Location = new System.Drawing.Point(271, 282);
            this.tableName_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableName_tb.Name = "tableName_tb";
            this.tableName_tb.Size = new System.Drawing.Size(208, 26);
            this.tableName_tb.TabIndex = 4;
            this.tableName_tb.Text = "Well_Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 285);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "table";
            // 
            // connectServer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 411);
            this.Controls.Add(this.connect_btn);
            this.Controls.Add(this.tableName_tb);
            this.Controls.Add(this.databaseName_tb);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.user_tb);
            this.Controls.Add(this.serverIP_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "connectServer_Form";
            this.Text = "Connect to SQL Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serverIP_tb;
        private System.Windows.Forms.TextBox user_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox databaseName_tb;
        private System.Windows.Forms.TextBox tableName_tb;
        private System.Windows.Forms.Label label5;
    }
}