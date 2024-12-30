using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day14_1
{
    internal class Inventory
    {
        int ArrSize;
        Item[] ItemInventory;
        public void CreateInvenBySize(int ArrSize)
        {

            ItemInventory = new Item[ArrSize];

            Console.WriteLine("배열의 크기는 : " + ArrSize);
            
        }


        public bool isInvenCreated()
        {
            if (ArrSize < 0 )
            {
                

                return false;
            }

            else if (ArrSize > 0)
            {


                return true;
            }

            return true;
        }

        public Item GetItemByIndex(int Index)
        {
            if (ItemInventory[Index] != null)
            {
                return ItemInventory[Index];
            }


            else if (ItemInventory[Index] == null)
            {
                Console.WriteLine("비어있음");
                return null;
            }
            


            return ItemInventory[Index];

        }

        public void SetItemByIndex(int Index, Item item)
        {

            ItemInventory[Index] = item;


        }








        }


}