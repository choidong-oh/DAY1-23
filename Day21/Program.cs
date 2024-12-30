using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21
{
    internal class Program
    {
        //상속안됌
        sealed class DontTouch
        {
            public string messageToOther = "위태로운 클래스니 건들지 말것";
        }



        static void Main(string[] args)
        {
            ////확정 메서드
            ////이미 만들어 진 클래스를 건드리지 않으면서 기능 추가하는 방법
            ////console, math,애초에 정적으로 만들어진 클래스는 확장메서드 못씀
            //Random rnd = new Random();
            //int tempNum = rnd.Next(1, 7);//1~6
            //Console.WriteLine($"주사위 굴려서 {tempNum}이 나왔습니다");

            //rnd.NextInclueEndNum(1, 6);//1~6

            //DontTouch dontTouch = new DontTouch();
            //dontTouch.messageToOther();

            //List<int> Intlist = new List<int>();

            //for(int i = 0; i < 5; i++)
            //{
            //    Intlist.Add(i);
            //}

            //Intlist.PrintAllMembers();

            ///////////////////////////////////////////////////////////////////////////


            //GIT

            //셔플 알고리즘 Fisher Yates, 피셔 예이츠
            //맨 뒤에서부터 역순으로, 앞에 인덱스 뽑아다가 랜덤으로 뽑아다가 섞는 알고리즘

            //int[] number = { 1, 2, 3, 4, 5,6,7,8,9,10,11,12 };

            //foreach(var ele in number)
            //{
            //    Console.Write(ele + " ");
            //}

            //Console.WriteLine("=================================================");

            //Aigorithm.FisherYatesShuffle(number);

            //foreach (var ele in number)
            //{
            //    Console.Write(ele + " ");
            //}

            //////////////////////////////////////////////////////////////////
            
            Stopwatch wath = new Stopwatch();
            int[] ints = new int[100];
            for(int i = 0; i < ints.Length; i++)
            {
                ints[i] = Aigorithm.random.Next();
            }

            wath.Start();
            Aigorithm aigorithm = new Aigorithm();
            //aigorithm.BubbleSort(ints);
            aigorithm.SelectionSort(ints);
            Console.WriteLine(wath.ElapsedMilliseconds);

            wath.Stop();

            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }




        }

       



        


        class Aigorithm
        {
            public static Random random = new Random();
            //피셔 예이츠
            public static void FisherYatesShuffle(int[] intArr)
            {
                for (int i = intArr.Length - 1; i >0 ; i--)
                {
                    int j = random.Next(0, i+1);

                    int temp = intArr[i];
                    intArr[i] = intArr[j];
                    intArr[j] = temp;   
                }



            }


            //버블정렬
            public void BubbleSort(int[] array)
            {
                //버블정렬
                //1. 배열을 쭉 반복하면서 인접한 두 값을 비교한다
                //2. 두 값이 크기 순서에 맞지 않으면 위치를 교환(swap)한다
                //3. 배열 끝까지 비교 마치고, 위 과정을 반복

                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j] > array[j])
                        {
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }


                    }



                }





            }


            //선택정렬
            //매 단계마다 배열에서 가장 작은거 찾아서 배열 맨앞에 가져다 두는 식
            //비교 횟수는 많은데, 버블보다 좀 남
            public void SelectionSort(int[] array)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    int minIdex = i;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] < array[minIdex])
                        {
                            minIdex = j;//인덱서 스왑
                        }
                    }

                    //최소값을 현재 위치 교환
                    int temp = array[i];
                    array[i] = array[minIdex];
                    array[minIdex] = temp;
                }


            }




        }




    }
}
