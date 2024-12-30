using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day20
{
    class mCharacter
    {
        public mWeapon wpn;
        public string Name { get; set; }
        public mCharacter(string wpnName)
        {
            this.Name = wpnName;
        }

        public mCharacter()
        {
            this.Name = wpn.Name;
        }
    }
    class mWeapon
    {
        public string Name = null;
    }


  
    internal class Program
    {
        static void Main(string[] args)
        {
            //LinkedList 링크/연결
            //List
            //길이가 자유롭다
            //데이터가 연속적으로 보관되어 있기에 인덱스로 접근이 가능
            //필요할 경우 앞에서부터 빠르게 뒤까지 검색 가능

            //단점 : 
            //중간 삽입삭제가 느림

            //LinkedList
            //데이터와 데이터가 연속으로 연결되어 있지 않고, 데이터는 각 다음 혹은
            //이전 데이터가 어디있는지 주소를 들고 있는 방식
            //중간 삽입 삭제가 빠름
            //특정 요소를 검색할 떄 느림
            //애니팡처럼 중간에 겁나 삭제 되는 그런것들에 유리
            //NPC 이동 경로와 같이 수시로 담을 내용이 바뀔 수 있는 그런거

            //LinkedList<int> list = new LinkedList<int>();
            //LinkedList2<int> list2 = new LinkedList2<int>();

            //list2.AddLast(123);
            //list2.AddLast(456);
            //list2.AddLast(789);

            ////모든 노드 출력
            //Node<int> current = list2.Head;

            //while (current !=null)
            //{
            //    Console.WriteLine(current.Value);
            //    current = current.Next;
            //}


            //Node<int> foundNode = list2.Find(123);
            //Console.WriteLine(foundNode.Value);
            /////////////////////////////////////////
            //nullable , 널이 가능한
            //여전히 값 타입
            //int? a = null;//널도 담을 수 있는// 널러블 인트가 되었음
            //bool? b = null;

            //if (a.HasValue)
            //{
            //    Console.WriteLine("값은"+a.Value + "입니다");
            //}
            //else
            //{
            //    Console.WriteLine("값이 없습니다");
            //} 
            /////////////////////////////////////////////////////
            //삼항 연산자
            //int toExamaine = 10;
            //bool isBiggerThanFive;
            //if(toExamaine > 5)
            //{
            //    isBiggerThanFive = true;
            //}
            //else
            //{
            //    isBiggerThanFive = false;
            //}

            //isBiggerThanFive = (toExamaine>5) ? true : false;
            //////////////////////////////////////////////////////
            //?연산자
            //null들어갈수있는거?하고싶은거 //null이면 사라짐,null이 아니면 하고싶은거함
            //mCharacter newCar = new mCharacter { Name = "이름" };//이니셜라이저 사용
            //Console.WriteLine(newCar?.Name);
            //Console.WriteLine(newCar?.wpn?.Name);

            //////////////////////////////////////////////////////////
            ///??연산자
            ///??기준 좌측에 있는 형식이 만약 null이라면 ??의 우측에 있는 내용,
            /////null이 아니었다면 ?? 기준 좌측에 있는 기능 사용

            //List<mCharacter> myTroop = new List<mCharacter>();

            //myTroop.Add(new mCharacter());
            //myTroop.Add(new mCharacter("창"));
            //myTroop.Add(new mCharacter());
            //myTroop.Add(new mCharacter("방패"));

            //foreach (var myUnit in myTroop)
            //{
            //    Console.WriteLine(myUnit.wpn.Name ?? "무기가 없습니다");

            //}

            /////////////////////////////////////////////////////////
            //Node
            //LinkedList
            //중간 삽입 삭제 빈번한, 퍼즐

            //단방향 연결 리스트
            //Node
            //값과
            //다음 주소
            //AddLast
            //AddFirst
            //Remove
            //Find

            ////널러블
            //int? a = null;//0과 null은 다르다

            ////??연산자
            //Console.WriteLine(a?.ToString()?? "무기가 지정되지 않았습니다");

            //형변환
            //Pig pig = new Pig();
            //((Animal)pig).Name = "dd";//같음
            //(pig as Animal).Name = "dd";//같음
            ////virtual 선행 => override 후행

           



        }

        class Animal
        {
            public string Name { get; set; }
            public virtual void printname()
            {

            }
        }

        class Pig : Animal
        {
            public void EatAlot()
            {
                Console.WriteLine("폭식 수행");
            }
            public override void printname()
            {

            }

        }




    }
}
