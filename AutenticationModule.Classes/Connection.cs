using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutenticationModule.Classes
{
    public class Connection
    {
        public static SqlConnection _conn;

        public static SqlConnection sqlConnection
        {
            get
            {

                if (_conn == null)
                {
                    _conn = new SqlConnection(@"Server = Lab206_17; Database = projetoestoque ; Uid = sa; Pwd = teste*123;");
                }

                return _conn;
            }
        }
    }
}
