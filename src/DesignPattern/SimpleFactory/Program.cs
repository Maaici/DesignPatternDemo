using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("请输入第一个数：");
            var numA = Console.ReadLine();
            Console.WriteLine("请输入第二个数：");
            var numB = Console.ReadLine();
            Console.WriteLine("请输入操作符（+、-、*、/）：");
            var operation = Console.ReadLine();

            double numberA, numberB;
            if (double.TryParse(numA, out numberA) && double.TryParse(numB, out numberB))
            {
                var calculate = CalculateFactory.GetCalculate(operation);
                calculate.NumberA = numberA;
                calculate.NumberB = numberB;
                Console.WriteLine("结果是：" + calculate.GetResult());
            }
            else {
                Console.WriteLine("请输入正确的数字");
            }

            Console.WriteLine("按任意按键退出。。。");
            Console.ReadKey();
        }
    }
}
