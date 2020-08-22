using System;

namespace AbstractFactoryForCSDN.DELL
{
    public class Dell2418t : IMonitor
    {
        public void PrintResult()
        {
            Console.WriteLine("DELL电脑：戴尔24寸2K显示器显示结果还不错，就是刷新率低了点。");
        }
    }
}
