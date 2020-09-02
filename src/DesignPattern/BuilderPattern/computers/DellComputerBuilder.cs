namespace BuilderPattern
{
    /// <summary>
    /// 具体建造者：戴尔电脑建造者，继承了抽象建造者，并重写了它的方法，有自己具体的独特的建造细节，返回戴尔电脑产品实例
    /// </summary>
    public class DellComputerBuilder : ComputerBuilder
    {
        Computer computer = new Computer();

        public override void Named()
        {
            computer.Name = " dell 高端电脑 ";
        }
        public override void BilderCPU()
        {
            computer.CPU = "Inter i9-9900K";
        }

        public override void BilderHardDisk()
        {
            computer.HardDisk = "Samsung960EVO";
        }

        public override void BilderMonitor()
        {
            computer.Monitor = "Dell2418t";
        }

        public override Computer GetComputer()
        {
            return computer;
        }

    }
}
