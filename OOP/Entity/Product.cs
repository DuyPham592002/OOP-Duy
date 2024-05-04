namespace Entity
{
    internal class Product : BaseRow
    {

        private int categoryId;

        public void setCategoryId(int categoryId)
        {
            this.categoryId = categoryId;
        }
        public Product() { }
        public Product(int id, string name, int categoryId)
        {
            this.id = id;
            this.name = name;
            this.categoryId = categoryId;
        }
    }
}
