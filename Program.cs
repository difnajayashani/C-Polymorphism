using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalApp;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.CanBreath();
            cat.MakeSound();
            cat.canWalk();
            cat.canRun();
            Console.WriteLine(" ");

            Dog dog = new Dog();
            dog.CanBreath();
            dog.MakeSound();
            dog.canWalk();
            dog.canRun();
            Console.WriteLine(" ");


            Frog frog = new Frog();
            frog.CanBreath();
            frog.MakeSound();
            frog.canJump();
            Console.WriteLine(" ");


            GoldFish goldFish = new GoldFish();
            goldFish.CanBreath();
            goldFish.MakeSound();
            goldFish.canSwim();
            Console.WriteLine(" ");

            YellowBird bird = new YellowBird();
            bird.CanBreath();
            bird.MakeSound();
            bird.canFly();
            Console.WriteLine(" ");


            Console.ReadLine();



        }
    }
}
