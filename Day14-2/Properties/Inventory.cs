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
        //public Item item;
        public Item[] ItemInventory;

        //배열의 크기 입력
        public void CreateInvenBySize(int ArrSize)
        {
            ItemInventory = new Item[ArrSize];
            Console.WriteLine("{0}만큼 인벤토리 만들어짐", ArrSize);
        }

        //배열 생성 여부 확인
        public bool isInvenCreated(Item[] ItemInventory)
        {
            if (ItemInventory == null || ItemInventory.Length < 0)
            {
                return false;
            }


            return true;
        }

        //배열 반환
        public Item GetItemByIndex(int index)
        {
            if (ItemInventory[index] == null)
            {
                Console.WriteLine("비어있음");
                return null;
            }

            return ItemInventory[index];
        }

        //배열 값에 item 대입
        public void SetItemByIndex(int index, Item item)
        {
            ItemInventory[index] = item;
        }
    }

}