using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql {
    public interface ISql {
        int Insert(WellData wellData);
        int DeleteOne(WellData wellData);
        int DeleteSome(List<WellData> listWellData);
        int Query(string sqlcmd, ref DataSet set);
        int Update(WellData wellData);
    }


}
