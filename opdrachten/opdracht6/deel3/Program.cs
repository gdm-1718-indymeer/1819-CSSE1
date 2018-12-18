using System;

namespace deel3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opdracht 6 - Deel 3 \n Factory: \n");
            VormFactory pen = new ConcreteVormFactory();

            IVorm cirkel = pen.GetVorm("Cirkel");
            cirkel.Teken();

            IVorm rechthoek = pen.GetVorm("Rechthoek");
            rechthoek.Teken();

            IVorm parallellogram = pen.GetVorm("Parallellogram");
            parallellogram.Teken();

            Console.WriteLine("\n Figuur: \n");

        }
    }
}
