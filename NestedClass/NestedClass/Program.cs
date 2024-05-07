namespace NestedClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clases Anidadas");

            OuterClass contenedora = new OuterClass();

            OuterClass.InnerClass innerClassInstance = new OuterClass.InnerClass();

            innerClassInstance.DisplayOuterField(contenedora);



        }
    }
}
