using System;
namespace Question3;
class Program 
{
    public static void Main(string[] args)
    {
        EmployeeInfo employee=new EmployeeInfo(DateTime.Now,40,50000,"may","Lakshmanan","Ganesan",Gender.Male,9876543210,new DateTime(2001,02,08),"Nandambakkam");
        employee.ShowDetails();
    }
}