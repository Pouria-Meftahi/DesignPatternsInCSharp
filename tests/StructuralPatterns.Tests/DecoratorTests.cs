using StructuralPatterns.Decorator;

namespace StructuralPatterns.Tests;

public class DecoratorTests
{
    [Fact]
    public void TestCoffeeWithDecorators()
    {
        // Arrange
        ICoffee coffee = new BasicCoffee();
        coffee = new SugarDecorator(coffee);
        coffee = new WhipDecorator(coffee);
        // Act
        double cost = coffee.GetCost();
        string description = coffee.GetDescription();
        // Assert
        Assert.Equal(7.5, cost);
        Assert.Equal("Simple Coffee, Sugar, Whip", description);
    }
    [Fact]
    public void TestDecorators()
    {
        // Arrange
        ICoffee coffee = new BasicCoffee();
        // Act
        double baseCost = coffee.GetCost();
        coffee = new SugarDecorator(coffee);
        double sugarCost = coffee.GetCost();
        coffee = new WhipDecorator(coffee);
        double whipCost = coffee.GetCost();
        // Assert
        Assert.Equal(5.0, baseCost);
        Assert.Equal(5.5, sugarCost);
        Assert.Equal(7.5, whipCost);
    }
    [Fact]
    public void TestDescriptionWithMultipleDecorators()
    {
        // Arrange
        ICoffee coffee = new BasicCoffee();
        coffee = new MilkDecorator(coffee);
        coffee = new SugarDecorator(coffee);
        coffee = new WhipDecorator(coffee);
        // Act
        string description = coffee.GetDescription();
        // Assert
        Assert.Equal("Simple Coffee, Milk, Sugar, Whip", description);
    }
    [Fact]
    public void TestCostWithMultipleDecorators()
    {
        // Arrange
        ICoffee coffee = new BasicCoffee();
        coffee = new MilkDecorator(coffee);
        coffee = new SugarDecorator(coffee);
        coffee = new WhipDecorator(coffee);
        // Act
        double cost = coffee.GetCost();
        // Assert
        Assert.Equal(9.0, cost);
    } 
    [Fact]
    public void TestBasicCoffee()
    {
        // Arrange
        ICoffee coffee = new BasicCoffee();
        // Act
        double cost = coffee.GetCost();
        string description = coffee.GetDescription();
        // Assert
        Assert.Equal(5.0, cost);
        Assert.Equal("Simple Coffee", description);
    }
    [Fact]
    public void TestSingleDecorator()
    {
        // Arrange
        ICoffee coffee = new BasicCoffee();
        coffee = new MilkDecorator(coffee);
        // Act
        double cost = coffee.GetCost();
        string description = coffee.GetDescription();
        // Assert
        Assert.Equal(6.5, cost);
        Assert.Equal("Simple Coffee, Milk", description);
    }
    [Fact]
    public void TestMultipleSameDecorators()
    {
        // Arrange
        ICoffee coffee = new BasicCoffee();
        coffee = new SugarDecorator(coffee);
        coffee = new SugarDecorator(coffee);
        // Act
        double cost = coffee.GetCost();
        string description = coffee.GetDescription();
        // Assert
        Assert.Equal(6.0, cost);
        Assert.Equal("Simple Coffee, Sugar, Sugar", description);
    }
    [Fact]
    public void TestNoDecorators()
    {
        // Arrange
        ICoffee coffee = new BasicCoffee();
        // Act
        double cost = coffee.GetCost();
        string description = coffee.GetDescription();
        // Assert
        Assert.Equal(5.0, cost);
        Assert.Equal("Simple Coffee", description);
    }
    [Fact]
    public void TestAllDecorators()
    {
        // Arrange
        ICoffee coffee = new BasicCoffee();
        coffee = new MilkDecorator(coffee);
        coffee = new SugarDecorator(coffee);
        coffee = new WhipDecorator(coffee);
        // Act
        double cost = coffee.GetCost();
        string description = coffee.GetDescription();
        // Assert
        Assert.Equal(9.0, cost);
        Assert.Equal("Simple Coffee, Milk, Sugar, Whip", description);
    }
    [Fact]
    public void TestDecoratorOrder()
    {
        // Arrange
        ICoffee coffee1 = new BasicCoffee();
        coffee1 = new SugarDecorator(coffee1);
        coffee1 = new MilkDecorator(coffee1);
        
        ICoffee coffee2 = new BasicCoffee();
        coffee2 = new SugarDecorator(coffee2);
        coffee2 = new MilkDecorator(coffee2);
        
        // Act
        double cost1 = coffee1.GetCost();
        string description1 = coffee1.GetDescription();
        
        double cost2 = coffee2.GetCost();
        string description2 = coffee2.GetDescription();
        
        // Assert
        Assert.Equal(cost1, cost2);
        Assert.Equal(description1, description2);
    }
    [Fact]
    public void TestDecoratorIndependence()
    {
        // Arrange
        ICoffee coffee1 = new BasicCoffee();
        coffee1 = new MilkDecorator(coffee1);
        
        ICoffee coffee2 = new BasicCoffee();
        coffee2 = new SugarDecorator(coffee2);
        
        // Act
        double cost1 = coffee1.GetCost();
        string description1 = coffee1.GetDescription();
        
        double cost2 = coffee2.GetCost();
        string description2 = coffee2.GetDescription();
        
        // Assert
        Assert.Equal(6.5, cost1);
        Assert.Equal("Simple Coffee, Milk", description1);
        
        Assert.Equal(5.5, cost2);
        Assert.Equal("Simple Coffee, Sugar", description2);
    }
    
}
