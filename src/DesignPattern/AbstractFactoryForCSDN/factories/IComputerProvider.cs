namespace AbstractFactoryForCSDN.factories
{
    //抽象工厂
    interface IComputerProvider
    {
        IHardDisk GetHardDisk();//拿到存储器

        ICentralProcessingUnit GetCPU();//拿到cpu

        IMonitor GetMonitor();//显示器
    }
}
