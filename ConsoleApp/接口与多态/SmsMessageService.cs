using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口与多态
{
    public class SmsMessageService : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"发送短信：{message}.");
        }
    }
}
