using System;

namespace 接口与多态
{
    internal class Program
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
            INotification mailService = new MailService();
            orderProcessor.RegisterNotification(mailService);
            INotification smsService = new SmsMessageService();
            orderProcessor.RegisterNotification(smsService);
            INotification wechatService = new WechatMessage();
            orderProcessor.RegisterNotification(wechatService);
            orderProcessor.Process(order);

            Console.Read();
        }
    }
}
