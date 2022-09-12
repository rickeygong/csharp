using System;

namespace 泛型Generics
{
    public class ProductList
    {
        public void Add(Product order)
        {
            throw new NotImplementedException();
        }

        public Product this[int index]
        {
            get { throw new NotImplementedException(); }
        }

    }

    public class GenericList<T>
    {
        public void Add(T order)
        {
            //throw new NotImplementedException();
        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
    public class Dictionary<Tkey,TValue>
    {
        public void Add(Tkey tkey, TValue value)
        {
            throw new NotImplementedException();
        }
        public TValue Get(Tkey tkey)
        {
            throw new NotImplementedException();
        }
    }
    //public class ObjectList
    //{
    //    public void Add(object order)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public object this[int index]
    //    {
    //        get { throw new NotImplementedException(); }
    //    }
    //}
}
