using Entity.DAO.DAO;
using System.Collections.Generic;

namespace Entity.DAO
{
    internal class AccessoryDAO
    {
        Database db = new Database();

        public bool Insert(Accesstion row)
        {
            db.InsertTable("accessotion", row);
            return db.accesssoryTable.Contains(row);
        }

        public void Update(Accesstion row)
        {
            db.UpdateTable("accessotion", row);
        }

        void Delete(Accesstion row)
        {
            db.DeleteTable("accessotion", row);
        }

        public List<object> FindAll(Accesstion row)
        {
            return db.SelectTable("accessotion", row);
        }

        object FindById(int id)
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

