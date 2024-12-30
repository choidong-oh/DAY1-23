using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Day17_1
{
    
    abstract class Monster
    {
        public int MonsterLevel;
        public string MonsterName;
        public MobType MonsterMobType;

        public Monster()
        {
            this.MonsterMobType = MobType.Normal;
            this.MonsterName = "";
            this.MonsterLevel = 1;
        }
        public Monster(MobType mobType,int level,string name )
        {
            this.MonsterMobType = mobType;
            this.MonsterLevel = level;
            this.MonsterName = name;
        }
        



        public abstract void BaseAttack();
        





    }
}
