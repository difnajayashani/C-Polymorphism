

using System;

namespace AnimalApp
{
    class GoldFish : Animal,ISwimmable
    {
        public override void CanBreath()
        {
            Console.WriteLine("Goldfish can breath");
        }

        public void canSwim()
        {
            Console.WriteLine("Goldfish can Swim");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Gold fish makes sound");
        }
    }
}
