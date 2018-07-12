using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Sql {
    class MysqlX : ISql {
        private string strCmd;

        private MySqlConnection con;
        private MySqlDataAdapter dataAdaptor;
        private MySqlCommand mysqlCmd = new MySqlCommand();

        private const string server = "192.168.0.2";
        private const int port = 3306;
        private const string user = "root";
        private const string host = "192.168.0.2";
        private const string password = "123";
        private const string database = "well";
        private static string source;

        static MysqlX(){
            source = "server=" + server
                + ";database=" + database
            + ";user=" + user
            + ";password=" + password
            + ";port=" + port.ToString()
            + ";host=" + host
            + ";SslMode=none";
        }

        public MysqlX() {
            con = new MySqlConnection();
            con.ConnectionString = source;
            try {
                con.Open();
                mysqlCmd.Connection = con;
                Console.WriteLine("open success");
            } catch(MySqlException ex) {
                Console.WriteLine("open error" + ex.ToString());
            } 
        }

        ~MysqlX() {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
        /// <summary>
        /// delete one entity
        /// </summary>
        /// <param name="wellData"></param>
        /// <returns>return rows affected </returns>
        public int DeleteOne(WellData wellData) {
            strCmd = "delete from wellInfo where id = " +
                wellData.Id.ToString();
            mysqlCmd.CommandText = strCmd;
            return mysqlCmd.ExecuteNonQuery();//return rows affected
        }

        /// <summary>
        /// delete a list of WellData objects
        /// </summary>
        /// <param name="listWellData"></param>
        /// <returns></returns>
        public int DeleteSome(List<WellData> listWellData) {
            int rowsAffected = 0; ;
            foreach(WellData wd in listWellData) {
                strCmd = "delete from wellInfo where id = " +
                    wd.Id.ToString();
                mysqlCmd.CommandText = strCmd;
                rowsAffected = mysqlCmd.ExecuteNonQuery();
            }
            return rowsAffected;
        }
        /// <summary>
        /// insert one WellData object
        /// </summary>
        /// <param name="wellData"></param>
        /// <returns></returns>
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
            mysqlCmd.CommandText = strCmd;
            return mysqlCmd.ExecuteNonQuery();
        }

        public int Query(string sqlcmd, ref DataSet set) {
            strCmd = sqlcmd;
            mysqlCmd.CommandText = strCmd;
            this.dataAdaptor = new MySqlDataAdapter(strCmd, con);
            return dataAdaptor.Fill(set);
        }

        public int Update(string sqlcmd, WellData wellData) {
            strCmd = sqlcmd;
            mysqlCmd.CommandText = strCmd;
            return mysqlCmd.ExecuteNonQuery();
        }
    }
}
