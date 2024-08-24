using AgroServicios.Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroServicios.Modelo.DAO
{
    class DAOClientes : DTOClientes
    {
        readonly SqlCommand Command = new SqlCommand();

        public DataSet ObtenerClientes()
        {
            try
            {
                //Accedemos a la coneccion de slq por medio de un comando
                Command.Connection = getConnection();
                //Creamos la instruccion que queremos que haga sql
                string query = "SELECT * FROM Clientes";
                //Ahora mandamos esta misma instruccion a sql y tambien por medio de este comando mandamos la respuesta de slq
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.ExecuteNonQuery();
                //Realizamos un adaptador para poder rellenar el data set
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                //Creamos un objeto del dataset el cual ayudara para devolver los resultados
                DataSet ds = new DataSet();
                //Rellenamos el dataset indicandole de que tabla debe de el rellenar los datos
                adp.Fill(ds, "Clientes");
                //Devolvemos el data set
                return ds;
            }
            catch (Exception)
            {
                //Returnamos null si la conexion no fallo
                return null;
            }
            finally
            {
                getConnection().Close();
            }
        }

        public int RetgistraCliente()
        {
            try
            {
                //Realizamos la coneccion a la base de datos
                Command.Connection = getConnection();
                //Realizamos la instrucciones que queremos que haga la base de datos
                string query2 = "INSERT INTO Clientes(Nombre, Telefono, Correo, Direccion)" + "VALUES (@name, @phone, @mail, @direccion)";
                //Pormedio de esto mandamos la instruccion que formulamos a la base de datos
                SqlCommand cmd2 = new SqlCommand(query2, Command.Connection);
                //Les daremos valores a los parametros del dto para realizar la insercion
                cmd2.Parameters.AddWithValue("name", Nombre1);
                cmd2.Parameters.AddWithValue("phone", Telefono1);
                cmd2.Parameters.AddWithValue("mail", Correo1);
                cmd2.Parameters.AddWithValue("direccion", Dirreccion1);
                //Ya se ejecuta el comando por que ya les agregamos sus respectivos parametros
                //Esta variable servira para comprovar si el comando tu exito
                int respuesta = cmd2.ExecuteNonQuery();
                if (respuesta == 1)
                {
                    //Si la respuesta es 1 entonces realizaremos si osi la insercion debidamente
                    string query = "INSERT INTO Clientes(idCliente, Nombre, Telefono, Correo, Direccion)" + "VALUES (@param1, @param2, @param3, @param4, @param5)";
                    //Realizamos el parametro que a cabamos de formular 
                    SqlCommand cmd = new SqlCommand(query, Command.Connection);
                    //Le damos una rellenada a los parametros en el query por medio de los parametros del DTO
                    cmd.Parameters.AddWithValue("@param1", IdCliente);
                    cmd.Parameters.AddWithValue("@param2", Nombre1);
                    cmd.Parameters.AddWithValue("@param3", Telefono1);
                    cmd.Parameters.AddWithValue("@param4", Correo1);
                    cmd.Parameters.AddWithValue("@param5", Dirreccion1);
                    //Ejecutamos este parametro ya seleccionados sus respectivos parametros 
                    //Con esto indicaremos que filas fueron fueron exitosas, lo normal es que diga 1 eso quiere decir que si se pudo realizar la inserccion pero si no es 1 es por que ubo un error
                    respuesta = cmd.ExecuteNonQuery();
                    return respuesta;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                //A ocurrido un error
                return -1;
            }
            finally
            {
                Command.Connection.Close();
            }
        }

        public int DeleteCLiente()
        {
            try
            {
                Command.Connection = getConnection();

                string query = "DELETE Clientes WHERE idCliente = @param1";

                SqlCommand cmd = new SqlCommand(query, Command.Connection);

                cmd.Parameters.AddWithValue("param1", IdCliente);

                int respuesta = cmd.ExecuteNonQuery();

                if (respuesta == 1)
                {
                    return respuesta;
                }
                else
                {
                    return 0;
                }
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

        public int ActualizarCliente()
        {
            try
            {
                Command.Connection = getConnection();

                string query = "UPDATE Clientes SET Nombre = @name, Telefono = @phone, Correo = @email, Direccion = @direction WHERE idCliente = @idClient";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);

                cmd.Parameters.AddWithValue("@idClient", IdCliente);
                cmd.Parameters.AddWithValue("@name", Nombre1);
                cmd.Parameters.AddWithValue("@phone", Telefono1);
                cmd.Parameters.AddWithValue("@email", Correo1);
                cmd.Parameters.AddWithValue("@direction", Dirreccion1);

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
