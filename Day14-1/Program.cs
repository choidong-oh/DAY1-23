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
            //Car car = new Car();
            //Monster monster = new Monster();
            //Inventory inventory = new Inventory();


            //monster.Powerproperty = -5;

            //monster.AttackCar(car);
            //Console.WriteLine(car.CarHp);
            //inventory.CreateInvenBySize(5);

            Item item = new Item();
            item.ItemName = "에어팟";

            //*******************************
            Item item1 = new Item();
            item1.ItemName = "버즈";

            Inventory inventory = new Inventory();
            Player player = new Player();
          

            //player.MakeInven(3);
            inventory.CreateInvenBySize(5);
            // inventory.GetItemByIndex(3) = 



            //***********************************
            inventory.SetItemByIndex(2, item);
            Inventory userInv = player.Inventory;
            //Item item1 = userInv.GetItemByIndex(3);

            inventory.SetItemByIndex(3, item1);




            player.Inventory.GetItemByIndex(3);

            player.Inventory.GetItemByIndex(2);



            //player.MakeInventory.SetItemByIndex(0,item.ItemName);
            Console.WriteLine();








        }


    }
}
