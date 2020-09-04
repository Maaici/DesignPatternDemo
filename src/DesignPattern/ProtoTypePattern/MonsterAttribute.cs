using System;

namespace ProtoTypePattern
{
    /// <summary>
    /// 小怪的属性
    /// </summary>
    public class MonsterAttribute :ICloneable
    {
        //生命值
        public int HealthValue { get; set; }
        //伤害值
        public int ForceValue { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
