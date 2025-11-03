namespace StructuralPatterns.Decorator
{
    public class MilkDecorator(ICoffee coffee) : CoffeeDecorator(coffee)
    {
        public override double GetCost()
        {
            return base.GetCost() + 1.5;
        }
        public override string GetDescription()
        {
            return base.GetDescription() + ", Milk";
        }
    }
}
