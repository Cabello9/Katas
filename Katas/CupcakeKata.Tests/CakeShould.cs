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
    public void Print_InOrder()
    {
        //var sut = Sugar(Nuts(Chocolate(Cupcake())));

        //sut.Name.Should().Be("");
        Assert.Fail();
    }
}