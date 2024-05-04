using Entity.DAO.DAO;
using System.Collections.Generic;

namespace Entity.DAO
{
    internal class CategoryDAO : BaseDAO
    {

        public BaseRow FindById(int id)
        {
            for (int i = 0; i < db.catagoryTable.Count; i++)
            {
                if (db.catagoryTable[i].getId() == id)
                {
                    return db.catagoryTable[i];
                }
            }
            return null;
        }
    }
}
