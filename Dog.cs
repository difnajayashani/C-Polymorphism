using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp
{
    class Dog : Animal , IRunnable, IWalkable
    {
        public override void CanBreath()
        {
            Console.WriteLine("Dog can breath");
        }

        public void canRun()
        {
            Console.WriteLine("Dog can Runnn");
        }

        public void canWalk()
        {
            Console.WriteLine("Dog can walk");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Baww Baww");
        }
    }
}
