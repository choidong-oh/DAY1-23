using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17_1
{
    class Pikachu : Monster
    {
        public override void BaseAttack()
        {
            Console.WriteLine("전광석화");
        }
        public Pikachu(MobType mobType,string name,int level) : base(mobType , level, name)
        {
            this.MonsterMobType = mobType;
            this.MonsterName = name;
            this.MonsterLevel = level;
        }



    }
}
