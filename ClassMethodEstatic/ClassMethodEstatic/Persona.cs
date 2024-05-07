using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodEstatic
{
    public class Persona
    {
        private static int contador = 0; // Campo estático

        public string Nombre { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
            contador++; // Incrementar el contador al crear una instancia
        }

        public static int ObtenerContador()
        {
            return contador;
        }
    }
}
