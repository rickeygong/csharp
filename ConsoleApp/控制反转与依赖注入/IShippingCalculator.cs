using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 控制反转与依赖注入
{
    public interface IShippingCalculator
    {
        public float CalculateShipping(Order order);
    }
}
