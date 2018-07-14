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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.QueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LastCommand_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.NumberOfLinesAffected_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.queryResult_dgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // queryResult_dgv
            // 
            this.queryResult_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryResult_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryResult_dgv.Location = new System.Drawing.Point(19, 48);
            this.queryResult_dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.queryResult_dgv.Name = "queryResult_dgv";
            this.queryResult_dgv.RowTemplate.Height = 23;
            this.queryResult_dgv.Size = new System.Drawing.Size(460, 186);
            this.queryResult_dgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(108, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Query Result";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QueryToolStripMenuItem,
            this.UpdateToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.generateReportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(497, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // QueryToolStripMenuItem
            // 
            this.QueryToolStripMenuItem.Name = "QueryToolStripMenuItem";
            this.QueryToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.QueryToolStripMenuItem.Text = "Query";
            this.QueryToolStripMenuItem.Click += new System.EventHandler(this.QueryToolStripMenuItem_Click);
            // 
            // UpdateToolStripMenuItem
            // 
            this.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            this.UpdateToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.UpdateToolStripMenuItem.Text = "Update";
            this.UpdateToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // generateReportToolStripMenuItem
            // 
            this.generateReportToolStripMenuItem.Name = "generateReportToolStripMenuItem";
            this.generateReportToolStripMenuItem.Size = new System.Drawing.Size(113, 21);
            this.generateReportToolStripMenuItem.Text = "GenerateReport";
            this.generateReportToolStripMenuItem.Click += new System.EventHandler(this.generateReportToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LastCommand_toolStripStatusLabel,
            this.NumberOfLinesAffected_toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 240);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(497, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LastCommand_toolStripStatusLabel
            // 
            this.LastCommand_toolStripStatusLabel.AutoSize = false;
            this.LastCommand_toolStripStatusLabel.Name = "LastCommand_toolStripStatusLabel";
            this.LastCommand_toolStripStatusLabel.Size = new System.Drawing.Size(210, 17);
            this.LastCommand_toolStripStatusLabel.Text = "Last Executed Query:";
            this.LastCommand_toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NumberOfLinesAffected_toolStripStatusLabel
            // 
            this.NumberOfLinesAffected_toolStripStatusLabel.AutoSize = false;
            this.NumberOfLinesAffected_toolStripStatusLabel.Name = "NumberOfLinesAffected_toolStripStatusLabel";
            this.NumberOfLinesAffected_toolStripStatusLabel.Size = new System.Drawing.Size(150, 17);
            this.NumberOfLinesAffected_toolStripStatusLabel.Text = "Lines Affected";
            this.NumberOfLinesAffected_toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NumberOfLinesAffected_toolStripStatusLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            // 
            // Query_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 262);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.queryResult_dgv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Query_Form";
            this.Text = "Well Info Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Query_Form_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.queryResult_dgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView queryResult_dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem QueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateReportToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel LastCommand_toolStripStatusLabel;
        public System.Windows.Forms.ToolStripStatusLabel NumberOfLinesAffected_toolStripStatusLabel;
    }
}

