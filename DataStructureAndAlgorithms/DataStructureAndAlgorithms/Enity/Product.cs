using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.Enity
{
    internal class Product
    {
        private string name;
        private int price;
        private int quality;
        private int categoryId;

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int Quality { get => quality; set => quality = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }

        public Product() { }

        public Product(string name, int price, int quality, int categoryId)
        {
            Name = name;
            Price = price;
            Quality = quality;
            CategoryId = categoryId;
        }
    }
}
