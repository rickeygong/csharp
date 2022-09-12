using System;

namespace 字段式事件声明
{
    public class MailService
    {
        internal static void OnOrderProcess(Object sender, OrderProcessorEventArgs e)
        {
            var order = (Order)sender;
            Console.WriteLine($"发送邮件..订单{order.Id}...处理结果{e.Status}...处理时间{e.ProcessingTime}...");
        }
    }
    public class SmsMessageService
    {
        internal static void OnOrderProcess(Object sender, OrderProcessorEventArgs e)
        {
            var order = (Order)sender;
            Console.WriteLine($"发送短信..订单{order.Id}...处理结果{e.Status}...处理时间{e.ProcessingTime}...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order
            {
                Id = 123,
                DatePlaced = DateTime.Now,
                TotalPrice = 30f
            };
            OrderProcessor orderProcessor = new OrderProcessor();
            orderProcessor.OrderProcessorEvent += SmsMessageService.OnOrderProcess;
            orderProcessor.OrderProcessorEvent += MailService.OnOrderProcess;
            orderProcessor.Process(order);
            Console.Read();
        }
    }
    public class OrderProcessorEventArgs : EventArgs
    {
        public string Status { get; set; }
        public DateTime ProcessingTime { get; set; }
        public string Description { get; set; }
    }
    //public delegate void OrderProcessorEventHandler(Order order, OrderProcessorEventArgs e);
    public class OrderProcessor
    {
        //public event OrderProcessorEventHandler OrderProcessorEvent;        
        public event EventHandler<OrderProcessorEventArgs> OrderProcessorEvent;

        #region 订单处理事件的声明和处理过程
        //private OrderProcessorEventHandler _orderProcessorEvent;

        //public event OrderProcessorEventHandler OrderProcessorEvent
        //{
        //    add { this._orderProcessorEvent += value; }
        //    remove { this._orderProcessorEvent -= value; }
        //}
        #endregion
        public void Process(Order order)
        {
            // 订单处理...
            // 订单处理完成，发送订单处理完成事件
            if (OrderProcessorEvent != null)
            {
                OrderProcessorEventArgs e = new OrderProcessorEventArgs
                {
                    Status = "Completed",
                    ProcessingTime = DateTime.Now,
                    Description = "订单处理成功"
                };
                OrderProcessorEvent(order, e);
            }
        }
    }
    public class Order
    {
        public int Id { get; set; }
        public DateTime DatePlaced { get; set; }
        public float TotalPrice { get; set; }
        public bool IsShipped { get; set; }
    }
}
