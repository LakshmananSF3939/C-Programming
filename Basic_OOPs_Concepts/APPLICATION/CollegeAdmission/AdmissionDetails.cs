using System;

namespace CollegeAdmission
{
  public enum AdmissionStatus{Admitted,Cancelled};
    public  class AdmissionDetails
    {
      
      private static int s_admissionId=1000;
      public  string AdmissionId{get;}
      public  string StudentID{get;set;}
      public string DepartMentID { get; set; }
      public DateTime AdmissionDate{get;set;}
      public AdmissionStatus AdmissionStatus{get;set;}
      
      public AdmissionDetails(string studentID,string departmentID,DateTime admissionDate,AdmissionStatus admissionStatus)
      {
        s_admissionId++;
        AdmissionId="AID"+s_admissionId;
        StudentID=studentID;
        DepartMentID=departmentID;
        AdmissionDate=admissionDate;
        AdmissionStatus=admissionStatus;
       
    }
    public AdmissionDetails(string data)
        {
            string[] values=data.Split(',');
            s_admissionId=int.Parse(values[0].Remove(0,3));
            AdmissionId=values[0];
        StudentID=values[1];
        DepartMentID=values[2];
        AdmissionDate=DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
        AdmissionStatus=Enum.Parse<AdmissionStatus>(values[4]);
        }
}
}
