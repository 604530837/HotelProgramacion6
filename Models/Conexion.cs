using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HotelProgramacion6.Models
{
    public class Conexion
    {
        public SqlConnection conectar()
        {
            string strConn = ConfigurationManager.ConnectionStrings["hoteles"].ConnectionString;

            SqlConnection conn = new SqlConnection(strConn);
            try
            {
                if (conn.State.Equals(ConnectionState.Closed))
                {
                    conn.Open();
                }
                else
                {
                    conn.Close();
                }
            }
            catch (Exception)
            {
                return null;
            }

            return conn;

        }
    }
}