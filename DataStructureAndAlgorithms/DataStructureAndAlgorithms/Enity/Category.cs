using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.Enity
{
    internal class Category
    {
        int id;
        string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public Category() { }

        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
