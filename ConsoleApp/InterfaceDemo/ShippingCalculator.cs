namespace InterfaceDemo
{
    class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            //if (order.TotalPrice < 50)
            //{
            //    return 10;
            //}else
            //{
            //    return 0;
            //}
            return 0;
        }
    }
}
