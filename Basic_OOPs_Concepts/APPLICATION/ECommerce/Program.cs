using System;
namespace ECommerce;
class Program 
{
    public static void Main(string[] args)
    {
        Files.Create();
        Files.ReadFiles();
        Operations.DefaultData();       
        Operations.MainMenu();
        Files.WriteFiles();
    }
}
