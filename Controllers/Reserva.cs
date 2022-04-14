using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using HotelProgramacion6.Models;

namespace HotelProgramacion6.Controllers
{
    public class Reserva
    {
        public List<Models.Reserva> listaReservas()
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "select * from Reservas where estado=true;";
            command.CommandType = System.Data.CommandType.Text;
            SqlDataReader dr = command.ExecuteReader();
            List<Models.Reserva> reservas = new List<Models.Reserva>();
            while (dr.Read())
            {
                Models.Reserva reserva = new Models.Reserva();
                reserva.reserva= int.Parse(dr["Reserva"].ToString());
                reserva.habitacion = int.Parse(dr["Habitacion"].ToString());
                reserva.nombre = dr["Nombre"].ToString();
                reserva.cedula = dr["Cedula"].ToString();
                reserva.correo = dr["Correo"].ToString();
                reserva.telefono = dr["Telefono"].ToString();
                reserva.adultos = int.Parse(dr["Adultos"].ToString());
                reserva.ninos = int.Parse(dr["Ninos"].ToString());
                reserva.fechaI = DateTime.Parse(dr["FechaI"].ToString());
                reserva.fechaS = DateTime.Parse(dr["FechaS"].ToString());
                reserva.dias = int.Parse(dr["Dias"].ToString());
                reserva.hospedaje = double.Parse(dr["Hospedaje"].ToString());
                reserva.alimentacion = double.Parse(dr["Alimentacion"].ToString());
                reserva.impuestos = double.Parse(dr["Impuestos"].ToString());
                reserva.total = double.Parse(dr["Total"].ToString());
                reservas.Add(reserva);
            }
            return reservas;
        }
        public Models.Reserva consultarReserva(int id)
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "select * from Reservas where reserva=@id;";
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.Add(new SqlParameter("id", id));
            SqlDataReader dr = command.ExecuteReader();

            Models.Reserva reserva = new Models.Reserva();
            if (dr.Read())
            {

                reserva.reserva = int.Parse(dr["Reserva"].ToString());
                reserva.habitacion = int.Parse(dr["Habitacion"].ToString());
                reserva.nombre = dr["Nombre"].ToString();
                reserva.cedula = dr["Cedula"].ToString();
                reserva.correo = dr["Correo"].ToString();
                reserva.telefono = dr["Telefono"].ToString();
                reserva.adultos = int.Parse(dr["Adultos"].ToString());
                reserva.ninos = int.Parse(dr["Ninos"].ToString());
                reserva.fechaI = DateTime.Parse(dr["FechaI"].ToString());
                reserva.fechaS = DateTime.Parse(dr["FechaS"].ToString());
                reserva.dias = int.Parse(dr["Dias"].ToString());
                reserva.hospedaje = double.Parse(dr["Hospedaje"].ToString());
                reserva.alimentacion = double.Parse(dr["Alimentacion"].ToString());
                reserva.impuestos = double.Parse(dr["Impuestos"].ToString());
                reserva.total = double.Parse(dr["Total"].ToString());
               
            }
            return reserva;
        }
        public bool insertarReserva(Models.Reserva reserva)
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "insert Reservas into(Habitacion,Nombre,Cedula,Correo,Telefono,Adultos,Ninos,FechaI,FechaS,Dias,Hospedaje,Alimentacion,Impuestos,Total,Estado) values(@habitacion,@nombre,@cedula,@correo,@telefono,@adultos,@ninos,@fechaI,@fechaS,@dias,@hospedaje,@alimentacion,@impuestos,@total,true);";
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.Add(new SqlParameter("Habitacion", reserva.habitacion));
            command.Parameters.Add(new SqlParameter("Nombre", reserva.nombre));
            command.Parameters.Add(new SqlParameter("Cedula", reserva.cedula));
            command.Parameters.Add(new SqlParameter("Correo", reserva.correo));
            command.Parameters.Add(new SqlParameter("Adultos",reserva.adultos));
            command.Parameters.Add(new SqlParameter("Ninos", reserva.ninos));
            command.Parameters.Add(new SqlParameter("FechaI", reserva.fechaI));
            command.Parameters.Add(new SqlParameter("FechaS", reserva.fechaS));
            command.Parameters.Add(new SqlParameter("Dias", reserva.dias));
            command.Parameters.Add(new SqlParameter("Hospedaje", reserva.hospedaje));
            command.Parameters.Add(new SqlParameter("Alimentacion", reserva.alimentacion));
            command.Parameters.Add(new SqlParameter("Impuestos", reserva.impuestos));
            command.Parameters.Add(new SqlParameter("Total", reserva.total));

            int rs = command.ExecuteNonQuery();
            conexion.conectar();


            return rs >= 0;
        }

        public bool editarReserva(Models.Reserva reserva)
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "update Reservas set Habitacion=@habitacion,Nombre=@nombre,Cedula=@cedula,Correo=@correo,Telefono=@telefono,Adultos=@adultos,Ninos=@ninos,FechaI=@fechaI,FechaS=@fechaS,Dias=@dias,Hospedaje=@hospedaje,Alimentacion=@alimentacion,Impuestos=@impuestos,Total=@total,Estado=true";
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.Add(new SqlParameter("Habitacion", reserva.habitacion));
            command.Parameters.Add(new SqlParameter("Nombre", reserva.nombre));
            command.Parameters.Add(new SqlParameter("Cedula", reserva.cedula));
            command.Parameters.Add(new SqlParameter("Correo", reserva.correo));
            command.Parameters.Add(new SqlParameter("Adultos", reserva.adultos));
            command.Parameters.Add(new SqlParameter("Ninos", reserva.ninos));
            command.Parameters.Add(new SqlParameter("FechaI", reserva.fechaI));
            command.Parameters.Add(new SqlParameter("FechaS", reserva.fechaS));
            command.Parameters.Add(new SqlParameter("Dias", reserva.dias));
            command.Parameters.Add(new SqlParameter("Hospedaje", reserva.hospedaje));
            command.Parameters.Add(new SqlParameter("Alimentacion", reserva.alimentacion));
            command.Parameters.Add(new SqlParameter("Impuestos", reserva.impuestos));
            command.Parameters.Add(new SqlParameter("Total", reserva.total));


            int rs = command.ExecuteNonQuery();
            conexion.conectar();
            return rs >= 0;
        }
        public bool eliminarReserva(int id)
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "update Reservas set estado=false where reserva=@id";
            command.CommandType = System.Data.CommandType.Text;

            command.Parameters.Add(new SqlParameter("id", id));
            int rs = command.ExecuteNonQuery();
            conexion.conectar();
            return rs >= 0;
        }


    }
}