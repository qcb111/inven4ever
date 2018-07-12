using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql {
    class SqlServer : ISql {
        private string strCmd;

        private SqlConnection con;
        private SqlDataAdapter dataAdaptor;
        private SqlCommand sqlCmd = new SqlCommand();

        private const string server = "192.168.0.2";
        private const int port = 3306;
        private const string user = "root";
        private const string host = "192.168.0.2";
        private const string password = "123";
        private const string database = "well";
        private static string source;

        static SqlServer() {
            source = "server=" + server
                + ";database=" + database
                + ";uid=" + user
                + ";pwd=" + password;
        }

        public SqlServer() {
            con = new SqlConnection();
            con.ConnectionString = source;
            try {
                con.Open();
                sqlCmd.Connection = con;
                Console.WriteLine("open success");
            }catch(SqlException ex) {
                Console.WriteLine("open error" + ex.ToString());
            }
        }

        ~SqlServer() {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        
        /// <summary>
        /// delete one entity
        /// </summary>
        /// <param name="wellData"></param>
        /// <returns>rows affected</returns>
        public int DeleteOne(WellData wellData) {
            strCmd = "delete from wellInfo where  id = "
                + wellData.Id;
            sqlCmd.CommandText = strCmd;
            return sqlCmd.ExecuteNonQuery();
        }

        public int DeleteSome(List<WellData> listWellData) {
            int rowsAffected = 0; ;
            foreach (WellData wd in listWellData) {
                strCmd = "delete from wellInfo where id = " +
                    wd.Id.ToString();
                sqlCmd.CommandText = strCmd;
                rowsAffected = sqlCmd.ExecuteNonQuery();
            }
            return rowsAffected;
        }

        public int Insert(WellData wellData) {
            strCmd = "insert into wellInfo"
              + " (wellName, xCoord, yCoord, wellType,"
              + " kellyBushing, totalDepth, recordDate)"
              + " values('"
              //+ wellData.Id + "','"
              + wellData.WellName + "',"
              + wellData.XCoord + ","
              + wellData.YCoord + ",'"
              + wellData.WellType + "',"
              + wellData.KellyBushing + ","
              + wellData.TotalDepth + ",'"
              + wellData.RecordDate + "');";
            sqlCmd.CommandText = strCmd;
            return sqlCmd.ExecuteNonQuery();
        }

        public int Query(string sqlcmd, ref DataSet set) {
            strCmd = sqlcmd;
            sqlCmd.CommandText = strCmd;
            this.dataAdaptor = new SqlDataAdapter(strCmd, con);
            return dataAdaptor.Fill(set);
        }

        public int Update(string sqlcmd, WellData wellData) {
            strCmd = sqlcmd;
            sqlCmd.CommandText = strCmd;
            return sqlCmd.ExecuteNonQuery();
        }
    }
}
