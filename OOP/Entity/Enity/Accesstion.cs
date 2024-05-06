using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    internal class Accesstion : BaseRow
    {
        /// <summary>
        /// no parameters
        /// </summary>
        public Accesstion() { }

        /// <summary>
        /// has parameters
        /// </summary>
        /// <param name="id">int</param>
        /// <param name="name">string</param>
        public Accesstion(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
