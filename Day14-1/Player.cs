using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_1
{
    struct VectorPlayer
    {
        public short x;
        public short y;
    }
    internal class Player
    {
        string PlayerName;
        int PlayerHp;
        Inventory inventory;
        Item[] ItemInventory;

        public void MakeInven(int ArrSize)
        {
            ItemInventory = new Item[ArrSize];
            
        }
        

        public Inventory Inventory
        {
            get
            {


                return inventory;
            }


        }





    }
}
