namespace Entity
{
    public abstract class BaseRow
    {
        protected int id;
        protected string name;
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
    }
}
