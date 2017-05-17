

using System;

namespace AnimalApp
{
    class Frog : Animal, IJumpable1
    {
        public override void CanBreath()
        {
            Console.WriteLine("Frog can breath");
        }

        public void canJump()
        {
            Console.WriteLine("Frog can Jump");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Baka Baka");
        }
    }
}
