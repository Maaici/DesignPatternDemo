using System.Reflection;
using System.Configuration;

namespace AbstractFactory
{
    public static class DataAccess
    {
        //1、简单工厂：
        //public static IUser GetUser(DbType dbType) {
        //    IUser user = null;
        //    switch (dbType)
        //    {
        //        case DbType.SqlServer:
        //            user = new SqlServerUser();
        //            break;
        //        case DbType.Access:
        //            user = new AccessUser();
        //            break;
        //        default:
        //            throw new Exception("DbType Error!");
        //            //break;
        //    }
        //    return user;
        //}

        //public static IDepartment GetDepartment(DbType dbType)
        //{
        //    IDepartment department = null;
        //    switch (dbType)
        //    {
        //        case DbType.SqlServer:
        //            department = new SqlServerDepartment();
        //            break;
        //        case DbType.Access:
        //            department = new AccessDepartment();
        //            break;
        //        default:
        //            throw new Exception("DbType Error!");
        //            //break;
        //    }
        //    return department;
        //}

        //2、使用配置文件个反射技术
        //读取配置文件中的程序集名称和类的名称（必须是完整的名字）
        private static string DbName = ConfigurationManager.AppSettings.Get("DbName");
        public static IUser GetUser()
        {
            string className = $"AbstractFactory.{DbName}User";
            IUser user = (IUser) Assembly.Load("AbstractFactory").CreateInstance(className);
            return user;
        }

        public static IDepartment GetDepartment()
        {
            string className = $"AbstractFactory.{DbName}Department";
            IDepartment department = (IDepartment)Assembly.Load("AbstractFactory").CreateInstance(className);
            return department;
        }

    }

    public enum DbType {
        SqlServer = 1,
        Access = 2
    }
}
