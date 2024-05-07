using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEnum
{
    internal class Empleados
    {

        public string Nombre { get; set; }
        public Cargo Cargo { get; set; }

        public Empleados(string nombre, Cargo cargo)
        {
            Nombre = nombre;
            Cargo = cargo;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Cargo: {Cargo}");
        }


    }
}
