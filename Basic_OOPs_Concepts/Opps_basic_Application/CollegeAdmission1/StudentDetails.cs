using System;
using System.Collections.Generic;

/// <summary>
/// used to process the college admission using this application
/// </summary>
namespace CollegeAdmission1
{
  /// <summary>
  /// used to select student gender
  /// </summary>
  public enum Gender{Default,Male,Female,TransGender}
  /// <summary>
  /// used to collect student detail's<see cref="StudentDetails"/>
  /// </summary>
    public class StudentDetails
    {       //field
           /// <summary>
           /// static field used to auto increment and it uniquely identify 
           /// <see cref="StudentDetails"/>
           /// </summary>
      private static int s_registerNumber=3000 ;
      /// <summary>
      /// given String and int type Id
      /// </summary>
      
       public string RegisterNumber { get;  }
       /// <summary>
       /// Property used for collect name detail from the student
       /// </summary>
       
       
        
       public string Name { get; set;} //Auto property
       /// <summary>
       /// property father name used to provide father's name of a student
       /// </summary>
       /// <value></value>
        public string FatherName { get; set; }
        /// <summary>
        /// property used provide DOB of a student
        /// </summary>
        /// <value></value>
        public DateTime DOB { get; set; }
        /// <summary>
        /// used to store gender enum variable
        /// </summary>
        /// <value></value>
        public Gender Gender { get; set; }
        /// <summary>
        /// Property used to provide mobile number of a student
        /// </summary>
        /// <value></value>
        public long Phone { get; set; }
        /// <summary>
        /// Property used to provide Mail Id of a student
        /// </summary>
        /// <value></value>
        public string Mail { get; set; }
        /// <summary>
        /// Property used to provide chemistry mark of a student
        // < see cref="StudentInfo"/>
        /// </summary>
        /// <value></value>
        public int Chemistry { get; set; }
        /// <summary>
        /// Property used to provide Physics mark of a student
        /// </summary>
        /// <value></value>
        public int Physics { get; set; }
        /// <summary>
        /// Property used to provide Maths mark of a student
        /// </summary>
        /// <value></value>
        public int Maths { get; set; }
        
        
        //parameterized constructor
        /// <summary>
        /// Constructer <see cref ="StudentDetails"/>class used to initialize values to its properties
        /// </summary>
        /// <param name="name">parameter name used to initialize a student's Name to Name property</param>
        /// <param name="fathername">parameter  name used to initialize a student's Father Name to Name property</param>
        /// <param name="dob">parameter name used to initialize a student's DOB to DOB property</param>
        /// <param name="gender">parameter gender used to initialize a student's gender to gender property</param>
        /// <param name="mail">parameter name used to initialize a student's mail Id to Mail Id property</param>
        /// <param name="phone">parameter name used to initialize a student's phone number to phone property</param>
        /// <param name="physicsMark">parameter name used to initialize a student's Chemistry mark to chemistry mark property</param>
        /// <param name="chemistryMark">parameter name used to initialize a student's physics mark to physics mark property</param>
        /// <param name="maths">parameter name used to initialize a student's maths mark to maths mark property</param>
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
          /// <summary>
          /// method check eligibility get cutt off value as a parameter and check eligibility<see cref="StudentDetails"/>
          /// It cutoff less or equal to check conditions
          /// </summary>
          /// <param name="cutOff">Check eligibility Conditions</param>
          /// return true if eligible else false<Returns></Returns>
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
         /// <summary>
         /// Print all student details
         /// </summary>
         public void  ShowDetails()
         {
          System.Console.WriteLine("Student  details:");

            System.Console.WriteLine($"Your name is {Name}");
            System.Console.WriteLine("Register number is "+RegisterNumber);
            System.Console.WriteLine($"Your Father name is {FatherName}");
            System.Console.WriteLine($"DOB :{DOB.ToShortDateString()}");
            System.Console.WriteLine($"Gender:{Gender}");
            System.Console.WriteLine($"Mobile No:{Phone}");
            System.Console.WriteLine($"Mail Id:{Mail}");
            System.Console.WriteLine($"Phsics Mark:{Physics}");
            System.Console.WriteLine($"Chemistry Mark:{Chemistry}");
            System.Console.WriteLine($"Maths Mark:{Maths}");

         }




        ~StudentDetails()
        {

        }
    }
}
