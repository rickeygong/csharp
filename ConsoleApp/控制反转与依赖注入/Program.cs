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

            //运行打印的结果为什么会打印"DoubleElevenShippingCalculator 被创建了"呢？
            //这就是ioc反转控制容器的强大之处。所有放入ioc的类的生命周期都由ioc自动控制，
            //因为订单类依赖于价格计算类，所以当我们在使用订单类的时候，ioc会自动识别它的依赖关系，
            //一旦发现订单依赖于价格类，那么ioc就会先创建价格类，然后才创建订单类。
            //所以你会看到console中的打印顺序是先创建价格然后才创建订单。
            //ioc最大的用处就是解耦，工作中每天都会接触，不管学java还是c#都是必须掌握的核心知识点。

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
