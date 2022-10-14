using System;

namespace CollegeAdmission
{
    
    public  class DepartmentDetails
    {
        private static int s_departmentID=100;
        public  string DepartMentId  { get;set; }
        public  string DepartMentName { get; set; }
        public  int NumberOFSeats { get; set; }
         public DepartmentDetails(string departmentName,int numberOFSeats)
        {
            s_departmentID++;
            DepartMentId="DID"+s_departmentID;
            DepartMentName=departmentName;
            NumberOFSeats=numberOFSeats;

        }
        public DepartmentDetails(string data)
        {
            string[] values=data.Split(',');
            s_departmentID=int.Parse(values[0].Remove(0,3));
            DepartMentId=values[0];
            DepartMentName=values[1];
            NumberOFSeats=int.Parse(values[2]);
        }
    }
}
