using System;

namespace LabWork.Figure
{
    internal class Circle : Point, IArea, ISetRadius
    {
        public Circle(ConsoleColor color, int flag, double radius) : base(color, flag)
        {
            this.color = color;
            condition = conditions[flag];
            this.radius = radius;
        }
        private double radius;

        public double CalArea()
        {
            return Math.PI * radius * radius;
        }
        public override void Draw()
        {
            Console.ForegroundColor = color;
            for (double y = -radius; y <= radius; y++)
            {
                for (double x = -radius; x <= radius; x += 0.5)
                    Console.Write(x * x + y * y <= radius * radius ? '*' : ' ');

                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void SetRadius(int radius)
        {
            this.radius = radius;
        }
    }
}
