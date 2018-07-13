using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.FrbaHotelModel
{
	public class Hotel
	{
		public int hotel_id { get; set; }
		public string hotel_direccion { get; set; }
		public string hotel_nombre { get; set; }
		public Hotel()
		{

		}
		public Hotel(int id, string direccion)
		{
			this.hotel_id = id;
			this.hotel_direccion = direccion;
		}
		//Se mostraran las habitaciones disponibles de un hotel para poder concretar una reserva
		public List<Hotel> getHotelesDisponibles()
		{
			try
			{
				List<Hotel> hotels = new List<Hotel>();
				using (SqlConnection Conexion = BdComun.ObtenerConexion())
				{
					SqlCommand Comando = new SqlCommand("pero_compila.getHoteles", Conexion);
					Comando.CommandType = CommandType.StoredProcedure;
					Comando.Parameters.Clear();
					//comenzamos a mandar cada uno de los parámetros, deben de enviarse en el orden que se encuentran en el procedure
					SqlDataReader reader = Comando.ExecuteReader();
					while (reader.Read())
					{
						Hotel hotel = new Hotel();

						hotel.hotel_id = reader.GetInt32(0);
						hotel.hotel_direccion = reader.GetString(1);
						hotels.Add(hotel);
					}
					Conexion.Close();
				}
				return hotels;

			}
			catch (Exception ex)
			{
				string msj = ex.Message;
				throw;
			}

		}
	}
}
