using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day15_1
{
    internal class Monster
    {
        public string MonsterName;
        public int MonsterHp;
        public int MonsterPower;
        public int MonsterDefensive;
        public int MonsterLevel;

        public Monster(string name = "Basic Monster", int hp = 50, int power = 15, int defensive = 5, int level = 1)
        {
            MonsterName = name;
            MonsterHp = hp;
            MonsterPower = power;
            MonsterDefensive = defensive;
            MonsterLevel = level;
        }

        public Monster()
        {
            MonsterName = "Basic Monster";
            MonsterHp = 50;
            MonsterPower = 15;
            MonsterDefensive = 5;
            MonsterLevel = 1;

        }

        public void TakeDamage(int herodamage)
        {
            MonsterHp = MonsterHp + MonsterDefensive - herodamage;
        }

        public void AttackHero(Hero hero)
        {
            TakeDamage(hero.HeroPower);

        }
        public void DisplayInfo()
        {
            Console.WriteLine("몬스터의 이름 : " + MonsterName);
            Console.WriteLine("몬스터의 체력 : " + MonsterHp);
            Console.WriteLine("몬스터의 공격력 : " + MonsterPower);
            Console.WriteLine("몬스터의 방어력 : " + MonsterDefensive);
            Console.WriteLine("몬스터의 레벨 : " + MonsterLevel);
        }







    }
}
