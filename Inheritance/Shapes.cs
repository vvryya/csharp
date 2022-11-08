using System;

namespace Inheritance
{
    class Shape
    {
        public string Name { get; set; }
    }

    class Circle : Shape
    {
        public double Radius { get; set; }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    class Squar : Rectangle
    {
        public double Size { get; set; }
    }

    public class ShapesMain
    {
        public static void Main()
        {
            var square = new Squar
            {
                Name = "Pretty square",
                Size = 12
            };

            Console.WriteLine($"We've created a square of size {square.Size}");
        }
    }
}