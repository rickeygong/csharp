using System;
using ExtensionMethods;
namespace 扩展方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string testEmail = "rickey.gong@foxmail.com";
            string result = testEmail.SplitEmailAddressPrefix();
            Console.WriteLine($"邮箱前缀是 { result}");
            Console.ReadKey();
        }
    }
}
