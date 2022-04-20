using HotelProgramacion6.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HotelProgramacion6.Controllers
{
    public class Habitacion
    {
        public List<Models.Habitacion> listaHabitaciones()
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "select * from Habitaciones where estado=1;";
            command.CommandType = System.Data.CommandType.Text;
            SqlDataReader dr = command.ExecuteReader();
            List<Models.Habitacion> habitaciones = new List<Models.Habitacion>();
            while (dr.Read()) {
               Models.Habitacion habitacion = new Models.Habitacion();
                habitacion.habitacion =int.Parse( dr["habitacion"].ToString());
                habitacion.descripcion = dr["Descripcion"].ToString();
                habitacion.precio = double.Parse(dr["Precio"].ToString());
                habitaciones.Add(habitacion);
            }
            return habitaciones;
        }
        public Models.Habitacion consultarHabitacion(int id)
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "select * from Habitaciones where habitacion=@id;";
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.Add(new SqlParameter("id",id));
            SqlDataReader dr = command.ExecuteReader();
            
            Models.Habitacion habitacion = new Models.Habitacion();
            if (dr.Read())
            {
               
                habitacion.habitacion = int.Parse(dr["habitacion"].ToString());
                habitacion.descripcion = dr["Descripcion"].ToString();
                habitacion.precio = double.Parse(dr["Precio"].ToString());
                
            }
            return habitacion;
        }
        public bool insertarHabitacion(Models.Habitacion habitacion)
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "insert  into Habitaciones(Descripcion,Precio,Estado) values(@descripcion,@precio,1)";
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.Add(new SqlParameter("descripcion", habitacion.descripcion));
            command.Parameters.Add(new SqlParameter("precio", habitacion.precio));
            int rs = command.ExecuteNonQuery();
            conexion.conectar();


            return rs>=0;
        }

        public bool editarHabitacion(Models.Habitacion habitacion)
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "update Habitaciones set Descripcion=@descripcion,Precio=@precio where habitacion=@id";
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.Add(new SqlParameter("Descripcion", habitacion.descripcion));
            command.Parameters.Add(new SqlParameter("Precio", habitacion.precio));
            command.Parameters.Add(new SqlParameter("id", habitacion.habitacion));
            int rs = command.ExecuteNonQuery();
            conexion.conectar();
            return rs >= 0;
        }
        public bool eliminarHabitacion(int id)
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "update Habitaciones set estado=0 where habitacion=@id";
            command.CommandType = System.Data.CommandType.Text;
            
            command.Parameters.Add(new SqlParameter("id", id));
            int rs = command.ExecuteNonQuery();
            conexion.conectar();
            return rs >= 0;
        }
    }
}