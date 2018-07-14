using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Sql;

namespace WellInfoManagement
{
    public partial class Query_Form : Form
    {
        public DataSet queryResult = new DataSet();
        connectServer_Form mainForm;
        public Query_Form()
        {
            InitializeComponent();
        }


        public Query_Form(connectServer_Form _mainForm):this()
        {
            mainForm = _mainForm;
            WellData data = new WellData("n-1", 123, 456, "abc", 123, 456);
            mainForm.sqlServer.Insert(data);
        }

        private void deleteResults_btn_Click(object sender, EventArgs e)
        {
            int[] idToBeDeleted = new int[this.queryResult_dgv.RowCount];
            for (int i = 0; i < idToBeDeleted.Length; i++)
            {
                idToBeDeleted[i] = int.Parse(queryResult_dgv.Rows[i].Cells[0].Value.ToString());
            }
            // delete
        }


        private void updateModifiedData_btn_Click(object sender, EventArgs e)
        {
            DataTable table = this.queryResult_dgv.DataSource as DataTable;
            DataSet set = new DataSet();
            set.Tables.Add(table);
            // update?
        }

        private void QueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchItems_Form searchItemsForm = new searchItems_Form(mainForm,this);
            searchItemsForm.ShowDialog(this);
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.queryResult_dgv.Rows.Count; i++)
            {
                if (int.TryParse(queryResult_dgv.Rows[i].Cells[0].Value.ToString(), out int id))
                {
                    WellData wellData = new WellData(
                        queryResult_dgv.Rows[i].Cells[1].Value.ToString(),
                        double.Parse(queryResult_dgv.Rows[i].Cells[2].Value.ToString()),
                        double.Parse(queryResult_dgv.Rows[i].Cells[3].Value.ToString()),
                        queryResult_dgv.Rows[i].Cells[4].Value.ToString(),
                        double.Parse(queryResult_dgv.Rows[i].Cells[5].Value.ToString()),
                        double.Parse(queryResult_dgv.Rows[i].Cells[6].Value.ToString())
                        );
                    mainForm.sqlServer.Update(wellData, id);
                }
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.queryResult_dgv.Rows.Count; i++)
            {                
                mainForm.sqlServer.DeleteOne(int.Parse(this.queryResult_dgv.Rows[i].Cells[0].Value.ToString()));
            }
        }

        private void generateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // System.Windows.Forms.DataGridView dgv_Info = new System.Windows.Forms.DataGridView();
            //if (dgv_Info.Rows.Count == 0)//判断是否有数据
            //    return;//返回
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();//实例化Excel对象
            excel.Application.Workbooks.Add(true);//在Excel中添加一个工作簿
            excel.Visible = true;//设置Excel显示
            //生成字段名称
            for (int i = 0; i < queryResult_dgv.ColumnCount; i++)
            {
                excel.Cells[1, i + 1] = queryResult_dgv.Columns[i].HeaderText;//将数据表格控件中的列表头填充到Excel中
            }
            //填充数据
            for (int i = 0; i < queryResult_dgv.RowCount - 1; i++)//遍历数据表格控件的所有行
            {
                for (int j = 0; j < queryResult_dgv.ColumnCount; j++)//遍历数据表格控件的所有列
                {
                    if (queryResult_dgv[j, i].ValueType == typeof(string))//判断遍历到的数据是否是字符串类型
                    {
                        excel.Cells[i + 2, j + 1] = "'" + queryResult_dgv[j, i].Value.ToString();//填充Excel表格
                    }
                    else
                    {
                        excel.Cells[i + 2, j + 1] = queryResult_dgv[j, i].Value.ToString();//填充Excel表格
                    }
                }
            }
        }
    }


}
