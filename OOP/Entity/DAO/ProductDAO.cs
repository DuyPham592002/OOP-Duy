using Entity.DAO.DAO;
using System.Collections.Generic;

namespace Entity.DAO
{
    internal class ProductDAO : BaseDAO , IDao
    {
        /// <summary>
        /// find name in table
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>BaseRow</returns>
        public BaseRow FindByName(string name)
        {
            for (int i = 0; i < instance.GetProductTable().Count; i++)
            {
                if (instance.GetProductTable()[i].getName() == name)
                {
                    return instance.GetProductTable()[i];
                }
            }
            return null;
        }
    }
}
