using System;
using System.IO;
using System.Collections.Generic;
using Computer.SDK;
using System.Runtime.Loader;

namespace Computer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //获得当前程序的路径(通过Path.Combine将当前文件夹和USB文件夹合并)
            string USBInterface = Path.Combine(Environment.CurrentDirectory, "USB");
            //Console.WriteLine(USBInterface);

            var dllFiles = Directory.GetFiles(USBInterface);//获取文件夹中所有dll文件

            //创建USB的设备列表(因为要遵循Computer中IUSB协议，所以设备列表类型为IUSB)
            var devicesList = new List<IUSB>();
            foreach (var dll in dllFiles)
            {

                var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(dll);//加载到程序中

                var typeList = assembly.GetTypes();//拿到dll的类型列表
                //检查dll类型列表是否符合IUSB协议
                foreach (var type in typeList)
                {
                    var interfaceList = type.GetInterfaces();//返回InterfaceInfo类型，用于取得该类实现的接口的信息

                    foreach (var i in interfaceList)
                    {
                        //判断是否是IUSB接口
                        if (i.Name == "IUSB")
                        {
                            var usb = (IUSB)Activator.CreateInstance(type);//实例化USB设备
                            devicesList.Add(usb);//添加到设备列表
                        }
                    }
                }
            }

            foreach (var usb in devicesList)
            {
                usb.GetInfo();
                usb.Read();
                usb.Write();
            }
            

            Console.ReadKey();
        }
    }
}
