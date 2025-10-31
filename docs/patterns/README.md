# Design Patterns Overview

This directory contains detailed documentation for all 23 Gang of Four design patterns.

## Pattern Categories

### Creational Patterns
Creational patterns provide various object creation mechanisms that increase flexibility and reuse of existing code.

- **[Singleton](Singleton.md)** - Ensures a class has only one instance
- **Factory Method** - Creates objects without specifying exact class
- **Abstract Factory** - Creates families of related objects
- **Builder** - Constructs complex objects step by step
- **Prototype** - Creates new objects by copying existing ones

### Structural Patterns
Structural patterns explain how to assemble objects and classes into larger structures while keeping them flexible and efficient.

- **Adapter** - Allows incompatible interfaces to work together
- **Bridge** - Separates abstraction from implementation
- **Composite** - Composes objects into tree structures
- **Decorator** - Adds responsibilities to objects dynamically
- **Facade** - Provides simplified interface to complex subsystem
- **Flyweight** - Shares data to support large numbers of objects
- **Proxy** - Provides placeholder for another object

### Behavioral Patterns
Behavioral patterns are concerned with algorithms and the assignment of responsibilities between objects.

- **Chain of Responsibility** - Passes requests along a chain of handlers
- **Command** - Encapsulates requests as objects
- **Interpreter** - Defines grammar and interpreter for a language
- **Iterator** - Accesses elements sequentially
- **Mediator** - Defines simplified communication between classes
- **Memento** - Captures and restores object's internal state
- **Observer** - Defines one-to-many dependency between objects
- **State** - Allows object to alter behavior when state changes
- **Strategy** - Defines family of interchangeable algorithms
- **Template Method** - Defines skeleton of algorithm in base class
- **Visitor** - Separates algorithms from objects they operate on

## Documentation Structure

Each pattern documentation includes:

1. **Intent** - What problem does the pattern solve?
2. **Motivation** - Why do we need this pattern?
3. **Structure** - UML diagram showing the pattern structure
4. **Implementation** - C# code examples
5. **Real-World Examples** - Practical use cases
6. **Advantages** - Benefits of using the pattern
7. **Disadvantages** - Drawbacks and limitations
8. **When to Use** - Appropriate scenarios
9. **When Not to Use** - Situations to avoid
10. **Related Patterns** - Connections to other patterns
11. **Best Practices** - Tips for effective implementation
12. **Testing Considerations** - How to test the pattern

## Pattern Selection Guide

### Choose Based on Your Need:

**Need to create objects?** ? Creational Patterns
- Single instance? ? **Singleton**
- Family of objects? ? **Abstract Factory**
- Complex object construction? ? **Builder**
- Clone objects? ? **Prototype**
- Defer instantiation to subclasses? ? **Factory Method**

**Need to structure objects?** ? Structural Patterns
- Interface incompatibility? ? **Adapter**
- Separate abstraction from implementation? ? **Bridge**
- Tree structures? ? **Composite**
- Add responsibilities dynamically? ? **Decorator**
- Simplify complex interface? ? **Facade**
- Share object data? ? **Flyweight**
- Control access? ? **Proxy**

**Need to define object behavior?** ? Behavioral Patterns
- Chain of handlers? ? **Chain of Responsibility**
- Encapsulate requests? ? **Command**
- Parse language? ? **Interpreter**
- Traverse collection? ? **Iterator**
- Centralize communication? ? **Mediator**
- Save/restore state? ? **Memento**
- Notify changes? ? **Observer**
- Behavior depends on state? ? **State**
- Interchangeable algorithms? ? **Strategy**
- Define algorithm skeleton? ? **Template Method**
- Operations on object structure? ? **Visitor**

## Learning Path

### Beginner (Start Here)
1. Singleton
2. Factory Method
3. Adapter
4. Decorator
5. Observer
6. Strategy

### Intermediate
7. Builder
8. Prototype
9. Composite
10. Facade
11. Proxy
12. Command
13. Iterator
14. Template Method
15. State

### Advanced
16. Abstract Factory
17. Bridge
18. Flyweight
19. Chain of Responsibility
20. Mediator
21. Memento
22. Interpreter
23. Visitor

## Additional Resources

- [Refactoring.Guru](https://refactoring.guru/design-patterns) - Excellent visual explanations
- [Design Patterns: Elements of Reusable Object-Oriented Software](https://www.amazon.com/Design-Patterns-Elements-Reusable-Object-Oriented/dp/0201633612) - The original GoF book
- [Head First Design Patterns](https://www.amazon.com/Head-First-Design-Patterns-Brain-Friendly/dp/0596007124) - Beginner-friendly approach
- [Microsoft Docs - Cloud Design Patterns](https://docs.microsoft.com/en-us/azure/architecture/patterns/) - Modern cloud patterns
