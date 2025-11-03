namespace StructuralPatterns.Decorator
{
    public class WhipDecorator(ICoffee coffee) : CoffeeDecorator(coffee)
    {
        public override double GetCost()
        {
            return base.GetCost() + 2.0;
        }
        public override string GetDescription()
        {
            return base.GetDescription() + ", Whip";
        }
    }
}
