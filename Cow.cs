using System;

namespace AnimalApp
{
    class Cow : Animal
    {
        public override void CanBreath()
        {
            Console.WriteLine("Cow can breath");
        }

        public override void MakeSound()
        {
            Console.WriteLine("umbaa Umbaa");
        }
    }
}
