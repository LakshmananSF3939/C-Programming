using System;
namespace Question10 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("ENter a charecter:");
            char c=char.Parse(Console.ReadLine());
            switch(c)
            {
                case 'a'or'A':
                {
                    System.Console.WriteLine("It is a vowel:");
                    break;
                }
                case 'e'or 'E':
                {
                    System.Console.WriteLine("It is a vowel:");
                    break;
                }
                case 'i'or'I':
                {
                    System.Console.WriteLine("It is a vowel:");
                    break;
                }
                case 'o'or'O':
                {
                    System.Console.WriteLine("It is a vowel:");
                    break;
                }
                case 'u'or'U':
                {
                    System.Console.WriteLine("It is a vowel:");
                    break;
                }
                default:
                {
                    System.Console.WriteLine("It is not a vowel");
                    break;
                }
             }
        }
    }
}
