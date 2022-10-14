using System;

namespace GroceryShopApplication
{
    public enum Gender{Default,Male,Female,TransGender}
    public class PersonalDetails
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long MobileNumber { get; set; }
        public DateTime DOB { get; set; }
        public string MailID { get; set; }
        public PersonalDetails()
        {

        }
        public PersonalDetails(string name,string fatherName,Gender gender,long number,DateTime dob,string mail)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            MobileNumber=number;
            DOB=dob;
            MailID=mail;
        }
    }
}
