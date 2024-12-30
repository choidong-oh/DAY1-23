using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_1
{
    struct Vector2
    {
        int x;
        int y;
    }
    internal class Monster
    {
        int MonsterPower;
        int MonsterHp;

        public int MonsterPowerPro
        {
            get
            {
                return MonsterPower;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                    Console.WriteLine("음수로 세팅 할 수없다고");
                }
                MonsterPower = value;
            }

        }

        public int MonsterHpPro
        {
            get
            {
                return MonsterHp;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                    Console.WriteLine("음수로 세팅 할 수없다고");
                }
                MonsterHp = value;
            }
        }

        public void AttackCar(Car car)
        {
            car.CarHp = car.CarHp - MonsterPower;
            Console.WriteLine("{0}만큼의 데미지를 {1}에 주었습니다", MonsterPower, car.CarName);

        }


        

        //기존에 있던 함수를 변수만 바꿔서 만듦
        public void AttackPlayer(Player player)
        {
            MonsterHpPro = MonsterHpPro - player.PlayerPowerPro;
            Console.WriteLine("몬스터에게 {0}만큼의 데미지를 줘서 몬스터의 hp가 {1}되었씁니다", player.PlayerPowerPro, MonsterHpPro);

        }




    }

}
