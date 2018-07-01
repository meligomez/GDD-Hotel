using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.FrbaHotelModel
{
    public class Usuario
    {
        public int usuarioXHotel_usuario { get; set; }
        public string rol_nombre { get; set; }
        public int hotel_id { get; set; }
        private readonly static Usuario _instance = new Usuario();

        private Usuario()
        {
        }

        public static Usuario Instance
        {
            get
            {
                try
                {
                    //Usuario user = new Usuario();
                    using (SqlConnection Conexion = BdComun.ObtenerConexion())
                    {
                        SqlCommand Comando = new SqlCommand(String.Format("DatosUser"), Conexion);
                        SqlDataReader reader = Comando.ExecuteReader();
                        while (reader.Read())
                        {
                            _instance.usuarioXHotel_usuario = reader.GetInt32(0);
                            _instance.rol_nombre = reader.GetString(1);
                            _instance.hotel_id = reader.GetInt32(2);
                            break;
                        }

                        Conexion.Close();
                    }
                    return _instance;
                }
                catch (Exception ex)
                {
                    string msj = ex.Message;
                    throw;
                }
                //return _instance;
            }
        }

        public static Usuario GetUserLogeado()
        {
            try
            {
                Usuario user = new Usuario();
                using (SqlConnection Conexion = BdComun.ObtenerConexion())
                {
                    SqlCommand Comando = new SqlCommand(String.Format("DatosUser"), Conexion);
                    SqlDataReader reader = Comando.ExecuteReader();
                    while (reader.Read())
                    {
                        user.usuarioXHotel_usuario= reader.GetInt32(0);
                        user.rol_nombre = reader.GetString(1);
                        user.hotel_id = reader.GetInt32(2);
                        break;
                    }

                    Conexion.Close();
                }
                return user;
            }
            catch (Exception ex)
            {
                string msj = ex.Message;
                throw;
            }
        }
    }
}
