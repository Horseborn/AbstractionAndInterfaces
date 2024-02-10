namespace abstractionAndInterfaces;

public abstract class Product
{
    public string Name { get; set; }
    public abstract float Price();
    public abstract string GetShelf();
    public abstract string Description();
}