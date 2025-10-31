

namespace DesignPatternsConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("╔═══════════════════════════════════════════════════════════╗");
        Console.WriteLine("║     Design Patterns in C# - Interactive Examples         ║");
        Console.WriteLine("╚═══════════════════════════════════════════════════════════╝");
        Console.WriteLine();

        while (true)
        {
            DisplayMenu();
            var choice = Console.ReadLine();

            if (choice == "0") break;

            Console.Clear();
            ExecutePattern(choice);

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        Console.WriteLine("Thank you for exploring Design Patterns!");
    }

    static void DisplayMenu()
    {
        Console.WriteLine("═══════════════════════════════════════════════════════════");
        Console.WriteLine("CREATIONAL PATTERNS");
        Console.WriteLine("═══════════════════════════════════════════════════════════");
        Console.WriteLine("1.  Singleton Pattern");
        Console.WriteLine("2.  Factory Method Pattern");
        Console.WriteLine("3.  Abstract Factory Pattern");
        Console.WriteLine("4.  Builder Pattern");
        Console.WriteLine("5.  Prototype Pattern");
        Console.WriteLine();
        Console.WriteLine("═══════════════════════════════════════════════════════════");
        Console.WriteLine("STRUCTURAL PATTERNS");
        Console.WriteLine("═══════════════════════════════════════════════════════════");
        Console.WriteLine("6.  Adapter Pattern");
        Console.WriteLine("7.  Bridge Pattern");
        Console.WriteLine("8.  Composite Pattern");
        Console.WriteLine("9.  Decorator Pattern");
        Console.WriteLine("10. Facade Pattern");
        Console.WriteLine("11. Flyweight Pattern");
        Console.WriteLine("12. Proxy Pattern");
        Console.WriteLine();
        Console.WriteLine("═══════════════════════════════════════════════════════════");
        Console.WriteLine("BEHAVIORAL PATTERNS");
        Console.WriteLine("═══════════════════════════════════════════════════════════");
        Console.WriteLine("13. Chain of Responsibility Pattern");
        Console.WriteLine("14. Command Pattern");
        Console.WriteLine("15. Interpreter Pattern");
        Console.WriteLine("16. Iterator Pattern");
        Console.WriteLine("17. Mediator Pattern");
        Console.WriteLine("18. Memento Pattern");
        Console.WriteLine("19. Observer Pattern");
        Console.WriteLine("20. State Pattern");
        Console.WriteLine("21. Strategy Pattern");
        Console.WriteLine("22. Template Method Pattern");
        Console.WriteLine("23. Visitor Pattern");
        Console.WriteLine();
        Console.WriteLine("0.  Exit");
        Console.WriteLine("═══════════════════════════════════════════════════════════");
        Console.Write("\nSelect a pattern to explore (0-23): ");
    }

    static void ExecutePattern(string? choice)
    {
        switch (choice)
        {
            case "1": DemoSingleton(); break;
            case "2": DemoFactory(); break;
            case "3": DemoAbstractFactory(); break;
            case "4": DemoBuilder(); break;
            case "5": DemoPrototype(); break;
            case "6": DemoAdapter(); break;
            case "7": DemoBridge(); break;
            case "8": DemoComposite(); break;
            case "9": DemoDecorator(); break;
            case "10": DemoFacade(); break;
            case "11": DemoFlyweight(); break;
            case "12": DemoProxy(); break;
            case "13": DemoChainOfResponsibility(); break;
            case "14": DemoCommand(); break;
            case "15": DemoInterpreter(); break;
            case "16": DemoIterator(); break;
            case "17": DemoMediator(); break;
            case "18": DemoMemento(); break;
            case "19": DemoObserver(); break;
            case "20": DemoState(); break;
            case "21": DemoStrategy(); break;
            case "22": DemoTemplateMethod(); break;
            case "23": DemoVisitor(); break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    static void PrintHeader(string patternName)
    {
        Console.WriteLine($"╔═══════════════════════════════════════════════════════════╗");
        Console.WriteLine($"║  {patternName.PadRight(57)}║");
        Console.WriteLine($"╚═══════════════════════════════════════════════════════════╝");
        Console.WriteLine();
    }

    // Creational Patterns Demos
    static void DemoSingleton()
    {
        PrintHeader("SINGLETON PATTERN");
       
    }

    static void DemoFactory()
    {
        PrintHeader("FACTORY METHOD PATTERN");
       
    }

    static void DemoAbstractFactory()
    {
        PrintHeader("ABSTRACT FACTORY PATTERN");
       
    }

    static void DemoBuilder()
    {
        PrintHeader("BUILDER PATTERN");
       
    }

    static void DemoPrototype()
    {
        PrintHeader("PROTOTYPE PATTERN");
       
    }

    // Structural Patterns Demos
    static void DemoAdapter()
    {
        PrintHeader("ADAPTER PATTERN");
       
    }

    static void DemoBridge()
    {
        PrintHeader("BRIDGE PATTERN");
        
    }

    static void DemoComposite()
    {
        PrintHeader("COMPOSITE PATTERN");
       
    }

    static void DemoDecorator()
    {
        PrintHeader("DECORATOR PATTERN");
        

    }

    static void DemoFacade()
    {
        PrintHeader("FACADE PATTERN");
       
    }

    static void DemoFlyweight()
    {
        PrintHeader("FLYWEIGHT PATTERN");
       
    }

    static void DemoProxy()
    {
        PrintHeader("PROXY PATTERN");
       
    }

    // Behavioral Patterns Demos
    static void DemoChainOfResponsibility()
    {
        PrintHeader("CHAIN OF RESPONSIBILITY PATTERN");
      
    }

    static void DemoCommand()
    {
        PrintHeader("COMMAND PATTERN");
      
    }

    static void DemoInterpreter()
    {
        PrintHeader("INTERPRETER PATTERN");
       
    }

    static void DemoIterator()
    {
        PrintHeader("ITERATOR PATTERN");
       
    }

    static void DemoMediator()
    {
        PrintHeader("MEDIATOR PATTERN");
       
    }

    static void DemoMemento()
    {
        PrintHeader("MEMENTO PATTERN");
       
    }

    static void DemoObserver()
    {
        PrintHeader("OBSERVER PATTERN");
       
    }

    static void DemoState()
    {
        PrintHeader("STATE PATTERN");
       
    }

    static void DemoStrategy()
    {
        PrintHeader("STRATEGY PATTERN");
       
    }

    static void DemoTemplateMethod()
    {
        PrintHeader("TEMPLATE METHOD PATTERN");
       
    }

    static void DemoVisitor()
    {
        PrintHeader("VISITOR PATTERN");
        
    }
}
