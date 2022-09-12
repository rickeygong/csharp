using System;

namespace 委托_end
{
    internal class Program
    {
        static void RedeyesRemovaFilter(Photo photo)
        {
            Console.WriteLine("一键去除红眼");
        }
        static void Main(string[] args)
        {
            var photo = Photo.load("phtot.jpg");

            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;

            filterHandler += filters.ApplyContrast;
            filterHandler += filters.Resize;
            filterHandler += RedeyesRemovaFilter;
            

            var processor = new PhotoProcessor();
            processor.Process(photo,filterHandler);
            Console.Read();
        }
    }
}
