namespace BuilderPattern
{
    /// <summary>
    /// 指挥者：定义了产品创建的步骤，但是自己不动手，指挥具体建造者来干活
    /// </summary>
    public class ComputerDirector
    {
        private readonly ComputerBuilder _builder;

        //构造函数接收一个抽象建造者，所有实现了抽象建造者的具体建造者实例都可以接收，实现不同的建造细节
        public ComputerDirector(ComputerBuilder builder)
        {
            _builder = builder;
        }

        public Computer GetComputer()
        {
            _builder.Named();               //1、先起名
            _builder.BilderCPU();           //2、安装CPU
            _builder.BilderHardDisk();      //3、安装存储
            _builder.BilderMonitor();       //4、连接显示器

            return _builder.GetComputer();  //返回具体的产品
        }

    }
}
