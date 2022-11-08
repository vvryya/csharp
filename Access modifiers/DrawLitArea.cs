using System;

namespace AccessModifiers
{
    class Point2D
    {
        public int X;
        public int Y;
    }

    class LitArea2D
    {
        private Point2D _topLeft;
        private Point2D _bottomRight;

        public LitArea2D(int xTopLeft, int yTopLeft, int xBottomRight, int yBottomRight)
        {
            _topLeft = new Point2D
            {
                X = xTopLeft,
                Y = yTopLeft
            };

            _bottomRight = new Point2D
            {
                X = xBottomRight,
                Y = yBottomRight
            };
        }

        public void Draw()
        {
            for(int i = 0; i <= _bottomRight.Y; i++)
            {
                for (int j = 0; j <= _bottomRight.X; j++)
                {
                    if (i < _topLeft.Y || j < _topLeft.X)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write('#');
                    }
                }
                Console.WriteLine();
            }
        }
    }


    class DrawLitArea
    {
        public static void Main()
        {
            int topLeftX = int.Parse(Console.ReadLine());
            int topLeftY = int.Parse(Console.ReadLine());
            int bottomRightX = int.Parse(Console.ReadLine());
            int bottomRightY = int.Parse(Console.ReadLine());

            var litArea = new LitArea2D(topLeftX, topLeftY, bottomRightX, bottomRightY);
            litArea.Draw();
        }
    }
}