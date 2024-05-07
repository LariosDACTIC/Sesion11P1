namespace PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Persona persona = new Persona();

            persona.Nombre = "Larios";

            persona.MostrarInformacion();
            
        }
    }
}
