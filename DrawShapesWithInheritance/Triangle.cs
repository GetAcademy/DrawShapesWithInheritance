using System;

namespace DrawShapesWithInheritance
{
    internal class Triangle : Shape
    {
        public Triangle(int width, int height)
        : base(width, height)
        {
        }

        protected override WidthAndGrowth InitDraw()
        {
            var width = _width % 2 == 0 ? 2 : 1;
            var grow = (_width - width) / (_height - 1);
            return new WidthAndGrowth(width, grow);
        }

        protected override void DrawLine(WidthAndGrowth values)
        {
            var line = string.Empty.PadRight(values.Width, Symbol);
            Console.Write(line);
            values.Width += values.Grow;
        }
    }
}
