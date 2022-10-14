using System;

namespace Question4
{
    public class BookInfo:DepartmentInfo
    {
        private static int s_bookID=1000;
        public string BookId { get; set; }
        public string BookName { get; set; }
        public string AuthorName{ get; set; }
        public int Price { get; set; }
        public BookInfo(string departMent,Degree degree,string bookName,string authorName,int price):base( departMent, degree)
        {
            s_bookID++;
            BookId="BID"+s_bookID;
            
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }
        public void ShowDetails()
        {
           System.Console.WriteLine("BookID:"+BookId);
           System.Console.WriteLine("BookName:"+BookName);
           System.Console.WriteLine("Author Name:"+AuthorName);
           System.Console.WriteLine("Price:"+Price);
           System.Console.WriteLine("Department:"+DepartMent);
           System.Console.WriteLine("Degree:"+Degree);
        }
    }
}
