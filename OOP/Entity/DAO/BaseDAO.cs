using Entity.DAO.DAO;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Entity.DAO
{
    internal abstract class BaseDAO
    {
        public Database instance = Database.GetInstance();

        /// <summary>
        /// insert row to table
        /// </summary>
        /// <param name="row">BaseRow</param>
        /// <returns>int</returns>
        public int Insert(BaseRow row)
        {
            instance.InsertTable(row.GetType().Name, row);
            return 1;
        }

        /// <summary>
        /// update row in table
        /// </summary>
        /// <param name="row">BaseRow</param>
        /// <returns>int</returns>
        public int Update(BaseRow row)
        {
            instance.UpdateTable(row.GetType().Name, row);
            return 1;
        }

        /// <summary>
        /// delete row in table
        /// </summary>
        /// <param name="row">BaseRow</param>
        /// <returns>bool</returns>
        public bool Delete(BaseRow row)
        {
            instance.DeleteTable(row.GetType().Name, row);
            return true;
        }

        /// <summary>
        /// select table to name
        /// </summary>
        /// <param name="row">BaseRow</param>
        /// <returns>List<BaseRow></returns>
        public List<BaseRow> FindAll(BaseRow row)
        {
            return instance.SelectTable(row.GetType().Name);
        }

        /// <summary>
        /// select table to id
        /// </summary>
        /// <param name="id">int</param>
        /// <param name="row">BaseRow</param>
        /// <returns>BaseRow</returns>
        public BaseRow FindById(int id, BaseRow row)
        {
            if (row.GetType().Name == StringCache.NAME_CATEGORY)
            {
                for (int i = 0; i < instance.GetCatagoryTable().Count; i++)
                {
                    if (instance.GetCatagoryTable()[i].getId() == id)
                    {
                        return instance.GetCatagoryTable()[i];
                    }
                }
            }

            if (row.GetType().Name == StringCache.NAME_PRODUCT)
            {
                for (int i = 0; i < instance.GetProductTable().Count; i++)
                {
                    if (instance.GetProductTable()[i].getId() == id)
                    {
                        return instance.GetProductTable()[i];
                    }
                }
            }
            return null;
        }
    }
}
