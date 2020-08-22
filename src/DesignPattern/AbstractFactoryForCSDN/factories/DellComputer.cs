using AbstractFactoryForCSDN.DELL;

namespace AbstractFactoryForCSDN.factories
{
    public class DellComputer : IComputerProvider
    {
        public ICentralProcessingUnit GetCPU()
        {
            return new InterI58500();
        }

        public IHardDisk GetHardDisk()
        {
            return new Samsung960EVO();
        }

        public IMonitor GetMonitor()
        {
            return new Dell2418t();
        }
    }
}
