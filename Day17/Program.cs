using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day17
{
    abstract class Character //불완전한 클래스
    {
        protected string _name;
        protected decimal _shilling; //정확한 숫자 필요할 때
        protected uint _storyProgress; //0 ~ 양수 담을때 쓰는 int

        public void ShowMoney()
        {
            Console.WriteLine($"잔액 {_shilling}");
        }

        public abstract void BaseAttack();//추상함수
        

    }

    class Mage : Character
    {
        string _staffType = "기본 스태프";
        public override void BaseAttack()
        {
            Console.WriteLine(_staffType + "마법 공격");
        }

        public void Teleport()
        {
            Console.WriteLine("순간이동");
        }
    }

    class Hunter : Character
    {
        string _gunType = "기본 총";

        public override void BaseAttack()
        {
            Console.WriteLine(_gunType + "총알 공격");
        }
        
        public void Roll()
        {
            Console.WriteLine("구른다");
        }

    }
    
    class Milk
    {
        public string _ExpireDate;

        public Milk(string ExpireDate)
        {
            _ExpireDate = ExpireDate;
        }
        public Milk()
        {
            
        }
    }


    class Coffee
    {
        public string CoffeeType;

    }
    class Water
    {
        public string WaterName;

    }

    class PaperClip
    {
        public string Material;
    }

    //T에 Milk 치환
    //where 옆에만 쓸수 있음 
    class Cup<T,U> 
        where T : Milk, new()//인자값을 요구하지 않는 생성자가 있는 클래스만 들어올 수있게끔 제약
        where U : struct
      //where Z : class ->> string 해당
    {
        T _contents = new T();
        U _fillAmount;

        public T GetContents()
        {
            return _contents;
        }

        public void SetFillAmount(U amount)
        {
            _fillAmount = amount;   
        }


    }

   

    //제네릭 : 하나의 클래스가 다양한 형태의 자료형을 처리할 수 있게 됨




    internal class Program
    {
        //오버라이드 : 상속관계에서 부모클래스의 메서드를 자식클래스에서 재정의 해서 사용
        //혹은 덮어씌우고 본인만의 기능을 새로 만드는 것을 보고 오버라이딩이라고 부름


        class Car
        {
            protected float _maxSpeed;
            protected string _brand;

            public virtual void Drive()//virtual
            {
                Console.WriteLine("주행");
            }
        }

        class Sedan : Car
        {
            public void Drive()
            {
                Console.WriteLine("승용차 주행");
            }

            public void SedanAction()
            {
                Console.WriteLine("동승자 태우기");
            }
        }

        class Truck : Car
        {
            public sealed override void Drive()//override
            {
                Console.WriteLine("오프로드 주행");
            }

            public void TruckAction()
            {
                Console.WriteLine("짐싣기");
            }
        }

        class Bulldoser : Car
        {
            //필요에 따라 파생클래스에서 재정의 하는것을보고, override라고 표현
            public void Drive()
            {
                Console.WriteLine("저속 주행");
            }
            public void BulldoserAction()
            {
                Console.WriteLine("평탄화작업");
            }
        }

        class TwoDonBan : Truck
        {
            //new float _maxSpeed;//필드 하이딩
            ////하이딩
            //public override void Drive()
            //{
            //    float _maxSpeed = 50;
            //    Console.WriteLine("두돈반 주행");
            //}
        }

        static void Main(string[] args)
        {
            //다형성
            //객체지향 프로그래밍에서 필요에 따라 형태를 바꿀 수있는 것을 보고 다형성 이라함
            //'다양하게 형을 바꾼다'
            //Car car = new Sedan(); //세단형 객체를 만들고, Car형에 담은 모습
            //Car bull = new Bulldoser(); 
            //Car truck = new Truck();

            //Car[] garage = new Car[3];
            //garage[0] = car;
            //garage[1] = bull;
            //garage[2] = truck;

            //오버라이드 알아볼거임
            //Car bull = new Bulldoser();   
            //Car truck = new Truck();

            //TwoDonBan tdd = new TwoDonBan();    
            //tdd.Drive();
            ////bull.Drive();
            ////truck.Drive();


            //추상클래스 (abstract class)
            //세부적인 구현은 자식에서 구현하도록 위임하고, 본인은
            //최소한의 기능만을 가지는 클래스

            //Character[] part = { new Mage(), new Hunter() };

            //Character wizard =new Mage();
            ////is 옆에 있는 타입인지 참거짓
            ////as 옆에 형으로 변환. 바꾸어 보고 성공시 변환, 실패시 null
            ////? 키워드 
            //if (wizard is Mage)//옆에 형으로 만들어진 애라면
            //{
            //    Console.WriteLine("메이지 입니다");
            //    ((Mage)wizard).Teleport();//메이지형으로 강제 형변환
            //    (wizard as Mage).Teleport();//as키워드로 변환은 시도해보고 실패하면 null
            //}

            //? 키워드 : null이 가능한 형태에 ?를 붙이면, 만약 null일 경우 모든 코드 뛰어넘음
            //null 조건부 연산자
            // (wizard as Mage)?.Teleport(); 
            //null이 아니면 함수실행, null이면 안함

            //제네릭 : 하나의 클래스가 다양한 형태의 자료형을 처리할 수 있게 됨
            //where 제약 걸때 씀
            //Cup<Milk,int> milkup = new Cup<Milk,int>();
            //Console.WriteLine(milkup.GetContents());

            //****************????? 면접
            //박싱, 언박싱
            //박싱 -> 포장하다, 박스에 집어넣는다
            //언박싱 -> 박스를 열다

            //int myInt = 23;
            //Random rd = new Random();
            //float myFloat = 23.456f;

            //object obFloat = myFloat;
            //object obInt = myInt;//힙 공간에 데이터 기억 할수 있는 공간생김, 거기에 우항을 복사해서 기억
            //object obRb = rd; //값타입을 포장해서 힙 공간으로 보내버리는 걸 보고 박싱
            ////박싱은 렉걸림
            ////박싱된걸 꺼내 쓸때는 형변환 해주어야함, 잘못 바꾸면 위험함
            ////박싱된거 꺼내 보는걸 언박싱
            //Console.WriteLine(obInt);

            //object형으로 다양한 형을 다루면 성능 저하
            //수많은 다양한 형을 다루기 위해서는 더 안전한 제네릭을 사용
            //제네릭은 들어오는 타입에 제약도 걸 수 있고, 안정성도 보장







        }

    }
}
