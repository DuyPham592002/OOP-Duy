namespace entity

class Category
{
    private int id;
    private string name;

    public int getId()
    {
        return id;
    }
    public int getName()
    {
        return name;
    }
    public int setName(string name)
    {
        this.name = name;
    }
    public int setId(int id)
    {
        this.id = id;
    }
}
