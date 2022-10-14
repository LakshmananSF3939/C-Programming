using System;
using System.Collections.Generic;
namespace AdmissionLibrary
{
  public enum Gender{Default,Male,Female,TransGender}
    public class StudentDetails
    {

      private static int s_registerNumber=3000 ;
       public string RegisterNumber { get;  }
       
       
        
       public string Name { get; set;} //Auto property
       
        public string FatherName { get; set; }
        
        public DateTime DOB { get; set; }
        
        public Gender Gender { get; set; }
        
        public long Phone { get; set; }
        
        public string Mail { get; set; }
        
        public int Chemistry { get; set; }
        
        public int Physics { get; set; }
        
        public int Maths { get; set; }
        
        
        //parameterized constructor
        public StudentDetails(string name,string fathername,DateTime dob,Gender gender,string mail,long phone,int physicsMark,int chemistryMark,int maths)
        {
          s_registerNumber++;
          RegisterNumber="SF"+s_registerNumber;
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

         public bool checkEligibility(double cutOff)
         {
          double average=(double)(Physics+Chemistry+Maths)/3.0;
          if(average>=cutOff)
          {
            return true;
          }
          else
          {
            return false;
          }
         }





        ~StudentDetails()
        {

        }
    }
}
