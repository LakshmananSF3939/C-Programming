using System;
using System.IO;
namespace FileAndFolders;
class  Program 
{
    public static void Main(string[] args)
    {
        string path=@"C:\Users\LakshmananGanesan\Desktop\myfolder";

        string folderPath=path+"/Lakshmanan";
        string filePath=path+"/newFile.txt";//csv
        if(!Directory.Exists(folderPath))
        {
            System.Console.WriteLine("Folder not found creating");
            //string folder=path+"/Lakshmanan";
            Directory.CreateDirectory(folderPath);
        }
         else
        {
            System.Console.WriteLine("Folder Already Exists");
        }
        if(!File.Exists(filePath))
        {
            System.Console.WriteLine("File not found creating");
            File.Create(filePath);
        }
        else
        {
            System.Console.WriteLine("File Already Exists");
        }
        System.Console.WriteLine("Select 1.create folder 2.create file 3.Delete folder 4.Delete file");
        int option=int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                System.Console.WriteLine("Enter the folder name you want to create");
                string name1=Console.ReadLine();
                string newPath=path+"\\"+name1;
                if(!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                }
                else
                {
                    System.Console.WriteLine("Already folder exists");
                }
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Enter file name you want to create:");
                string fileName=Console.ReadLine();
                System.Console.WriteLine("Enter the extension you want to create");
                string extension=Console.ReadLine();
                string newPath=path+"\\"+fileName+"."+extension;
                if(!File.Exists(newPath))
                {
                    File.Create(newPath);
                }
                else
                {
                    System.Console.WriteLine("File already exists");
                }
                break;
            }
            case 3:
            {
                foreach(string name in Directory.GetDirectories(path))//file manager
                System.Console.WriteLine(name);
                System.Console.WriteLine("Select folder you want to delete");
                string name1=Console.ReadLine();
                String newPath=path+"\\"+name1;
                foreach(string name in Directory.GetDirectories(path))
                {
                    if(name==newPath)
                    {
                        try
                        {
                            Directory.Delete(newPath);
                        System.Console.WriteLine("Folder deleted");
                        }
                       catch(DirectoryNotFoundException e)
                        {
                          System.Console.WriteLine("Folder not found"+e.Message);
                         }
                    }
                        
                }
                break;
            }
            case 4:
            {
                foreach(string name in Directory.GetFiles(path))
                {
                    System.Console.WriteLine(name);
                }
                System.Console.WriteLine("Do you want delete the file");
                string name1=Console.ReadLine();
                System.Console.WriteLine("Do you delete extension file");
                string extension=Console.ReadLine();
                string newPath=path+"\\"+name1+"."+extension;
                foreach(string name in Directory.GetFiles(path))
                {
                    if(name==newPath)
                    {
                        try
                        {
                          File.Delete(newPath);
                          System.Console.WriteLine("File deleted");
                        }
                        catch(Exception e)
                        {
                            System.Console.WriteLine(e.Message);
                        }
                    }
                }

                break;
            }
        }
    }
}
