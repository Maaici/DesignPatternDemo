using System;

namespace AbstractFactoryForCSDN.DELL
{
    public class Samsung960EVO : IHardDisk
    {
        public void LoadProgram()
        {
            Console.WriteLine("DELL电脑：三星960EVO固态硬盘加载程序速度真快！！！");
        }
    }
}
