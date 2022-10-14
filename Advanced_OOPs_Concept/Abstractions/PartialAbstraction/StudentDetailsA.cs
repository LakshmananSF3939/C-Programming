using System;

namespace PartialAbstraction
{
    public partial class StudentDetails
    {
        public StudentDetails(string aadharID,string name,string fatherName,Gender gender,long mobile,Department department,string year)
        {
            s_studentID++;
            StudentID="SID"+s_studentID;
            Department=department;
            Year=year;

        }
         public StudentDetails(string studentID,string aadharID,string name,string fatherName,Gender gender,long mobile,Department department)
        {
            StudentID=studentID;
            Department=department;
            

        }
    }
}
