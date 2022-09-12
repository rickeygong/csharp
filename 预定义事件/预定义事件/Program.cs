using System;
using System.Timers;
namespace 预定义事件
{
    class Program
    {
        public class Rickey
        {
            public void AlarmEventHandler(object sender, ElapsedEventArgs e)
            {
                Console.WriteLine("闹钟响了...我不管...我要继续睡...");
            }
        }
        public class RoomMate
        {
            public int RageValue { get; set; }
            public void AlarmEventHandler(object sender, ElapsedEventArgs e)
            {
                RageValue += 25;
                if (RageValue >= 100)
                {
                    Console.WriteLine("受不了了");
                    var alram = (Timer)sender;
                    alram.Stop();
                }
                else
                {
                    Console.WriteLine("闹钟响了...我也不管...我要继续睡...");
                }
                
            }
        }
        static void Main(string[] args)
        {
            var rickey = new Rickey();
            var roomMate = new RoomMate();

            Timer alarm = new Timer();

            alarm.Interval = 1000;

            alarm.Elapsed += rickey.AlarmEventHandler;
            alarm.Elapsed += roomMate.AlarmEventHandler;

            alarm.Start();

            Console.ReadKey();
        }
    }
}
