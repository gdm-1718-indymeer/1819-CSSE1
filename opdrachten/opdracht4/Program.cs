using System;

namespace opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public class MenuItems
        {
            
        }

        public class Product : MenuItems
        {
            string naam, type;
            string[] ingediënten;
            public Product(string naam, string type, string[] ingediënten)
            {
                this.naam = naam;
                this.type = type;
                this.ingediënten = ingediënten;
            }
        }
        public class Prijs : MenuItems
        {
            string valuta;
            decimal bedrag;
            public Prijs(string valuta, decimal bedrag)
            {
                this.valuta = valuta;
                this.bedrag = bedrag;
            }
        }
    }
}