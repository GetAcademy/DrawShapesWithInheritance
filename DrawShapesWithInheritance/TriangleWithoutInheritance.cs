using System;

namespace DrawShapesWithInheritance
{
    internal class TriangleWithoutInheritance
    {
        private const char Symbol = '█';
        private readonly int _height;
        private readonly int _width;

        public TriangleWithoutInheritance(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public void Draw(int startColIndex, int startRowIndex)
        {
            var width = _width % 2 == 0 ? 2 : 1;
            var grow = (_width - width) / (_height - 1);

            for (var rowIndex = 0; rowIndex < _height; rowIndex++)
            {
                Console.CursorTop = startRowIndex + rowIndex;
                Console.CursorLeft = startColIndex;
                Console.Write(string.Empty.PadRight(width, Symbol));
                width += grow;
            }
        }
    }
}

