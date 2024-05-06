namespace Entity
{
    public abstract class BaseRow
    {
        protected int id;
        protected string name;

        /// <summary>
        /// get id
        /// </summary>
        /// <returns>int</returns>
        public int getId()
        {
            return id;
        }

        /// <summary>
        /// get name
        /// </summary>
        /// <returns>string</returns>
        public string getName()
        {
            return name;
        }

        /// <summary>
        /// set name
        /// </summary>
        /// <param name="name">string</param>
        public void setName(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// set id
        /// </summary>
        /// <param name="id">int</param>
        public void setId(int id)
        {
            this.id = id;
        }
    }
}
