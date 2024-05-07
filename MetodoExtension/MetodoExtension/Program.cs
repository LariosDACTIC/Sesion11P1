namespace MetodoExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string myString = "hello world";

            string capitalized = myString.FirstToUpper();

            Console.WriteLine(capitalized);  // Output: "Hello world"



            // Crear una instancia de Persona
            Persona persona = new Persona("Juan", new DateTime(1990, 5, 15));

            // Utilizar los métodos de extensión
            int edad = persona.CalcularEdad();
            bool esAdulto = persona.EsAdulto();

            Console.WriteLine($"Edad de {persona.Nombre}: {edad} años");
            Console.WriteLine($"¿Es adulto? {esAdulto}");
        }
    }
    }
}
