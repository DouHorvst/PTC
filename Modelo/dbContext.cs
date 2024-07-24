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
                //Conextor a base de datos local
                //string server = "DESKTOP-QR03KRF";
                //string server = "FELIPE\\SQLEXPRESS";
                //string database = "Base_de_datos_Agro";
                //SqlConnection conexion = new SqlConnection("Server =" + server +
                //                                                 "; DataBase = " + database +
                //                                                 "; Integrated Security = true;");
                
                //Conector a base de datos en linea
                string server = "SQL8006.site4now.net";
                string database = "db_aab115_siasbase";
                string userId = "db_aab115_siasbase_admin";
                string Password = "MichI#12@3";
                SqlConnection conexion = new SqlConnection($"Server = {server}; DataBase = {database}; User Id = {userId}; Password = {Password}");
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
