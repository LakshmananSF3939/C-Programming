using System;

namespace SingleInheritance
{
    public enum Department{Default,EEE,ECE,CSE}
    public class StudentDetails:PersonalDetails
    {
        private static int s_studentID=1000;
        public string StudentID {get;set;}
        public Department Department { get; set; }
        public string Year { get; set; }
        public StudentDetails(string aadharID,string name,string fatherName,Gender gender,long mobile,Department department,string year):base( aadharID, name, fatherName, gender, mobile)
        {
            s_studentID++;
            StudentID="SID"+s_studentID;
            Department=department;
            Year=year;

        }
        public void ShowStudent()
        {
            System.Console.WriteLine("Student ID:"+StudentID);
            ShowDetails();
            System.Console.WriteLine($"Department\t:{Department}\nYear\t\t:{Year}");
        }
    }
}
