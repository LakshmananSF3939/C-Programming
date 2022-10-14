using System;

namespace Question3
{
    public enum Gender{Default,Male,Femle,TransGender}
    public class EmployeeInfo:SalaryInfo
    {
        private static int s_mployeeID=100;
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long Mobile { get; set; }
        public DateTime DOB { get; set; }
        public string Branch { get; set; }
        public EmployeeInfo(DateTime date,int numberOfWorkedHour,int salary,string month,string name,string fatherName,Gender gender,long mobile,DateTime dob,string branch):base( date, numberOfWorkedHour, salary, month)
        {
            s_mployeeID++;
            EmployeeID="EID"+s_mployeeID;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Mobile=mobile;
            DOB=dob;
            Branch=branch;
        }
        public void ShowDetails()
        {
            System.Console.WriteLine("Employee Number:"+EmployeeID);
             System.Console.WriteLine("Name:"+Name);
            System.Console.WriteLine("Father Name:"+FatherName);
            System.Console.WriteLine("Mobile Number:"+Mobile);
            System.Console.WriteLine("Gender:"+Gender);
            System.Console.WriteLine("DOB:"+DOB);
            System.Console.WriteLine("Date:"+Date);
            System.Console.WriteLine("Working Hours:"+NumberOfWorkedHour);
        }
    }
}
