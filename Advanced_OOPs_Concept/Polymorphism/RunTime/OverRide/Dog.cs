using System;

namespace SealedMethod
{
    public class Dog:Animal
    {
        public override void MakeSound()
        {
            System.Console.WriteLine("Dog Barkes");
        }
    }
}
