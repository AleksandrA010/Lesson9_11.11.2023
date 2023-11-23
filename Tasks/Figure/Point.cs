using System;

namespace LabWork.Figure
{
    internal class Point : Figure
    {
        public Point(ConsoleColor color, int flag)
        {
            condition = conditions[flag];
            this.color = color;
        }
        public virtual void Draw()
        {
            Console.ForegroundColor = color;
            Console.WriteLine("*");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public virtual void Drive()
        {

        }
        public override void PrintParameters()
        {
            Console.WriteLine($"{Convert.ToString(color)}, {condition}");
        }
    }
}
