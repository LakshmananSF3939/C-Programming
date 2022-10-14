using System;

namespace MultipleInheritance
{
    public enum Gender{Default,Male,Female}
    public class PersonalDetails
    {
        private static int s_aadharID=21100;
        public string AadharID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long MobileNumber { get; set; }
        public PersonalDetails(string name,string fatherName,Gender gender,long mobile)
        {
            s_aadharID++;
            AadharID="AID"+s_aadharID;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            MobileNumber=mobile;
        }
        public PersonalDetails(string aadharID,string name,string fatherName,Gender gender,long mobile)
        {
            AadharID=aadharID;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            MobileNumber=mobile;
        }
        public void ShowDetails()
        {
            System.Console.WriteLine($"Your Name\t:{Name}\nYour Father Name:{FatherName}\nGender\t\t:{Gender}\nMobileNumber\t:{MobileNumber}\nYour Aadhar ID\t:{AadharID}");
        }
    }
}
