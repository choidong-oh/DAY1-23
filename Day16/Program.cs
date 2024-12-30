using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16
{
    class Reward
    {
        int _gold;

        public int gold
        {
            get { return _gold; }
            set { _gold = value; }
        }


    }

    class Enemy
    {
        //public static Reward rwd = new Reward(); //정적필드...긴 한데 참조가 곁들인
        static Reward rwd;//정적 필드
        static public Reward Rwd//정적 프로퍼티
        {
            get 
            {
                if(rwd == null)
                {
                    rwd = new Reward();
                }


                return rwd;
            }
            set { rwd = value; }
        }

        static int _createCount;//정적필드
        int _health;
        public static int CreateCount
        {
            get { return _createCount; }
            set { _createCount = value; }   

        }

        public int _id; 
        public int UniqeID
        {
            get { return _id; }
            set { _id = value; }
        }

        public Enemy()
        {
            //_createCount++;
            //UniqeID = _createCount;

            if (rwd == null)
            {
                rwd = new Reward();
            }

        }

        public void IncreaseCraeateCount()
        {
            _createCount++;
        }

        public void ShowCreateCount()
        {
            Console.WriteLine(_createCount);
        }
    }

    class StaticFunc
    {
        int nonStaticNum = 5; //비정적, 일반적인 필드
        static int staticNum = 10; //정적 필드

        public static void PrintNum()//정적 메소드 만들었음
        {
            //이건왜댐??? static지우면
            //Console.WriteLine("비정적 인트값 : " + nonStaticNum);
            Console.WriteLine("정적 인트값 : " + staticNum);
        }
        public  void PrintNormalNum()//일반 메서드
        {
            Console.WriteLine("비정적 인트값 : " + nonStaticNum);
            
        }


        public static void IncreaseAndPrintStaticNum()//정적 메서드는 정적 메서드만 부름
        {
            //정적 메서드 내에서 "지역변수"들은 static일 필요없음
            int a = 10;//지역변수
            staticNum++;
            PrintNum();

        }


    }

    struct intAlike
    {
        public static void ParseAlike()
        {
            Console.WriteLine("int.parse랑 비슷하게 적었음");
        }
    }

    //정적 필드
    //정적 프로퍼티
    //정적 메소드
    //정적 클래스


    //static class는 static만가능
    static class MyMath
    {

        //int b;//static아니어서 안됌
        static int a;
        public const float PI = 3.1415926535f;

        public static int DoubleTheNumber(int _toDouble)
        {
            return _toDouble*2;
        }

        //정적 클래스의 정적 생성자
        //public 쓰지말래
        static MyMath()//정적 생성자
        {
            Console.WriteLine("나 생성");
        }

        public static void DoSome()//정적 메서드
        {
            Console.WriteLine("뭐라도 해");
        }


    }





    internal class Program
    {

        static void Main(string[] args)
        {
            ////스택(집), 힙(주소) ??????????????
            ////int는 동적할당인가???? 값?
            ////클래스, 배열 = 동적할당
            //Random rnd = new Random();
            //int[] dd = new int[4];  //동적할당

            ////정적 : 항시 상주하고, 변하지 않는 공간을 사용하는
            ////지워지지 않는 곳에 위치하는 것

            //Enemy enemy1 = new Enemy();
            //Enemy enemy2 = new Enemy();
            //Enemy enemy3 = new Enemy();

            //enemy1.ShowCreateCount();
            //enemy2.ShowCreateCount();
            //enemy3.ShowCreateCount();

            //enemy2.IncreaseCraeateCount();

            //enemy1.ShowCreateCount();
            //enemy2.ShowCreateCount();
            //enemy3.ShowCreateCount();


            //static은 힙과 스택이 아닌 static들만의 공간이 따로 있음
            //data영역, (힙 영역, 스택 영역, 데이터 영역, 코드 영역)
            //Console.WriteLine(enemy1._createCount);
            // Console.WriteLine(Enemy._createCount);

            //Enemy behemoth = new Enemy();
            //Enemy.rwd.gold = 25000;

            //Console.WriteLine(Enemy.rwd.gold);

            //Enemy behemoth2 = new Enemy();
            //Console.WriteLine(Enemy.rwd.gold);

            //Enemy.Rwd.gold = 1000;
            //Console.WriteLine(Enemy.Rwd.gold);

            //StaticFunc temp = new StaticFunc();
            //StaticFunc.PrintNum();

            //intAlike.ParseAlike();
            //int.Parse("dd");

            //int myNum = 4;
            //int doubleNum = MyMath.DoubleTheNumber(myNum);

            //MyMath.DoSome();
            //MyMath.DoSome();
            //MyMath.DoSome();
            //MyMath.DoSome();
            //MyMath.DoSome();
            //MyMath.DoSome();






        }
    }
}
