using System;
namespace Question1 
{
  
  class Program 
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Your Name:");
        string name=Console.ReadLine();
        Console.WriteLine("Hello"+name);
        Console.WriteLine("Hello {0}",name);
        Console.WriteLine($"Hello {name}");
    }
  }
}
