using Examen.Data.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Examen.Data.DataAccess
{
    internal class VehículoDB
    {
        // CONECTAR A LA BASE DE DATOS EN WORKBENCH
        private string connectionString = "Server=localhost;Database=examen;Uid=root;Pwd=MyMolin@07*_";

        // METODO PARA PROBAR LA CONEXION ENTRE VISUAL STUDIO Y WORKBENCH
        public bool ProbarConexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); // INTENTA ABRIR LA CONEXION
                    return true; // SI TIENE ÉXITO, DEVUELVE VERDADERO
                }
                catch (Exception ex)
                {
                    // SI HAY UNA ERROR DEVUELVE FALSO
                    return false;
                }
            }
        }

        // METODO PARA MOSTRAR LOS DATOS DE LA TABLA DE VEHICULOS
        public DataTable MostrarTabla()
        {
            DataTable vehiculos = new DataTable();

            // INTENTA ESTABLECER UNA CONEXION A LA BASE DE DATOS
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM tabla_vehiculos"; // EJECUTA LA CONSULTA SQL

                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(vehiculos);
                    }
                }
            }
            return vehiculos; // DEVUELVE EL DATATABLE CON LOS DATOS DE LA TABLA
        }

        // METODO PARA INSERTAR DATOS EN LA TABLA DE VEHICULOS
        public void InsertarDatos(Vehiculo Veh)
        {
            // UTILIZA UNA NUEVA INSTANCIA DE MySqlConnection PARA ESTABLECER UNA CONEXIÓN A LA BASE DE DATOS
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // CONSULTA SQL PARA INSERTAR UN NUEVO REGISTRO EN LA TABLA
                    string query = "INSERT INTO tabla_vehiculos (ID, Placas, Tipo, Marca, Modelo, Color, Caja, Traccion4x4, Propietario, Fecha) VALUES (@ID, @Placas, @Tipo, @Marca, @Modelo, @Color, @Caja, @Traccion4x4, @Propietario, @Fecha)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // ASIGNA LOS PARÁMETROS DEL COMANDO
                    cmd.Parameters.AddWithValue("@ID", Veh.ID);
                    cmd.Parameters.AddWithValue("@Placas", Veh.Placas);
                    cmd.Parameters.AddWithValue("@Tipo", Veh.Tipo);
                    cmd.Parameters.AddWithValue("@Marca", Veh.Marca);
                    cmd.Parameters.AddWithValue("@Modelo", Veh.Modelo);
                    cmd.Parameters.AddWithValue("@Color", Veh.Color);
                    cmd.Parameters.AddWithValue("@Caja", Veh.Caja);
                    cmd.Parameters.AddWithValue("@Traccion4x4", Veh.Traccion);
                    cmd.Parameters.AddWithValue("@Propietario", Veh.Propietario);
                    cmd.Parameters.AddWithValue("@Fecha", Veh.FechaCreacion);

                    connection.Open();
                    cmd.ExecuteNonQuery(); // EJECUTA EL COMANDO PARA INSERTAR LOS DATOS EN LA TABLA
                }
                catch (Exception ex)
                {
                    // PROPAGA LA EXCEPCIÓN PARA QUE SEA MANEJADA EN EL FORMULARIO
                    throw new Exception("ERROR AL AGREGAR EL REGISTRO: " + ex.Message);
                }
                finally
                {
                    connection.Close(); // CIERRA LA CONEXIÓN
                }
            }
        }

        // METODO PARA ACTUALIZAR DATOS EN LA TABLA DE VEHICULOS
        public void ActualizarDatos(Vehiculo Veh)
        {
            // UTILIZA UNA NUEVA INSTANCIA DE MySqlConnection PARA ESTABLECER UNA CONEXION A LA BASE DE DATOS
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // CONSULTA SQL PARA ACTUALIZAR UN REGISTRO EN LA TABLA SEGUN EL ID
                    string query = "UPDATE tabla_vehiculos SET Placas = @Placas, Tipo = @Tipo, Marca = @Marca, Modelo = @Modelo, Color = @Color, Caja = @Caja, Traccion4x4 = @Traccion4x4, Propietario = @Propietario, Fecha = @Fecha WHERE ID = @ID";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    // ASIGNA LOS PARAMETROS DEL COMANDO
                    cmd.Parameters.AddWithValue("@ID", Veh.ID);
                    cmd.Parameters.AddWithValue("@Placas", Veh.Placas);
                    cmd.Parameters.AddWithValue("@Tipo", Veh.Tipo);
                    cmd.Parameters.AddWithValue("@Marca", Veh.Marca);
                    cmd.Parameters.AddWithValue("@Modelo", Veh.Modelo);
                    cmd.Parameters.AddWithValue("@Color", Veh.Color);
                    cmd.Parameters.AddWithValue("@Caja", Veh.Caja);
                    cmd.Parameters.AddWithValue("@Traccion4x4", Veh.Traccion);
                    cmd.Parameters.AddWithValue("@Propietario", Veh.Propietario);
                    cmd.Parameters.AddWithValue("@Fecha", Veh.FechaCreacion);

                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery(); // EJECUTA EL COMANDO Y OBTIENE EL NUMERO DE FILAS AFECTADAS
                }
                catch (Exception ex)
                {
                    // MUESTRA UN MENSAJE DE ERROR SI OCURRE UNA EXCEPCION DURANTE LA ACTUALIZACION
                    MessageBox.Show("ERROR AL ACTUALIZAR REGISTRO: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        // METODO PARA BORRAR UN VEHICULO DE LA TABLA POR SU ID
        public int BorrarDatos(int id)
        {
            // UTILIZA UNA NUEVA INSTANCIA DE MySqlConnection PARA ESTABLECER UNA CONEXIÓN A LA BASE DE DATOS
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // CONSULTA SQL PARA BORRAR UN REGISTRO DE LA TABLA SEGÚN EL ID
                    string sql = "DELETE FROM tabla_vehiculos WHERE id = @id";

                    // UTILIZA UN COMANDO PARA EJECUTAR LA CONSULTA SQL CON EL PARÁMETRO ID
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id); // ASIGNA EL VALOR DEL PARÁMETRO ID
                        return command.ExecuteNonQuery(); // EJECUTA EL COMANDO Y DEVUELVE EL NÚMERO DE FILAS AFECTADAS
                    }
                }
                catch (Exception ex)
                {
                    // MUESTRA UN MENSAJE DE ERROR SI OCURRE UNA EXCEPCIÓN DURANTE LA ELIMINACIÓN
                    MessageBox.Show("ERROR AL BORRAR EL REGISTRO: " + ex.Message);

                    // DEVUELVE -1 PARA INDICAR QUE HUBO UN ERROR
                    return -1;
                }
                finally
                {
                    connection.Close(); // CIERRA LA CONEXIÓN
                }
            }
        }

        // METODO PARA BUSCAR UN VEHICULO POR SU ID Y DEVOLVER SU INFORMACIONS
        public DataRow BuscarID(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                // CONSULTA SQL PARA SELECCIONAR UN REGISTRO DE LA TABLA SEGUN EL ID ESPECIFICADO
                string query = "SELECT * FROM tabla_vehiculos WHERE ID = @ID";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", id); // ASIGNA EL VALOR DEL PARAMETRO ID
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    connection.Open();
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                // MUESTRA UN MENSAJE DE ERROR SI OCURRE UNA EXCEPCION DURANTE LA LECTURA DEL REGISTRO
                MessageBox.Show("Error al leer el registro: " + ex.Message);
            }

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]; // DEVUELVE LA PRIMERA FILA DEL DATATABLE SI SE ENCONTRARON RESULTADOS
            }
            else
            {
                return null; // DEVUELVE NULL SI NO SE ENCONTRARON RESULTADOS
            }
        }

        // METODO PARA OBTENER TODOS LOS VEHICULOS DE LA TABLA Y DEVOLVERLOS COMO UNA LISTA
        public List<Vehiculo> ObtenerTodosLosDatos()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>(); // CREA UNA NUEVA LISTA PARA ALMACENAR LOS VEHICULOS
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM tabla_vehiculos"; // CONSULTA SQL PARA SELECCIONAR TODOS LOS REGISTROS DE LA TABLA
                MySqlCommand cmd = new MySqlCommand(query, connection); // UTILIZA UN COMANDO PARA EJECUTAR LA CONSULTA SQL

                try
                {
                    connection.Open(); // ABRE LA CONEXION A LA BASE DE DATOS
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // RECORRE CADA FILA DEL RESULTADO Y CREA UN OBJETO VEHICULO CON LOS DATOS OBTENIDOS
                    while (reader.Read())
                    {
                        Vehiculo nuevoVehiculo = new Vehiculo(
                            reader.GetInt32(reader.GetOrdinal("ID")),
                            reader.GetString(reader.GetOrdinal("Placas")),
                            reader.GetString(reader.GetOrdinal("Tipo")),
                            reader.GetString(reader.GetOrdinal("Marca")),
                            reader.GetString(reader.GetOrdinal("Modelo")),
                            reader.GetString(reader.GetOrdinal("Color")),
                            reader.GetString(reader.GetOrdinal("Caja")),
                            reader.GetBoolean(reader.GetOrdinal("Traccion4x4")),
                            reader.GetString(reader.GetOrdinal("Propietario")),
                            reader.GetDateTime(reader.GetOrdinal("Fecha"))
                        );

                        vehiculos.Add(nuevoVehiculo); // AGREGA EL NUEVO VEHICULO A LA LISTA
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    // MUESTRA UN MENSAJE DE ERROR SI OCURRE UNA EXCEPCION DURANTE LA LECTURA DE LOS REGISTROS
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return vehiculos; // DEVUELVE LA LISTA DE VEHICULOS
        }
    }
}