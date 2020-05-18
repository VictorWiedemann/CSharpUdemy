using System;
using System.Collections.Generic;

namespace CSharpUdemy
{
    //cannot create a shape class anymore because it is abstract
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position X { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("copy function here");
        }


        public class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Draw Circle");
            }
        }

        public class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Draw rect");
            }
        }

        public class Canvas
        {
            public void DrawShapes(List<Shape> shapes)
            {
                foreach (var shape in shapes)
                {
                    shape.Draw();
                }
            }
        }

    }
}