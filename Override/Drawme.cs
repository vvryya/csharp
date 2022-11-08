using System;

namespace Inheritance
{
    class GeometricFigure
    {
        public virtual void Draw()
        {
            Console.WriteLine("Base drawing!");
        }
    }

    class Square : GeometricFigure
    {
        public int Size { get; set; }

        public override void Draw()
        {
            string upper = "#";
            string middle = "#";

            for(int i = 0; i < Size-2; i++)
            {
                upper += "#";
                middle += " ";
            }

            upper += "#";
            middle += "#";

            Console.WriteLine(upper);

            for(int i = 0; i < Size-2; i++)
                Console.WriteLine(middle);

            Console.WriteLine(upper);
        }
    }

    class Arrow : GeometricFigure
    {
        public int Length { get; set; }

        public override void Draw()
        {
            for (int i = 0; i < Length - 1; i++)
                Console.Write("-");

            Console.Write(">");
        }
        

    }

    public class Me
    {
        public static void Main()
        {
            var size = int.Parse(Console.ReadLine());

            var square = new Square { Size = size };
            var arrow = new Arrow { Length = size };

            square.Draw();
            arrow.Draw();
        }
    }
}