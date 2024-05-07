using Entity.DAO.DAO;
using System;
using System.Collections.Generic;

namespace Entity.DAO
{
    internal abstract class BaseDAO
    {
        public Database instance = Database.GetInstance();

        /// <summary>
        /// insert row to table
        /// </summary>
        /// <param name="row">BaseRow</param>
        /// <returns></returns>
        public int Insert(BaseRow row)
        {
            if (instance.InsertTable(row.GetType().Name, row) == 1)
            {
                return 1;
            }
            return 0;
        }

        /// <summary>
        /// update row in table
        /// </summary>
        /// <param name="row">BaseRow</param>
        /// <returns></returns>
        public int Update(BaseRow row)
        {
            if (instance.UpdateTable(row.GetType().Name, row) == 1)
            {
                return 1;
            }
            return 0;
        }

        /// <summary>
        /// delete row in table
        /// </summary>
        /// <param name="row">BaseRow</param>
        /// <returns></returns>
        public bool Delete(BaseRow row)
        {
            if (instance.DeleteTable(row.GetType().Name, row) == true)
            {
                return true;
            }
            return false;
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
            if (row is Category)
            {
                for (int i = 0; i < instance.GetCatagoryTable().Count; i++)
                {
                    if (instance.GetCatagoryTable()[i].getId() == id)
                    {
                        return instance.GetCatagoryTable()[i];
                    }
                }
            }

            if (row is Product)
            {
                for (int i = 0; i < instance.GetProductTable().Count; i++)
                {
                    if (instance.GetProductTable()[i].getId() == id)
                    {
                        return instance.GetProductTable()[i];
                    }
                }
            }

            if (row is Accesstion)
            {
                for (int i = 0; i < instance.GetAccesssoryTable().Count; i++)
                {
                    if (instance.GetAccesssoryTable()[i].getId() == id)
                    {
                        return instance.GetAccesssoryTable()[i];
                    }
                }
            }
            return null;
        }
    }
}
