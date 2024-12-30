using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day17_1
{
    public enum MobType
    {
        Normal, Fire, Water, Grass, electricity
    }
    internal class Trainer
    {
        public int havebadge;
        public string TrainerName;
        public string StartingName;
        public Monster[] TotalMonster ;

        int arrsize = 1;

        
        public Trainer(string trainername, string monstername)
        {
            this.TrainerName = trainername; 
            this.StartingName = monstername;
            TotalMonster = new Monster[6];
        }

        public Trainer(Pikachu pikachu)
        {
            TotalMonster = new Monster[6];

            TotalMonster[0] = pikachu;
        }

        
        //객체를 받아온다??
        //다형성 예시)인자값에 피카츄 넣으면 필요한 6개를 선언해야함
        public void AddMonster(Monster monster)
        {
            Console.WriteLine(arrsize);
            if (arrsize >= 6)
            {
                Console.WriteLine("경 고 : arrsize 6됌");
            }
            else if (arrsize < 6)
            {
                TotalMonster[arrsize] = monster;
                arrsize++;
            }

        }

        public void AllAttack()
        {
            for (int i = 0; i < TotalMonster.Length; i++)
            {
                //int[] a = null;
                //a?.ToString();

                TotalMonster[i]?.BaseAttack();
            }


        }
       



        public void ShowFirstMob()
        {
            for(int i = 0; i < TotalMonster.Length; i++)
            {
                Console.WriteLine($"TotalMonster[{i}].MonsterLevel : "+TotalMonster[i]?.MonsterLevel);
                Console.WriteLine($"TotalMonster[{i}].MonsterName " + TotalMonster[i]?.MonsterName);
            }
           
        }

        public string ChangeMonster(string changemonster)
        {
            this.StartingName = changemonster;

            return StartingName;
        }

        




    }
}
