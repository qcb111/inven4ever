namespace WellInfoManagement
{
    partial class Query_Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.queryResult_dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.updateModifiedData_btn = new System.Windows.Forms.Button();
            this.deleteResults_btn = new System.Windows.Forms.Button();
            this.sendSearchRequest_btn = new System.Windows.Forms.Button();
            this.generateReport_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.queryResult_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // queryResult_dgv
            // 
            this.queryResult_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryResult_dgv.Location = new System.Drawing.Point(406, 81);
            this.queryResult_dgv.Name = "queryResult_dgv";
            this.queryResult_dgv.RowTemplate.Height = 23;
            this.queryResult_dgv.Size = new System.Drawing.Size(333, 194);
            this.queryResult_dgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(486, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Query Result(s)";
            // 
            // updateModifiedData_btn
            // 
            this.updateModifiedData_btn.Location = new System.Drawing.Point(421, 295);
            this.updateModifiedData_btn.Name = "updateModifiedData_btn";
            this.updateModifiedData_btn.Size = new System.Drawing.Size(273, 23);
            this.updateModifiedData_btn.TabIndex = 2;
            this.updateModifiedData_btn.Text = "Update Modified Data";
            this.updateModifiedData_btn.UseVisualStyleBackColor = true;
            this.updateModifiedData_btn.Click += new System.EventHandler(this.updateModifiedData_btn_Click);
            // 
            // deleteResults_btn
            // 
            this.deleteResults_btn.Location = new System.Drawing.Point(421, 324);
            this.deleteResults_btn.Name = "deleteResults_btn";
            this.deleteResults_btn.Size = new System.Drawing.Size(273, 23);
            this.deleteResults_btn.TabIndex = 2;
            this.deleteResults_btn.Text = "Delete ALL Results";
            this.deleteResults_btn.UseVisualStyleBackColor = true;
            this.deleteResults_btn.Click += new System.EventHandler(this.deleteResults_btn_Click);
            // 
            // sendSearchRequest_btn
            // 
            this.sendSearchRequest_btn.Location = new System.Drawing.Point(98, 371);
            this.sendSearchRequest_btn.Name = "sendSearchRequest_btn";
            this.sendSearchRequest_btn.Size = new System.Drawing.Size(175, 23);
            this.sendSearchRequest_btn.TabIndex = 3;
            this.sendSearchRequest_btn.Text = "Send Search Request";
            this.sendSearchRequest_btn.UseVisualStyleBackColor = true;
            this.sendSearchRequest_btn.Click += new System.EventHandler(this.sendSearchRequest_btn_Click);
            // 
            // generateReport_btn
            // 
            this.generateReport_btn.Location = new System.Drawing.Point(421, 353);
            this.generateReport_btn.Name = "generateReport_btn";
            this.generateReport_btn.Size = new System.Drawing.Size(273, 23);
            this.generateReport_btn.TabIndex = 4;
            this.generateReport_btn.Text = "Generate Report Upon Query Results";
            this.generateReport_btn.UseVisualStyleBackColor = true;
            // 
            // Query_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.generateReport_btn);
            this.Controls.Add(this.sendSearchRequest_btn);
            this.Controls.Add(this.deleteResults_btn);
            this.Controls.Add(this.updateModifiedData_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.queryResult_dgv);
            this.Name = "Query_Form";
            this.Text = "Well Info Management System";
            ((System.ComponentModel.ISupportInitialize)(this.queryResult_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView queryResult_dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateModifiedData_btn;
        private System.Windows.Forms.Button deleteResults_btn;
        private System.Windows.Forms.Button sendSearchRequest_btn;
        private System.Windows.Forms.Button generateReport_btn;
    }
}

