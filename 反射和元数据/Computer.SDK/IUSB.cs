using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer.SDK
{
    public interface IUSB
    {
        /// <summary>
        /// 读取设备信息
        /// </summary>
        void GetInfo();
        /// <summary>
        /// 读取数据
        /// </summary>
        void Read();
        /// <summary>
        /// 写入数据
        /// </summary>
        void Write();
    }
}
