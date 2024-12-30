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
        public int x;
        public int y;
    }
    internal class Monster
    {
        public int Power;
        int Hp = 50;
        Vector2 vector2 = new Vector2();
        public int Powerproperty
        {
            get
            {
                return Power;
            }
            set
            {
                //공격력, HP에 음수를 세팅할 경우
                if(value < 0)
                {
                    Console.WriteLine("음수로 세팅 할 수 없다고 출력");
                    value = 0;
                }
                Power = value;
            }
        }

        public int Hpproperty
        {
            get
            {
                return Hp;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("음수로 세팅 할 수 없다고 출력");
                    value = 0;
                }
                Power = value;
            }
        }

        public void AttackCar(Car car)
        {
            //Monster monster = new Monster();
            //monster.Powerproperty = 5;
            car.CarHp -= Powerproperty;


        }


    }

}
