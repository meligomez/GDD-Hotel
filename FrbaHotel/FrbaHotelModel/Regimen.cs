using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.FrbaHotelModel
{
    public class Regimen
    {
        public int regimen_Id { get; set; }
        public String regimen_Descripcion { get; set; }
        public decimal regimen_precioBase { get; set; }
        public bool regimen_estado { get; set; }
		public Regimen()
		{
				
		}
		public Regimen(int regimenId,string descripcion)
		{
			this.regimen_Id = regimen_Id;
			this.regimen_Descripcion = descripcion;
		}
        public List<Regimen> getRegimenes(String rolUsuario)
        {   
            try
            {
                if (rolUsuario!="administrador")
                {
                    return null;
                }
                List<Regimen> regimens = new List<Regimen>();
                using (SqlConnection Conexion = BdComun.ObtenerConexion())
                {
                    SqlCommand Comando = new SqlCommand(String.Format("select r.regimen_Id," +
                        "r.regimen_Descripcion,r.regimen_precioBase, r.regimen_estado " +
                        "FROM " +
                        "pero_compila.Regimen r " +
                        "WHERE r.regimen_estado= 1 "), Conexion);
                    SqlDataReader reader = Comando.ExecuteReader();
                    
                    while (reader.Read())
                    {Regimen regimen = new Regimen();
                        regimen.regimen_Id = reader.GetInt32(0);
                        regimen.regimen_Descripcion = reader.GetString(1);
                        regimen.regimen_precioBase = reader.GetDecimal(2);
                        regimen.regimen_estado = reader.GetBoolean(3);
                        regimens.Add(regimen);
                    }
                    Conexion.Close();
                }
                return regimens;

            }
            catch (Exception ex)
            {
                string msj = ex.Message;
                throw;
            }
            
        }
		public List<Regimen> getRegimenes(int hotelId)
		{
			try
			{
				List<Regimen> regimens = new List<Regimen>();
				using (SqlConnection Conexion = BdComun.ObtenerConexion())
				{
					SqlCommand comando = new SqlCommand("pero_compila.getRegimenesPorHotel", Conexion);
					comando.CommandType = CommandType.StoredProcedure;
					//se limpian los parámetros
					comando.Parameters.Clear();
					//comenzamos a mandar cada uno de los parámetros, deben de enviarse en el
					//tipo de datos que coincida en sql server por ejemplo c# es string en sql server es varchar()
					comando.Parameters.AddWithValue("@idHotel", hotelId);
					SqlDataReader reader = comando.ExecuteReader();
					while (reader.Read())
					{
						Regimen regimen = new Regimen();
						regimen.regimen_Id = reader.GetInt32(0);
						regimen.regimen_Descripcion = reader.GetString(1);
						regimen.regimen_precioBase = reader.GetDecimal(2);
						regimen.regimen_estado = reader.GetBoolean(3);
						regimens.Add(regimen);
					}
					Conexion.Close();
				}
				return regimens;

			}
			catch (Exception ex)
			{
				string msj = ex.Message;
				throw;
			}
		}
		public List<Regimen> getRegimenes()
		{
			try
			{
				List<Regimen> regimens = new List<Regimen>();
				using (SqlConnection Conexion = BdComun.ObtenerConexion())
				{
					SqlCommand Comando = new SqlCommand(String.Format("select r.regimen_Id," +
						"r.regimen_Descripcion,r.regimen_precioBase, r.regimen_estado " +
						"FROM " +
						"pero_compila.Regimen r " +
						"WHERE r.regimen_estado= 1 "), Conexion);
					SqlDataReader reader = Comando.ExecuteReader();

					while (reader.Read())
					{
						Regimen regimen = new Regimen();
						regimen.regimen_Id = reader.GetInt32(0);
						regimen.regimen_Descripcion = reader.GetString(1);
						regimen.regimen_precioBase = reader.GetDecimal(2);
						regimen.regimen_estado = reader.GetBoolean(3);
						regimens.Add(regimen);
					}
					Conexion.Close();
				}
				return regimens;

			}
			catch (Exception ex)
			{
				string msj = ex.Message;
				throw;
			}
		}
			public int addRegimen(Regimen regimen)
        {
            SqlConnection Conexion = BdComun.ObtenerConexion();
            try
            {
                SqlCommand comando = new SqlCommand("pero_compila.[sp_alta_regimen]", Conexion);
                comando.CommandType = CommandType.StoredProcedure;
                //se limpian los parámetros
                comando.Parameters.Clear();
                //comenzamos a mandar cada uno de los parámetros, deben de enviarse en el
                //tipo de datos que coincida en sql server por ejemplo c# es string en sql server es varchar()
                comando.Parameters.AddWithValue("@regimen_Descripcion", regimen.regimen_Descripcion);
                comando.Parameters.AddWithValue("@regimen_precioBase", regimen.regimen_precioBase);
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
        public int UpdateRegimen(Regimen regimen)
        {
            SqlConnection Conexion = BdComun.ObtenerConexion();
            try
            {
                SqlCommand comando = new SqlCommand("pero_compila.[sp_actualizar_regimen]", Conexion);
                comando.CommandType = CommandType.StoredProcedure;
                //se limpian los parámetros
                comando.Parameters.Clear();
                //comenzamos a mandar cada uno de los parámetros, deben de enviarse en el
                //tipo de datos que coincida en sql server por ejemplo c# es string en sql server es varchar()
                comando.Parameters.AddWithValue("@regimen_Id", regimen.regimen_Id);
                comando.Parameters.AddWithValue("@regimen_Descripcion", regimen.regimen_Descripcion);
                comando.Parameters.AddWithValue("@regimen_precioBase", regimen.regimen_precioBase);
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
        public Regimen GetRegimenById(int id)
        {
            try
            {
                if (id == 0) {
                    return null;
                }
                Regimen regimen = new Regimen();
                using (SqlConnection Conexion = BdComun.ObtenerConexion())
                {                    
                    SqlCommand Comando = new SqlCommand(String.Format("select r.regimen_Id," +
                            "r.regimen_Descripcion,r.regimen_precioBase, r.regimen_estado " +
                            "FROM " +
                            "pero_compila.Regimen r " +
                            "WHERE r.regimen_estado= 1 and r.regimen_Id= '{0}'", id), Conexion);
                    SqlDataReader reader = Comando.ExecuteReader();
                    while (reader.Read())
                    {
                        regimen.regimen_Id = reader.GetInt32(0);
                        regimen.regimen_Descripcion = reader.GetString(1);
                        regimen.regimen_precioBase = reader.GetDecimal(2);
                        regimen.regimen_estado = reader.GetBoolean(3);
                        break;
                    }

                    Conexion.Close();
                }
                return regimen;
            }
            catch (Exception ex)
            {
                string msj = ex.Message;
                throw;
            }
        }
        //public List<Sucursal> getListSucursales()
        //{
        //    List<Sucursal> sucs = new List<Sucursal>();

        //    using (SqlConnection Conexion = BDComun.ObtenerConexion())
        //    {
        //        SqlCommand Comando = new SqlCommand(String.Format("SELECT DISTINCT sucursal_Id,sucursal_nombre from pero_compila.Sucursal where sucursal_nombre not like 'null'"), Conexion);
        //        SqlDataReader reader = Comando.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            Sucursal s = new Sucursal();
        //            s.Id = reader.GetInt32(0);
        //            s.Nombre = reader.GetString(1);

        //            sucs.Add(s);
        //        }
        //        Conexion.Close();
        //    }
        //    return sucs;
        //}



    }
}
