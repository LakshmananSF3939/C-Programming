using System;
namespace DictionaryDS;
class Program 
{
    public static void Main(string[] args)
    {
        Dictionary<char,int> datas=new Dictionary<char, int>();
        datas.AddElement('a',10);
        datas.AddElement('b',30);
        datas.AddElement('c',26);
        datas.AddElement('d',12);
        datas.AddElement('e',25);
        

        
        System.Console.WriteLine(datas.ElementAt(4).key+" "+datas.ElementAt(4).Value);
    }
}
