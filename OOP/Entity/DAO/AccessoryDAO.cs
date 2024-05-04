using Entity.DAO.DAO;
using System.Collections.Generic;

namespace Entity.DAO
{
    internal class AccessoryDAO : BaseDAO , IDao
    {
        public BaseRow FindById(int id)
        {
            for (int i = 0; i < db.accesssoryTable.Count; i++)
            {
                if (db.accesssoryTable[i].getId() == id)
                {
                    return db.accesssoryTable[i];
                }
            }
            return null;
        }
    }
}

