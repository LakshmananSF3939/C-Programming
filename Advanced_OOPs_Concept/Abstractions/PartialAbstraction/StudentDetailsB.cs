using System;

namespace PartialAbstraction
{
    public partial class StudentDetails
    {
       
       
        public void ShowStudent()
        {
            System.Console.WriteLine("Student ID:"+StudentID);
           
            System.Console.WriteLine($"Department\t:{Department}\nYear\t\t:{Year}");
        }
    }
}
