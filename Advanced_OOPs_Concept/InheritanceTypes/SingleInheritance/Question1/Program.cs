using System;
namespace Question1;
class Program 

{
    public static void Main(string[] args)
    {
        StudentInfo student=new StudentInfo("Lakshmanan","Ganesan",9876544444,"abc@gmail.com",new DateTime(2001,02,08),"12th","Bio-maths",2018);
         student.ShowDetails();
    }
    
}
