using System;
using System.Collections.Generic;
using System.IO;
namespace ListFileManipulation;
class Program 
{
    public static void Main(string[] args)
    {
        List<StudentDetail>vlist=new List<StudentDetail>();
        vlist.Add(new StudentDetail(){Name="Lakshmanan",FatherName="Ganesan",Gender=Gender.Male,DOB=new DateTime(2001,02,08)});
        vlist.Add(new StudentDetail(){Name="karthi",FatherName="Ganesan",Gender=Gender.Male,DOB=new DateTime(2003,12,02)});
        vlist.Add(new StudentDetail(){Name="suriya",FatherName="Durai",Gender=Gender.Male,DOB=new DateTime(2000,01,08)});
         Insert(vlist);
         Display();
    }
   static void Insert(List<StudentDetail>vlist)
   {
     StreamWriter write=null;
     if(!File.Exists("Data.csv"))
     {
        System.Console.WriteLine("Creating new file");
        File.Create("Data.csv");
     }
     else
     {
        System.Console.WriteLine("File found");
     }
     write=new StreamWriter(File.OpenWrite("Data.csv"));
     foreach(var v in vlist)
     {
        write.WriteLine(v.Name+","+v.FatherName+","+v.Gender+","+v.DOB.ToString("dd/MM/yyyy"));
     }
     write.Close();
   } 
   static void Display()
   {
      StreamReader reader=null;
      List<StudentDetail>listA=new List<StudentDetail>();
      if(!File.Exists("Data.csv"))
      {
         reader=new StreamReader(File.OpenRead("Data.csv"));
         while(!reader.EndOfStream)
         {
            var line=reader.ReadLine();
            var values=line.Split(',');
            if(values[0]!="")
            {
               listA.Add(new StudentDetail(){Name=values[0],FatherName=values[1],Gender=Enum.Parse<Gender>(values[2]),DOB=DateTime.ParseExact(values[3],"dd/MM/yyyy",null)}); 
            }
         }
      }
      foreach(var temp in listA)
      {
         System.Console.WriteLine("Name:"+temp.Name);
         System.Console.WriteLine("Father Name:"+temp.FatherName);
         System.Console.WriteLine("Gender:"+temp.Gender);
         System.Console.WriteLine("DateTime:"+temp.DOB);
      }
   }
}
