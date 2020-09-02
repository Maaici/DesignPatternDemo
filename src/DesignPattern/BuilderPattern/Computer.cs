namespace BuilderPattern
{
    /// <summary>
    /// 产品类：一个电脑
    /// </summary>
    public class Computer
    {
        //假设我们认为这个类的创建很复杂。
        public string Name { get; set; }
        public string CPU { get; set; }
        public string HardDisk { get; set; }
        public string Monitor { get; set; }

        //获取电脑的配置清单
        public void GetConfigurationList()
        {
            System.Console.WriteLine("--------本机配置清单-----");
            System.Console.WriteLine($"--计算机名称：{this.Name}");
            System.Console.WriteLine($"--处理器型号：{this.CPU}");
            System.Console.WriteLine($"--存储器型号：{this.HardDisk}");
            System.Console.WriteLine($"--显示器型号：{this.Monitor}");
        }
    }
}
