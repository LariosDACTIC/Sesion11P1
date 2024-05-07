using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpleadosGUIA
{
    internal class Empleado
    {

        // Variables miembro de la clase Empleado
        private string nombre;
        private int numeroEmpleado;
        private decimal salario;
        private bool activo; // Estado del empleado (activo o inactivo)

        // Constructor de la clase Empleado
        public Empleado(string nombre, int numeroEmpleado, decimal salario, bool activo = true)//si no se recibe un valor por defecto es true
        {
            this.nombre = nombre;
            this.numeroEmpleado = numeroEmpleado;
            this.salario = salario;
            this.activo = activo;
        }

        // Método para mostrar los detalles del empleado
        public void MostrarDetalles()
        {
            string estado = (activo) ? "Activo" : "Inactivo";
            Console.WriteLine($"Nombre: {nombre}, Número de Empleado: {numeroEmpleado}, Salario: {salario:C}, Estado: {estado}");
        }

        // Método para obtener el número de empleado
        public int ObtenerNumeroEmpleado()
        {
            return this.numeroEmpleado;
        }

        // Método para cambiar el estado del empleado
        public void CambiarEstado(int nuevoEstado)
        {
            if (nuevoEstado == 1)
            {
                activo = true; // Activar empleado
                Console.WriteLine("Empleado activado.");
            }
            else if (nuevoEstado == 0)
            {
                activo = false; // Desactivar empleado
                Console.WriteLine("Empleado desactivado.");
            }
            else
            {
                Console.WriteLine("Estado no válido.");
            }
        }
    }
}
