using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Day15_1
{
    internal class Game
    {
        Hero hero =new Hero("Archer",100,30,5);
        Monster monster = new Monster("Skeleton",50,20,5,1);

        public void Play()
        {
            int answer;
            Console.WriteLine("일단 게임시작");
            while (hero.HeroHP >= 0 || monster.MonsterHp >= 0)
            {

                Console.WriteLine("다음 행동으로 무엇을 하시겠습니까? (1 혹은 2 엔터)");
                Console.WriteLine("1. 영웅이 몬스터를 공격");
                Console.WriteLine("2. 몬스터가 영웅 공격");
                answer = int.Parse(Console.ReadLine());
                if(answer == 1)
                {
                    monster.AttackHero(hero);
                    hero.DisplayInfo();
                    monster.DisplayInfo();
                }
                else if(answer == 2)
                {
                    hero.AttackMob(monster);
                    hero.DisplayInfo();
                    monster.DisplayInfo();
                }
                while (true)
                {
                    if(answer == 1 || answer == 2)
                    {
                        break;
                    }
                    else if(answer != 1 && answer != 2)
                    {
                        Console.WriteLine("1,2 아닌 값 입력했음 다시 입력바람");
                    }
                }

                if(hero.HeroHP <= 0)
                {
                    Console.WriteLine("영웅다이");
                    break;
                }

                if(monster.MonsterHp <= 0)
                {
                    Console.WriteLine("몹 사망");
                    break;
                }


               




            }

        }
       



    }
}
