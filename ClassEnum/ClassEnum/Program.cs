namespace ClassEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Crear empleados con diferentes cargos
            Empleados empleado1 = new Empleados("Juan", Cargo.Gerente);
            Empleados empleado2 = new Empleados("María",Cargo.Supervisor);
            Empleados empleado3 = new Empleados("Pedro",Cargo.Analista);

            // Mostrar información de los empleados
            empleado1.MostrarInformacion();
            empleado2.MostrarInformacion();
            empleado3.MostrarInformacion();

        }
    }
}
