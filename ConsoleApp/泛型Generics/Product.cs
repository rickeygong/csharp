﻿namespace 泛型Generics
{
    public class DiscountCalculator<T> where T : Product
    {

    }
    public class Product
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
    }
}
