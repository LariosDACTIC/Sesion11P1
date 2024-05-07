using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodEstatic
{
    public static class Calculadora
    {
        public static int Sumar(int a, int b)
        {
            return a + b;
        }

        public static int Restar(int a, int b)
        {
            return a - b;
        }

        public static class Matematicas
        {
            public static int Factorial(int n)
            {
                if (n == 0)
                    return 1;
                else
                    return n * Factorial(n - 1);
            }
        }




    }
}
