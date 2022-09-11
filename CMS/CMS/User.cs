using System;

namespace CMS
{
    partial class Program
    {
        public class User : IUser
        {
            public bool IsUserLogin { get; set; }
            public void Login()
            {
                string username;
                string password;

                username = CmdReader("用户名：");
                if (username != "admin")
                {
                    Console.WriteLine("查无此人");
                    return;
                }

                password = CmdReader("密码：");
                if (password != "123456")
                {
                    Console.WriteLine("输入的密码错误，退出系统");
                    return;
                }

                //isUserLogin = true;
                IsUserLogin = true;
            }
        }
    }
}
