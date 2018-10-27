using System;

class Program
{
    public static int Fibonacci(int n)
    {
        int a = 0;
        int b = 1;
        for (int i = 0; i < n; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a;
    }
    

    static void Main(string[] args)
    {
        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine(Fibonacci(i));
        }
         // faculteit
         int intTeller, intGetal, intFaculteit;
         intFaculteit = 1;

         Console.Write("Geef een willekeurig getal in: ");
         intGetal = Convert.ToInt32(Console.ReadLine());

            for(intTeller = 1; intTeller <= intGetal; intTeller++){
                intFaculteit = intFaculteit * intTeller;
            }
            Console.WriteLine("De faculteit van " + intGetal.ToString() + " is gelijk aan " + intFaculteit.ToString());

            // tafels
            int start = 7;
            for(int qq=0; qq<=10; qq++){
                int vermenigvuldigen = 7*qq;
                Console.WriteLine(start + "x" + qq + "=" + vermenigvuldigen);
                
            }
    }
}








