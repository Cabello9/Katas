namespace CupcakeKata.Domain;

public class Topping
{
    public string Name { get; }
    public float Price { get; }

    Topping(string name, float price)
    {
        Name = name;
        Price = price;
    }

    public static Topping Chocolate() => new("Chocolate", 0.1f);
    public static Topping Peanut() => new("Peanut", 0.2f);
}