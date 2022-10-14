using System;

namespace CollegeAdmission
{
    public enum Gender{Default,Male,Female,TransGender}
    public class StudentDetails
    {
      private static int s_studentId=3000;
      public string RegistrationId { get;}  
      public string StudentName { get; set; }
      public string FatherName { get; set; }
      public DateTime DOB { get; set; }
      public Gender Gender { get; set; }
      public int Physics { get; set; }
      public int Chemistry { get; set; }
      public int Maths { get; set; }

      public StudentDetails(string studentName,string fatherName,DateTime dob,Gender gender,int physics,int chemistry,int maths)
      {
         s_studentId++;
         RegistrationId="SF"+s_studentId;
         StudentName=studentName;
         FatherName=fatherName;
         DOB=dob;
         Gender=gender;
         Physics=physics;
         Chemistry=chemistry;
         Maths=maths;
      }
      public StudentDetails(string data)
      {
        string[] valuse=data.Split(',');
        s_studentId=int.Parse(valuse[0].Remove(0,2));
        RegistrationId=valuse[0];
        StudentName=valuse[1];
        FatherName=valuse[2];
        DOB=DateTime.ParseExact(valuse[3],"dd/MM/yyyy",null);
        Gender=Enum.Parse<Gender>(valuse[4]);
        Physics=int.Parse(valuse[5]);
        Chemistry=int.Parse(valuse[6]);
        Maths=int.Parse(valuse[7]);
      }
      public bool CheckEligibility(double cutOff)
      {
        double average=(Physics+Chemistry+Maths)/3.0;
        if(cutOff<average)
        {
          return true;
        }
        else
        {
          return false;
        }
      }

      public void ShowDetails()
      {
        System.Console.WriteLine("Your Name:"+StudentName);
        System.Console.WriteLine("Father Name:"+FatherName);
        System.Console.WriteLine("Date of birth:"+DOB);
        System.Console.WriteLine("Gender:"+Gender);
        System.Console.WriteLine("Physics Mark:"+Physics);
        System.Console.WriteLine("Chemistry Mark:"+Chemistry);
        System.Console.WriteLine("Maths:"+Maths);
      }      

    }
}
