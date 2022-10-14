using System;
namespace Question4;
class Program 
{
    public static void Main(string[] args)
    {
        BookInfo book=new BookInfo("EEE",Degree.BE,"Electro Megnetic","Author1",1000);
        book.ShowDetails();
    }
}

