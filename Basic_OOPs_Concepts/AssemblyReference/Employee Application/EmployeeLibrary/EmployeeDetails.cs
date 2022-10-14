using System;

namespace EmployeeLibrary;
    public enum WorkLocation{Madura,Eymard}
    public enum Gender{Default,Male,Gender,TransGender}
    public class EmployeeDetails
    {
        private static int s_employeeID=1000;

        public string EmployeeId { get; }
        public string EmployeeName { get; set; }
        public Gender Gender { get; set; } 
        public string Role { get; set; }
        public WorkLocation WorkLocation { get; set; }
        public string  TeamName { get; set; }
        public int WorkingDays ;
        public DateTime DateOfJoining { get; set; }
        
        public int Leave { get; set; }


        public EmployeeDetails(string name,Gender gender,string role,WorkLocation workLocation,string teamName,DateTime dateOfJoining,int leave,int totalDays)
        {
          s_employeeID++;
          EmployeeId="SF"+s_employeeID;
          EmployeeName=name;
          Gender=gender;
          Role=role;
          WorkLocation=workLocation;
          TeamName=teamName;
          DateOfJoining=dateOfJoining;
          Leave=leave;
          WorkingDays=totalDays;
          
        }
        
        public void CalculateAmount()
        {
            
            double salary=(WorkingDays-Leave)*500;
            System.Console.WriteLine("Your salary is:"+salary);
        }
        }

