using System;

namespace HelloWorld
{
    class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public int FontName { get; set; }
        public void AddHyperLink()
        {
            Console.WriteLine("添加超链接");
        }
    }



}
