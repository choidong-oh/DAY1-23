using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21
{
    //확장메소드 만들기 위해선 정적클래스 필요
    //this 메소드
    static class Cdo  //static
    {
        public static int NextInclueEndNum(this Random rd, int startNum, int endNum)
        { 
            return rd.Next(startNum, endNum + 1);
        }

        public static void AddedFunc(this DontTouch dt)
        {
            Console.WriteLine("추가했음");

        }

        //List<T> 여기에 기능 추가해볼 것
        public static void PrintAllMembers<T>(this List<T> list) //PrintAllMembers<T>
        {
            foreach (T ele in list)
            {
                Console.Write(ele + "\t");
            }
            Console.WriteLine();
        }



    }
}
