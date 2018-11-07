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
        // fibonaci 
        Console.WriteLine(" \n Fibonaci:");


        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine(Fibonacci(i));
        }


         // faculteit

        Console.WriteLine("\n Faculteit: ");

         int intTeller, intGetal, intFaculteit;
         intFaculteit = 1;

         Console.Write("Geef een willekeurig getal in: ");
         intGetal = Convert.ToInt32(Console.ReadLine());

            for(intTeller = 1; intTeller <= intGetal; intTeller++){
                intFaculteit = intFaculteit * intTeller;
            }
            Console.WriteLine("De faculteit van " + intGetal.ToString() + " is gelijk aan " + intFaculteit.ToString());

             //alle tafels

        Console.WriteLine("\n Tafels: ");


        for (int i= 0; i<=10; i++){
        Console.WriteLine( "\n" + "Tafel van:" + i );

            for(int qq=0; qq<=10; qq++){
                int vermenigvuldigen = i*qq;
                Console.WriteLine(i + "x" + qq + "=" + vermenigvuldigen);
                
            }
        }
        // VERMENIGVULDIGEN MET INPUT GETAL


         Console.WriteLine("\n Tafel met input:");

        Console.Write("Van welk getal wil je de tafel opnieuw zien: ");
        int start = Convert.ToInt32(Console.ReadLine());;
          
            for(int i=0; i<=10; i++){
                int vermenigvuldigen = start*i;
                Console.WriteLine(start + "x" + i + "=" + vermenigvuldigen);
                
            }
    }
}








