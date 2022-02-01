namespace DrawShapesWithInheritance
{
    internal class WidthAndGrowth
    {
        public int Width { get; set; }
        public int Grow { get; }

        public WidthAndGrowth(int width, int grow)
        {
            Width = width;
            Grow = grow;
        }
    }
}
