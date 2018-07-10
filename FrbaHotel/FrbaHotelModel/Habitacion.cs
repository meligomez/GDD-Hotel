using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.FrbaHotelModel
{
    public class Habitacion
    {
        public int habitacion_numero { get; set; }
        public int habitacion_piso { get; set; }
        public int habitacion_tipo { get; set; }
        public string habitacion_descripcion { get; set; }
        public string habitacion_ubicacion { get; set; }
        public int habitacion_codigo { get; set; }
        public bool habitacion_estado { get; set; }
        public int habitacion_hotel { get; set; }

		
		public decimal getPrecioHabitacionPorNoche(
			int hotelId,int habitacionNro ,int cantHuespedes,int tipoRegimen) {
			try
			{
				using (SqlConnection Conexion = BdComun.ObtenerConexion())
				{
					SqlCommand Comando = new SqlCommand("pero_compila.PrecioHabitacion", Conexion);
					Comando.CommandType = CommandType.StoredProcedure;
					Comando.Parameters.Clear();
					//comenzamos a mandar cada uno de los parámetros, deben de enviarse en el
					//tipo de datos que coincida en sql server por ejemplo c# es string en sql server es varchar()
					Comando.Parameters.AddWithValue("@hotel_Id", hotelId);
					Comando.Parameters.AddWithValue("@habitacionNro", habitacionNro);
					Comando.Parameters.AddWithValue("@cantHuespedes", cantHuespedes);
					Comando.Parameters.AddWithValue("@tipoRegimen", tipoRegimen);
					SqlDataReader reader = Comando.ExecuteReader();
					while (reader.Read())
					{
						decimal precioCalculado=0;
						return precioCalculado= reader.GetDecimal(0);
					}
					Conexion.Close();
				}
				return 0;
			}
			catch (Exception ex)
			{
				string msj = ex.Message;
				throw;
			}

		}
    }
}
