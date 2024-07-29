using AgroServicios.Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Web.Security;
using System.Windows.Forms;

namespace AgroServicios.Modelo.DAO
{
    class DAOProductos : DTOProductos
    {

        readonly SqlCommand Command = new SqlCommand();

        public DataSet ObtenerProductos()
        {
            try
            {
                //Accedemos a la conexión que ya se tiene
                Command.Connection = getConnection();
                //Instrucción que se hará hacia la base de datos
                string query = "SELECT * FROM Productos";
                //Comando sql en el cual se pasa la instrucción y la conexión
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                //Se ejecuta el comando y con ExecuteNonQuery se verifica su retorno
                //ExecuteNonQuery devuelve un valor entero.
                cmd.ExecuteNonQuery();
                //Se utiliza un adaptador sql para rellenar el dataset
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                //Se crea un objeto Dataset que es donde se devolverán los resultados
                DataSet ds = new DataSet();
                //Rellenamos con el Adaptador el DataSet diciendole de que tabla provienen los datos
                adp.Fill(ds, "Productos");
                //Devolvemos el Dataset
                return ds;
            }
            catch (Exception)
            {
                //Retornamos null si existiera algún error durante la ejecución
                return null;
            }
            finally
            {
                //Independientemente se haga o no el proceso cerramos la conexión
                getConnection().Close();
            }

        }

        public DataSet LlenarCombo()
        {
            try
            {
                //Se crea una conexión para garantizar que efectivamente haya conexión a la base.
                Command.Connection = getConnection();
                //**
                //Se crea el query que indica la acción que el sistema desea realizar con la base de datos
                //En caso sea una consulta parametrizada se deberá respetar la sintaxis sobre como colocar parametros en la instrucción sql (REVISAR LOS DEMÁS MANTENIMIENTOS PARA VER COMO SE CREAN PARAMETROS Y SE LES DA VALORES).
                string query = "SELECT * FROM Marcas";
                //Se crea un comando de tipo sql al cual se le pasa el query y la conexión, esto para que el sistema sepa que hacer y donde hacerlo.
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                //ExecuteNonQuery indicará cuantos filas fueron afectadas, es decir, cuantas filas de datos se ingresaron o encontraron, por lo general cuando es una consulta su valor puede ser 1 o mayor a 1.
                cmd.ExecuteNonQuery();
                //Se crea un objeto SqlDataAdapter para poder llenar el DataSet que posteriormente utilizaremos, además recibe el comando sql
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                //Se crea un DataSet que será el objeto de retorno del método
                DataSet ds = new DataSet();
                //Rellenamos el DataSet con los datos encontrados con el SqlDataAdapter, además, indicamos de donde provienen los datos
                adp.Fill(ds, "Marcas");
                //Retornamos el objeto DataSet
                return ds;
            }
            catch (Exception)
            {
                //Se retorna null si durate la ejecución del try ocurrió algún error
                return null;
            }
            finally
            {
                //Independientemente se haga o no el proceso cerramos la conexión
                getConnection().Close();
            }
        }

