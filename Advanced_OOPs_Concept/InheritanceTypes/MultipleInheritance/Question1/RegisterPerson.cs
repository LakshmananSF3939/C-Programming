using System;

namespace Question1
{
    public class RegisterPerson:PersonalDetail,InterfaceShowData,IFamily
    {
        private static int s_registerNumber=1000;
        public string RegisterNumber { get; set; }
        public DateTime Registerdate { get; set; }
        public string FatherName { get; set; }
         public string MotherName { get; set; }
        public string Address { get; set; }
        public RegisterPerson(string name,long mobile,string mail,DateTime dob,DateTime registerDate,string fatherName,string motherName,string address):base( name, mobile, mail, dob)
        {
          s_registerNumber++;
          RegisterNumber="RID"+s_registerNumber;
          Registerdate=registerDate;
          FatherName=fatherName;
          MotherName=motherName;
        }
        public void ShowInfo()
        {
             System.Console.WriteLine("Name:"+Name);
            System.Console.WriteLine("Register Number:"+RegisterNumber);
            System.Console.WriteLine("Mobile Number:"+phoneNumber);
            System.Console.WriteLine("Mail:"+Mail);
            System.Console.WriteLine("DOB:"+DOB);
            System.Console.WriteLine("RegisterNumber Date:"+Registerdate);
            System.Console.WriteLine("Father Name:"+FatherName);
            System.Console.WriteLine("Mother Name:"+MotherName);
            
        }
    }
}
