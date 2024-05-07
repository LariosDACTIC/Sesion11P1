namespace ClassMethodEstatic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("");

           //Calculadora cal = new Calculadora();

            Console.WriteLine(Calculadora.Sumar(1, 1));




            Persona persona1 = new Persona("Juan");
            Persona persona2 = new Persona("María");

            Console.WriteLine($"Número de personas creadas: {Persona.ObtenerContador()}");

           

        }
    }
}
