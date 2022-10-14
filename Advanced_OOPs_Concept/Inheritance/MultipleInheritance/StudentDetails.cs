using System;

namespace MultipleInheritance
{
    public enum Department{Default,EEE,ECE,CSE}
    public class StudentDetails:PersonalDetails,IMarkDetails
    {
        private static int s_studentID=1000;
        public string StudentID {get;set;}
        public Department Department { get; set; }
        public string Year { get; set; }
        public int Physics { get; set; }//Property declaration only allowed
         public int Chemistry { get; set; } 
         public int Maths { get; set; }
         public double Average {get;set;}
        public StudentDetails(string aadharID,string name,string fatherName,Gender gender,long mobile,Department department,string year):base( aadharID, name, fatherName, gender, mobile)
        {
            s_studentID++;
            StudentID="SID"+s_studentID;
            Department=department;
            Year=year;

        }
        public void GetMark(int physics,int chemistry,int maths)
        {
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
        public void Calculate()
        {
            Average=(Physics+Chemistry+Maths)/3;
            
        }
        public void ShowMark()
        {
            System.Console.WriteLine($"Physics\t:{Physics}\nChemistry\t:{Chemistry}\nMaths\t:{Maths}");
            System.Console.WriteLine("Average\t:"+Average);
        }
        public void ShowStudent()
        {
            System.Console.WriteLine("Student ID:"+StudentID);
            ShowDetails();
            System.Console.WriteLine($"Department\t:{Department}\nYear\t\t:{Year}");
        }
    }
}
