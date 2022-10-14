using System;

namespace Covid
{
    public enum Gender{Default,Male,Female,TransGender}
    public class BenificiaryDetails
    {
        private static int s_registration=1000;
        public  string RegistrationNumber { get; set; }
        public  string Name { get; set; }
        public  Gender Gender { get; set; }
        public  long MobileNumber  { get; set; }
        public  string City { get; set; }
        public  int Age { get; set; }
        public  BenificiaryDetails(string name,Gender gender,long mobile,string city,int age)
        {
            s_registration++;
            RegistrationNumber="BID"+s_registration;
            Name=name;
            Gender=gender;
            MobileNumber=mobile;
            City=city;
            Age=age;
        }
    }
}
