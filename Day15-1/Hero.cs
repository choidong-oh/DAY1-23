using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day15_1
{
    internal class Hero
    {
        public string HeroName;
        public int HeroHP;
        public int HeroPower;
        public int HeroDefensive;

        public Hero(string Name = "Unknown Hero", int HP = 100, int Power = 20, int Defensive = 10)
        {
            HeroName = Name;
            HeroHP = HP;
            HeroPower = Power;
            HeroDefensive = Defensive;

        }
        public Hero()
        {
            HeroName = "Unknown Hero";
            HeroHP = 100;
            HeroPower = 20;
            HeroDefensive = 10;

        }

        public void TakeDamage(int monsterdamage)
        {
            HeroHP = HeroHP + HeroDefensive - monsterdamage;
        }

        public void AttackMob(Monster mob)
        {
            Console.WriteLine($"{mob.MonsterName} 공격");
            TakeDamage(mob.MonsterPower);

        }

        public void DisplayInfo()
        {
            Console.WriteLine("영웅의 이름 : " + HeroName);
            Console.WriteLine("영웅의 체력 : " + HeroHP);
            Console.WriteLine("영웅의 공격력 : " + HeroPower);
            Console.WriteLine("영웅의 방어력 : " + HeroDefensive);


        }




        }
}
