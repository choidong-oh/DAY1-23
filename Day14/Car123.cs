using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day14
{
    enum CarMake 
    {
        Audi, bmw, 
    }

    class Car123
    {
        //요소
        public int _posX; //맴버변수 or 필드
        public int _posY; //맴버변수 or 필드
        public float _maxSpeed; //맴버변수 or 필드
        private int _carNumber;

        //기능(이제부터 Method, 메소드라고 부를거임)
        public void MoveForWard(int posX)
        {
            _posX += posX;
            //혹은
            this._posX += posX;

        }

        //**자동구현 프로퍼티
        public string MyName
        {
            get; set;
        }



        //굳이 외부에 공개될 필요 없는 맴버변수를 private로 숨기고,
        //외부에서 직접 접근하지 못하도록 숨기고 메서드를 통해서만 조작하는 걸 "정보 은닉" 이라함

        // -객체 내부 테이터 변경을 실수로부터 지킬 수 있음
        // 위 _posX는 타인이 보기엔 차의 위치일수도, 혹은 주차장의 위치, 윈도우 크기x등 모른다


        //프로퍼티//속성
        //프로퍼티는 외부에 노출될 필요가 없는 맴버변수들을 정보은닉 시켜준다
        //또한 외부와 소통할 일이 있을떄, 직접 맴버변수와 소통하는 것이 아닌 일종의 필터도 가능
        public int posX
        {
            //입력전용 //부를때 cw // 반환값이있는거
            get
            {
                return _posX;
            }
            //읽기전용 //넣을때 a = 10; // 인자값이있는거// value가 들어옴
            set
            {
                if (value > 1920)//해상도
                {
                    _posX = 1920;
                }
                else
                {
                    _posX = value;
                }
            }

        }



        //public int GetCarNum()
        //{
        //    return _carNumber;
        //} 

        ////외부에서 넘겨준 인자값으로 카넘버 세팅
        //public void SetCarNum(int carNumber)
        //{
        //    if(carNumber < 0)
        //    {
        //        _carNumber = 0;
        //    }
        //    else
        //    {
        //        _carNumber = carNumber; 
        //    }

        //}


        
    }
}
