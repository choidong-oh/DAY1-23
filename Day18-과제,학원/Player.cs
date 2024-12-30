using Day18_과제;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18_과제
{
    internal class Player : IInteractable
    {
        int playerposX ;
        public void Interact()
        {

        }
        public void InteractWithNPC(IInteractable npc)
        {

            npc.Interact();

            
        }

        
    }
}
