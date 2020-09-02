namespace BuilderPattern
{
    /// <summary>
    /// 抽象建造者：包含了一些了步骤的抽象
    /// </summary>
    public abstract class ComputerBuilder
    {
        public abstract void Named();//起名
        public abstract void BilderCPU();//安装cpu
        public abstract void BilderHardDisk();//安装存储
        public abstract void BilderMonitor(); //安装显示器
        public abstract Computer GetComputer();//成品出货
    }
}
