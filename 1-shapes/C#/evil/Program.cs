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

            DrawShapes(shapes);

        }

        public static void DrawShapes(IList<Shape> shapes)
        {
            foreach (Shape shape in shapes)
            {
                if (shape is Circle)
                {
                    DrawCircle((Circle) shape);
                }
                else if (shape is Square)
                {
                    DrawSquare((Square) shape);
                }
                else if (shape is Triangle)
                {
                    DrawTriangle((Triangle) shape);
                }
                else {
                    Console.WriteLine("What shape that is, I do not know.");
                }
            }
        }

        private static void DrawCircle(Circle circle) 
        {
            Console.WriteLine(String.Format("I am a circle with radius {0} and area {1}", circle.Radius, circle.ComputeArea()));
        }
        
        private static void DrawSquare(Square square) 
        {
            Console.WriteLine(String.Format("I am a square with length {0} and area {1}", square.Length, square.ComputeArea()));
        }

        private static void DrawTriangle(Triangle triangle) 
        {
            Console.WriteLine(String.Format("I am a triangle with base {0} and height {1} and area {2}", triangle.Base, triangle.Height, triangle.ComputeArea()));
        }
    }
}
