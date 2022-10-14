using System;
namespace ListDS;
class Program 
{
    public static void Main(string[] args)
    {
        List<int> datas=new List<int>();
        datas.AddElement(90);
        datas.AddElement(100);
        datas.AddElement(189);
        datas.AddElement(1288);
        datas.AddElement(1887);
        datas.AddElement(1888);
        datas.Insert(3,89);
        System.Console.WriteLine("Insert");

        List<int> datas2=new List<int>();
        datas2.AddElement(15);
        datas2.AddElement(27);
        datas2.AddElement(17);
        
        datas.AddRange(datas2);

        foreach(int data in datas)
        {
            System.Console.WriteLine(data);
        }
        
        datas.RemoveAt(3);
        System.Console.WriteLine("RemoveAt");
       
        datas.Remove(1887);
        System.Console.WriteLine("Remove");
        
       /* foreach(var value in datas)
        {
            System.Console.WriteLine(value);
        }*/
       for(int i=0;i<datas.Count;i++)
        {
            System.Console.WriteLine(datas[i]); 
        }
    }
    
}
