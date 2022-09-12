using System;
using System.Reflection;

namespace 反射和元数据
{
    public class List
    {
        public void Add()
        {
            Console.WriteLine("Add...Add...Add...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string classLocation = "反射和元数据.List,反射和元数据";
            Type objType = Type.GetType(classLocation);
            object obj = Activator.CreateInstance(objType);

            MethodInfo addMethod = objType.GetMethod("Add");
            addMethod.Invoke(obj,null);

            Console.ReadKey();
        }
    }
}
