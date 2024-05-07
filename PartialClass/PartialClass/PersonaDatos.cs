using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class Persona
    {
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Fecha de Nacimiento: {FechaNacimiento}");
            Console.WriteLine($"Dirección: {Direccion}, Teléfono: {Telefono}");
        }
    }
}
