using System;

namespace CMS
{
    partial class Program
    {
        public class CMSController : ICMSController
        {
            private readonly IUser _user;
            private readonly IMenu _menu;
            public CMSController(IUser user, IMenu menu)
            {
                _user = user;
                _menu = menu;
            }
            public void Start()
            {
                Console.WriteLine("==========客户管理系统==========");
                Console.WriteLine("请登录");

                // Login
                do
                {
                    _user.Login();
                }
                while (!_user.IsUserLogin);

                //显示菜单
                _menu.ShowMenu();
            }
        }
    }
}
