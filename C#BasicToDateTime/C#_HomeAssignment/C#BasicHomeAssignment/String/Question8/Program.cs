using System ;
namespace Question 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a String:");
            string str=Console.ReadLine();
            int positionStart=int.Parse(Console.ReadLine());
            int positionEnd=positionStart+int.Parse(Console.ReadLine());
            System.Console.WriteLine(str.Substring(4,9));
            for(int i=positionStart;i<positionEnd;i++)
            {
                System.Console.Write(str[i]);
            }
        }
    }
}
