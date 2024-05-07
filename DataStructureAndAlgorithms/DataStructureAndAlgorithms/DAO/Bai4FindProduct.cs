using DataStructureAndAlgorithms.Enity;
using System.Collections.Generic;

namespace DataStructureAndAlgorithms.DAO
{
    internal class Bai4FindProduct
    {
        public Product FindProduct(List<Product> listProduct, string nameProduct)
        {
            for (int i = 0; i < listProduct.Count; i++)
            {
                if (listProduct[i].Name == nameProduct)
                return listProduct[i];
            }
            return null;
        }
    }
}
