namespace Entity
{
    internal class Category
    {
        private int id;
        private string name;

        public int getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public Category() { }
        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
