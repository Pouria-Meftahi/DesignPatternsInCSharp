namespace StructuralPatterns.Decorator
{
    public class BasicCoffee : ICoffee
    {
        public double GetCost()
        { 
               return 5.0;
        }

        public string GetDescription()
        {
            return "Simple Coffee";
        }
    }
}