        public int RegistrarProducto()
        {
            try
            {
                //Se crea una conexión para garantizar que efectivamente haya conexión a la base.
                Command.Connection = getConnection();
                //**
                //Se crea el query que indica la acción que el sistema desea realizar con la base de datos
                //el query posee parametros para evitar algún tipo de ataque como SQL Injection
                string query2 = "INSERT INTO Productos(Nombre, idMarca, Precio, Stock, Descripcion) VALUES (@name, @price, @stock, @description, @idBrand)";
                //Se crea un comando de tipo sql al cual se le pasa el query y la conexión, esto para que el sistema sepa que hacer y donde hacerlo.
                SqlCommand cmd2 = new SqlCommand(query2, Command.Connection);
                //Se le da un valor a los parametros contenidos en el query, es importante mencionar que lo que esta entre comillas es el nombre del parametro y lo que esta después de la coma es el valor que se le asignará al parametro, estos valores vienen del DTO respectivo.
                cmd2.Parameters.AddWithValue("name", Nombre1);
                cmd2.Parameters.AddWithValue("price", Precio1);
                cmd2.Parameters.AddWithValue("stock", Stock1);
                //cmd2.Parameters.AddWithValue("imgNomrbe", ImgNombre);
                cmd2.Parameters.AddWithValue("description", Descripcion1);
                cmd2.Parameters.AddWithValue("idBrand", IdMarca);
                //Se ejecuta el comando ya con todos los valores de sus parametros.
                //ExecuteNonQuery indicará cuantos filas fueron afectadas, es decir, cuantas filas de datos se ingresaron, por lo general devolvera 1 porque se hace una inserción a la vez.
                int respuesta = cmd2.ExecuteNonQuery();
                //Se evalúa el valor de la variable respuesta que contiene el numero de filas afectadas
                if (respuesta == 1)
                {
                    //Si el valor de respuesta es 1, se procede a la inserción de los datos de la persona, como se puede observar en el diagrama de base de datos, primero es el usuario y despues la persona.
                    string query = "INSERT INTO Productos (Nombre, Precio, Stock, Descripcion, idMarca) VALUES (@param1, @param2, @param3, @param4, @param5)";
                    //Se crea un comando de tipo sql al cual se le pasa el query y la conexión, esto para que el sistema sepa que hacer y donde hacerlo.
                    SqlCommand cmd = new SqlCommand(query, Command.Connection);
                    //Se le da un valor a los parametros contenidos en el query, es importante mencionar que lo que esta entre comillas es el nombre del parametro y lo que esta después de la coma es el valor que se le asignará al parametro, estos valores vienen del DTO
                    cmd.Parameters.AddWithValue("param1", Nombre1);
                    cmd.Parameters.AddWithValue("param2", Precio1);
                    cmd.Parameters.AddWithValue("param3", Stock1);
                    //cmd.Parameters.AddWithValue("param4", ImgNombre);
                    cmd.Parameters.AddWithValue("param4", Descripcion1);
                    cmd.Parameters.AddWithValue("param5", IdMarca);
                    //Se ejecuta el comando ya con todos los valores de sus parametros.
                    //ExecuteNonQuery indicará cuantos filas fueron afectadas, es decir, cuantas filas de datos se ingresaron, por lo general devolvera 1 porque se hace una inserción a la vez.
                    respuesta = cmd.ExecuteNonQuery();
                    //Se retorna el valor de respuesta, que si su valor es 1 indica que los valores fueron ingresados.
                    return respuesta;
                }
                else
                {
                    //Se retorna cero si sus valores no pudieron ser ingresados
                    return 0;
                }
            }
            catch (Exception)
            {
                //Se retorna -1 en caso que en el segmento del try haya ocurrido algún error.
                return -1;
            }
            finally
            {
                //Independientemente se haga o no el proceso cerramos la conexión
                Command.Connection.Close();
            }
        }

        public int DeteleEmpleado()
        {
            try
            {
                Command.Connection = getConnection();

                string query = "DELETE Productos WHERE idProducto = @param1";

                SqlCommand cmd = new SqlCommand(query, Command.Connection);

                cmd.Parameters.AddWithValue("param1", IdProducto);

                int respuesta = cmd.ExecuteNonQuery();

                return respuesta;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                getConnection().Close();
            }

        }

        public int ActualizarProducto()
        {
            try
            {
                Command.Connection = getConnection();

                string query = "UPDATE Productos SET idProducto = @idproduct , Nombre = @nombre, Precio = @price, Stock = @stock, Descripcion = @description, idMarca = @idbrand WHERE idProducto = @idproduct";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);

                cmd.Parameters.AddWithValue("@idproduct",IdProducto);
                cmd.Parameters.AddWithValue("@nombre", Nombre1);
                cmd.Parameters.AddWithValue("@price", Precio1);
                cmd.Parameters.AddWithValue("@stock", Stock1);
                //cmd.Parameters.AddWithValue("@imgNombre", ImgNombre);
                cmd.Parameters.AddWithValue("@description", Descripcion1);
                cmd.Parameters.AddWithValue("@idbrand", IdMarca);

                int respuesta = cmd.ExecuteNonQuery();
                return respuesta;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                Command.Connection.Close();
            }
        }
    }
}
