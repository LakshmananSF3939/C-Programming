using System;

namespace Question1
{
    public class TeacherInfo:PersonalInfo
    {
        private static int s_teacherID=1000;
        public string TeacherID{ get; set; }
        public string Department { get; set; }
        public string Subject { get; set; }
        public int Experience { get; set; }
        public DateTime DateOfJoining{ get; set; }
        public TeacherInfo(string name,string fatherName,long mobile,string mail,DateTime dob,string department,string subject,int experience,DateTime dateofJoining):base( name, fatherName, mobile, mail, dob)
        {
            s_teacherID++;
            TeacherID="TID"+s_teacherID;
            Department=department;
            Subject=subject;
            Experience=experience;
            DateOfJoining=dateofJoining;
        }
        public void ShowTeacher()
        {
            System.Console.WriteLine("Teacher Id:"+TeacherID);
            System.Console.WriteLine("DepartMent:"+Department);
            System.Console.WriteLine("Subject:"+Subject);
            System.Console.WriteLine("Date Of Joining"+DateOfJoining);
            Show();
        }
    }
}
