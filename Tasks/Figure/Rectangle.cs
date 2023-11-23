using System;

namespace LabWork.Figure
{
    internal class Rectangle : Point, IArea, ISetSizeHW
    {
        public Rectangle(ConsoleColor color, int flag, double height, double width) : base(color, flag)
        {
            this.color = color;
            condition = conditions[flag];
            this.width = width;
            this.height = height;
        }
        private double height;
        private double width;
        public double CalArea()
        {
            return height * width;
        }
        public override void Draw()
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void SetSize(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }
}
