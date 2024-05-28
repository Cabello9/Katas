namespace CupcakeKata.Domain;

public class Cake
{
    Cake(string name, float price)
    {
        Name = name;
        Price = price;
    }

    public string Name { get; }
    public float Price { get; }

    public static Cake Cupcake() => new("Cupcake", 1f);
    public static Cake Cookie() => new("Cookie", 2f);
    
    public static Cake Chocolate(Cake cake)
    {
        return new($"{cake.Name} with Chocolate", cake.Price + 0.1f);
    }
}