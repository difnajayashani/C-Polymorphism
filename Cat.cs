using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AnimalApp
{
    class Cat : Animal,IRunnable, IWalkable
    {
        public override void CanBreath()
        {
            Console.WriteLine("Cat can breath");
        }

        public void canRun()
        {
            Console.WriteLine("Cat can Run");
        }

        public void canWalk()
        {
            Console.WriteLine("Cat can walk");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meaaaww Meaawww");
        }
    }


}
