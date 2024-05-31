using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Examen.Data.Models
{
    internal class Vehiculo
    {
        // PROPIEDADES DEL VEHICULO
        public int ID { get; set; }
        public string Placas { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Caja { get; set; }
        public bool Traccion { get; set; }
        public string Propietario { get; set; }
        public DateTime FechaCreacion { get; set; }

        // CONSTRUCTOR SIN PARÁMETROS
        public Vehiculo() { }

        // CONSTRUCTOR CON PARÁMETROS
        public Vehiculo(int id, string placas, string tipo, string marca, string modelo, string color, string caja, bool traccion, string propietario, DateTime fechacreacion)
        {
            ID = id;
            Placas = placas;
            Tipo = tipo;
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Caja = caja;
            Traccion = traccion;
            Propietario = propietario;
            FechaCreacion = fechacreacion;
        }
    }
}