using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Trangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("--- 画三角形 ---");
        }
    }
    public class Circle:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("--- 画圆 ---");
        }
    }
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("--- 画方 ---");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var shapeList = new List<Shape>();
            shapeList.Add(new Circle());
            shapeList.Add(new Rectangle());
            shapeList.Add(new Trangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapeList);
            Console.ReadKey();
        }
    }
}
