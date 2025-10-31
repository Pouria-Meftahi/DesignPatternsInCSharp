# Quick Start Guide

## Running the Project

### Option 1: Interactive Demo (Recommended for Learning)
```bash
dotnet run --project examples/ConsoleApp/ConsoleApp.csproj
```

This launches an interactive menu where you can explore all 23 design patterns with live examples.

### Option 2: Run Specific Pattern Tests
```bash
# Test all Creational Patterns
dotnet test tests/CreationalPatterns.Tests/CreationalPatterns.Tests.csproj

# Test all Structural Patterns
dotnet test tests/StructuralPatterns.Tests/StructuralPatterns.Tests.csproj

# Test all Behavioral Patterns
dotnet test tests/BehavioralPatterns.Tests/BehavioralPatterns.Tests.csproj

# Run all tests
dotnet test
```

### Option 3: Build and Explore the Code
```bash
# Build everything
dotnet build

# Open in Visual Studio
start DesignPatterns.sln

# Or open in VS Code
code .
```

## Pattern Quick Reference

### When to Use Each Pattern

**Object Creation Problems?** ? Creational Patterns
- Need ONE instance? ? **Singleton**
- Creating objects without knowing exact type? ? **Factory Method**
- Creating families of related objects? ? **Abstract Factory**
- Building complex objects step-by-step? ? **Builder**
- Copying objects? ? **Prototype**

**Object Structure Problems?** ? Structural Patterns
- Incompatible interfaces? ? **Adapter**
- Separate abstraction from implementation? ? **Bridge**
- Tree structures (part-whole)? ? **Composite**
- Adding features dynamically? ? **Decorator**
- Simplifying complex APIs? ? **Facade**
- Too many similar objects? ? **Flyweight**
- Controlling access to objects? ? **Proxy**

**Object Behavior Problems?** ? Behavioral Patterns
- Passing requests through chain? ? **Chain of Responsibility**
- Encapsulating actions as objects? ? **Command**
- Implementing a language/grammar? ? **Interpreter**
- Traversing collections? ? **Iterator**
- Centralizing object communication? ? **Mediator**
- Saving/restoring object state? ? **Memento**
- Notifying dependents of changes? ? **Observer**
- Behavior depends on state? ? **State**
- Swappable algorithms? ? **Strategy**
- Defining algorithm skeleton? ? **Template Method**
- Operations on object structures? ? **Visitor**

## Example Usage

### Singleton Pattern
```csharp
// Get the singleton instance
var logger = Singleton.Instance;
logger.Log("Application started");
```

### Factory Method Pattern
```csharp
// Create product without knowing exact class
ProductFactory factory = new ProductAFactory();
IProduct product = factory.CreateProduct();
```

### Builder Pattern
```csharp
// Build complex object step by step
var computer = new ComputerBuilder()
    .SetCPU("Intel i9")
    .SetRAM("32GB")
    .SetGPU("RTX 4090")
    .Build();
```

### Decorator Pattern
```csharp
// Add features dynamically
ICoffee coffee = new SimpleCoffee();
coffee = new MilkDecorator(coffee);
coffee = new SugarDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} - ${coffee.GetCost()}");
```

### Observer Pattern
```csharp
// Subscribe to notifications
var weatherStation = new WeatherStation();
weatherStation.Attach(new PhoneDisplay());
weatherStation.Attach(new TVDisplay());
weatherStation.Weather = "Sunny"; // Notifies all observers
```

### Strategy Pattern
```csharp
// Swap algorithms at runtime
var cart = new ShoppingCart();
cart.SetPaymentStrategy(new CreditCardPayment("1234-5678"));
cart.Checkout(100.00m);

cart.SetPaymentStrategy(new PayPalPayment("user@email.com"));
cart.Checkout(75.00m);
```

## Project Structure Quick View

```
src/
??? CreationalPatterns/   # Object creation
??? StructuralPatterns/     # Object composition  
??? BehavioralPatterns/     # Object collaboration

tests/
??? CreationalPatterns.Tests/
??? StructuralPatterns.Tests/
??? BehavioralPatterns.Tests/

examples/
??? ConsoleApp/         # Interactive demos

docs/
??? patterns/              # Detailed documentation
```

## Common Tasks

### Add a New Pattern
1. Create folder in appropriate category
2. Implement the pattern classes
3. Add to the main library project
4. Create unit tests
5. Add demo to ConsoleApp
6. Document in docs/patterns/

### Run Specific Test
```bash
dotnet test --filter "FullyQualifiedName~SingletonTests"
```

### Check Code Coverage
```bash
dotnet test --collect:"XPlat Code Coverage"
```

### Generate Documentation
```bash
# Install DocFX
dotnet tool install -g docfx

# Generate docs
docfx docs/docfx.json
```

## Troubleshooting

### Build Errors
```bash
# Clean and rebuild
dotnet clean
dotnet build
```

### Test Failures
```bash
# Run tests with detailed output
dotnet test --logger "console;verbosity=detailed"
```

### Missing Dependencies
```bash
# Restore NuGet packages
dotnet restore
```

## Learning Path

**Beginners** - Start here:
1. Singleton
2. Factory Method
3. Decorator
4. Observer
5. Strategy

**Intermediate**:
6. Builder
7. Adapter
8. Composite
9. Command
10. State

**Advanced**:
11. Abstract Factory
12. Bridge
13. Flyweight
14. Chain of Responsibility
15. Visitor

## Tips

?? **Best Practices:**
- Start with the console app to see patterns in action
- Read the pattern documentation before diving into code
- Try modifying examples to understand the patterns better
- Look at the tests to see how patterns are used

?? **Next Level:**
- Combine multiple patterns in real projects
- Understand when NOT to use a pattern
- Learn pattern relationships and variations
- Study modern alternatives (e.g., DI vs Singleton)

## Getting Help

- ?? Check `docs/patterns/README.md` for detailed guides
- ?? Review test files for usage examples
- ?? Run the console app for interactive demos
- ?? See README.md for additional resources

---

Happy Learning! ??
