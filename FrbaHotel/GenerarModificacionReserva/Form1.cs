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
    public partial class frmListHabitacionesDiponiblesPorHotel : Form
	{
		public List<Habitacion> _habitacions { get; set; }
		public frmListHabitacionesDiponiblesPorHotel()
        {
			InitializeComponent();
        }
		public frmListHabitacionesDiponiblesPorHotel(List<Habitacion> habitacions)
		{
			this._habitacions = habitacions;
			InitializeComponent();
		}
		private void frmListHabitacionesDiponiblesPorHotel_Load(object sender, EventArgs e)
		{

		}
		public void cargarHabitacionesDisponibles() {
			try
			{
				dgvHabitaciones.DataSource = this._habitacions;

			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
