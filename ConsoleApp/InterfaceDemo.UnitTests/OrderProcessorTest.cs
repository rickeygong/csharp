using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterfaceDemo;
using System;

namespace InterfaceDemo.UnitTests
{
    [TestClass]
    public class OrderProcessorTest
    {
        //被测方法_条件_期望结果
        [TestMethod]
        public void Process_OrderUnshipped_SetShippment()
        {
            OrderProcessor orderProcessor = new OrderProcessor(new FakeShippingCalculator());

            Order order = new Order
            {
                Id = 123,
                DatePlaced = DateTime.Now,
                TotalPrice = 100f
            };

            orderProcessor.Process(order);

            Assert.AreEqual(order.Shipment.Cost,5);
            Assert.IsTrue(order.IsShipped);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsShipped_ThrowException()
        {
            OrderProcessor orderProcessor = new OrderProcessor(new FakeShippingCalculator());

            Order order = new Order
            {
                Id = 123,
                DatePlaced = DateTime.Now,
                TotalPrice = 100f,
                IsShipped = true
            };

            orderProcessor.Process(order);
        }
    }
}
