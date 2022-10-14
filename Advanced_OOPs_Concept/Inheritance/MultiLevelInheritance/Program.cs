using System;
namespace MultiLevelInheritance;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Personal Details");
        PersonalDetails detail1=new PersonalDetails("Lakshmanan","Ganesan",Gender.Male,9524626590);
        detail1.ShowDetails();

        System.Console.WriteLine("Student Details");
        StudentDetails student=new StudentDetails("644235","Lakshmanan","Ganesan",Gender.Male,9524626580,Department.EEE,"Final");
        student.ShowStudent();
        
        System.Console.WriteLine("Cutomer Details");
        CustomerDetails customer=new CustomerDetails("644235","Lakshmanan","Ganesan",Gender.Male,9524626580);
        customer.Recharge();
        customer.ShowCustomerDetails();
        
        System.Console.WriteLine("Mark Details");
        student.GetMark(99,99,99);
        student.Calculate();
        student.ShowMark();

        System.Console.WriteLine("Employee Details");
        EmployementDetails employee=new EmployementDetails("SF3001","1234567","Lakshmanan","Father Name",Gender.Male,098765432,Department.EEE);
        employee.ShowEmployeeDetails();
    }
      
    
}
