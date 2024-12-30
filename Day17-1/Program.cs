using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //함수대입? 이 표현보다 다른??
            //abstract클래스의 함수 쓰는이유 : 상속받은 같은함수를 다르게 쓰고싶어서??
            //abstract의 함수 쓰는이유 : 무조건  abstract함수 써야댐// 협업?
            //클래스명 객체 = new 다른클래스(); //다형성
            //오버라이드 쓸려면 상속에 virtual 써야댐





            //Monster monster = new Monster(MobType.Fire,3,"유니콘");
            //Trainer trainer = new Trainer(monster);
            //trainer.ShowFirstMob();

            //Pikachu pikachu = new Pikachu(MobType.Fire,"피카츄",3);
            //Trainer trainer = new Trainer(pikachu);
            //pikachu.BaseAttack();
            //trainer.ShowFirstMob();

            Pikachu pikachu = new Pikachu(MobType.electricity, "피카츄", 3);
            Trainer trainer = new Trainer(pikachu);//0
            Charmander charmander = new Charmander(MobType.Fire, "파이리", 5);

            Bulbasaur bulbasaur = new Bulbasaur(MobType.Normal, "이상해 씨", 1);
            Squirtle squirtle = new Squirtle(MobType.Water, "꼬부기", 2);

            //객체를 받아 온다
            trainer.AddMonster(bulbasaur);//2
            trainer.AddMonster(squirtle);//3
            trainer.AddMonster(squirtle);//4
            trainer.AddMonster(squirtle);//5
            trainer.AddMonster(charmander);//6부터 추가 안됌

            trainer.AllAttack();

            trainer.ShowFirstMob();

        }
    }
}
