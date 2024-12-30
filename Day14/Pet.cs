using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14
{
    
    /*속성
    이름 : 문자열
    등급 : [Rare, Epic, Legendary] 세가지중 하나만 가질 수 있음
    레벨 : 1~30의 정수
    속성 : [speed, critical, specialize] 세가지중 하나만 가질 수 있음
    스킬 : [manaRestore, healthRestore, attSpeedUp, none]

    메소드 or 프로퍼티
    - 펫 이름은 열람도, 수정도 가능
    - 펫 등급을 보여주는 기능 보유. 희귀면 파랑색으로 Rare 출력, 에픽은 보라로 Epic, 
	전설은 노랑글씨로 Legendary 출력하는 기능
    - 레벨은 열람만 가능, 레벨을 1 올린다는 메소드가 하나 존재. 30 넘어가면 30 고정
    - 속성을 열람 및 설정 가능함. 단, 속성에 부여 가능한 세가지중 하나로만 가능
    - 랜덤 스킬 부여 라는 메소드 보유. 펫 등급이 legendary가 아니면 none이 자동 부여,
	전설이면 none을 제외한 스킬 중 랜덤하게 하나가 배정됨
    - 스킬을 보여주는 메서드도 있음

     */




    enum Tier
    {
        Rare, Epic, Legendary
    }


    class Pet
    {
        public enum PetType
        {
            Speed, Critical, Specialize
        }

        enum PetSkill
        {
            ManaRestore, HealthRestore, AttSpeedUp, None
        }


        string name  = "dd";
        Tier petTier;
        PetType petType;
        int lvl;
        PetSkill petSkill;
        Random rd = new Random();
        //(매개변수) 메소드

        public string PetName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public void PrintTierWithColor()
        {
            switch (petTier)
            {
                case Tier.Rare:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    //Console.WriteLine("Rare");
                    break;
                case Tier.Epic:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    //Console.WriteLine("Epic");
                    break;
                case Tier.Legendary:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                   // Console.WriteLine("Legendary");
                    break;
            }
            Console.WriteLine(petTier);
            Console.ResetColor();
        }
        

        //열람만
        public int PetLvl
        {
            get
            {
                return lvl;
            }

        }

        public void IncreasePetLvl()
        {
            if (lvl < 30)
            {
                lvl++;
            }

        }

        public PetType MypetType
        {
            get;set;

        }

        public void AddSkill()
        {
            rd =new Random();
            int randomNum = rd.Next(0,3);
            if(petTier != Tier.Legendary)
            {
                petSkill = PetSkill.None;
            }
            else
            {
                petSkill = (PetSkill)randomNum;
            }

        }



        //public int petLevel()
        //{
        //    lvl++;
        //    if(lvl >= 30)
        //    {
        //        lvl = 30;
        //    }
        //    return lvl;
        //}


        // public void ValueColor(string Value)
        //{
        //    if(Value == "Rare")
        //    {
        //        Console.ForegroundColor = ConsoleColor.Blue;
        //        Console.WriteLine("Rare");
        //        Console.ResetColor();
        //    }
        //    else if(Value =="Epic")
        //    {
        //        Console.ForegroundColor = ConsoleColor.Magenta;
        //        Console.WriteLine("Epic");
        //        Console.ResetColor();
        //    }
        //    else if(Value =="Legendary")
        //    {
        //        Console.ForegroundColor = ConsoleColor.Yellow;
        //        Console.WriteLine("Legendary");
        //        Console.ResetColor();
        //    }

        //}










    }





}
