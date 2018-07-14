using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql {
    public class SqlServer : ISql {
        private string strCmd;
        /// <summary>
        /// choose one connection type
        /// </summary>


        private SqlConnection con;
        private SqlDataAdapter dataAdaptor;
        private SqlCommand sqlCmd = new SqlCommand();

        private static string server;
        private static string user;
        //private static string host;
        private static string password;
        private static string database;
        private static string source;

        private string[] titleNames;
        private string tableName;

        public string[] TitleNames { get => titleNames;  }
        public string TableName { get => tableName; }

        private static void constructSource_sql_auth() {
            source = "server=" + server
                + ";database=" + database
                + ";uid=" + user
                + ";pwd=" + password;
        }
        private static void constructSource_win_auth() {
            source = "server=" + server
                + ";database=" + database
                + "integrated security=SSPI";
        }

        private int TrySelect(ref DataSet set) {
            strCmd = "select * from " + tableName;
            return Query(strCmd, ref set);
        }

        public SqlServer(string server_p,
            string user_p, string passwd_p,
            string dataBase_p, string tableName, ConnectionType conType) {
            server = server_p;
            user = user_p;
            password = passwd_p;
            database = dataBase_p;
            this.tableName = tableName;

            if (conType == ConnectionType.sqlServerAuthentication)
                constructSource_sql_auth();
            else
                constructSource_win_auth();

            con = new SqlConnection();
            con.ConnectionString = source;
            try {
                con.Open();
                sqlCmd.Connection = con;
                DataSet set = new DataSet();
                TrySelect(ref set);
                setTitleNames(ref set);
                Console.WriteLine("open success");
            }catch(SqlException ex) {
                Console.WriteLine("open error" + ex.ToString());
            }
        }

        private void setTitleNames(ref DataSet set) {
            int count = set.Tables[0].Columns.Count;
            titleNames = new string[count];
            for(int i = 0; i < count; i++) {
                titleNames[i] = set.Tables[0].Columns[i].ToString();
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
            strCmd = "delete from " +  tableName + " where id = "
                + wellData.Id;
            sqlCmd.CommandText = strCmd;
            return sqlCmd.ExecuteNonQuery();
        }

        public int DeleteOne(int id)
        {
            strCmd = "delete from " + tableName +" where id = "
                + id;
            sqlCmd.CommandText = strCmd;
            return sqlCmd.ExecuteNonQuery();
        }

        public int DeleteSome(List<WellData> listWellData) {
            int rowsAffected = 0; ;
            foreach (WellData wd in listWellData) {
                strCmd = "delete from " + tableName + " where id = " +
                    wd.Id.ToString();
                sqlCmd.CommandText = strCmd;
                rowsAffected = sqlCmd.ExecuteNonQuery();
            }
            return rowsAffected;
        }

        public int Insert(WellData wellData) {
            strCmd = "insert into " + tableName
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

        public int Update(WellData wellData, int id) {

            string strCmd = "update " + tableName + " set "
                + " WellName = '" + wellData.WellName.ToString() +"'"
                + " ,xCoord = " + wellData.XCoord.ToString()
                + " ,yCoord = " + wellData.YCoord.ToString()
                + " ,wellType = '" + wellData.WellType.ToString() + "'"
                + " ,KellyBushing = " + wellData.KellyBushing.ToString()
                + " ,totalDepth = " + wellData.TotalDepth.ToString()
                + " where id=" + id.ToString();

            sqlCmd.CommandText = strCmd;
            return sqlCmd.ExecuteNonQuery();
        }
    }
}
