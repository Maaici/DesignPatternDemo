using System;

namespace AdapterPattern
{
    /// <summary>
    /// Mysql帮助类，他没有实现IDbHelper接口
    /// 假设我们也不太方便修改代码，让他实现接口，但是我们又要用这个类
    /// 同时又要尽量少的修改已有代码，则可以考虑使用适配器
    /// </summary>
    public class MySqlHelper 
    {
        public void AddData<T>()
        {
            Console.WriteLine($" 使用 {this.GetType().Name} 添加了数据。 ");
        }

        public void DeleteData<T>()
        {
            Console.WriteLine($" 使用 {this.GetType().Name} 删除了数据。 ");
        }
        public void UpdateData<T>()
        {
            Console.WriteLine($" 使用 {this.GetType().Name} 修改了数据。 ");
        }

        public void QueryData<T>()
        {
            Console.WriteLine($" 使用 {this.GetType().Name} 查询数据。 ");
        }

        public void TruncateTable() 
        {
            Console.WriteLine($" 使用 {this.GetType().Name} 删库跑路，这是 MySqlHelper 中特有的方法，IDbHelper中不包含这个方法。。。 ");
        }
    }
}
