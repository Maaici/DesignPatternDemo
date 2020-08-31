using System;

namespace AbstractFactoryForCSDN.ChinaComputer
{
    public class HuaWei : IHardDisk
    {
        public void LoadProgram()
        {
            Console.WriteLine("国产电脑：国产存储也很好哦！！！");
        }
    }
}
