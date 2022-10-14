using System;
namespace SingleInheritance;
class Program
{
    public static void Main(string[] args)
    {
        PersonalDetails detail1=new PersonalDetails("Lakshmanan","Ganesan",Gender.Male,9524626590);
        detail1.ShowDetails();
        StudentDetails student=new StudentDetails("644235","Lakshmanan","Ganesan",Gender.Male,9524626580,Department.EEE,"Final");
        student.ShowStudent();
        
    }
      
    
}
