using System;

namespace Question1
{
    public class StudentInfo:PersonalInfo
    {
        private static int s_studentID=1000;
        public string StudentID { get; set; }
        public string Degree { get; set; }
        public string Department { get; set; }
        public int Semester { get; set; }
        public StudentInfo(string name,string fatherName,long mobile,string mail,DateTime dob,string degree,string department,int semester):base(name, fatherName, mobile, mail, dob)
        {
            s_studentID++;
            StudentID="SID"+s_studentID;
            Degree=degree;
            Department=department;
            Semester=semester;
        }
        public void ShowStudent()
        {
            System.Console.WriteLine("Student ID:"+StudentID);
            System.Console.WriteLine("Degree:"+Degree);
            System.Console.WriteLine("Department:"+Department);
            System.Console.WriteLine("Semester:"+Semester);
            Show();
        }

    }
}
