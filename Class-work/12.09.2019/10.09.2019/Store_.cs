using System;
using System.Collections.Generic
using System.Text;

namespace  Store
{
    partial class Store_
    {
        public override string ToString()
        {
            string buf="";
            for (int i = 0; i < product.Count; i++)
            {
                buf+=product[i].Info.type;
            }
            return buf;
        }
        void AddProd(Product newprod)
        {
            if (newprod == null)
                throw new Exception("added prod is null");
            product.Add(newprod);
        }
        Product GetProd(int cod)
        {
            return null;
        }
        void DeleteProd(int cod)
        {
            foreach(var i in product)
               if( i.Info.type.cod==cod)
        }
    }
    partial class Store_
    {
        private List<Product> product;
        Store_(short size) 
        {
            product = new List<Product>(size);
        }
        public int ConuntOfProduct()
        {
            return product.Count;
        }
        public int ConuntOfProduct(ProductType type)
        {
            int counter = 0;
            foreach(var n in product)
            {
                if (n.Info.type == type)
                    counter++;
            }
            return counter;
        }
        public int TotalPrice()
        {
            int allSum = 0;
            foreach (var n in product)
            {
                allSum += n.Price;
            }
            return allSum;
        }
        public int AveragePrice(ProductType type)
        {
            return TotalPrice()/ product.Count;
        }
    }
}
