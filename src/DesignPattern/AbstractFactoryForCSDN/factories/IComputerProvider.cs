using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryForCSDN.factories
{
    interface IComputerProvider
    {
        IHardDisk GetHardDisk();

        ICentralProcessingUnit GetCPU();

        IMonitor GetMonitor();
    }
}
