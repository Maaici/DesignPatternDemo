using System;

namespace AbstractFactory
{
    public class AccessUser : IUser
    {
        public void InserUser(User user)
        {
            Console.WriteLine($"通过 Access 添加了一个名叫 {user.Name} 的用户。");
        }

        public void GetUser(int id)
        {
            Console.WriteLine("通过 Access 获取一个用户。");
        }
    }
}
