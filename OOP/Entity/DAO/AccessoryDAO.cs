using Entity.DAO.DAO;
using System.Collections.Generic;

namespace Entity.DAO
{
    internal class AccessoryDAO : BaseDAO , IDao
    {
        /// <summary>
        /// find name in table
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>BaseRow</returns>
        public BaseRow FindByName(string name)
        {
            for (int i = 0; i < instance.GetAccesssoryTable().Count; i++)
            {
                if (instance.GetAccesssoryTable()[i].getName() == name)
                {
                    return instance.GetAccesssoryTable()[i];
                }
            }
            return null;
        }
    }
}
