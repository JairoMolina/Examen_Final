using Examen.Data.DataAccess;
using Examen.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Examen
{
    public partial class FormEnsamblador : Form
    {
        // INSTANCIAMOS UN OBJETO DE LA CLASE Vehiculo PARA TRABAJAR CON LOS DATOS DEL VEHICULO
        Vehiculo Veh = new Vehiculo();

        // INSTANCIAMOS UN OBJETO DE LA CLASE VehículoDB PARA CONECTARNOS A LA BASE DE DATOS
        VehículoDB Conexion = new VehículoDB();

        // CREAMOS UNA LISTA PARA ALMACENAR TODOS LOS VEHICULOS OBTENIDOS DE LA BASE DE DATOS
        List<Vehiculo> Todos;

        // INSTANCIAMOS UN OBJETO DE LA CLASE ManejoRegistros PARA GESTIONAR EL MANEJO DE REGISTROS
        ManejoRegistros Seleccion = new ManejoRegistros();

        // INSTANCIAMOS UN OBJETO DE LA CLASE VehículoDB PARA BUSCAR UN VEHICULO EN LA BASE DE DATOS
        VehículoDB BuscarVehiculo = new VehículoDB();

        // DECLARACIÓN DEL CAMPO DE LA CLASE VehículoDB
        private VehículoDB vehículo;


        // ARREGLO DE CADENAS PARA LOS TIPOS DE CAJA DE CAMBIOS DISPONIBLES
        private string[] TipoCaja =
        {
            "MECANICO",
            "AUTOMATICO"
        };

        // ARREGLO DE CADENAS PARA LOS TIPOS DE VEHICULOS DISPONIBLES
        private string[] TipoVehiculo =
        {
            "SEDAN",
            "MINIVAN",
            "PICK-UP",
            "CUPE",
            "STATION WAGON"
        };

        public FormEnsamblador()
        {
            InitializeComponent(); // INICIALIZA LOS COMPONENTES DEL FORMULARIO

            // CREA UNA NUEVA INSTANCIA DE LA CLASE VehículoDB PARA TRABAJAR CON LA BASE DE DATOS
            vehículo = new VehículoDB();
        }

        // METODO PARA INICIAR EL FORMULARIO, LIMPIAR LOS CONTROLES Y CARGAR LOS DATOS INICIALES
        private void Iniciar()
        {
            try
            {
                // LIMPIA LOS CONTROLES DEL FORMULARIO
                txtboxID.Clear();
                txtboxPlacas.Clear();
                comboxTipo.SelectedIndex = -1;
                comboxMarca.SelectedIndex = -1;
                comboxModelo.SelectedIndex = -1;
                txtboxColor.Clear();
                comboxCaja.SelectedIndex = -1;
                checkbox4x4.Checked = false;
                txtboxPropietario.Clear();
                dtpFecha.Value = DateTime.Now;

                // OBTIENE TODOS LOS VEHICULOS DESDE LA BASE DE DATOS
                Todos = Conexion.ObtenerTodosLosDatos();
                if (Todos.Count > 0)
                {
                    // ACTUALIZA EL TOTAL DE REGISTROS Y MUESTRA EL PRIMER VEHICULO ENCONTRADO
                    Seleccion.TotalRegistros = Todos.Count;
                    MostrarDatos(Todos[Seleccion.Actual]);
                }
                else
                {
                    // MUESTRA UN MENSAJE SI NO HAY REGISTROS EN LA BASE DE DATOS
                    MessageBox.Show("NO SE ENCONTRARON REGISTROS");
                }
            }
            catch (Exception ex)
            {
                // MUESTRA UN MENSAJE DE ERROR SI OCURRE UNA EXCEPCIÓN DURANTE EL PROCESO
                MessageBox.Show("ERROR AL INICIAR: " + ex.Message);
            }
        }

        // CARGA EL FORMULARIO POR PRIMERA VEZ
        private void Form1_Load(object sender, EventArgs e)
        {
            // AGREGA LOS ELEMENTOS DEL ARREGLO TipoVehiculo AL COMBOBOX comboxTipo
            comboxTipo.Items.AddRange(TipoVehiculo);

            // AGREGA LOS ELEMENTOS DEL ARREGLO TipoCaja AL COMBOBOX comboxCaja
            comboxCaja.Items.AddRange(TipoCaja);

            // INICIA EL FORMULARIO, LIMPIA LOS CONTROLES Y CARGA LOS DATOS INICIALES
            Iniciar();
        }


        // PRUEBA LA CONEXION ENTRE WORKBENCH Y VS
        private void btnPrueba_Click(object sender, EventArgs e)
        {
            // VERIFICA SI LA CONEXIÓN ES EXITOSA LLAMANDO AL MÉTODO ProbarConexion DE LA CLASE VehículoDB
            if (vehículo.ProbarConexion())
            {
                // MUESTRA UN MENSAJE SI LA CONEXIÓN ES EXITOSA
                MessageBox.Show("CONEXIÓN EXITOSA");
            }
            else
            {
                // MUESTRA UN MENSAJE SI LA CONEXIÓN FALLA
                MessageBox.Show("CONEXIÓN FALLIDA");
            }
        }

        // CREA UN NUEVO REGISTRO
        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                // INSERTAR LOS VALORES DEL VEHÍCULO DESDE LOS CONTROLES DEL FORMULARIO
                Veh.ID = Convert.ToInt32(txtboxID.Text);
                Veh.Placas = txtboxPlacas.Text.ToUpper();
                Veh.Tipo = comboxTipo.Text;
                Veh.Marca = comboxMarca.Text;
                Veh.Modelo = comboxModelo.Text;
                Veh.Color = txtboxColor.Text.ToUpper();
                Veh.Caja = comboxCaja.Text;
                Veh.Traccion = checkbox4x4.Checked;
                Veh.Propietario = txtboxPropietario.Text.ToUpper();
                Veh.FechaCreacion = dtpFecha.Value;

                // PREGUNTAR AL USUARIO SI ESTÁ SEGURO DE CREAR EL REGISTRO
                DialogResult result = MessageBox.Show("¿ESTÁ SEGURO DE CREAR EL REGISTRO?", "CONFIRMAR CREACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // SI EL USUARIO CONFIRMA LA OPERACIÓN
                if (result == DialogResult.Yes)
                {
                    // INSERTA LOS DATOS DEL VEHÍCULO EN LA BASE DE DATOS
                    Conexion.InsertarDatos(Veh);

                    // ACTUALIZA EL DATAGRIDVIEW CON LOS DATOS ACTUALIZADOS DESDE LA BASE DE DATOS
                    dtagridwTabla.DataSource = vehículo.MostrarTabla();

                    // MUESTRA UN MENSAJE DE ÉXITO
                    MessageBox.Show("REGISTRO CREADO CON ÉXITO", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // MUESTRA UN MENSAJE DE CANCELACIÓN
                    MessageBox.Show("CREACIÓN DE REGISTRO CANCELADA", "CANCELADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // MUESTRA UN MENSAJE DE ERROR SI OCURRE UNA EXCEPCIÓN AL INSERTAR LOS DATOS
                MessageBox.Show("ERROR AL CREAR REGISTRO: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // DICCIONARIO PARA ALMACENAR LAS MARCAS DISPONIBLES POR TIPO DE VEHÍCULO
        private Dictionary<string, List<string>> marcasPorTipo = new Dictionary<string, List<string>>
        {
            {"SEDAN", new List<string> {"HONDA", "MAZDA", "TOYOTA"}},
            {"MINIVAN", new List<string> {"CHRYSLER", "KIA", "VOLKSWAGEN"}},
            {"PICK-UP", new List<string> {"FORD", "RAM"}},
            {"CUPE", new List<string> {"AUDI", "BMW"}},
            {"STATION WAGON", new List<string> {"SUBARU", "VOLVO"}}
        };

        // DICCIONARIO PARA ALMACENAR LOS MODELOS DISPONIBLES POR MARCA
        private Dictionary<string, List<string>> modelosPorMarca = new Dictionary<string, List<string>>
        {
            {"HONDA", new List<string> {"ACCORD", "CIVIC", "INSIGHT"}},
            {"MAZDA", new List<string> {"2", "3", "6"}},
            {"TOYOTA", new List<string> {"AVALON", "CAMRY", "CORROLLA"}},
            {"CHRYSLER", new List<string> {"PACIFICA", "VOYAGER"}},
            {"KIA", new List<string> {"CARENS", "CARNIVAL", "SEDONA"}},
            {"VOLKSWAGEN", new List<string> {"CARAVELLE", "TOURAN"}},
            {"FORD", new List<string> {"F-150", "RANGER", "SUPER DUTY"}},
            {"RAM", new List<string> {"1500", "2500", "3500"}},
            {"AUDI", new List<string> {"A5", "S5", "TT"}},
            {"BMW", new List<string> {"M4", "SERIE 2", "SERIE 4"}},
            {"SUBARU", new List<string> {"LEGACY", "LEVORG", "OUTBLACK"}},
            {"VOLVO", new List<string> {"V60", "V90"}}
        };

        // SELECCIONA EL TIPO DE VEHICULO
        private void comboxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // OBTENER EL TIPO DE VEHÍCULO SELECCIONADO
            string tipoSeleccionado = comboxTipo.SelectedItem?.ToString();

            // LIMPIAR LA SELECCIÓN DEL COMBOBOX DE MARCA
            comboxMarca.SelectedIndex = -1;

            // LIMPIAR LOS ELEMENTOS DEL COMBOBOX DE MARCA
            comboxMarca.Items.Clear();

            // ACTUALIZAR LAS MARCAS DISPONIBLES SEGÚN EL TIPO DE VEHÍCULO SELECCIONADO
            if (tipoSeleccionado != null && marcasPorTipo.ContainsKey(tipoSeleccionado))
            {
                comboxMarca.Items.AddRange(marcasPorTipo[tipoSeleccionado].ToArray());
            }
        }

        // SELECCIONA LA MARCA
        private void comboxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            // OBTENER LA MARCA DE VEHÍCULO SELECCIONADA
            string marcaSeleccionada = comboxMarca.SelectedItem?.ToString();

            // LIMPIAR LA SELECCIÓN DEL COMBOBOX DE MODELO
            comboxModelo.SelectedIndex = -1;

            // LIMPIAR LOS ELEMENTOS DEL COMBOBOX DE MODELO
            comboxModelo.Items.Clear();

            // ACTUALIZAR LOS MODELOS DISPONIBLES SEGÚN LA MARCA DE VEHÍCULO SELECCIONADA
            if (marcaSeleccionada != null && modelosPorMarca.ContainsKey(marcaSeleccionada))
            {
                comboxModelo.Items.AddRange(modelosPorMarca[marcaSeleccionada].ToArray());
            }
        }

        // ACTUALIZA UN REGISTRO
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // OBTIENE LOS DATOS DEL VEHÍCULO DESDE LOS CONTROLES DEL FORMULARIO
                Veh.ID = Convert.ToInt32(txtboxID.Text);
                Veh.Placas = txtboxPlacas.Text.ToUpper();
                Veh.Tipo = comboxTipo.Text;
                Veh.Marca = comboxMarca.Text;
                Veh.Modelo = comboxModelo.Text;
                Veh.Color = txtboxColor.Text.ToUpper();
                Veh.Caja = comboxCaja.Text;
                Veh.Traccion = checkbox4x4.Checked;
                Veh.Propietario = txtboxPropietario.Text.ToUpper();
                Veh.FechaCreacion = dtpFecha.Value;

                // PREGUNTAR AL USUARIO SI ESTÁ SEGURO DE ACTUALIZAR EL REGISTRO
                DialogResult result = MessageBox.Show("¿ESTÁ SEGURO DE ACTUALIZAR EL REGISTRO?", "CONFIRMAR ACTUALIZACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // SI EL USUARIO CONFIRMA LA OPERACIÓN
                if (result == DialogResult.Yes)
                {
                    // ACTUALIZA LOS DATOS DEL VEHÍCULO EN LA BASE DE DATOS
                    Conexion.ActualizarDatos(Veh);

                    // ACTUALIZA EL DATAGRIDVIEW CON LOS DATOS ACTUALIZADOS DESDE LA BASE DE DATOS
                    dtagridwTabla.DataSource = vehículo.MostrarTabla();

                    // MUESTRA UN MENSAJE DE ÉXITO
                    MessageBox.Show("REGISTRO ACTUALIZADO CON ÉXITO", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // MUESTRA UN MENSAJE DE ERROR SI OCURRE UNA EXCEPCIÓN AL ACTUALIZAR LOS DATOS
                MessageBox.Show("ERROR AL ACTUALIZAR EL REGISTRO: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ELIMINA UN REGISTRO
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // OBTIENE EL ID DEL VEHÍCULO A ELIMINAR DESDE EL TEXTO EN EL CUADRO DE TEXTO
                int id = Convert.ToInt32(txtboxID.Text);

                // PREGUNTA AL USUARIO SI ESTÁ SEGURO DE ELIMINAR EL REGISTRO
                DialogResult result = MessageBox.Show("¿ESTÁ SEGURO DE ELIMINAR EL REGISTRO?", "CONFIRMAR ELIMINACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // SI EL USUARIO CONFIRMA LA OPERACIÓN
                if (result == DialogResult.Yes)
                {
                    // LLAMA AL MÉTODO PARA BORRAR EL VEHÍCULO DE LA BASE DE DATOS
                    int respuesta = vehículo.BorrarDatos(id);

                    // VERIFICA SI EL REGISTRO SE ELIMINÓ CORRECTAMENTE
                    if (respuesta > 0)
                    {
                        // LIMPIA LOS CONTROLES DEL FORMULARIO
                        txtboxID.Clear();
                        txtboxPlacas.Clear();
                        comboxTipo.SelectedIndex = -1;
                        comboxMarca.SelectedIndex = -1;
                        comboxModelo.SelectedIndex = -1;
                        txtboxColor.Clear();
                        comboxCaja.SelectedIndex = -1;
                        checkbox4x4.Checked = false;
                        txtboxPropietario.Clear();

                        // ACTUALIZA EL DATAGRIDVIEW CON LOS DATOS ACTUALIZADOS DESDE LA BASE DE DATOS
                        dtagridwTabla.DataSource = vehículo.MostrarTabla();

                        // MUESTRA UN MENSAJE DE ÉXITO
                        MessageBox.Show("ELIMINADO CON ÉXITO");
                    }
                    else
                    {
                        // MUESTRA UN MENSAJE DE ERROR SI EL REGISTRO NO SE ELIMINÓ CORRECTAMENTE
                        MessageBox.Show("HUBO UN ERROR AL ELIMINAR EL REGISTRO");
                    }
                }
            }
            catch (Exception ex)
            {
                // MUESTRA UN MENSAJE DE ERROR SI OCURRE UNA EXCEPCIÓN
                MessageBox.Show("ERROR AL ELIMINAR EL REGISTRO: " + ex.Message);
            }
        }

        // MUESTRA LA TABLA DE VEHICULOS
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                // OBTIENE LOS DATOS DE LA TABLA DE VEHÍCULOS DESDE LA BASE DE DATOS
                DataTable dt = vehículo.MostrarTabla();

                // ASIGNA LOS DATOS AL DATAGRIDVIEW
                dtagridwTabla.DataSource = dt;
            }
            catch (Exception ex)
            {
                // MUESTRA UN MENSAJE DE ERROR SI OCURRE UNA EXCEPCIÓN AL MOSTRAR LA TABLA
                MessageBox.Show("Error al mostrar la tabla: " + ex.Message);
            }
        }

        // BUSCA UN REGISTRO POR SU ID
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // OBTIENE EL REGISTRO CORRESPONDIENTE AL ID PROPORCIONADO DESDE LA BASE DE DATOS
                DataRow Del = BuscarVehiculo.BuscarID(int.Parse(txtboxID.Text));

                // VERIFICA SI SE ENCONTRÓ EL REGISTRO
                if (Del != null)
                {
                    // ASIGNA LOS VALORES DEL REGISTRO A LOS CONTROLES DEL FORMULARIO
                    txtboxPlacas.Text = Del["Placas"].ToString();
                    comboxTipo.Text = Del["Tipo"].ToString();
                    comboxMarca.Text = Del["Marca"].ToString();
                    comboxModelo.Text = Del["Modelo"].ToString();
                    txtboxColor.Text = Del["Color"].ToString();
                    comboxCaja.Text = Del["Caja"].ToString();
                    checkbox4x4.Checked = Convert.ToBoolean(Del["Traccion4x4"]);
                    txtboxPropietario.Text = Del["Propietario"].ToString();
                }
                else
                {
                    // MUESTRA UN MENSAJE SI NO SE ENCONTRÓ EL REGISTRO
                    MessageBox.Show("No se encontró el registro");
                }
            }
            catch (Exception ex)
            {
                // MUESTRA UN MENSAJE DE ERROR SI OCURRE UNA EXCEPCIÓN AL BUSCAR EL REGISTRO
                MessageBox.Show("Error al buscar el registro: " + ex.Message);
            }
        }

        // MUESTRA EL FORMULARIO EN LAS CAJAS DE TEXTO
        private void MostrarDatos(Vehiculo veh)
        {
            try
            {
                // ASIGNA LOS VALORES DEL VEHÍCULO A LOS CONTROLES DEL FORMULARIO
                txtboxID.Text = veh.ID.ToString();
                txtboxPlacas.Text = veh.Placas;
                comboxTipo.SelectedIndex = comboxTipo.FindStringExact(veh.Tipo);
                comboxMarca.SelectedIndex = comboxMarca.FindStringExact(veh.Marca);
                comboxModelo.SelectedIndex = comboxModelo.FindStringExact(veh.Modelo);
                txtboxColor.Text = veh.Color;
                comboxCaja.SelectedIndex = comboxCaja.FindStringExact(veh.Caja);
                checkbox4x4.Checked = veh.Traccion;
                txtboxPropietario.Text = veh.Propietario;
                dtpFecha.Value = veh.FechaCreacion;

            }
            catch (Exception ex)
            {
                // MUESTRA UN MENSAJE DE ERROR SI OCURRE UNA EXCEPCIÓN AL MOSTRAR LOS DATOS DEL VEHÍCULO
                MessageBox.Show("Error al mostrar los datos del vehículo: " + ex.Message);
            }
        }

        // MUESTRA EL REGISTRO ANTERIOR
        private void btnAtras_Click(object sender, EventArgs e)
        {
            try
            {
                // VERIFICA SI HAY UN REGISTRO ANTERIOR
                if (Seleccion.Actual > 0)
                {
                    // DISMINUYE EL ÍNDICE PARA MOSTRAR EL REGISTRO ANTERIOR
                    Seleccion.Actual--;
                }
                else
                {
                    // SI NO HAY REGISTRO ANTERIOR, VUELVE AL ÚLTIMO REGISTRO
                    Seleccion.Actual = Seleccion.TotalRegistros - 1;
                    MessageBox.Show("Inicio de los registros, volviendo al final.");
                }

                // MUESTRA LOS DATOS DEL REGISTRO SELECCIONADO
                MostrarDatos(Todos[Seleccion.Actual]);
            }
            catch (Exception ex)
            {
                // MUESTRA UN MENSAJE DE ERROR SI OCURRE UNA EXCEPCIÓN AL IR AL REGISTRO ANTERIOR
                MessageBox.Show("Error al retroceder al registro anterior: " + ex.Message);
            }
        }

        // MUESTRA EL REGISTRO POSTERIOR
        private void btnAdelante_Click(object sender, EventArgs e)
        {
            try
            {
                // VERIFICA SI HAY UN SIGUIENTE REGISTRO
                if (Seleccion.Actual < Seleccion.TotalRegistros - 1)
                {
                    // AUMENTA EL ÍNDICE PARA MOSTRAR EL SIGUIENTE REGISTRO
                    Seleccion.Actual++;
                }
                else
                {
                    // SI NO HAY SIGUIENTE REGISTRO, VUELVE AL PRIMER REGISTRO
                    Seleccion.Actual = 0;
                    MessageBox.Show("Fin de los registros, volviendo al inicio.");
                }

                // MUESTRA LOS DATOS DEL REGISTRO SELECCIONADO
                MostrarDatos(Todos[Seleccion.Actual]);
            }
            catch (Exception ex)
            {
                // MUESTRA UN MENSAJE DE ERROR SI OCURRE UNA EXCEPCIÓN AL IR AL SIGUIENTE REGISTRO
                MessageBox.Show("Error al avanzar al siguiente registro: " + ex.Message);
            }
        }

        // DEJA EN BLANCO TODOS LOS CAMPOS
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                // LIMPIA LOS CONTROLES DEL FORMULARIO
                txtboxID.Clear();
                txtboxPlacas.Clear();
                comboxTipo.SelectedIndex = -1;
                comboxMarca.SelectedIndex = -1;
                comboxModelo.SelectedIndex = -1;
                txtboxColor.Clear();
                comboxCaja.SelectedIndex = -1;
                checkbox4x4.Checked = false;
                txtboxPropietario.Clear();

                // MUESTRA UN MENSAJE DE ÉXITO
                MessageBox.Show("LIMPIO CON ÉXITO");
            }
            catch (Exception ex)
            {
                // MUESTRA UN MENSAJE DE ERROR SI OCURRE UNA EXCEPCIÓN
                MessageBox.Show("ERROR AL LIMPIAR: " + ex.Message);
            }
        }
    }
}