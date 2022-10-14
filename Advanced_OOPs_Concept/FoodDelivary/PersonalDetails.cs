using System;

namespace FoodDelivary
{
    public enum Gender{Male,Female,TransGender}
    public class PersonalDetails
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long MobileNumber { get; set; }
        public DateTime DOB { get; set; }
        public string MailID { get; set; }
        public string Location { get; set; }
        public PersonalDetails(string name,string fatherName,Gender gender,long phoneNumber,DateTime dob,string mail,string location)
        {
          Name=name;
          FatherName=fatherName;
          Gender=gender;
          MobileNumber=phoneNumber;
          DOB=dob;
          MailID=mail;
          Location=location;
        }
        public PersonalDetails()
        {
          
        }
    }
}
