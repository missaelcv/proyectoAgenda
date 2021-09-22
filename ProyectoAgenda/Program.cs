using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgenda
{
    public class Program
    {
        static void Main(string[] args)
        {
            Contacto contacto = new Contacto();
            contacto.Nombre = "Missael";
            contacto.Apellido = "Caceres";
            contacto.Direccion = "Castellana";
            contacto.CorreoElectronico = "misael@gmail.com";
            contacto.Cuidades = "San Francisco";

            Console.WriteLine("{0} / {1} / {2} / {3} / {4} ", contacto.Nombre, contacto.Apellido, contacto.Direccion, contacto.CorreoElectronico, contacto.Cuidades);

            Console.ReadKey();
        }
    }
}
