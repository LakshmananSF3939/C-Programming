using System;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("---------StudentInfo---------");
        StudentInfo student=new StudentInfo("LAkshmanan","Ganesan",9876543210,"abc@gmail",new DateTime(2001,02,08),"BE","EEE",8);
        student.ShowStudent();
        System.Console.WriteLine("----------TeacherInfo----------");
        TeacherInfo teacher=new TeacherInfo("Lakshmanan","Ganesan",98765432,"Abc@gmail",new DateTime(2000,08,06),"EEE","RER",6,DateTime.Now);
        teacher.ShowTeacher();
        System.Console.WriteLine("-----------Principle------------");
        PrincipleInfo principle=new PrincipleInfo("lakshmanan","Ganesan",987654321,"jhgf@gmail",new DateTime(2000,08,08),"ME",2019);
        principle.ShowPrinciple();
    }
}

