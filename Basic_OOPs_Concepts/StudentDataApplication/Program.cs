using System;
namespace StudentDataApplication;
class Program 
{
    public static void Main(string[] args)
    {
        StudentInfo.Display();
        System.Console.WriteLine(StudentInfo.RegisterNumber);
        StudentInfo.RegisterNumber=22;
        System.Console.WriteLine(StudentInfo.RegisterNumber);
     }
}