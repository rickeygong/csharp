namespace 控制反转与依赖注入
{
    class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 50)
            {
                return 10;
            }
            else
            {
                return 0;
            }
        }
    }
}
