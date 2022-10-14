using System;
using System.Collections.Generic;
namespace CollegeAdmission ;

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
        string gender=Console.ReadLine();
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
        System.Console.WriteLine("Are you willing to join this college:");
         willing=Console.ReadLine().ToLower();
        
       }while(willing=="yes");






       do  
       {
         
        StudentDetails student1=new StudentDetails();
        System.Console.WriteLine("Enter your Name:");
        string name=Console.ReadLine();
        student1.Name=name;
        System.Console.WriteLine("Enter your Father Name:");
        string fatherName=Console.ReadLine();
        student1.FatherName=fatherName;
        System.Console.WriteLine("Enter DOB dd/MM/yyyy");
        DateTime dob=DateTime.ParseExact(Console.ReadLine)
        student1.DOB=dob;
        System.Console.WriteLine("Enter Gender:");
        student1.Gender=Console.ReadLine();
        System.Console.WriteLine("Enter Mail:");
        student1.Mail=Console.ReadLine();
        System.Console.WriteLine("Enter mobile No:");
        long phone=long.Parse(Console.ReadLine());
        student1.Phone=phone;
        System.Console.WriteLine("Enter Physics Mark:");
        student1.Physics=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Chemistry Mark:");
        student1.Chemistry=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Maths Mark:");
        student1.Maths=int.Parse(Console.ReadLine());
        studentList.Add(student1);
        System.Console.WriteLine("Admitted!!!");
        System.Console.WriteLine("Are you willing to join this college:");
         willing=Console.ReadLine().ToLower();
        
       }while(willing=="yes");
       
       
         foreach(StudentDetails student in studentList) 
         {
            System.Console.WriteLine("Student  details:");

            System.Console.WriteLine($"Your name is {student.Name}");
            System.Console.WriteLine($"Your Father name is {student.FatherName}");
            System.Console.WriteLine($"DOB :{student.DOB.ToShortDateString()}");
            System.Console.WriteLine($"Gender:{student.Gender}");
            System.Console.WriteLine($"Mobile No:{student.Phone}");
            System.Console.WriteLine($"Mail Id:{student.Mail}");
            System.Console.WriteLine($"Phsics Mark:{student.Physics}");
            System.Console.WriteLine($"Chemistry Mark:{student.Chemistry}");
            System.Console.WriteLine($"Maths Mark:{student.Maths}");
            System.Console.WriteLine();
         }

         


      
    }
}
