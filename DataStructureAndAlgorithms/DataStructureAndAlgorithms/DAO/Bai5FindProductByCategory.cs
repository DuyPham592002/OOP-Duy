using DataStructureAndAlgorithms.Enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.DAO
{
    internal class Bai5FindProductByCategory
    {
        public List<Product> FindProductByCategoty(List<Product> listProduct, int categoryId)
        {
            List<Product> products = new List<Product>();
            for (int i = 0; i < listProduct.Count; i++)
            {
                if (listProduct[i].CategoryId == categoryId)
                {
                    products.Add(listProduct[i]);
                }
            }
            return products;
        }
    }
}
