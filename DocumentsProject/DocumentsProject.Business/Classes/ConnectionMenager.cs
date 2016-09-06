using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsProject.Business.Classes
{
   public class ConnectionMenager
    {
        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public SqlConnection Connection
        {
            get { return con; }
        }

        public void Open()
        {
            if (con.State != System.Data.ConnectionState.Open)
                con.Open();
        }
        public void Close()
        {
            if (con.State != System.Data.ConnectionState.Closed)
                con.Close();
        }

    }
}
