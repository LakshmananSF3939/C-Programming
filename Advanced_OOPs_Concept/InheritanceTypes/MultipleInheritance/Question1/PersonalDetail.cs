using System;

namespace Question1
{
    public class PersonalDetail:InterfaceShowData
    {
        
        public string Name { get; set; }
        
        public long phoneNumber { get; set; }
        public string Mail { get; set; }
        public DateTime DOB { get; set; }
        public PersonalDetail(string name,long mobile,string mail,DateTime dob)
        {
            Name=name;
            
            phoneNumber=mobile;
            Mail=mail;
            DOB=dob;
        }
        public void ShowInfo()
    {
            System.Console.WriteLine("Name:"+Name);
            
            System.Console.WriteLine("Mobile Number:"+phoneNumber);
            System.Console.WriteLine("Mail:"+Mail);
            System.Console.WriteLine("DOB:"+DOB);
    } 
    }
}
