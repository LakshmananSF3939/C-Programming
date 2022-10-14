using System;
namespace Question6 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string:");
            string str=Console.ReadLine();
            int alphabetCount=0;
            int numbersCount=0;
            int specialCount=0;
            foreach(char i in str)
            {
                if((i>=32 && i<=47)||(i>=58 && i<=64)||(i>=91 && i<=96)||(i>=123 && i<=126))
                {
                    specialCount++;
                }
                if(i>=48 && i<=57)
                {
                    numbersCount++;
                }
                if((i>=65 && i<=90)||(i>=97 && i<=122))
                {
                    alphabetCount++;
                }
            }
            System.Console.WriteLine($"Alphabet Count:{alphabetCount}\nNumbers count:{numbersCount}\nSpecial characters count:{specialCount}");
        }//32–47 / 58–64 / 91–96 / 123–126
    }
}
