using System;

namespace ConsoleApp1
{
    public class Shape
    {
        public int Width { get; set; }//长
        public int Height { get; set; }//高
        //public Position Position { get; set; }//坐标位置

        //public ShapeType shapeType { get; set; }//图像类型

        public virtual void Draw()
        {
            Console.WriteLine("绘制图案");
        }

    }
}
