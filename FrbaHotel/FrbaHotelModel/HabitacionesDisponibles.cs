using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.FrbaHotelModel
{
	public class HabitacionesDisponibles
	{
		public int habitacion_numero { get; set; }
		public int habitacionTipo_id { get; set; }
		public string HabitacionTipo_Descripcion { get; set; }
		public HabitacionesDisponibles()
		{

		}
		public HabitacionesDisponibles(int habitacionNumero, int habitacionTipo, string descripcion)
		{
			this.habitacion_numero = habitacionNumero;
			this.habitacionTipo_id = habitacionTipo;
			this.HabitacionTipo_Descripcion = descripcion;
		}
		//Se mostraran las habitaciones disponibles de un hotel para poder concretar una reserva
		public List<HabitacionesDisponibles> getHabitacionesDisponibles(int hotelId,
														   string fechaInicio,
														   string fechaFin,
														   int cantHuesped)
		{
			try
			{
				//if (rolUsuario.rol_nombre == "administrador")
				//{
				//	return null;
				//}
				List<HabitacionesDisponibles> habitaciones = new List<HabitacionesDisponibles>();
				using (SqlConnection Conexion = BdComun.ObtenerConexion())
				{
					SqlCommand Comando = new SqlCommand("pero_compila.HabitacionesPorHotel", Conexion);
					Comando.CommandType = CommandType.StoredProcedure;
					Comando.Parameters.Clear();
					//comenzamos a mandar cada uno de los parámetros, deben de enviarse en el orden que se encuentran en el procedure
					Comando.Parameters.AddWithValue("@hotelId", hotelId);
					Comando.Parameters.AddWithValue("@fechaInicio", DateTime.Parse(fechaInicio));
					Comando.Parameters.AddWithValue("@fechaFin ", DateTime.Parse(fechaFin));
					Comando.Parameters.AddWithValue("@cantHuesped", cantHuesped);
					SqlDataReader reader = Comando.ExecuteReader();

					while (reader.Read())
					{
						HabitacionesDisponibles habitacion = new HabitacionesDisponibles();

						habitacion.habitacion_numero = reader.GetInt32(0);
						habitacion.habitacionTipo_id= reader.GetInt32(1);
						habitacion.HabitacionTipo_Descripcion= reader.GetString(2);
						habitaciones.Add(habitacion);
					}
					Conexion.Close();
				}
				return habitaciones;

			}
			catch (Exception ex)
			{
				string msj = ex.Message;
				throw;
			}

		}
	}
}
