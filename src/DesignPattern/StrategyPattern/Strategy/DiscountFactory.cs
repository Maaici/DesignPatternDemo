namespace StrategyPattern.Strategy
{
    public class DiscountFactory
    {
        public static CashStrategy GetDiscountinstance(string type)
        {
            CashStrategy super;
            switch (type)
            {
                case "8折":
                    super = new Discount(0.8);
                    break;
                case "7折":
                    super = new Discount(0.7);
                    break;
                case "5折":
                    super = new Discount(0.5);
                    break;
                case "满100减25":
                    super = new Reflow(100, 25);
                    break;
                default:
                    super = new Discount(1);
                    break;
            }
            return super;
        }
    }
}
