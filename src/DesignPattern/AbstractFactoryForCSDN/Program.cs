using AbstractFactoryForCSDN.factories;
using System;

namespace AbstractFactoryForCSDN
{
    class Program
    {
        static void Main(string[] args)
        {
            IComputerProvider computer = new DellComputer();

            ICentralProcessingUnit cpu = computer.GetCPU() ;
            IHardDisk hd = computer.GetHardDisk();
            IMonitor monitor = computer.GetMonitor();

            cpu.ExecutionProgram();
            hd.LoadProgram();
            monitor.PrintResult();

            Console.ReadLine();
        }
    }
}
