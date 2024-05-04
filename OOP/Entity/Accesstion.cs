using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    internal class Accesstion : BaseRow
    {
        public Accesstion() { }
        public Accesstion(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
