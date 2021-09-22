using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgenda
{
    public class Contacto
    {

        #region Construtor Con Paramentros
        public Contacto (string nombre, string apellido, double telefonoMovil, double telefonoCasa,
            string correoElectronico, string direccion, string cuidades)
        {
            Nombre = nombre;
            Apellido = apellido;
            TelefonoCasa = telefonoCasa;
            TelefonoMovil = telefonoMovil;
            CorreoElectronico = correoElectronico;
            Direccion = direccion;
            Cuidades = cuidades;
        }
        #endregion


        #region Construtor Vacio
        public Contacto ()
        {
            // Contrutor Vacio
        }
        #endregion



        #region Variables
        public string Nombre { get; set;  }

        public string Apellido { get; set; }

        public double TelefonoMovil { get; set; }

        public double TelefonoCasa { get; set; }

        public string CorreoElectronico { get; set; }

        public string Direccion { get; set; }
        public string Cuidades { get; set; }
        
         }
        #endregion
}


