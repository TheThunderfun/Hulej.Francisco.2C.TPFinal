using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hulej.Francisco._2C.TPFinal
{
    public static class GestorSql
    {
        private static string stringConnection;

        static GestorSql()
        {
            GestorSql.stringConnection = "Server=.;Database=CineThun;Trusted_Connection=True";
        }



        public static void NuevoCliente(string nombre, string apellido, double dni, double tarjeta, int cantEntradas, int idPelicula, Guid nTransaccion,int idComboBox)
        {
            SqlConnection connection = new SqlConnection(GestorSql.stringConnection);
            string sentencia = $"INSERT INTO Clientes (nombre, apellido, dni,tarjeta,nTransaccion,cantEntradas,idPelicula,idComboBox)"+ "VALUES (@nombre,@apellido,@dni,@tarjeta,@nTransaccion,@cantEntradas,@idPelicula,@idComboBox)";
            SqlCommand command = new SqlCommand(sentencia,connection);

            try
            {
                command.Parameters.AddWithValue("nombre", nombre);
                command.Parameters.AddWithValue("apellido", apellido);
                command.Parameters.AddWithValue("dni", dni);
                command.Parameters.AddWithValue("tarjeta", tarjeta);
                command.Parameters.AddWithValue("nTransaccion", nTransaccion);
                command.Parameters.AddWithValue("cantEntradas", cantEntradas);
                command.Parameters.AddWithValue("idPelicula", idPelicula);
                command.Parameters.AddWithValue("idComboBOx", idComboBox);
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }

        }


        public static void GetAllClientes(List<Cliente> listaClientes)
        {
            SqlConnection connection = new SqlConnection(GestorSql.stringConnection);
            string sentencia = "SELECT * FROM CLIENTES ";
            Cliente cliente;
            string nombre;
            string apellido;
            double dni;
            Guid nTransaccion;
            double tarjeta;
            int cantEntradas;
            int idPeliculas;
            int idComboBox;
            try
            {
                SqlCommand command = new SqlCommand(sentencia, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    nombre = reader.GetString(0);
                    apellido = reader.GetString(1);
                    dni = reader.GetDouble(2);
                    tarjeta = reader.GetDouble(3);
                    nTransaccion = Guid.Parse(reader.GetString(4));
                    cantEntradas = reader.GetInt32(5);
                    idPeliculas = reader.GetInt32(6);
                    idComboBox = reader.GetInt32(7);

                    cliente = new Cliente(nombre, apellido, dni, tarjeta, cantEntradas, idPeliculas,idComboBox);
                    listaClientes.Add(cliente);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }

        public static void GetAllEmpleados(List<Empleado> listaEmpleados)
        {
            SqlConnection connection = new SqlConnection(GestorSql.stringConnection);
            string sentencia = "SELECT * FROM EMPLEADO ";

            Empleado empleado;
            string nombre;
            string apellido;
            double dni;
            string puesto;
            int horasATranajar;

            try
            {
                SqlCommand command = new SqlCommand(sentencia, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    nombre = reader.GetString(0);
                    apellido = reader.GetString(1);
                    dni = reader.GetDouble(2);
                    puesto = reader.GetString(3);
                    horasATranajar = int.Parse(reader.GetString(4));

                    empleado = new Empleado(nombre, apellido, dni, horasATranajar);
                    listaEmpleados.Add(empleado);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public static void GetAllPeliculas(List<Pelicula> listaPeliculas)
        {
            SqlConnection connection = new SqlConnection(GestorSql.stringConnection);
            string sentencia = "SELECT * FROM  PELICULAS ";

            Pelicula pelicula;
            string nombre;
            int duracion;
            int cantEntradas;
            int idPeliculas;

            try
            {
                SqlCommand command = new SqlCommand(sentencia, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    nombre = reader.GetString(0);
                    duracion = reader.GetInt32(1);
                    cantEntradas = reader.GetInt32(2);
                    idPeliculas = reader.GetInt32(3);

                    pelicula = new Pelicula(nombre,duracion,cantEntradas);
                    listaPeliculas.Add(pelicula);
                }

            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public static void EditarCliente(int idABuscar,string nombre,string apellido,double dni,double tarjeta)
        {
            SqlConnection connection = new SqlConnection(GestorSql.stringConnection);
            string sentencia = "UPDATE CLIENTES SET Nombre="+nombre+", Apellido="+apellido+",Dni="+dni+", Tarjeta="+tarjeta;
            try
            {
                SqlCommand command = new SqlCommand(sentencia, connection);
                connection.Open();
                if(command.ExecuteNonQuery()==0) {
                    
                
                }

            }
            catch (SqlException ex)
            {

            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

    }

}
