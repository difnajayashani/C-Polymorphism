

using System;

namespace AnimalApp
{
    class YellowBird : Animal,IFlyable
    {
        public override void CanBreath()
        {
            Console.WriteLine("YellowBird can breath");
        }

        public void canFly()
        {
            Console.WriteLine("YellowBird can Flyyy");
        }

        public override void MakeSound()
        {
            Console.WriteLine("YellowBird can sing to make sound");
        }
    }
}
