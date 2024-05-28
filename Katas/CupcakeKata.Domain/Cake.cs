namespace CupcakeKata.Domain;

public class Cake
{
    Cake(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public static Cake Cupcake() => new("Cupcake");
    public static Cake Cookie() => new("Cookie");
}