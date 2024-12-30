using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day14_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //과제1
            //Monster monster = new Monster();
            //Car car = new Car();
            //monster.MonsterPowerPro = 20;
            //monster.AttackCar(car);
            //Console.WriteLine("자동차의 체력은" + car.CarHp);


           // item 값 대입
            Item item = new Item();
            item.ItemName = "집행검";
            item.ItemPrice = 2500;
            item.ItemType = "양손검";

            Item item1 = new Item();
            item1.ItemName = "앨리스";
            item1.ItemPrice = 2000;
            item1.ItemType = "양손검";

            Player player = new Player();
            //new 할당
            player.MakeInven();
            //5칸 크기의 배열 생성
            player.inven.CreateInvenBySize(5);
            //ItemInventory[3] = item
            player.inven.SetItemByIndex(3, item);
            //ItemInventory[2] = item
            player.inven.SetItemByIndex(2, item1);

           // Console.WriteLine(item.ItemName);
            Console.WriteLine(player.inven.GetItemByIndex(2).ItemName);




            //심화마지막
            //Player player = new Player();
            //Monster monster = new Monster();
            //monster.MonsterPowerPro = 10;
            //monster.MonsterHpPro = 100;

            //player.PlayerHpPro = 200;
            //player.PlayerPowerPro = 20;

            //monster.AttackPlayer(player);





        }


    }
}
