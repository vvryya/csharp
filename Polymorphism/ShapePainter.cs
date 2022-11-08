using System;

namespace Polymorphism
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Can't draw unknown shape");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("+=======+");
            Console.WriteLine("|       |");
            Console.WriteLine("+=======+");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("  #");
            Console.WriteLine(" ###");
            Console.WriteLine("#####");
        }
    }

    public class Unknown : Shape
    {
    }

    public class ShapePainter
    {
        public static void Main()
        {
            var whatToDraw = Console.ReadLine();

            if (whatToDraw == "rectangle")
            {
                var rectangle = new Rectangle();
                DrawShape(rectangle);
            }
            else if (whatToDraw == "triangle")
            {
                var triangle = new Triangle();
                DrawShape(triangle);
            }
            else
            {
                var idk = new Unknown();
                DrawShape(idk);
            }
        }

        private static void DrawShape(Shape shape)
        {
            shape.Draw();
        }
    }
}