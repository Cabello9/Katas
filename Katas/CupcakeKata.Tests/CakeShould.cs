using CupcakeKata.Domain;
using FluentAssertions;

namespace CupcakeKata.Tests;

public class CakeShould
{
    [Test]
    public void Be_ACupcake()
    {
        Cake.Cupcake().Name.Should().Be("Cupcake");
    }

    [Test]
    public void Be_ACookie()
    {
        Cake.Cookie().Name.Should().Be("Cookie");
    }

    [Test]
    public void Cookie_HigherPrice_ThanCupcake()
    {
        throw new NotImplementedException();
    }
    
    [Test]
    public void Print_InOrder()
    {
        //var sut = Sugar(Nuts(Chocolate(Cupcake())));

        //sut.Name.Should().Be("");
        Assert.Fail();
    }
}