using DataStructureAndAlgorithms.Enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.DAO
{
    internal class Bai6FindProductByPrice
    {
        public List<Product> FindProductByPrice(List<Product> listProduct, int price)
        {
            List<Product> products = new List<Product>();
            for (int i = 0; i < listProduct.Count; i++)
            {
                if (listProduct[i].Price < price)
                {
                    products.Add(listProduct[i]);
                }
            }
            return products;
        }
    }
}
