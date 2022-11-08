using System;

namespace Inheritance
{
    public class Furniture
    {
        protected Furniture(string brand, decimal price)
        {
            Brand = brand;
            Price = price;
        }

        public string Category;
        protected string Brand;
        protected decimal Price;
        private int _id;
    }

    public class Sofa : Furniture
    {
        public Sofa(string brand, decimal price) 
            : base(brand, price) // Call constructor from Furniture
        { }

        public void PrintPriceTag()
        {
            Console.WriteLine($"Sofa - {Brand}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Price: {Price}");
        }
    }

    public class FurnitureDealer
    {
        public static void Main()
        {
            var sofa = new Sofa("IKEA", 103.12m); // "m" convets number to decimal
            sofa.Category = "Premium";
            sofa.PrintPriceTag();
        }
    }
}