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
                Console.WriteLine("结果是：" + calculate.GetResult(numberA,numberB));
            }
            else {
                Console.WriteLine("请输入正确的数字");
            }
        }
    }
}
