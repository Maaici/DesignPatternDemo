using System;

namespace ProtoTypePattern
{
    /// <summary>
    /// 小怪对象     实现ICloneable 接口中就一个Clone方法
    /// </summary>
    public class Monster : ICloneable 
    {
        public Monster()
        {
            Console.WriteLine("我被实例化了。。。。。");
        }
        //编号
        public string MonsterType { get; set; }

        //***********这边将原先的两个字段合并到一个属性类种，产生一个引用类型的字段***************//
        public MonsterAttribute  MonsterAttribute { get; set; }
        //攻击
        public void GetMonsterAttribute()
        {
            Console.WriteLine($"编号：{MonsterType}，\t生命值：{MonsterAttribute.HealthValue} ，\t伤害值：{MonsterAttribute.ForceValue} ");
        }
        //实现接口方法，返回一个object对象
        public object Clone()
        {
            //内置的MemberwiseClone()方法，完成对象的拷贝
            return this.MemberwiseClone();
        }
    }
}
