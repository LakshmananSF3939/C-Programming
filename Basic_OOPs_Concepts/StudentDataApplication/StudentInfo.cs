using System;

namespace StudentDataApplication
{
    public static class StudentInfo
    {
        public static string Name { get; set; }//static property
        public static int RegisterNumber;//static field
        static StudentInfo()
        {
           Name="Lakshmanan";
           RegisterNumber=3939;
        }
        public  static void Display()
        {
            
            System.Console.WriteLine("Register Number"+RegisterNumber);
            System.Console.WriteLine("Name"+Name);
            
        }
    }
}
