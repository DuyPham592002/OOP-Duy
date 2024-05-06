namespace Entity
{
    internal class Category : BaseRow
    {
        /// <summary>
        /// no parameters
        /// </summary>
        public Category() { }

        /// <summary>
        /// has parameters
        /// </summary>
        /// <param name="id">int</param>
        /// <param name="name">string</param>
        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
