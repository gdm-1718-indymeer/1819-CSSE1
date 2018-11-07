using System;

namespace opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
        //alle afels
        for (int i= 0; i<=10; i++){
            for(int qq=0; qq<=10; qq++){
                int vermenigvuldigen = i*qq;
                Console.WriteLine(i + "x" + qq + "=" + vermenigvuldigen);
                
            }
        }
        // VERMENIGVULDIGEN MET INPUT GETAL

        Console.Write("Van welk getal wil je de tafel opnieuw zien: ");
        int start = Convert.ToInt32(Console.ReadLine());;
          
            for(int i=0; i<=10; i++){
                int vermenigvuldigen = start*i;
                Console.WriteLine(start + "x" + i + "=" + vermenigvuldigen);
                
            }

        }
    }
}
