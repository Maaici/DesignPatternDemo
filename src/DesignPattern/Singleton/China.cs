using System;

namespace Singleton
{
    public class China
    {
        //1、常规实现（懒汉式）
        private static China _china = null;//3、提供静态私有变量，用来存放类的实例
        private static readonly object locker = new object();  //静态只读的进程辅助对象，用于加锁
        private China()             //1、私有化构造函数
        {
            Console.WriteLine("出现了一个中国");
        }

        public static China GetInstence() //2、提供一个外部可以获取实例的静态方法
        {
            if (_china == null)     //双重锁定
            {
                lock (locker)       //加锁，同一时间只能有一个进程进入执行
                {
                    if (_china == null)
                    {
                        _china = new China();
                    }
                }
            }
            return _china;
        }

        //2、静态构造实现
        //private static China _china = null;

        //private China()             //私有化构造函数不能省，这样外部可以通过 new 来创建实例，产生多个实例
        //{
        //    Console.WriteLine("出现了一个中国");
        //}

        //static China() {
        //    _china = new China();
        //}

        //public static China GetInstence() //提供一个外部可以获取实例的静态方法
        //{
        //    return _china;
        //}

        //3、静态字段实现
        //private static China _china = new China(); //提供静态私有变量,并直接初始化该变量

        //private China()             //私有化构造函数不能省，这样外部可以通过 new 来创建实例，产生多个实例
        //{
        //    Console.WriteLine("出现了一个中国");
        //}

        //public static China GetInstence() //提供一个外部可以获取实例的静态方法
        //{
        //    return _china;
        //}
    }
}
