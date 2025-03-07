﻿namespace GestionEmpleadosGUIA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicacion de Gestion de Empleados");

           

            // Crear una lista para almacenar empleados
            List<Empleado> listaEmpleados = new List<Empleado>();

            // Agregar empleados de ejemplo a la lista
            listaEmpleados.Add(new Empleado("Juan", 101, 30000));
            listaEmpleados.Add(new Empleado("María", 102, 35000));
            listaEmpleados.Add(new Empleado("Pedro", 103, 32000, false)); // Empleado inactivo

            // Mostrar los detalles de cada empleado en la lista
            foreach (var empleado in listaEmpleados)
            {
                empleado.MostrarDetalles();
            }

            // Cambiar el estado de un empleado por su número de empleado
            int numeroEmpleadoCambiarEstado = 103; // Número de empleado a cambiar estado
            Empleado empleadoCambiarEstado = BuscarEmpleado(listaEmpleados, numeroEmpleadoCambiarEstado);

            if (empleadoCambiarEstado != null)
            {
                // Cambiar el estado a activo (1) o inactivo (0)
                empleadoCambiarEstado.CambiarEstado(1); // Cambiar a activo
                empleadoCambiarEstado.MostrarDetalles(); // Mostrar detalles actualizados
            }
            else
            {
                Console.WriteLine($"Empleado con número {numeroEmpleadoCambiarEstado} no encontrado.");
            }

        }

        // Método para buscar un empleado por su número de empleado
        static Empleado BuscarEmpleado(List<Empleado> empleados, int numeroEmpleado)
        {
            foreach (var empleado in empleados)
            {
                if (empleado.ObtenerNumeroEmpleado() == numeroEmpleado)
                {
                    return empleado;
                }
            }
            return null; // Retorna null si no se encuentra ningún empleado con ese número

        }
    }
}
