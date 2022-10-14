using System;
namespace OnlineMedicalStore;
class Program
{
    public static void Main(string[] args)
    {
        Files.CreateFiles();
        Files.ReadFiles();
        Operations.MainMenu();
        Files.WriteFiles();
    }
    
}
