using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sql;
using System.Data.SqlClient;

namespace WellInfoManagement
{
    public partial class connectServer_Form : Form
    {
        public Query_Form queryForm;
        public searchItems_Form searchItemsForm;
        public SqlServer sqlServer;
        public connectServer_Form()
        {
            InitializeComponent();

        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            if(ConnectToSqlServerSuccessful())
            {
                if(queryForm == null)
                {
                    queryForm = new Query_Form(this);
                    //queryForm.Parent = this;
                    queryForm.ShowDialog(this);
                    Hide();                    
                }
            }
            else
            {
                MessageBox.Show("Connection Failed.","Error");
                //this.serverIP_tb.Text = "";
                //this.user_tb.Text = "";
                //this.password_tb.Text = "";
                //this.databaseName_tb.Text = "";
                this.serverIP_tb.Focus();
            }

        }

        private bool ConnectToSqlServerSuccessful()
        {
            // to be completed
            sqlServer = new SqlServer(this.serverIP_tb.Text,
                this.user_tb.Text, 
                this.password_tb.Text, 
                this.databaseName_tb.Text,
                ConnectionType.sqlServerAuthentication);
            if (sqlServer == null)
                return false;
            else
            {
                return true;
            }
        }
    }
}
