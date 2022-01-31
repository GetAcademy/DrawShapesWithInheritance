using System;

namespace DrawShapesWithInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rectangle1 = new RectangleWithoutInheritance(8, 3);
            rectangle1.Draw(10, 1);

            var triangle1 = new TriangleWithoutInheritance(10, 5);
            triangle1.Draw(1, 5);

            //var rectangle2 = new Rectangle(8, 3);
            //rectangle2.Draw(10, 11);

            //var triangle2 = new Triangle(10, 5);
            //triangle1.Draw(1, 15);
        }
    }
}
