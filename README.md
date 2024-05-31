Aplicación de Gestión de Vehículos
- Estructura
El proyecto está organizado en las siguientes clases y archivos:
FormEnsamblador: Clase principal que representa el formulario de la aplicación y contiene la lógica de interacción con la interfaz de usuario.
Vehiculo: Clase que representa un vehículo y define sus propiedades.
VehículoDB: Clase que se encarga de la conexión y las operaciones con la base de datos MySQL.
ManejoRegistros: Clase auxiliar para gestionar el manejo de registros en la interfaz de usuario.

- Funcionalidades
- - Clase FormEnsamblador
Iniciar(): Método que se encarga de limpiar los controles del formulario, obtener todos los vehículos de la base de datos y mostrar el primer vehículo encontrado.
Form1_Load(): Método que se ejecuta cuando se carga el formulario por primera vez. Agrega los elementos de los arreglos TipoVehiculo y TipoCaja a los ComboBox correspondientes y llama al método Iniciar().
btnPrueba_Click(): Método que se ejecuta al hacer clic en el botón "Prueba". Verifica si la conexión a la base de datos es exitosa y muestra un mensaje correspondiente.
btnCrear_Click(): Método que se ejecuta al hacer clic en el botón "Crear". Obtiene los datos del vehículo desde los controles del formulario, inserta el registro en la base de datos y actualiza el DataGridView.
comboxTipo_SelectedIndexChanged(): Método que se ejecuta al seleccionar un tipo de vehículo en el ComboBox. Actualiza las marcas disponibles según el tipo seleccionado.
comboxMarca_SelectedIndexChanged(): Método que se ejecuta al seleccionar una marca de vehículo en el ComboBox. Actualiza los modelos disponibles según la marca seleccionada.
btnActualizar_Click(): Método que se ejecuta al hacer clic en el botón "Actualizar". Obtiene los datos actualizados del vehículo desde los controles del formulario y actualiza el registro correspondiente en la base de datos.
btnEliminar_Click(): Método que se ejecuta al hacer clic en el botón "Eliminar". Obtiene el ID del vehículo a eliminar y borra el registro correspondiente de la base de datos.
btnMostrar_Click(): Método que se ejecuta al hacer clic en el botón "Mostrar". Obtiene los datos de la tabla de vehículos desde la base de datos y los muestra en el DataGridView.
btnBuscar_Click(): Método que se ejecuta al hacer clic en el botón "Buscar". Obtiene el ID del vehículo a buscar y muestra los datos del registro correspondiente en los controles del formulario.
MostrarDatos(): Método que se encarga de mostrar los datos de un vehículo en los controles del formulario.
btnAtras_Click(): Método que se ejecuta al hacer clic en el botón "Atrás". Muestra el registro anterior de vehículo.
btnAdelante_Click(): Método que se ejecuta al hacer clic en el botón "Adelante". Muestra el siguiente registro de vehículo.
btnNuevo_Click(): Método que se ejecuta al hacer clic en el botón "Nuevo". Limpia todos los campos del formulario.

- - Clase VehículoDB
ProbarConexion(): Método que intenta establecer una conexión a la base de datos y devuelve true si tiene éxito, o false si falla.
MostrarTabla(): Método que obtiene todos los registros de la tabla de vehículos de la base de datos y los devuelve como un DataTable.
InsertarDatos(): Método que inserta un nuevo registro de vehículo en la base de datos utilizando los datos proporcionados.
ActualizarDatos(): Método que actualiza un registro de vehículo existente en la base de datos con los nuevos datos proporcionados.
BorrarPersonaje(): Método que borra un registro de vehículo de la base de datos según el ID proporcionado.
BuscarID(): Método que busca un registro de vehículo en la base de datos por su ID y devuelve los datos del registro como un DataRow.
ObtenerTodosLosUsuarios(): Método que obtiene todos los registros de vehículos de la base de datos y los devuelve como una lista de objetos Vehiculo.

- Configuración
Es necesario configurar los siguientes parámetros en la cadena de conexión:
Server: Nombre o dirección IP del servidor MySQL.
Database: Nombre de la base de datos.
Uid: Nombre de usuario para acceder a la base de datos.
Pwd: Contraseña para acceder a la base de datos.
Asegúrate de tener una base de datos MySQL configurada con la estructura de tabla adecuada para almacenar la información de los vehículos.

- Dependencias
MySql.Data: Biblioteca para la conexión y interacción con la base de datos MySQL.
System.Windows.Forms: Biblioteca para el desarrollo de aplicaciones de Windows Forms.
Para que funcione este proyecto también fue necesario instalar los paquetes Nuggets respectivamente en el proyecto

GRACIAS POR LEER 😁
