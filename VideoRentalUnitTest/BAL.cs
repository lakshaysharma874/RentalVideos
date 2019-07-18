using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalVideos
{
    public class BAL
    {
        DAL dataLayer = new DAL();


        public DataTable geDataTableWithParamter(string SPName, SqlParameter[] SP)
        {
            SqlCommand cmd = new SqlCommand(SPName, dataLayer.SQLConnection());
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = SPName;
            cmd.CommandTimeout = 600;
            foreach (SqlParameter sp in SP)
            {
                cmd.Parameters.Add(sp);
            }



            try
            {
                dataLayer.SqlOpen();
                da.SelectCommand = cmd;
                da.Fill(dt);
                dataLayer.SqlClose();

            }
            catch (Exception e)
            {
                // Response.Write(" <script>alert('"+e.ToString()+"')</script>");

            }
            finally
            {
                cmd.Dispose();
                dataLayer.SqlClose();
            }
            return dt;


        }

        public DataTable getDataTableWithoutParamter(string SPName)
        {
            SqlCommand cmd = new SqlCommand(SPName, dataLayer.SQLConnection());
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = SPName;
            cmd.CommandTimeout = 600;
            try
            {
                dataLayer.SqlOpen();
                da.SelectCommand = cmd;
                da.Fill(dt);
                dataLayer.SqlClose();

            }
            catch { }
            finally
            {
                cmd.Dispose();
                dataLayer.SqlClose();
            }
            return dt;


        }
    }
}
