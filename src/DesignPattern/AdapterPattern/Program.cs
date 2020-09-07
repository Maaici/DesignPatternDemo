using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            IDbHepler dbHepler = new SqlServerHelper();
            dbHepler.Add<Program>();
            dbHepler.Delete<Program>();
            dbHepler.Update<Program>();
            dbHepler.Query<Program>();

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            //IDbHepler dbHepler1 = new MySqlClassAdapter();
            MySqlClassAdapter dbHepler1 = new MySqlClassAdapter();
            dbHepler1.Add<Program>();
            dbHepler1.Delete<Program>();
            dbHepler1.Update<Program>();
            dbHepler1.Query<Program>();
            dbHepler1.TruncateTable();//使用 MySqlClassAdapter 类型来接收对象的实例 才能用着方法  用接口来接收是不行的

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            //IDbHepler dbHepler2 = new MySqlObjectAdapter(new MySqlHelper());
            IDbHepler dbHepler2 = new MySqlObjectAdapter();
            dbHepler2.Add<Program>();
            dbHepler2.Delete<Program>();
            dbHepler2.Update<Program>();
            dbHepler2.Query<Program>();
            //dbHepler2.TruncateTable(); //只能调用接口定义的方法，与类适配器的区别之一

            Console.ReadLine();
        }
    }
}
