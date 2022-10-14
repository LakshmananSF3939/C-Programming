using System;

namespace Question1
{
    public class StudentInfo:PersonalInfo
    {
        private static int s_registerNumber=1000;
        public string RegisterNumber { get; set; }
        public string Standard { get; set; }
        public string Branch { get; set; }
        public int Year { get; set; }
        public StudentInfo(string name,string fatherName,long mobile,string mail,DateTime dob,string standard,string branch,int year):base( name, fatherName, mobile, mail, dob)
        {
           s_registerNumber++;
           RegisterNumber="SID"+s_registerNumber;
           Standard=standard;
           Branch=branch;
           Year=year;
        }
        public void Disply()
        {
            Show();
            System.Console.WriteLine("Register Number:"+RegisterNumber);
            System.Console.WriteLine("Standard:"+Standard);
            System.Console.WriteLine("Branch:"+Branch);
            System.Console.WriteLine("Year:"+Year);
        }
    }
}
