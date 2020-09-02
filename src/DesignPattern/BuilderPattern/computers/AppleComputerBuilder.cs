using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.computers
{
    /// <summary>
    /// 具体建造者：苹果电脑建造者，继承了抽象建造者，并重写了它的方法，有自己具体的独特的建造细节，返回苹果电脑产品实例
    /// </summary>
    public class AppleComputerBuilder : ComputerBuilder
    {
        Computer computer = new Computer();

        public override void Named()
        {
            computer.Name = " MacBookPro ";
        }
        public override void BilderCPU()
        {
            computer.CPU = "Inter i7 八核心Cpu";
        }

        public override void BilderHardDisk()
        {
            computer.HardDisk = "专利存储方案，就是快！";
        }

        public override void BilderMonitor()
        {
            computer.Monitor = "高清视网膜屏幕，养眼！";
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
}
