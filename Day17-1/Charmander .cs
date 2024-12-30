using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17_1
{
    internal class Charmander : Monster
    {
        public override void BaseAttack()
        {
            Console.WriteLine("화염방사");
        }

        public Charmander(MobType mobType, string name, int level) : base(mobType, level, name)
        {
            this.MonsterMobType = mobType;
            this.MonsterName = name;
            this.MonsterLevel = level;
        }


    }
}
