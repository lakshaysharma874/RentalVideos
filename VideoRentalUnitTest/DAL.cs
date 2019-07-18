using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalVideos
{
   public class DAL
    {
        public String appsetting = System.Configuration.ConfigurationManager.ConnectionStrings["connection"].ToString();
        SqlConnection sqlConnection = new SqlConnection();

        public SqlConnection SQLConnection()
        {
            sqlConnection = new SqlConnection(appsetting);
            return sqlConnection;

        }
        public bool SqlOpen()
        {
            try
            {
                sqlConnection.Open();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }


        }
        public bool SqlClose()
        {
            sqlConnection.Close();
            sqlConnection.Dispose();
            return true;
        }
    }
}
