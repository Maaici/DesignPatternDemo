namespace StrategyPattern.Factory
{
    public class Discount : DiscountSuper
    {
        private readonly double coefficient;

        public Discount(double coefficient)
        {
            if (coefficient > 1 || coefficient <= 0)
            {
                this.coefficient = 1;
            }
            else
            {
                this.coefficient = coefficient;
            }

        }

        public override double GetPaidAmount(double original)
        {
            return original * coefficient;
        }
    }
}
