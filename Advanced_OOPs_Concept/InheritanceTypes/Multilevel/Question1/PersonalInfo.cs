using System;

namespace Question1;
   public enum Gender{Default,Male,Female,TransGender}

    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName{ get; set; }
        public long phoneNumber { get; set; }
        public string Mail { get; set; }
        public DateTime DOB { get; set; }
        public PersonalInfo(string name,string fatherName,long mobile,string mail,DateTime dob)
        {
            Name=name;
            FatherName=fatherName;
            phoneNumber=mobile;
            Mail=mail;
            DOB=dob;
        }
    public void Show()
    {
            System.Console.WriteLine("Name:"+Name);
            System.Console.WriteLine("Father Name:"+FatherName);
            System.Console.WriteLine("Mobile Number:"+phoneNumber);
            System.Console.WriteLine("Mail:"+Mail);
            System.Console.WriteLine("DOB:"+DOB);
    } 
}

