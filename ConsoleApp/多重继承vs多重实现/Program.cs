using System;

namespace 多重继承vs多重实现
{
    public interface ICopyable
    {
        void Copy();
        void Paste();
    }
    public interface IDragable
    {
        void Drag();
    }
    public class UIText : UIBase, IDragable, ICopyable
    {
        public void Copy()
        {
            throw new NotImplementedException();
        }

        public void Drag()
        {
            throw new NotImplementedException();
        }

        public void Paste()
        {
            throw new NotImplementedException();
        }
    }
    public class UIBase
    {
        public int Size { get; set; }
        public int Position { get; set; }
        public void Draw()
        {
            Console.WriteLine("---- 绘制  ----");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
