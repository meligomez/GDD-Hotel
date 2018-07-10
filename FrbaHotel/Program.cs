using FrbaHotel.AbmRegimen;
using FrbaHotel.FrbaHotelModel;
using FrbaHotel.GenerarModificacionReserva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Usuario s = Usuario.Instance;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new SeleccionHabitacionParaReserva());
			Application.Run(new SeleccionHabitacionParaReserva());

		}
	}
}
