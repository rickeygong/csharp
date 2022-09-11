using System;
using Microsoft.Extensions.DependencyInjection;

namespace CMS
{
    public partial class Program
    {
        static string CmdReader(string instruction) {
            Console.Write(instruction);
            string cmd = Console.ReadLine();
            return cmd;
        }
        static void Main(string[] args)
        {
            ServiceCollection services = new ServiceCollection();
            services.AddScoped<IUser, User>();
            services.AddScoped<IMenu, Menu>();
            services.AddScoped<ICMSController,CMSController>();
            var serviceProvider = services.BuildServiceProvider();
            var cmsController = serviceProvider.GetService<ICMSController>();
            cmsController.Start();
            Console.ReadKey();
        }
    }
}
