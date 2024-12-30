using Day18_과제;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18_과제
{

   
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
           
            ReinforceNPC reinforceNPC = new ReinforceNPC();
            JobNPC jobNPC = new JobNPC();
            WarehouseNPC warehouseNPC = new WarehouseNPC();
            

            player.InteractWithNPC();


        }
    }
}
