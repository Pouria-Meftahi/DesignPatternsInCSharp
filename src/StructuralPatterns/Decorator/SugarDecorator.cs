namespace StructuralPatterns.Decorator
{
    public class SugarDecorator(ICoffee coffee) : CoffeeDecorator(coffee)
    {
        public override double GetCost()
        {
            return base.GetCost() + 0.5;
        }
        public override string GetDescription()
        {
            return base.GetDescription() + ", Sugar";
        }
    }
}
