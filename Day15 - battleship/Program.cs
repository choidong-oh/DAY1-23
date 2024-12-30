using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15___battleship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship();
            int[,] BattleshipSpace = new int[10,10];
            int answer1 = 0;//십의 자리
            int answer2 = 0;//일의 자리
            int answer3 = 0;
            int totalanswer = 0;

            //0대입
            for(int i = 0;i<10;i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    BattleshipSpace[i, j] = 0;
                }

            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(BattleshipSpace[i, j] + " ");
                }
                Console.WriteLine();
            }



            Console.WriteLine("첫 배 숫자 선택 바람 예) 35");
            totalanswer = int.Parse(Console.ReadLine());
            answer1 = totalanswer / 10;
            answer2 = totalanswer - answer1 * 10;
            Console.WriteLine("위로할시 1, 옆으로할시2");
            answer3 = int.Parse(Console.ReadLine());
            if (answer3 == 2)
            {
                BattleshipSpace[answer1, answer2] = 1;
                BattleshipSpace[answer1, answer2+1] = 1;

            }
            else if(answer3 == 1)
            {
                BattleshipSpace[answer1, answer2] = 1;
                BattleshipSpace[answer1-1, answer2] = 1;
            }
            Console.Clear();

            //맵
            ShipPrint(BattleshipSpace);




            Console.WriteLine("두번쨰 배 숫자 선택 바람 예) 8 5");
            totalanswer = int.Parse(Console.ReadLine());
            answer1 = totalanswer / 10;
            answer2 = totalanswer - answer1 * 10;
            Console.WriteLine("위로할시 1, 옆으로할시2");
            answer3 = int.Parse(Console.ReadLine());

            if (answer3 == 2)
            {
                BattleshipSpace[answer1, answer2] = 2;
                BattleshipSpace[answer1, answer2 + 1] = 2;
                BattleshipSpace[answer1, answer2 + 2] = 2;


            }
            else if (answer3 == 1)
            {
                BattleshipSpace[answer1, answer2] = 2;
                BattleshipSpace[answer1 - 1, answer2] = 2;
                BattleshipSpace[answer1 - 2, answer2] = 2;
            }

            Console.Clear();

            //맵
            ShipPrint(BattleshipSpace);



            Console.WriteLine("세번쨰 배 숫자 선택 바람 예) 8 5");
            totalanswer = int.Parse(Console.ReadLine());
            answer1 = totalanswer / 10;
            answer2 = totalanswer - answer1 * 10;
            Console.WriteLine("위로할시 1, 옆으로할시2");
            answer3 = int.Parse(Console.ReadLine());
            if (answer3 == 2)
            {
                BattleshipSpace[answer1, answer2] = 3;
                BattleshipSpace[answer1, answer2 + 1] = 3;
                BattleshipSpace[answer1, answer2 + 2] = 3;
                BattleshipSpace[answer1, answer2 + 3] = 3;


            }
            else if (answer3 == 1)
            {
                BattleshipSpace[answer1, answer2] = 3;
                BattleshipSpace[answer1 - 1, answer2] = 3;
                BattleshipSpace[answer1 - 2, answer2] = 3;
                BattleshipSpace[answer1 - 3, answer2] = 3;
            }

            Console.Clear();
            //맵
            ShipPrint(BattleshipSpace);

            //이제부터찾는다

            int FindTotalNum = 35;
            int FindNum1;//십의 자리
            int FindNum2;//일의 자리

            FindNum1 = FindTotalNum / 10;
            FindNum2 = FindTotalNum - FindNum1 * 10;


            if (BattleshipSpace[FindNum1, FindNum2] !=0)
            {
                BattleshipSpace[FindNum1, FindNum2] = 0;
                Console.WriteLine("피격당했음");
            }

            Console.Clear();
            //맵
            ShipPrint(BattleshipSpace);

            //for구문으로 1,2,3 있는지 확인
            //없는수 있으면 cw침몰









        }

        //맵
        static void ShipPrint(int[,] BattleshipSpace)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(BattleshipSpace[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        static void 







    }
}
