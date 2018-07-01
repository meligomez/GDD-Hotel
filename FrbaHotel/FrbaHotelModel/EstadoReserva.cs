using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.FrbaHotelModel
{
    public class EstadoReserva
    {
        public int estadoReserva_Id { get; set; }
        public string estadoReserva_descripcion { get; set; }

		//Las mismas pueden ser generadas por el recepcionista del Hotel o por los usuarios Guest.
		public List<EstadoReserva> getEstadoReservas()
        {
            try
            {
                List<EstadoReserva> estadoReservas = new List<EstadoReserva>();
                using (SqlConnection Conexion = BdComun.ObtenerConexion())
                {
                    SqlCommand Comando = new SqlCommand(String.Format("select r.estadoReserva_Id," +
                        "r.estadoReserva_descripcion " +
                        "FROM " +
                        "pero_compila.EstadoReserva r "), Conexion);
                    SqlDataReader reader = Comando.ExecuteReader();
                    EstadoReserva estadoReserva = new EstadoReserva();
                    while (reader.Read())
                    {
                        estadoReserva.estadoReserva_Id = reader.GetInt32(0);
                        estadoReserva.estadoReserva_descripcion = reader.GetString(1);
                        estadoReservas.Add(estadoReserva);
                    }
                    Conexion.Close();
                }
                return estadoReservas;
            }
            catch (Exception ex)
            {
                string msj = ex.Message;
                throw;
            }

        }
    }
}
