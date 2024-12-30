using Day18_과제;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18_과제
{


    abstract class Npc
    {
        interface IInteractable
        {

            void Interact();

        }

        int posX;
        string name;
        void Interact()
        {

        }


    }
}
