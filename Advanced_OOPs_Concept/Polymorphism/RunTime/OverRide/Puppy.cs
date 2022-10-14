using System;

namespace SealedMethod
{
    public class Puppy:Dog
    {
        public override void MakeSound()//over ride
        {
            System.Console.WriteLine("Puppy Sound");
        }
    }
}
