using FrbaHotel.FrbaHotelModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.GenerarModificacionReserva
{
	public partial class SeleccionHabitacionParaReserva : Form
	{
		public SeleccionHabitacionParaReserva()
		{
			InitializeComponent();
		}

		private void buscarHabitacion_Click(object sender, EventArgs e)
		{
			try
			{
				//Usuario.Instance.rol_nombre == "Administrador";
				if (fechaInicio.Text.Trim() == ""
					|| cantDias.Text.Trim() == "" || cantHuespedes.Text.Trim() == ""
					|| cantDias.Text.Trim() == "0" || cantHuespedes.Text.Trim() == "0")
				{
					MessageBox.Show("Faltan completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				Habitacion habitacion = new Habitacion();
				List<Habitacion> habitacions = new List<Habitacion>();
				
				habitacions = habitacion.getHabitacionesDisponibles(Usuario.GetUserLogeado());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
