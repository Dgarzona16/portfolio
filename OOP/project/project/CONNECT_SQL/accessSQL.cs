using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace project.CONNECT_SQL
{
    public abstract class accessSQL
    {
        private readonly string connection;
        public accessSQL()
        {
            this.connection = "Server=localhost;DataBase=BINAES;Trusted_Connection=True";
        }

        protected SqlConnection getConnection()
        {
            return new SqlConnection(connection);
        }
    }
}
