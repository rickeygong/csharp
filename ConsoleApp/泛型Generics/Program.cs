using System;

namespace 泛型Generics
{
    public class Utility
    {
        public int FindMax(int a, int b)
        {
            return a > b ? a : b;
        }

        public T FindMax<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
    public static class StringExtension
    {
        public static string ShortTerm(this string text, int number)
        {
            return text.Substring(0, number);
        }
        public static void SayHello()
        {
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string hello = "rickey.gong";
            hello.ShortTerm(3);
            Console.WriteLine(hello.ShortTerm(3));
            //var numberList = new List();
            //var productList = new ProductList();

            var numberlist = new GenericList<int>();
            var productList = new GenericList<Product>();
            productList.Add(new Product()
            {
                Id = 1,
                Price = 100
            });

            var database = new Dictionary<string, Product>();
            database.Add("123", new Product() { Id = 2, Price = 100 });
            database.Add("345", new Product() { Id = 3, Price = 120 });
            database.Add("456", new Product() { Id = 4, Price = 140 });
            Product p = database.Get("123");
            Console.Read();
        }
    }
}
