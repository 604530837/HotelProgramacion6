using HotelProgramacion6.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotelProgramacion6
{
    public partial class Reservacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                cargarHabitacion();
            }
        }
        private void cargarHabitacion() {
            Habitacion habitacion = new Habitacion();
            List<Models.Habitacion> habitaciones = habitacion.listaHabitaciones();
            foreach (Models.Habitacion h in habitaciones) {
                ListItem i = new ListItem(h.habitacion+"", h.habitacion + "");
                this.ddlHabitacion.Items.Add(i);
            }

        }
        private void insertar()
        {
            Habitacion habitacion = new Habitacion();
            Models.Habitacion model = new Models.Habitacion();
            model.precio = 3000;
            model.descripcion = "No se 2";
            habitacion.insertarHabitacion(model);
        }
    }
}