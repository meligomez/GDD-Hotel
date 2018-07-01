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
        public List<Habitacion> getHabitacionesDisponibles(Usuario rolUsuario)
        {
            try
            {
                if (rolUsuario.rol_nombre != "administrador")
                {
                    return null;
                }
                List<Habitacion> habitaciones = new List<Habitacion>();
                using (SqlConnection Conexion = BdComun.ObtenerConexion())
                {
                    SqlCommand Comando = new SqlCommand("[HabitacionesPorHotel]", Conexion);
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.Parameters.Add("@hotel_Id", SqlDbType.Int);

                    Comando.UpdatedRowSource = UpdateRowSource.None;
                    Comando.Parameters[0].Value = rolUsuario.hotel_id;

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
