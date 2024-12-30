using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_1
{
    internal class Car
    {
        //과제1번
        public enum CarName
        {
            Bmw, Bus, F1
        }

        public enum CarNumber
        {
            one, two, three
        }
        int hp=500;
      


        public int CarHp
        {
            get
            {
                return hp;
            }
            set
            {
                hp = value;
            }

        }

    }
}
