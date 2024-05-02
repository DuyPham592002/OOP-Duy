namespace entity

class Product
{
    private int id;
    private string name;
    private int categoryId;

    public int getId()
    {
        return id;
    }
    public int getName()
    {
        return name;
    }
    public int getCategoryId()
    {
        return categoryId;
    }
    public int setName(string name)
    {
        this.name = name;
    }
    public int setId(int id)
    {
        this.id = id;
    }
    public int setCategoryId(int categoryId)
    {
        this.categoryId = categoryId;
    }
}


