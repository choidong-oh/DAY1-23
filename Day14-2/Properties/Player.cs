using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Day14_1
{
    struct VectorPlayer
    {
        public short x;
        public short y;
    }
    internal class Player
    {
        public string PlayerName;
        int PlayerHp;
        int PlayerPower;
        Inventory inventory;
        //new 할당
        public void MakeInven()
        {
            inventory = new Inventory();
        }
        //프로퍼티
        public Inventory inven
        {
            get
            {
                return inventory;
            }
        }

        public int PlayerPowerPro
        {
            get
            {
                return PlayerPower;
            }
            set
            {
                PlayerPower = value;
            }


        }


        public int PlayerHpPro
        {
            get
            {
                return PlayerHp;
            }
            set
            {
                PlayerHp = value;
            }


        }



    }
}
