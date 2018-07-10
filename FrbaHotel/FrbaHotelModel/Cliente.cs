using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.FrbaHotelModel
{
	public class Cliente
	{
		public decimal cliente_identificacion { get; set; }
		public string cliente_email { get; set; }
		public string cliente_nombre { get; set; }
		public string cliente_apellido { get; set; }

		public Cliente GetCliente(int identificacion, string mail)
		{
			try
			{
				if (identificacion == 0)
				{
					return null;
				}
				Cliente cliente = new Cliente();
				using (SqlConnection Conexion = BdComun.ObtenerConexion())
				{
					SqlCommand comando = new SqlCommand("[pero_compila].[getCliente]", Conexion);
					comando.CommandType = CommandType.StoredProcedure;
					//se limpian los parámetros
					comando.Parameters.Clear();
					//comenzamos a mandar cada uno de los parámetros, deben de enviarse en el
					//tipo de datos que coincida en sql server por ejemplo c# es string en sql server es varchar()
					comando.Parameters.AddWithValue("@identificaccion", identificacion);
					comando.Parameters.AddWithValue("@mail", mail);
					
					SqlDataReader reader = comando.ExecuteReader();
					while (reader.Read())
					{
						cliente.cliente_identificacion = reader.GetDecimal(0);
						cliente.cliente_email = reader.GetString(1);
						cliente.cliente_nombre = reader.GetString(2);
						cliente.cliente_apellido = reader.GetString(3);
						break;
					}

					Conexion.Close();
				}
				return cliente;
			}
			catch (Exception ex)
			{
				string msj = ex.Message;
				return null;
			}
		}
	}
}
