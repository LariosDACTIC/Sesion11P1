using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoExtension
{
    public class Persona
    {
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Persona(string nombre, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
        }

    }

    // Clase estática que contiene métodos de extensión para la clase Persona
    public static class PersonaExtensions
    {
        // Método de extensión para calcular la edad de una persona
        public static int CalcularEdad(this Persona persona)
        {
            DateTime ahora = DateTime.Today;
            int edad = ahora.Year - persona.FechaNacimiento.Year;

            if (ahora < persona.FechaNacimiento.AddYears(edad))
            {
                edad--;
            }

            return edad;
        }

        // Método de extensión para verificar si una persona es adulta (mayor de edad)
        public static bool EsAdulto(this Persona persona)
        {
            int edad = persona.CalcularEdad();
            return edad >= 18;
        }
    }


}
