using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroServicios.Modelo
{
    public class dbContext
    {
        public static SqlConnection getConnection()
        {
            try
            {
                //string server = "DESKTOP-QR03KRF";
                string server = "FELIPE\\SQLEXPRESS";
                string database = "Base_de_datos_Agro";
                SqlConnection conexion = new SqlConnection("Server =" + server +
                                                                 "; DataBase = " + database +
                                                                 "; Integrated Security = true;");
                conexion.Open();
                return conexion;
            }
            catch (Exception)
            {
                return null;
            }

        }

       
    }
}
