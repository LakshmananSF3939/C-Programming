using System;

namespace MultiLevelInheritance
{
    public class EmployementDetails:StudentDetails
    {
        private static int s_employeeId=10000;
        public string EmlployeeID { get; set; }
        public DateTime RegistrationDate{ get; set; }
        public EmployementDetails(string studentID,string aadharID,string name,string fatherName,Gender gender,long mobile,Department department):base( studentID, aadharID, name, fatherName, gender, mobile, department)
        {
            s_employeeId++;
            EmlployeeID="EID"+s_employeeId;
            RegistrationDate=DateTime.Now;
        }
        public void ShowEmployeeDetails()
        {
            System.Console.WriteLine("Employee ID:"+EmlployeeID);
            ShowStudent();
            System.Console.WriteLine("Registration Date:"+RegistrationDate);
        }
    }
    
}
