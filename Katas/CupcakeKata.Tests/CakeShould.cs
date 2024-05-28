using FluentAssertions;
using static CupcakeKata.Domain.Cake;

namespace CupcakeKata.Tests;

public class CakeShould
{
    [Test]
    public void Be_ACupcake()
    {
        Cupcake().Name.Should().Be("Cupcake");
    }

    [Test]
    public void Be_ACookie()
    {
        Cookie().Name.Should().Be("Cookie");
    }

    [Test]
    public void Cookie_HigherPrice_ThanCupcake()
    {
        Cookie().Price.Should().BeGreaterThan(Cupcake().Price);
    }

    [Test]
    public void HaveChocolate()
    {
        var cupcake = Chocolate(Cupcake());
        var cookie = Chocolate(Cookie());

        cupcake.Name.Should().Be("Cupcake with Chocolate");
        cookie.Name.Should().Be("Cookie with Chocolate");
    }
    
    [Test]
    public void HavePeanut()
    {
        var cupcake = Peanut(Cupcake());
        var cookie = Peanut(Cookie());

        cupcake.Name.Should().Be("Cupcake with Peanut");
        cookie.Name.Should().Be("Cookie with Peanut");
    }

    [Test]
    public void SumPriceOfChocolateTopping()
    {
        var cupcake = Chocolate(Cupcake());
        var cookie = Chocolate(Cookie());

        cupcake.Price.Should().Be(1.1f);
        cookie.Price.Should().Be(2.1f);
    }
    
    [Test]
    public void HaveChocolateAndPeanut()
    {
        var cupcake = Peanut(Chocolate(Cupcake()));

        cupcake.Name.Should().Be("Cupcake with Chocolate and Peanut");
    }
    
    [Test]
    public void HavePeanutAndChocolate()
    {
        var cupcake = Chocolate(Peanut(Cupcake()));

        cupcake.Name.Should().Be("Cupcake with Peanut and Chocolate");
    }
    
    [Test]
    public void SumPriceOfAllToppings()
    {
        var cupcake = Peanut(Chocolate(Cupcake()));
        var reversedCupcake = Chocolate(Peanut(Cupcake()));

        cupcake.Price.Should().Be(1.3f);
        reversedCupcake.Price.Should().Be(1.3f);
    }
}