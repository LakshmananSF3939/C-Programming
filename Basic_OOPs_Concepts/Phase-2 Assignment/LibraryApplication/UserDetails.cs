using System;

namespace LibraryApplication
{
    public enum Gender{Male,Female}
    public enum Department{ECE,EEE,CSE}
    public class UserDetails
    {
        private static int s_registrationID=3000;
        public string RegistrationID { get; set; }
        public string UserName { get; set; }
        public Gender Gender { get; set; }
        public Department Department{ get; set; }
        public long MobileNumber { get; set; }
        public string MailID {get; set;}
        public int WalletBalance{get;set;}
        public UserDetails(string name,Gender gender,Department department,long mobile,string mail,int balance)
        {
           s_registrationID++;
           RegistrationID="SF"+s_registrationID;
           UserName=name;
           Gender=gender;
           Department=department;
           MobileNumber=mobile;
           MailID=mail;
           WalletBalance=balance;
        }
    }
}
