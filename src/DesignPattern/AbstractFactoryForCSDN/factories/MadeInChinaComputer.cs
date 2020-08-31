using AbstractFactoryForCSDN.ChinaComputer;

namespace AbstractFactoryForCSDN.factories
{
    public class MadeInChinaComputer : IComputerProvider
    {
        public ICentralProcessingUnit GetCPU()
        {
            return new LongXin();
        }

        public IHardDisk GetHardDisk()
        {
            return new HuaWei();
        }

        public IMonitor GetMonitor()
        {
            return new JdfMonitor();
        }
    }
}
