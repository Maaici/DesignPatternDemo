namespace StrategyPattern.Strategy
{
    public class Discount : CashStrategy
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
        public override double GetPayMoney(double original)
        {
            return original * coefficient;
        }
    }
}
