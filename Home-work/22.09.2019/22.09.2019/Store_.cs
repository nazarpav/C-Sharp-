using System;
using System.Collections.Generic;
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
                buf+=product[i].Info.Type;
            }
            return buf;
        }
        void AddProd(Product newprod)
        {
            if(newprod==null)
            throw new Exception("ArgumentNullException ");
            if (newprod == null)
                throw new Exception("added prod is null");
            product.Add(newprod);
        }
        Product GetProd(int cod)
        {
            foreach (var i in product)
                if (i.Info.Code == cod)
                    return i;
            throw new Exception("ProductNotFoundException ");
        }
        void DeleteProd(int cod)
        {
            foreach(var i in product)
               if( i.Info.Code==cod)
                    product.Remove(i);
            throw new Exception("ProductNotFoundException ");
        }
    }
    partial class Store_
    {
        private List<Product> product;
        Store_(short size) 
        {
            product = new List<Product>(size);
        }
        public int GetConuntOfProduct()
        {
            return product.Count;
        }
        public int GetConuntOfProduct(ProductType type)
        {
            int counter = 0;
            foreach(var n in product)
            {
                if (n.Info.Type == type)
                    counter++;
            }
            return counter;
        }
        public int GetTotalPrice()
        {
            int allSum = 0;
            foreach (var n in product)
            {
                allSum += n.Price;
            }
            return allSum;
        }
        public int GetAveragePrice(ProductType type)
        {
            return GetTotalPrice()/ product.Count;
        }
    }
}
