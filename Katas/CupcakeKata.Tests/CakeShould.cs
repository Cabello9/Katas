using CupcakeKata.Domain;
using FluentAssertions;

namespace CupcakeKata.Tests;

public class CakeShould
{
    [Test]
    public void Be_ACupcake()
    {
        var sut = Cake.Cupcake();

        sut.Name.Should().Be("Cupcake");
    }

    [Test]
    public void Be_ACookie()
    {
        var sut = Cake.Cookie();
        sut.Name.Should().Be("Cookie");
    }
    
    [Test]
    public void Print_InOrder()
    {
        //var sut = Sugar(Nuts(Chocolate(Cupcake())));

        //sut.Name.Should().Be("");
        Assert.Fail();
    }
}