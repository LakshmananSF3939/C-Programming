using System;

namespace EmployeePayroll;
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


        public EmployeeDetails(string name,Gender gender,string role,WorkLocation workLocation,string teamName,DateTime dateOfJoining)
        {
          s_employeeID++;
          EmployeeId="SF"+s_employeeID;
          EmployeeName=name;
          Gender=gender;
          Role=role;
          WorkLocation=workLocation;
          TeamName=teamName;
          DateOfJoining=dateOfJoining;
          
          
        }
        public void ShowDetails()
        {
           System.Console.WriteLine("Your Employee Id:"+EmployeeId);
            System.Console.WriteLine("Your name is "+EmployeeName);
            System.Console.WriteLine("Gender:"+Gender);
            System.Console.WriteLine("Role:"+Role);
            System.Console.WriteLine("Work Location:"+WorkLocation);
            System.Console.WriteLine("Team Name:"+TeamName);
            System.Console.WriteLine("Date of Joining:"+DateOfJoining.ToShortDateString());
        }
        public void Leaves()
        {
           System.Console.WriteLine("Enter Month 1-12");
            int month=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter year yyyy format");
            int year=int.Parse(Console.ReadLine());
            WorkingDays=DateTime.DaysInMonth(year,month);
            System.Console.WriteLine("Enter leave:");
            Leave=int.Parse(Console.ReadLine());
        }
        
        public void CalculateAmount()
        {
            
            double salary=(WorkingDays-Leave)*500;
            System.Console.WriteLine("Your salary is:"+salary);
        }
        }

