using System;
using System.IO;
namespace ReadWriteTXTFile;
class Program 
{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
            Directory.CreateDirectory("TestFolder");
            System.Console.WriteLine("Folder created");
        }
        else
        {
            System.Console.WriteLine("Already folder Exists");
        }
        if(!File.Exists("TestFolder/Test.txt"))
        {
            File.Create("TestFolder/Test.txt");
            System.Console.WriteLine("Folder created");
        }
        
        
        
            System.Console.WriteLine("Select 1.Read file info 2.Write file info");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    string line;
                    StreamReader sr=null;
                    try
                    {
                        sr=new StreamReader("TestFolder/Test.txt");
                        line=sr.ReadLine();
                        while(line!=null)
                        {
                            //write the line
                            System.Console.WriteLine(line);
                            //read next line
                            line=sr.ReadLine();
                        }
                    }
                    catch(Exception e)
                    {
                        System.Console.WriteLine(e.Message);
                    }
                    finally
                    {
                        if(sr!=null)
                        {
                            System.Console.WriteLine("Executing finally block");
                            sr.Close();
                        }
                    }
                    break;
                }
                case 2:
                {
                    StreamWriter sw=null;
                    try
                    {
                        string[] old=File.ReadAllLines("TestFolder/Test.txt");
                        sw=new StreamWriter("TestFolder/Test.txt");
                        System.Console.WriteLine("Enter new content to be placed in file");
                        string info=Console.ReadLine();
                        string old1="";
                          foreach(string text in old)
                          {
                            old1=old1+"\n"+text;

                          }
                          old1=old1+"\n"+info;
                          sw.WriteLine(old1);
                    }
                    catch(Exception e)
                    {
                        System.Console.WriteLine(e.Message);
                    }
                    finally
                    {
                        if(sw!=null)
                        {
                          sw.Close();
                          System.Console.WriteLine("File closed");
                        }
                    }
                    break;
                }
            }
        
    }
}
