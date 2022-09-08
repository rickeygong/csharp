using System;
using Microsoft.Extensions.DependencyInjection;
namespace ConsoleApp
{
    interface IUsb
    {
        public void Process();
    }
    public class Upan : IUsb
    {
        public Upan()
        {
            Console.WriteLine("Upan 被创建了");
        }

        public void Process()
        {
            Console.WriteLine("Process");
        }
    }
    interface ITypeC
    {
        public void TypeCKey();
    }
    public class ComputerDisplay : ITypeC
    {
        public ComputerDisplay()
        {
            Console.WriteLine("ComputerDisplay 被创建了");
        }
        public void TypeCKey()
        {
            Console.WriteLine("TypeCKey");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //配置ICO
            ServiceCollection services = new ServiceCollection();
            services.AddScoped<IUsb, Upan>();
            services.AddScoped<ITypeC, ComputerDisplay>();
            //从IOC提取服务
            IServiceProvider serviceProvider = services.BuildServiceProvider();
            var upanProcess = serviceProvider.GetService<IUsb>();
            Console.Read();
        }
    }

}
