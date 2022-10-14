using System;
namespace Question9 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter month");
            string month=Console.ReadLine();
            if(month=="december"||month=="january"||month=="bebruary")
            {
                System.Console.WriteLine("Winter");
            }
            else if(month=="march"||month=="april"||month=="may")
            {
                System.Console.WriteLine("Spring");
            }
            else if(month=="june"||month=="july"||month=="august")
            {
                System.Console.WriteLine("Summer");
            }
            else 
            {
            if(month=="september"||month=="october"||month=="november")
            {
                System.Console.WriteLine("Rainfall");
            }
            }



        }
    }
}
