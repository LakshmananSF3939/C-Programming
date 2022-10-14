using System;
namespace Question7 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string:");
            string str=Console.ReadLine();
            int vowelCount=0;
            int consonentCount=0;
            foreach (char item in str)
            {
              if((item>=65 && item<=90)||(item>=97 && item<=122))  
              {
                if(item=='a'||item=='e'||item=='i'||item=='o'||item=='u'||item=='A'||item=='E'||item=='I'||item=='O'||item=='U')
                {
                   vowelCount++;
                }
                else
                {
                    consonentCount++;
                }
              }
            }
            System.Console.WriteLine($"Alphabet Count:{vowelCount}\nConsonent Count:{consonentCount}");
        }
    }
}
