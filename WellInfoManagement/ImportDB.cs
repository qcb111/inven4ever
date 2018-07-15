using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellInfoManagement
{
    class ImportDB
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private OleDbConnection oleCon;
        private OleDbDataAdapter oleDbcommand;
        private DataSet ds;
        private string strConn;
        private string excelsql;

        string tWellName, tWellType;
        double tXCoord, tYCoord;
        double tKellyBushing, tTotalDepth;

        public ImportDB()
        {
            //ReadExcel("C:\\Users\\zlvin\\Desktop\\well.xlsx");
        }

        public bool ReadExcel(string filePath)
        {
            strConn = "Provider=Microsoft.Ace.OleDb.12.0;" + "Data Source=" + filePath + ";" + "Extended Properties=Excel 12.0";
            oleCon = new OleDbConnection(strConn);
            oleCon.Open();
            oleDbcommand = new OleDbDataAdapter("select * from [Sheet1$]", oleCon);
            ds = new DataSet();
            oleDbcommand.Fill(ds, "[Sheet1$]");
            oleCon.Close();
            oleCon.Dispose();
            int count = ds.Tables["[Sheet1$]"].Rows.Count;

            sqlConnection = new SqlConnection("server=localhost;database=Well_Info;Integrated Security=True");
            sqlConnection.Open();

            for (int i = 0; i < count; i++)
            {
                tWellName = ds.Tables["[Sheet1$]"].Rows[i]["wellName"].ToString().Trim();
                tWellType = ds.Tables["[Sheet1$]"].Rows[i]["wellType"].ToString().Trim();
                tXCoord  = Convert.ToDouble(ds.Tables["[Sheet1$]"].Rows[i]["xCoord"].ToString().Trim());
                tYCoord = Convert.ToDouble(ds.Tables["[Sheet1$]"].Rows[i]["yCoord"].ToString().Trim());
                tKellyBushing = Convert.ToDouble(ds.Tables["[Sheet1$]"].Rows[i]["kellyBushing"].ToString().Trim());
                tTotalDepth = Convert.ToDouble(ds.Tables["[Sheet1$]"].Rows[i]["totalDepth"].ToString().Trim());

                excelsql = "insert into Well_Info(wellName, xCoord, yCoord, wellType, kellyBushing, totalDepth) values ('" + tWellName + "','" + tXCoord + "','" + tYCoord + "','" + tWellType + "','" + tKellyBushing + "','" + tTotalDepth + "')";

                try
                {
                    sqlCommand = new SqlCommand(excelsql, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    return false;
                }
                finally
                {
                    ;
                }
            }
            //sqlCommand = null;
            sqlConnection.Close();
            //sqlConnection = null;
            return true;
        }
    }
}
