using System;

namespace AdapterPattern
{
    /// <summary>
    /// 实现IDbHepler接口，实现增删改查的具体操作方法
    /// </summary>
    public class SqlServerHelper : IDbHepler
    {
        public void Add<T>()
        {
            Console.WriteLine($" 使用 {this.GetType().Name} 添加了数据。 ");
        }

        public void Delete<T>()
        {
            Console.WriteLine($" 使用 {this.GetType().Name} 删除了数据。 ");
        }

        public void Update<T>()
        {
            Console.WriteLine($" 使用 {this.GetType().Name} 修改了数据。 ");
        }

        public void Query<T>()
        {
            Console.WriteLine($" 使用 {this.GetType().Name} 查询数据。 ");
        }
    }
}
