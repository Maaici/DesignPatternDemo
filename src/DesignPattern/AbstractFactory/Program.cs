using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User { ID = 1, Name = "maaici" };
            Department department = new Department { ID = 1, DeptName = "信息中心" };
            //1、原始写法
            //SqlServerUser sqlServer = new SqlServerUser();
            //sqlServer.InserUser(user);
            //sqlServer.GetUser(1);

            //2、工厂方法(目前支持了sql和access两种数据库访问)
            // 导入：假设数据库只有一个user表 需要支持 sqlserver 和 access 两种数据库
            //IFactory factory = new SqlServerFactory(); // 选用sqlserver工厂则使用sqlserver访问
            //IFactory factory = new AccessFactory();
            //IUser _user = factory.CreateUser();
            //_user.InserUser(user);
            //_user.GetUser(1);

            //导入：在上面的基础上，增加一个表 部门表（department）
            //IFactory factory = new SqlServerFactory();
            //IFactory factory = new AccessFactory();
            //IDepartment _department = factory.CreateDepartment();
            //_department.InserDepartment(department);
            //_department.GetDepartment(1);

            //3、用一下简单工厂（DataAccess类相当于一个简单工厂类）
            //var dept = DataAccess.GetDepartment(DbType.SqlServer);
            //dept.GetDepartment(1);
            //var u = DataAccess.GetUser(DbType.Access);
            //u.GetUser(1);

            //4、改造简单工厂使其根据配置文件选择数据库，并用反射技术来实例化数据库操作对象，不需要客户端来选择
            // 修改过后再客户端完全不需要关注用哪个数据操作，实现了完全的隔离，我们通过修改配置文件，实现了不需要修改代码，不需要重新编译就能实现数据库的切换
            var dept = DataAccess.GetDepartment();
            dept.InserDepartment(department);
            dept.GetDepartment(1);
            Console.WriteLine("=====*********======");
            var u = DataAccess.GetUser();
            u.InserUser(user);
            u.GetUser(1);

            Console.ReadKey();
        }
    }
}
