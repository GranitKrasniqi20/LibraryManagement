using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace MenaxhimiBibliotekes.DAL
{
    class DbHelper
    {
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;




        public static SqlConnection GetConnection()
        {

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                return conn;
            }
            catch (Exception)
            {

                //MessageBox
                throw;
            }
        }

        public static SqlCommand Command(SqlConnection connection, string cmdText, CommandType commandType)
        {
            SqlCommand command = new SqlCommand(cmdText, connection);
            command.CommandType = commandType;
            return command;
        }

 


    }
}
