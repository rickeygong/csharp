using System;
using Microsoft.Extensions.DependencyInjection;

namespace 控制反转与依赖注入
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 创建一个订单，有订单编号、订单时间、订单金额
            var order = new Order
            {
                Id = 123,
                DatePlaced = DateTime.Now,
                TotalPrice = 100f
            };
            #endregion

            #region 配置ICO
            ServiceCollection services = new ServiceCollection();
            // singleton -- 单例模式,
            // scoped -- 作用域模式,
            // tansient -- 瞬时模式
            services.AddScoped<IOrderProcessor, OrderProcessor>();
            services.AddScoped<IShippingCalculator,DoubleElevenShippingCalculator>();

            // 从IOC提取服务
            IServiceProvider serviceProvider = services.BuildServiceProvider();
            var orderProcess = serviceProvider.GetService<IOrderProcessor>();//通过接口调用

            // 处理订单
            orderProcess.Process(order);
            #endregion

            //创建了订单处理系统，计算订单的运费，改变订单的状态
            //IShippingCalculator doubleEleven = new DoubleElevenShippingCalculator();
            //var orderProcessor = new OrderProcessor(doubleEleven);
            //orderProcessor.Process(order);

            Console.Read();
        }
    }
}
