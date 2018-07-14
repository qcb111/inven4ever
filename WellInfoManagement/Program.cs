using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WellInfoManagement {
    static class Program {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new connectServer_Form());
        }
    }
}
