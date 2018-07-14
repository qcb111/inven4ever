﻿namespace WellInfoManagement
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "user";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "password";
            // 
            // serverIP_tb
            // 
            this.serverIP_tb.Location = new System.Drawing.Point(172, 22);
            this.serverIP_tb.Margin = new System.Windows.Forms.Padding(4);
            this.serverIP_tb.Name = "serverIP_tb";
            this.serverIP_tb.Size = new System.Drawing.Size(148, 28);
            this.serverIP_tb.TabIndex = 1;
            this.serverIP_tb.Text = "100.96.140.17";
            this.serverIP_tb.TextChanged += new System.EventHandler(this.serverIP_tb_TextChanged);
            // 
            // user_tb
            // 
            this.user_tb.Location = new System.Drawing.Point(172, 70);
            this.user_tb.Margin = new System.Windows.Forms.Padding(4);
            this.user_tb.Name = "user_tb";
            this.user_tb.Size = new System.Drawing.Size(148, 28);
            this.user_tb.TabIndex = 2;
            this.user_tb.Text = "sa";
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(172, 119);
            this.password_tb.Margin = new System.Windows.Forms.Padding(4);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(148, 28);
            this.password_tb.TabIndex = 3;
            this.password_tb.Text = "123456";
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(126, 209);
            this.connect_btn.Margin = new System.Windows.Forms.Padding(4);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(112, 34);
            this.connect_btn.TabIndex = 5;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "database";
            // 
            // databaseName_tb
            // 
            this.databaseName_tb.Location = new System.Drawing.Point(172, 164);
            this.databaseName_tb.Margin = new System.Windows.Forms.Padding(4);
            this.databaseName_tb.Name = "databaseName_tb";
            this.databaseName_tb.Size = new System.Drawing.Size(148, 28);
            this.databaseName_tb.TabIndex = 4;
            this.databaseName_tb.Text = "Well_Info";
            // 
            // connectServer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 303);
            this.Controls.Add(this.connect_btn);
            this.Controls.Add(this.databaseName_tb);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.user_tb);
            this.Controls.Add(this.serverIP_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}