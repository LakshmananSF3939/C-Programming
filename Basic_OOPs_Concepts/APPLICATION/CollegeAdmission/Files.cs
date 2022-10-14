using System;
using System.IO;
namespace CollegeAdmission
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("College"))
            {
                System.Console.WriteLine("Create folder");
                Directory.CreateDirectory("College");
            }
            else
            {
                System.Console.WriteLine("Already exists");
            }
            if(!File.Exists("College/StudentDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("College/StudentDetails.csv");
            }
            else
            {
                System.Console.WriteLine("Already exists");
            }
            if(!File.Exists("College/AdmissionDetails.csv"))
            {
                System.Console.WriteLine("Create file");
                File.Create("College/AdmissionDetails.csv");
            }
            if(!File.Exists("College/DepartmentDetails.csv"))
            {
                System.Console.WriteLine("Create file");
                File.Create("College/DepartmentDetails.csv");
            }
        }
        public static void ReadFiles()
        {
            string[] students=File.ReadAllLines("College/StudentDetails.csv");
            foreach(string data in students)
            {
                StudentDetails student=new StudentDetails(data);
                Operations.studentList.Add(student);
            }
            string[] admission =File.ReadAllLines("College/AdmissionDetails.csv");
            foreach(string data1 in admission)
            {
                AdmissionDetails admissions=new AdmissionDetails(data1);
                Operations.admissionList.Add(admissions);
            }
            string[] department =File.ReadAllLines("College/DepartmentDetails.csv");
            foreach(string data2 in department)
            {
                DepartmentDetails depart=new DepartmentDetails(data2);
                Operations.departmentList.Add(depart);
            }
        }
        public static void WriteOfFiles()
        {
            string[] studentDetails=new string[Operations.studentList.Count];
            for(int i=0;i<Operations.studentList.Count;i++)
            {
                studentDetails[i]=Operations.studentList[i].RegistrationId+","+Operations.studentList[i].StudentName+","+Operations.studentList[i].FatherName+","+Operations.studentList[i].DOB.ToString("dd/MM/yyyy")+","+Operations.studentList[i].Gender+","+Operations.studentList[i].Physics+","+Operations.studentList[i].Chemistry+","+Operations.studentList[i].Maths;
            }
            File.WriteAllLines("College/StudentDetails.csv",studentDetails);

            string[] departmenDetails=new string[Operations.departmentList.Count];
            for(int i=0;i<Operations.admissionList.Count;i++)
            {
                departmenDetails[i]=Operations.departmentList[i].DepartMentId+","+Operations.departmentList[i].DepartMentName+","+Operations.departmentList[i].NumberOFSeats;
            }
            File.WriteAllLines("College/DepartmentDetails.csv",departmenDetails);
            
            string[] admissionDetails=new string[Operations.admissionList.Count];
            for(int i=0;i<Operations.admissionList.Count;i++)
            {
                admissionDetails[i]=Operations.admissionList[i].AdmissionId+","+Operations.admissionList[i].StudentID+","+Operations.admissionList[i].DepartMentID+","+Operations.admissionList[i].AdmissionDate.ToShortDateString()+","+Operations.admissionList[i].AdmissionStatus;
            }
            File.WriteAllLines("College/AdmissionDetails.csv",admissionDetails);
        }
    }
}
