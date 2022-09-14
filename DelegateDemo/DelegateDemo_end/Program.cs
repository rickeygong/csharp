using System;

namespace DelegateDemo_end
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var photo = Photo.load("phtot.jpg");
            var processor = new PhotoProcessor();
            //processor.Process(photo);
            Console.Read();
        }
    }
}
