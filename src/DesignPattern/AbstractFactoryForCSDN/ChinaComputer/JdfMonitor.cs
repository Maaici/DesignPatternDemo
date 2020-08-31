using System;

namespace AbstractFactoryForCSDN.ChinaComputer
{
    public class JdfMonitor : IMonitor
    {
        public void PrintResult()
        {
            Console.WriteLine("国产电脑：京东方显示器效果响当当。");
        }
    }
}
