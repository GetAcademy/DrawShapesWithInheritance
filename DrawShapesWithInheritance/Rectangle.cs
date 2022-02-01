using System;

namespace DrawShapesWithInheritance
{
    internal class Rectangle : Shape
    {
        private readonly string _line;

        public Rectangle(int width, int height)
        : base(width, height)
        {
            _line = string.Empty.PadRight(width, Symbol);
        }

        protected override void DrawLine(WidthAndGrowth values)
        {
            Console.Write(_line);
        }
    }
}
