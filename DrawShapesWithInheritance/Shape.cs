using System;

namespace DrawShapesWithInheritance
{
    internal abstract class Shape
    {
        protected const char Symbol = '█';
        protected readonly int _height;
        protected readonly int _width;

        protected Shape(int width, int height)
        {
            _height = height;
            _width = width;
        }

        public void Draw(int startColIndex, int startRowIndex)
        {
            var values = InitDraw();

            for (var rowIndex = 0; rowIndex < _height; rowIndex++)
            {
                Console.CursorTop = startRowIndex + rowIndex;
                Console.CursorLeft = startColIndex;
                DrawLine(values);
            }
        }

        protected abstract void DrawLine(WidthAndGrowth values);

        protected virtual WidthAndGrowth InitDraw()
        {
            return null;
        }
    }
}
