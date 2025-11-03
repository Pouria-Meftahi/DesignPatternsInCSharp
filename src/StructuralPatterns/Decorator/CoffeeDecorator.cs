namespace StructuralPatterns.Decorator
{
    public abstract class CoffeeDecorator(ICoffee coffee) : ICoffee
    {
        protected readonly ICoffee _coffee = coffee;
        
        public virtual double GetCost()
        {
            return _coffee.GetCost();
        }
        public virtual string GetDescription()
        {
            return _coffee.GetDescription();
        }
    }
}
