using System;

namespace AbstractFactory
{
    public class SqlServerUser : IUser
    {
        public void InserUser(User user)
        {
            Console.WriteLine($"通过 SQL server 添加了一个名叫 {user.Name} 的用户。");
        }

        public void GetUser(int id)
        {
            Console.WriteLine("通过 SQL server 获取一个用户。");
        }
    }
}
