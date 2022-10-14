using System;

namespace Question1
{
    public class PrincipleInfo:PersonalInfo
    {
        private static int s_principleID=1000;
        public string PrincipleID { get; set; }
        public string Qualification{ get; set; }
        public int YearOfJoining { get; set; }
        public PrincipleInfo(string name,string fatherName,long mobile,string mail,DateTime dob,string qualification,int year):base( name, fatherName, mobile, mail, dob)
        {
            s_principleID++;
            PrincipleID="PID"+s_principleID;
            Qualification=qualification;
            YearOfJoining=year;
            
        }
        public void ShowPrinciple()
        {
            System.Console.WriteLine("Principle ID:"+PrincipleID);
            System.Console.WriteLine("Qualification:"+Qualification);
            System.Console.WriteLine("Year of Join:"+YearOfJoining);
        }
    }
}
