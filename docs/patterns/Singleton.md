# Singleton Pattern

## Intent
Ensure a class has only one instance and provide a global point of access to it.

## Motivation
Sometimes we need to ensure that a class has exactly one instance. For example:
- Database connections
- Configuration managers
- Logging services
- Thread pools
- Caches

## Structure
```
???????????????????????
?     Singleton    ?
???????????????????????
? - instance: static  ?
? - Singleton()       ?
???????????????????????
? + GetInstance()     ?
? + Operation()     ?
???????????????????????
```

## Implementation in C#

### Thread-Safe Implementation using Lazy<T>
```csharp
public sealed class Singleton
{
    private static readonly Lazy<Singleton> _instance = 
        new(() => new Singleton());

    private Singleton() { }

    public static Singleton Instance => _instance.Value;
}
```

## Real-World Examples

### 1. Configuration Manager
```csharp
public sealed class ConfigurationManager
{
    private static readonly Lazy<ConfigurationManager> _instance = 
  new(() => new ConfigurationManager());
    
    private readonly Dictionary<string, string> _settings;

    private ConfigurationManager()
  {
        _settings = LoadSettings();
    }

    public static ConfigurationManager Instance => _instance.Value;

    public string GetSetting(string key) => _settings[key];
}
```

### 2. Logger
```csharp
public sealed class Logger
{
    private static readonly Lazy<Logger> _instance = 
        new(() => new Logger());

    private Logger() { }

    public static Logger Instance => _instance.Value;

    public void Log(string message)
    {
        Console.WriteLine($"[{DateTime.Now}] {message}");
    }
}
```

## Advantages
? Controlled access to sole instance  
? Reduced memory footprint  
? Permits refinement of operations  
? Can control number of instances (can be extended to n-ton)  

## Disadvantages
? Violates Single Responsibility Principle  
? Can make unit testing difficult  
? Requires special treatment in multi-threaded environment  
? Can mask bad design (when components know too much about each other)  

## When to Use
- When exactly one instance of a class is needed
- When the instance needs to be accessible from multiple points in the application
- When the single instance should be extensible by subclassing

## When Not to Use
- When you need multiple instances
- When lifetime management is complex
- In situations where dependency injection would be better

## Related Patterns
- **Abstract Factory**: Often implemented as Singletons
- **Facade**: Can be implemented as a Singleton
- **State**: State objects are often Singletons

## Best Practices
1. Make the constructor private
2. Use thread-safe lazy initialization
3. Seal the class to prevent inheritance
4. Consider dependency injection as an alternative
5. Be cautious with state management

## Testing Considerations
```csharp
// Testing can be challenging with Singletons
// Consider using interfaces and dependency injection

public interface IConfigurationManager
{
 string GetSetting(string key);
}

public class ConfigurationManager : IConfigurationManager
{
    // Implementation
}

// In tests, you can now mock the interface
public class ServiceTests
{
  [Fact]
 public void TestWithMockedConfig()
    {
        var mockConfig = new Mock<IConfigurationManager>();
        mockConfig.Setup(c => c.GetSetting("key")).Returns("value");
     
        var service = new Service(mockConfig.Object);
   // Test service...
    }
}
```

## References
- Design Patterns: Elements of Reusable Object-Oriented Software (Gang of Four)
- [Refactoring.Guru - Singleton](https://refactoring.guru/design-patterns/singleton)
