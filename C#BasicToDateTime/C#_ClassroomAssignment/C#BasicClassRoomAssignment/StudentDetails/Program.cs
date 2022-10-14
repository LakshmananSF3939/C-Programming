using System;
namespace StudentDetails 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Your name:");
            string studentName=Console.ReadLine();

            Console.WriteLine("Enter your father name:");
            string fatherName=Console.ReadLine();

            Console.WriteLine("Gender:");
            char gender=Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Age:");
            int age=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Mobile Number:");
            string mobileNo=Console.ReadLine();

             Console.WriteLine("Mail Id::");
            string mailId=Console.ReadLine();

            Console.WriteLine("Chemistry Mark:");
            int chemistryMark=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Physics Mark:");
            int physicsMark=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Maths Mark:");
            int mathsMark=Convert.ToInt32(Console.ReadLine());
            float total=chemistryMark+physicsMark+mathsMark;
            float average=total/3;
            float percentage=total/600*100;
            Console.WriteLine($"Name :{studentName}\nFather name:{fatherName}\nGender:{gender}\nAge:{age}\nMobile No:{mobileNo}");
            Console.WriteLine($"\nMail Id:{mailId}\nChemistry:{chemistryMark}\nPhysics:{physicsMark}\nMaths:{mathsMark}");
            Console.WriteLine($"\nAverage:{average}\nPercentage:{percentage}");

        }
    }
}
