using System;
namespace AbstractClasses;
class Program 
{
    public static void Main(string[] args)
    {
        Syncfusion job1=new Syncfusion();
        job1.Name="Developer";
        job1.Salary(30);

        Syncfusion job2=new Syncfusion();
        {
            job2.Name="Software Engineer";
            job2.Salary(15);
        }
    }
}