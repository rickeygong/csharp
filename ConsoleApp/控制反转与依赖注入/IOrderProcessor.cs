using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 控制反转与依赖注入
{
    internal interface IOrderProcessor
    {
        public void Process(Order order);
    }
}
