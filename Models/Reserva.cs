using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelProgramacion6.Models
{
    public class Reserva
    {
        public int reserva { get; set; }
        public int habitacion { get; set; }
        public string nombre { get; set; }
        public string cedula { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public int adultos { get; set; }
        public int ninos { get; set; }
        public DateTime fechaI { get; set; }
        public DateTime fechaS { get; set; }
        public string tipoAlimentacion { get; set; }
        public int dias { get; set; }
        public double hospedaje { get; set; }
        public double  alimentacion  { get; set; }
        public double impuestos { get; set; }
        public double total { get; set; }


    }
}