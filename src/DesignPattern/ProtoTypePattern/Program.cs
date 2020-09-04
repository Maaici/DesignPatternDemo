using System;

namespace ProtoTypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Monster monster = new Monster() {
                MonsterType = "垃圾小怪", 
                MonsterAttribute = new MonsterAttribute { HealthValue = 100, ForceValue = 100 } 
            };

            Monster monster1 = (Monster)monster.Clone();
            monster1.MonsterType = "普通小怪";
            monster1.MonsterAttribute = new MonsterAttribute() { HealthValue = 200, ForceValue = 300 };

            Monster monster2 = (Monster)monster.Clone();
            monster2.MonsterType = "进阶怪物";
            monster2.MonsterAttribute.HealthValue = 500;
            monster2.MonsterAttribute.ForceValue = 600;

            monster.GetMonsterAttribute();
            monster1.GetMonsterAttribute();
            monster2.GetMonsterAttribute();

            Console.ReadLine();
        }
    }
}
