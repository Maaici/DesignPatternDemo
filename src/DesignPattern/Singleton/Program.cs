using System;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++) {
                Task.Run(() =>
                {
                    China c = China.GetInstence();
                });
            }
            Console.ReadKey();
        }
    }
}
