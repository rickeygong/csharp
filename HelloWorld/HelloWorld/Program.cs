using System;

namespace HelloWorld
{
    class Program
    {
        public class Shape
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public int X { get; set; }
            public int Y { get; set; }
            public void Draw()
            {
                Console.WriteLine($"width:{Width}，height:{Height},position{X},{Y}");
            }
        }
        public class Text:Shape
        {
            public int FontSize { get; set; }
            public int FontName { get; set; }
        }
        static void Main(string[] args)
        {
            Text text = new Text();
            Shape shape = text;



            Console.ReadKey();
        }
    }



}
