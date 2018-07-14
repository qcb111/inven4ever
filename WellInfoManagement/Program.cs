using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sql;
using System.Data.SqlClient;
namespace well_info {
    class Program {
        static void Main()
        {
            SqlServer sql = new SqlServer();
            DataSet set = new DataSet();
            sql.Query("select * from well_info", ref set);
            //test MysqlX
            #region  
            //MysqlX mysql = new MysqlX();
            //DataSet set = new DataSet();
            //mysql.Query("select * from wellInfo", ref set);
            #endregion
			
			
        }
    }
}
