using System;

namespace 接口与多态
{
    internal class MailService : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"发送Email: {message}.");
        }
    }
}
