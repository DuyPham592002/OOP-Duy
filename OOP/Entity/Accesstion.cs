using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    internal class Accesstion

    {
        private int id;
        private string name;

        public int getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public Accesstion() { }
        public Accesstion(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
