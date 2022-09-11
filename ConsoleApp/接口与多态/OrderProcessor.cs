using System.Collections.Generic;

namespace 接口与多态
{
    public class OrderProcessor
    {
        //private readonly MailService _mailService;
        private readonly List<INotification> messageServices;

        public OrderProcessor()
        {
            //_mailService = new MailService();
            messageServices = new List<INotification>();
        }
        public void RegisterNotification(INotification notification)
        {
            messageServices.Add(notification);
        }
        public void Process(Order order)
        {
            // 处理订单...处理发货...

            // 通知用户收货
            foreach (INotification notification in messageServices)
            {
                notification.Send("订单已发货");
            }
            
        }
    }
}
