using System;

namespace Polymorphism
{
    public interface IFruit
    {
        string Name { get; }
    }

    public class Apple : IFruit
    {
        public string Name
        {
            get { return "Apple"; }
        }
    }

    public class Mango : IFruit
    {
        public string Name
        {
            get { return "Mango"; }
        }
    }

    public class Fruits
    {
        public static void Main()
        {
            var apple = new Apple();
            var mango = new Mango();

            PrintName(apple);
            PrintName(mango);
        }

        private static void PrintName(IFruit fruit)
        {
            Console.WriteLine(fruit.Name);
        }
    }
}