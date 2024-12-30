using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Day14
{
    internal class Program
    {
        //객체지향 입문, 자동차를 생각해보면...
        //구성요소 : 자동차, 바퀴, 엔진, 기어, 브레이크, 핸들, 나사
        //구성기능 : 전진, 후진, 좌회전, 우회전, 워셔액 분사

        //프로그램에 필요한 요소와 기능들만 추려서 담는 것을 보고 "추상화"라고 한다
        //"요소" + "기능" 만들어진 자료형이 바로 "클래스" 이다
        //위 자료형 클래스로 만들어진 실체화 결과물이 "객체" 이다


        //struct와 class 차이는 간다하게, 값타입이나 참조타입이냐
        //struct는 크기는 작고 간단한 객체를 정의할 때 사용. 클래스는 복잡

        //값타입과 참조타입
        //메모리 구조
        //가비지 콜렉터
        //접근 지정자 public

        //클래스 : 설계도
        //객체 : 클래스 설계도를 바탕으로 나온 실체

        //클래스와 구조체 차이?
        //1. 참조,  값차이
        //2. 클래스는 좀 크고 복잡하거나 현실 물체를 객체로 표현할때
        //   구조체는 가볍고 적은 데이터 (값타입이라 크면 스택 터짐)

        //stack, heap 스택 힙
        //stack : 값타임, 매개변수, 지역변수
        //heap : 참조타입, 배열, 클래스로 만들어진 객체 

        //가비지콜렉터 : 쓰레기, 더이상 참조되지 않는 힙의 메모리 공간
        //메소드 : 클래스 내부에서 사용하는 함수, 객체가 쓸 기능들
        //필드 : 클래스 내부 각종 요소들, 객체가 쓸 요소들
        //프로퍼티 : 클래스 요소들을 안전하게 다루기 위해 제공되는 문법
        //정보은닉 : 외부에 공개될 필요 없는 맴버변수를 숨긴다

        static void Main(string[] args)
        {
            //Car myCar;

            ////값타입
            //int myNum;
            //myNum = 4;

            ////참조타입
            //int[] intArr;
            //intArr = new int[10];//배열 참조형
            //myCar = new Car();//클래스는 참조형

            //Stack
            //스택, 매겨변수, 지역변수

            //Heap
            //큰 객체가 여기 잡힘
            //배열도 여기
            //"동적 할당"

            //Data, Code영역
            // 프로그램에 실행되는 코드는 Code영역 . 끝
            // 전역변수나 Static등, 프로그램이 실행되는 동안 유지되는 메모리 공간




            ////배열, class 비슷함 , 참조형> new할당해야댐
            //int[] arr = new int[2];
            //arr[1] = 5;


            //Car myCar; //주소를 담을수 있는 빈 변수 선언
            //myCar = new Car();
            //myCar._posX = 10;
            


            //Car myCar = new Car();//자동차 new할당 했음
            //myCar._posX = 14;//x에 14 넣었음

            ////가비지 콜렉터가 안쓰는 메모리 회수해감
            //myCar = new Car();  //자동차 new할당 또 했음
            //Console.WriteLine(myCar._posX);// 값 = 0


            //Car myCar = new Car();//자동차 new할당 했음
            //myCar._posX = 14;//x에 14 넣었음

            //Car myCar2;//둘째 자동차 생성
            //myCar2 = myCar;//참조형은 그냥 주소를 복사한다
            //Console.WriteLine(myCar2._posX);//이번엔 뭐가 나올까요?

            //가비지 콜렉터는 쓰지 않는 힙의 메모를 회수한다
            //많이돌면 렉 걸린다
            //MoveForWard(myCar, 2);

            //myCar.MoveForWard(10);//자동차 10칸 만큼 전진
            ////MoveForWard(자동차명, 인자값) //자동차를 들고와서 거기 속 x를 찾아 10을 전진
            //myCar.GetCarNum();
            ////private여도 함수로 반환하면 보임
            //Console.WriteLine("마이카 넘버 : "+ myCar.GetCarNum());
            //myCar.SetCarNum(10);
            //Console.WriteLine(myCar.GetCarNum());

            //Car123 mycar = new Car123();
            //mycar.posX = 1990;
            //Console.WriteLine(mycar.posX);

            //mycar.MyName = "sad";
            //Console.WriteLine(mycar.MyName);

            Pet mypet;
            mypet = new Pet();
            Car123 car;
            car = new Car123();

            car.posX
            
            








        }

        ////주소
        //static void MoveForWard(Car car, int toMove)
        //{
        //    car._posX += toMove;

        //}



    }
}
