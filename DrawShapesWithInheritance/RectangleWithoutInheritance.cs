using System;

namespace DrawShapesWithInheritance
{
    internal class RectangleWithoutInheritance
    {
        private const char Symbol = '█';
        private readonly int _height;
        private readonly string _line;

        public RectangleWithoutInheritance(int width, int height)
        {
            _height = height;
            _line = string.Empty.PadRight(width, Symbol);
        }

        public void Draw(int startColIndex, int startRowIndex)
        {
            for (var rowIndex = 0; rowIndex < _height; rowIndex++)
            {
                Console.CursorTop = startRowIndex + rowIndex;
                Console.CursorLeft = startColIndex;
                Console.Write(_line);
            }
        }
    }
}
