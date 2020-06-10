namespace StrategyPattern.Strategy
{
    public class CashStrategyContext
    {
        private readonly CashStrategy _strategy;

        public CashStrategyContext(string text)
        {
            #region 让策略上下文来决定选择什么样的策略，客户端不要关注（这边也可以使用简单工厂来简化实例的创建）

            //CashStrategy super;
            //switch (text)
            //{
            //    case "8折":
            //        super = new Discount(0.8);
            //        break;
            //    case "7折":
            //        super = new Discount(0.7);
            //        break;
            //    case "5折":
            //        super = new Discount(0.5);
            //        break;
            //    case "满100减25":
            //        super = new Reflow(100, 25);
            //        break;
            //    default:
            //        super = new Discount(1);
            //        break;
            //}

            //简单工厂
            CashStrategy super = DiscountFactory.GetDiscountinstance(text);

            #endregion

            _strategy = super;
        }

        public double GetPayAMount(double original)
        {
            return _strategy.GetPayMoney(original);
        }
    }
}
