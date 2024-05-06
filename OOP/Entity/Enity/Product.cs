namespace Entity
{
    internal class Product : BaseRow
    {

        private int categoryId;

        /// <summary>
        /// get categoryId
        /// </summary>
        /// <returns>int</returns>
        public int GetCategoryId()
        {
            return categoryId;
        }

        /// <summary>
        /// set categoryId
        /// </summary>
        /// <param name="categoryId">int</param>
        public void setCategoryId(int categoryId)
        {
            this.categoryId = categoryId;
        }

        /// <summary>
        /// no parameters
        /// </summary>
        public Product() { }

        /// <summary>
        /// has parameters
        /// </summary>
        /// <param name="id">int</param>
        /// <param name="name">string</param>
        /// <param name="categoryId"></param>
        public Product(int id, string name, int categoryId)
        {
            this.id = id;
            this.name = name;
            this.categoryId = categoryId;
        }
    }
}
