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
        public int habitacion_nuemro { get; set; }
        public int habitacion_piso { get; set; }
        public int habitacion_tipoPorcentual { get; set; }
        public string habitacion_descripcion { get; set; }
        public string habitacion_ubicacion { get; set; }
        public int habitacion_codigo { get; set; }
        public bool habitacion_estado { get; set; }
        public int habitacion_hotel { get; set; }

		//Se mostraran las habitaciones disponibles de un hotel para poder concretar una reserva
        public List<Habitacion> getHabitacionesDisponibles(Usuario rolUsuario,
														   string fechaInicio,
														   int cantDias,
														   int cantHuesped)
        {
            try
            {
                if (rolUsuario.rol_nombre == "administrador")
                {
                    return null;
                }
                List<Habitacion> habitaciones = new List<Habitacion>();
                using (SqlConnection Conexion = BdComun.ObtenerConexion())
                {
                    SqlCommand Comando = new SqlCommand("pero_compila.HabitacionesPorHotel", Conexion);
                    Comando.CommandType = CommandType.StoredProcedure;
					//               Comando.Parameters.Add("@hotel_Id", SqlDbType.Int);
					//Comando.Parameters.Add("@fechaInicio", SqlDbType.DateTime);
					//Comando.Parameters.Add("@cantDias", SqlDbType.Int);
					//Comando.Parameters.Add("@cantHuesped", SqlDbType.Int);

					//Comando.UpdatedRowSource = UpdateRowSource.None;
					//               Comando.Parameters[0].Value = rolUsuario.hotel_id;
					//Comando.Parameters[1].Value = DateTime.Parse(fechaInicio);
					//Comando.Parameters[2].Value = cantDias;
					//Comando.Parameters[3].Value = cantHuesped;
					Comando.Parameters.Clear();
					//comenzamos a mandar cada uno de los parámetros, deben de enviarse en el
					//tipo de datos que coincida en sql server por ejemplo c# es string en sql server es varchar()
					Comando.Parameters.AddWithValue("@hotelId", rolUsuario.hotel_id);
					Comando.Parameters.AddWithValue("@fechaInicio", DateTime.Parse(fechaInicio));
					Comando.Parameters.AddWithValue("@cantDias", cantDias);
					Comando.Parameters.AddWithValue("@cantHuesped", cantHuesped);
					SqlDataReader reader = Comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Habitacion habitacion = new Habitacion();
                        habitacion.habitacion_codigo = reader.GetInt32(0);
                        habitacion.habitacion_descripcion = reader.GetString(1);
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
