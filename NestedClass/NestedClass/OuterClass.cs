using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClass
{
    public class OuterClass//clase principal o contenedora 
    {

        private int outerField = 10;//campo privado
        private string name = "Larios";//campo name privado

        public class InnerClass //clase interna
        {
            public void DisplayOuterField(OuterClass outer)//le pasamos como parametri la clase para acceder a los elementos
            {
                Console.WriteLine($"Outer field value : {outer.outerField}");
                Console.WriteLine($"Campo Name Privado : {outer.name}");
            }
        
 
        
        }





    }




}
