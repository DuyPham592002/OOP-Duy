using Entity.DAO.DAO;
using System.Collections.Generic;

namespace Entity.DAO
{
    internal class ProductDAO : BaseDAO
    {
        public BaseRow FindById(int id)
        {
            for (int i = 0; i < db.productTable.Count; i++)
            {
                if (db.productTable[i].getId() == id)
                {
                    return db.productTable[i];
                }
            }
            return null;
        }

        public BaseRow FindByName(string name)
        {
            for (int i = 0; i < db.productTable.Count; i++)
            {
                if (db.productTable[i].getName() == name)
                {
                    return db.productTable[i];
                }
            }
            return null;
        }
    }
}
