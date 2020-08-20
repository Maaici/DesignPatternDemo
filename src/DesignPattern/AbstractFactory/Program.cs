using AbstractFactory.Factories;
using AbstractFactory.t_department;
using AbstractFactory.t_user;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User { ID = 1, Name = "maaici" };
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
            IFactory factory = new AccessFactory();
            Department department = new Department { ID = 1, DeptName = "信息中心" };
            IDepartment _department = factory.CreateDepartment();
            _department.InserDepartment(department);
            _department.GetDepartment(1);

            Console.ReadKey();
        }
    }
}
