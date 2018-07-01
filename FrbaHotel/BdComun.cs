using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel
{
    public class BdComun
    {
        public static SqlConnection ObtenerConexion()
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(@"Server=LAPTOP-3EPVVMOD\Javi;initial catalog=GD1C2018;Trusted_Connection=True;MultipleActiveResultSets=true");
                Conexion.Open();
                return Conexion;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
