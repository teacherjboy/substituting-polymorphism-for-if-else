using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IList<Shape> shapes = new List<Shape>() {
                new Circle(1.5),
                new Square(3),
                new Triangle(2, 5)
            };

            drawShapes(shapes);

        }

        public static void drawShapes(IList<Shape> shapes)
        {
            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }
        }

    }
}
