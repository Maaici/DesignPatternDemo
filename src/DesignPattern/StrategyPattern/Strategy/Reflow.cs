using System;

namespace StrategyPattern.Strategy
{
    public class Reflow : CashStrategy
    {
        private readonly double _baseAmount;
        private readonly double _retAmount;

        public Reflow(double baseAmount, double retAmount)
        {
            _baseAmount = baseAmount;
            _retAmount = retAmount;
        }

        public override double GetPayMoney(double original)
        {
            return original - Math.Floor((original / _baseAmount)) * _retAmount;
        }
    }
}
