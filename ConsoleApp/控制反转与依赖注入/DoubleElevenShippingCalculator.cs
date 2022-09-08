using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 控制反转与依赖注入
{
    class DoubleElevenShippingCalculator : IShippingCalculator
    {
        public DoubleElevenShippingCalculator()
        {
            Console.WriteLine("DoubleElevenShippingCalculator 被创建了");
        }

        public float CalculateShipping(Order order)
        {
            return 0;
        }
    }
}
