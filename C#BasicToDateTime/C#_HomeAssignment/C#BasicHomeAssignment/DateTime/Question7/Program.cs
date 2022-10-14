using System;
namespace Question7 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the DateTime1:");
            DateTime dateTime1=new DateTime(2016,8,1,0,0,0);
            System.Console.WriteLine("Enter the DateTime2:");
            DateTime dateTime2=new DateTime(2016,08,01,12,00,00);
            int result=DateTime.Compare(dateTime1,dateTime2);
             
            string str;
            if(result<0)
            {
              str="IS Earlier than";
            }
            else if(result==0)
            {
                str="Same time";
            }
            else
            {
                str="is Later than";
            }
            System.Console.WriteLine($"{dateTime1} {str} {dateTime2}");
        }
    }
}