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
        public DataSet queryResult;
        public Query_Form()
        {
            InitializeComponent();
     
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

        private void sendSearchRequest_btn_Click(object sender, EventArgs e)
        {
            searchItems_Form searchItemsForm = new searchItems_Form();
            searchItemsForm.ShowDialog(this);
        }

        private void QueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchItems_Form searchItemsForm = new searchItems_Form();
            searchItemsForm.ShowDialog(this);
        }


    }


}
