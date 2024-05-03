using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    internal class Product
    {
        private int id;
        private string name;
        private int categoryId;

        public int getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public int getCategoryId()
        {
            return categoryId;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public void setCategoryId(int categoryId)
        {
            this.categoryId = categoryId;
        }
        public Product() { }
        public Product(int id, string name, int categoryId)
        {
            this.id = id;
            this.name = name;
            this.categoryId = categoryId;
        }
    }
}
