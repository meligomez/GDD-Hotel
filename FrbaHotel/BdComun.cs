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
                SqlConnection Conexion = new SqlConnection(@"Data source=.;initial catalog=GD1C2018;User id=gdHotel2018; Password=gd2018");
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
