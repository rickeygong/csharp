using System;

namespace ConsoleApp
{
    public class Person 
    {
        private int age = 18;

        public int Age { get => age; set => age = value; }

        public void SayHello()
        {
            Console.WriteLine($"我{age}岁了。");
        }
    }
    public class Student : Person 
    {
        public int age = 10;
        public void SayHello()
        {
            Console.WriteLine($"我{age}岁了。");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.SayHello();//我10岁了
            Console.WriteLine(s.age.ToString());//10
            Person p = s;
            p.SayHello();//我18岁了
            p.Age = 50;
            p.SayHello();//我18岁了
            s.SayHello();//我10岁了
            Console.WriteLine();


        }
    }
    static class ToolsHelper
    {
        //静态类只包含静态成员
        //private string name = "rickey.gong";

        //不能包含实例构造函数
        //public void ToolsHelper()
        //{

        //}

        //可以包含静态构造函数
        static ToolsHelper()
        {
            Console.WriteLine("静态类 -- 静态构造方法");
        }

        internal static void SayHello()
        {
            Console.WriteLine("静态类 -- SayHello方法");
        }
    }
}
