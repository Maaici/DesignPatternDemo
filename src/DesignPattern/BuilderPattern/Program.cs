using BuilderPattern.computers;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //1、实例化具体建造者
            ComputerBuilder builder = new DellComputerBuilder();
            //ComputerBuilder builder = new AppleComputerBuilder();
            //2、用具体建造者实例，实例化指挥者
            ComputerDirector director = new ComputerDirector(builder);
            //3、指挥者负责调度具体建造者来创建产品类
            var dellComputer = director.GetComputer();
            //4、用创建好的产品类，干活
            dellComputer.GetConfigurationList();
        }
    }
}
