using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.FrbaHotelModel
{
    public class Reserva
    {
        public int reserva_Id { get; set; }
        public DateTime reserva_fechaCreacion { get; set; }
        public DateTime reserva_fechaInicio { get; set; }
        public int reserva_cantDias { get; set; }
        public string reserva_tipoHabitacion { get; set; }
        public int reserva_tipoRegimen { get; set; }
        public bool reserva_activa { get; set; }
        public decimal reserva_valor { get; set; }
        public int reserva_estado { get; set; }
        public decimal reserva_clienteIdentificacion { get; set; }
        public string reserva_clienteMail { get; set; }
        public int reserva_usuario { get; set; }
        public int reserva_cantHuespedes { get; set; }

        public List<Reserva> getReservas()
        {
            try
            {
                List<Reserva> reservas = new List<Reserva>();
                using (SqlConnection Conexion = BdComun.ObtenerConexion())
                {
                    SqlCommand Comando = new SqlCommand(String.Format("select r.regimen_Id," +
                        "r.regimen_Descripcion,r.regimen_precioBase, r.regimen_estado " +
                        "FROM " +
                        "pero_compila.Regimen r " +
                        "WHERE r.regimen_estado= 1 "), Conexion);
                    SqlDataReader reader = Comando.ExecuteReader();
                    Reserva reserva = new Reserva();
                    while (reader.Read())
                    {
                        //regimen.regimen_Id = reader.GetInt32(0);
                        //regimen.regimen_Descripcion = reader.GetString(1);
                        //regimen.regimen_precioBase = reader.GetDecimal(2);
                        //regimen.regimen_estado = reader.GetBoolean(3);
                        reservas.Add(reserva);
                    }
                    Conexion.Close();
                }
                return reservas;

            }
            catch (Exception ex)
            {
                string msj = ex.Message;
                throw;
            }

        }
        public int addReserva(Reserva reserva)
        {
            SqlConnection Conexion = BdComun.ObtenerConexion();
            try
            {
                SqlCommand comando = new SqlCommand("pero_compila.[sp_alta_reserva]", Conexion);
                comando.CommandType = CommandType.StoredProcedure;
                //se limpian los parámetros
                comando.Parameters.Clear();
                //comenzamos a mandar cada uno de los parámetros, deben de enviarse en el
                //tipo de datos que coincida en sql server por ejemplo c# es string en sql server es varchar()
                comando.Parameters.AddWithValue("@reserva_fechaInicio", reserva.reserva_fechaInicio);
                comando.Parameters.AddWithValue("@reserva_cantDias", reserva.reserva_cantDias);
                comando.Parameters.AddWithValue("@reserva_tipoHabitacion", reserva.reserva_tipoHabitacion);
                comando.Parameters.AddWithValue("@reserva_tipoRegimen", reserva.reserva_tipoRegimen);
                comando.Parameters.AddWithValue("@reserva_valor", reserva.reserva_valor);
                comando.Parameters.AddWithValue("@reserva_clienteIdentificacion", reserva.reserva_clienteIdentificacion);
                comando.Parameters.AddWithValue("@reserva_clienteMail", reserva.reserva_clienteMail);
                comando.Parameters.AddWithValue("@reserva_usuario", reserva.reserva_usuario);
                comando.Parameters.AddWithValue("@reserva_cantHuespedes", reserva.reserva_cantHuespedes);
                if (comando.ExecuteNonQuery() > 0)
                {
                    Conexion.Close();
                    return 1;
                }
                else
                {
                    Conexion.Close();
                    return 0;
                }

            }
            catch (Exception ex)
            {
                string mje = ex.Message;
                Conexion.Close();
                return 0;
            }
        }
        //public int UpdateRegimen(Reserva regimen)
        //{
        //    SqlConnection Conexion = BdComun.ObtenerConexion();
        //    try
        //    {
        //        SqlCommand comando = new SqlCommand("pero_compila.[sp_actualizar_regimen]", Conexion);
        //        comando.CommandType = CommandType.StoredProcedure;
        //        //se limpian los parámetros
        //        comando.Parameters.Clear();
        //        //comenzamos a mandar cada uno de los parámetros, deben de enviarse en el
        //        //tipo de datos que coincida en sql server por ejemplo c# es string en sql server es varchar()
        //        comando.Parameters.AddWithValue("@regimen_Id", regimen.reserva_Id);
        //        //comando.Parameters.AddWithValue("@regimen_Descripcion", regimen.regimen_Descripcion);
        //        //comando.Parameters.AddWithValue("@regimen_precioBase", regimen.regimen_precioBase);
        //        if (comando.ExecuteNonQuery() > 0)
        //        {
        //            Conexion.Close();
        //            return 1;
        //        }
        //        else
        //        {
        //            Conexion.Close();
        //            return 0;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        string mje = ex.Message;
        //        Conexion.Close();
        //        return 0;
        //    }
        //}
        //public Regimen GetRegimenById(int id)
        //{
        //    try
        //    {
        //        if (id == 0)
        //        {
        //            return null;
        //        }
        //        Regimen regimen = new Regimen();
        //        using (SqlConnection Conexion = BdComun.ObtenerConexion())
        //        {
        //            SqlCommand Comando = new SqlCommand(String.Format("select r.regimen_Id," +
        //                    "r.regimen_Descripcion,r.regimen_precioBase, r.regimen_estado " +
        //                    "FROM " +
        //                    "pero_compila.Regimen r " +
        //                    "WHERE r.regimen_estado= 1 and r.regimen_Id= '{0}'", id), Conexion);
        //            SqlDataReader reader = Comando.ExecuteReader();
        //            while (reader.Read())
        //            {
        //                regimen.regimen_Id = reader.GetInt32(0);
        //                regimen.regimen_Descripcion = reader.GetString(1);
        //                regimen.regimen_precioBase = reader.GetDecimal(2);
        //                regimen.regimen_estado = reader.GetBoolean(3);
        //                break;
        //            }

        //            Conexion.Close();
        //        }
        //        return regimen;
        //    }
        //    catch (Exception ex)
        //    {
        //        string msj = ex.Message;
        //        throw;
        //    }
        //}
    }
}
