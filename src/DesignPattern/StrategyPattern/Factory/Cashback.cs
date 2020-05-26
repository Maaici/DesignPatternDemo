using System;

namespace StrategyPattern.Factory
{
    public class Cashback : DiscountSuper
    {
        private readonly double _baseAmount;
        private readonly double _retAmount;

        public Cashback(double baseAmount, double retAmount)
        {
            _baseAmount = baseAmount;
            _retAmount = retAmount;
        }

        public override double GetPaidAmount(double original)
        {
            return original - Math.Floor((original / _baseAmount)) * _retAmount;
        }
    }
}
