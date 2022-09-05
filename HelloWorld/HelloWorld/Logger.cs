using System;

namespace HelloWorld
{
    class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"日志：{DateTime.Now} - {message}");
        }
    }



}
