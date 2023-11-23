using System;

namespace LabWork.Figure
{
    internal abstract class Figure
    {
        protected ConsoleColor color;
        protected string condition;
        protected string[] conditions = new string[] { "notVisible", "visible" };
        public abstract void PrintParameters();
    }
}
