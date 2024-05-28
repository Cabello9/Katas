using System.Text;

namespace CupcakeKata.Domain;

public class Cake
{
    readonly List<Topping> toppings = new();
    readonly float price;
    readonly string name;

    Cake(string name, float price)
    {
        this.name = name;
        this.price = price;
    }

    public string Name
    {
        get
        {
            return toppings.Count != 0
                ? ComposeToppings()
                : name;

            string ComposeToppings()
            {
                var sb = new StringBuilder();
                sb.Append(name);
                for(var index = 0; index < toppings.Count; index++)
                {
                    if(index == 0)
                        sb.Append($" with {toppings[index].Name}");
                    else
                        sb.Append($" and {toppings[index].Name}");
                }

                return sb.ToString();
            }
        }
    }

    public float Price => price + toppings.Sum(t => t.Price);
    
    public static Cake Cupcake() => new("Cupcake", 1f);
    public static Cake Cookie() => new("Cookie", 2f);
    public static Cake Chocolate(Cake cake) => cake.With(Topping.Chocolate());
    public static Cake Peanut(Cake cake) => cake.With(Topping.Peanut());
    
    Cake With(Topping topping)
    {
        toppings.Add(topping);
        return this;
    }
}