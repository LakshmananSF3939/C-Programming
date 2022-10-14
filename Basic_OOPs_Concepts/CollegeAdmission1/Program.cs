using System;
using System.Collections.Generic;
namespace CollegeAdmission1 ;

class Program 
{
    public static void Main(string[] args)
    {

       List<StudentDetails> studentList=new List<StudentDetails>();
         System.Console.WriteLine("Are you willing to join this college:");
         string willing=Console.ReadLine().ToLower();

        do  
       {
         
        
        System.Console.WriteLine("Enter your Name:");
        
        string name=Console.ReadLine();
        System.Console.WriteLine("Enter your Father Name:");
        string fatherName=Console.ReadLine();
        System.Console.WriteLine("Enter DOB dd/MM/yyyy");
        DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        System.Console.WriteLine("Enter Gender:");


        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);


        System.Console.WriteLine("Enter Mail:");
        string mail=Console.ReadLine();
        System.Console.WriteLine("Enter mobile No:");
        long phone=long.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Physics Mark:");
        int physics=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Chemistry Mark:");
        int chemistry=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Maths Mark:");
        int maths=int.Parse(Console.ReadLine()); 

        StudentDetails student1=new StudentDetails(name,fatherName,dob,gender,mail,phone,physics,chemistry,maths);
        studentList.Add(student1);
        System.Console.WriteLine("Admitted!!!");
         System.Console.WriteLine("Register number is "+student1.RegisterNumber);
        System.Console.WriteLine("Are you willing to join this college:");
         willing=Console.ReadLine().ToLower();
        
       }while(willing=="yes");






       
       
         foreach(StudentDetails student in studentList) 
         {
            System.Console.WriteLine("Student  details:");

            System.Console.WriteLine($"Your name is {student.Name}");
            System.Console.WriteLine("Register number is "+student.RegisterNumber);
            System.Console.WriteLine($"Your Father name is {student.FatherName}");
            System.Console.WriteLine($"DOB :{student.DOB.ToShortDateString()}");
            System.Console.WriteLine($"Gender:{student.Gender}");
            System.Console.WriteLine($"Mobile No:{student.Phone}");
            System.Console.WriteLine($"Mail Id:{student.Mail}");
            System.Console.WriteLine($"Phsics Mark:{student.Physics}");
            System.Console.WriteLine($"Chemistry Mark:{student.Chemistry}");
            System.Console.WriteLine($"Maths Mark:{student.Maths}");
            bool eligible=student.checkEligibility(75.0);
            if(eligible)
            {
              System.Console.WriteLine("You are eligible for admission");
            }
            else
            {
              System.Console.WriteLine("You are not eligible for admission");
            }
            System.Console.WriteLine();
         }

         


      
    }
}
