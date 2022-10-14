using System;
using System.Collections.Generic;
namespace CollegeAdmission
{
    public class StudentDetails
    {
       // private string _name;//Field declaration
       // public string Name { get {return _name;} set { _name=value;} }
        
       public string Name { get; set;} //Auto property
       
        public string FatherName { get; set; }
        
        public DateTime DOB { get; set; }
        
        public string Gender { get; set; }
        
        public long Phone { get; set; }
        
        public string Mail { get; set; }
        
        public int Chemistry { get; set; }
        
        public int Physics { get; set; }
        
        public int Maths { get; set; }
        
        public StudentDetails()//Default constructor
        {
           Name="Your Name";
           FatherName="Your Father Name";
        }
        //parameterized constructor
        public StudentDetails(string name,string fathername,DateTime dob,string gender,string mail,long phone,int physicsMark,int chemistryMark,int maths)
        {
          Name=name;
          FatherName=fathername;
          DOB=dob;
          Gender=gender;
          Mail=mail;
          Phone=phone;
          Physics=physicsMark;
          Chemistry=chemistryMark;
          Maths=maths;
        }
    }
}
