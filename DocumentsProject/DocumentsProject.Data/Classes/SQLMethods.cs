using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DocumentsProject.Data.Classes
{
    public abstract class SQLMethods
    {
       private SqlConnection _con;


        public SQLMethods (SqlConnection con)
        {
            _con = con;
        }


        public SqlDataReader ExecuteReader(CommandType type, string CommandText, SqlParameter[] pars)
        {
            SqlCommand com = new SqlCommand
            {
                CommandText = CommandText,
                Connection = _con,
                CommandType = type
            };

            com.Parameters.AddRange(pars);

            return com.ExecuteReader();


        }


        public object ExecuteScalar(CommandType type, string CommandText, SqlParameter[] pars)
        {
            SqlCommand com = new SqlCommand
            {
                CommandText = CommandText,
                Connection = _con,
                CommandType = type
            };

            com.Parameters.AddRange(pars);

            return com.ExecuteScalar();
        }


    }
}
