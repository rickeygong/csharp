using System;

namespace 控制反转与依赖注入
{
    public class OrderProcessor : IOrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            Console.WriteLine("OrderProcessor 被创建了");
            _shippingCalculator = shippingCalculator;        }

        public void Process(Order order)
        {
            if (order.IsShipped)
            {
                throw new InvalidOperationException("订单已发货");
            }

            DateTime doubleEleven = new DateTime(2022, 11, 11);

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
            order.IsShipped = true;
            Console.WriteLine($"订单#{order.Id}完成，已发货");
        }
    }
}
