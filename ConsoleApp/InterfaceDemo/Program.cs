using System;

namespace InterfaceDemo
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


            //创建了订单处理系统，计算订单的运费，改变订单的状态
            IShippingCalculator doubleEleven = new DoubleElevenShippingCalculator();
            var orderProcessor = new OrderProcessor(doubleEleven);

            orderProcessor.Process(order);

            Console.Read();
        }
    }
}
