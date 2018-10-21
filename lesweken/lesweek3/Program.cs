using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Het afdrukken van een tekts in de console.
            Console.WriteLine("Hello World!");

  

            int resultaat = (107 * 3)+(5 * deling(optellen(406, 7367), 69)) + vermeningvuldigen(73, 41) - 39 + vermeningvuldigen(7, 8) - 19;


            Console.WriteLine("het resultaat is: " + resultaat);
        }

        static int optellen(int a, int b)
        {
            return a + b;
        }

        static int vermeningvuldigen(int a, int b)
        {
            return a * b;
        }
        static int deling(int a, int b)
        {
            return a/b;
        }

       static int verhogen(int a)
        {
            return a++;
        }
       
    }
}
