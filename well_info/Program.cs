using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sql;
namespace well_info {
    class Program {
        static void Main()
        {
            //test MysqlX
            #region  
            MysqlX mysql = new MysqlX();
            DataSet set = new DataSet();
            mysql.Query("select * from wellInfo", ref set);
            #endregion
			
			
        }
    }
}
