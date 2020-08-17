using FactoryMethod.Factories;
using FactoryMethod.operations;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //计算加法
            IFactory addFactory = new AddFactory();       //1、实例化工厂
            Operation add = addFactory.GetOperation();    //2、用工厂产生加法操作的实例
            add.NumberA = 50;
            add.NumberB = 60;
            Console.WriteLine($"{add.NumberA} + {add.NumberB} = {add.GetResult()}");

            //计算减法
            IFactory subFactory = new SubFactory();
            Operation sub = subFactory.GetOperation();
            sub.NumberA = 80;
            sub.NumberB = 60;
            Console.WriteLine($"{sub.NumberA} - {sub.NumberB} = {sub.GetResult()}");

            Console.ReadLine();
        }
    }
}
