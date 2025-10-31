# Design Patterns in C#

A comprehensive implementation of the 23 Gang of Four (GoF) Design Patterns in C# with examples and unit tests.

## ?? Table of Contents

- [Overview](#overview)
- [Project Structure](#project-structure)
- [Patterns Implemented](#patterns-implemented)
- [Getting Started](#getting-started)
- [Running Examples](#running-examples)
- [Running Tests](#running-tests)
- [Contributing](#contributing)

## ?? Overview

This repository contains complete implementations of all 23 classic Design Patterns from the "Gang of Four" book, organized into three categories:

- **Creational Patterns**: Deal with object creation mechanisms
- **Structural Patterns**: Deal with object composition
- **Behavioral Patterns**: Deal with object collaboration and responsibility distribution

## ?? Project Structure

```
DesignPatternsInCSharp/
??? README.md
??? .gitignore
??? DesignPatterns.sln
??? src/
?   ??? CreationalPatterns/
?   ??? StructuralPatterns/
?   ??? BehavioralPatterns/
??? tests/
?   ??? CreationalPatterns.Tests/
?   ??? StructuralPatterns.Tests/
?   ??? BehavioralPatterns.Tests/
??? examples/
?   ??? ConsoleApp/
??? docs/
    ??? images/
    ??? patterns/
```

## ?? Patterns Implemented

### Creational Patterns (5)
- ? **Singleton**: Ensures a class has only one instance
- ? **Factory Method**: Creates objects without specifying exact class
- ? **Abstract Factory**: Creates families of related objects
- ? **Builder**: Constructs complex objects step by step
- ? **Prototype**: Creates new objects by copying existing ones

### Structural Patterns (7)
- ? **Adapter**: Allows incompatible interfaces to work together
- ? **Bridge**: Separates abstraction from implementation
- ? **Composite**: Composes objects into tree structures
- ? **Decorator**: Adds responsibilities to objects dynamically
- ? **Facade**: Provides simplified interface to complex subsystem
- ? **Flyweight**: Shares data to support large numbers of objects
- ? **Proxy**: Provides placeholder for another object

### Behavioral Patterns (11)
- ? **Chain of Responsibility**: Passes requests along a chain of handlers
- ? **Command**: Encapsulates requests as objects
- ? **Interpreter**: Defines grammar and interpreter for a language
- ? **Iterator**: Accesses elements sequentially without exposing structure
- ? **Mediator**: Defines simplified communication between classes
- ? **Memento**: Captures and restores object's internal state
- ? **Observer**: Defines one-to-many dependency between objects
- ? **State**: Allows object to alter behavior when state changes
- ? **Strategy**: Defines family of algorithms and makes them interchangeable
- ? **Template Method**: Defines skeleton of algorithm in base class
- ? **Visitor**: Separates algorithms from objects they operate on

## ?? Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download) or later
- Visual Studio 2022, Visual Studio Code, or JetBrains Rider

### Building the Solution

```bash
# Clone the repository
git clone https://github.com/yourusername/DesignPatternsInCSharp.git
cd DesignPatternsInCSharp

# Restore dependencies
dotnet restore

# Build the solution
dotnet build

# Run all tests
dotnet test
```

## ?? Running Examples

```bash
# Run the console application with examples
dotnet run --project examples/ConsoleApp/ConsoleApp.csproj
```

## ?? Running Tests

```bash
# Run all tests
dotnet test

# Run tests for a specific category
dotnet test tests/CreationalPatterns.Tests/CreationalPatterns.Tests.csproj
dotnet test tests/StructuralPatterns.Tests/StructuralPatterns.Tests.csproj
dotnet test tests/BehavioralPatterns.Tests/BehavioralPatterns.Tests.csproj

# Run tests with coverage
dotnet test --collect:"XPlat Code Coverage"
```

## ?? Documentation

Detailed documentation for each pattern can be found in the `docs/patterns/` directory:

- Each pattern includes:
  - Intent and motivation
  - UML diagram
  - Real-world examples
  - Implementation details
  - Usage guidelines
  - Advantages and disadvantages

## ?? Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## ?? License

This project is licensed under the MIT License - see the LICENSE file for details.

## ?? References

- "Design Patterns: Elements of Reusable Object-Oriented Software" by Gang of Four
- [Refactoring.Guru - Design Patterns](https://refactoring.guru/design-patterns)
- [Microsoft Docs - Design Patterns](https://docs.microsoft.com/en-us/azure/architecture/patterns/)

## ? Star History

If you find this repository helpful, please consider giving it a star!
