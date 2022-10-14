using System;

namespace LibraryApplication
{
    public enum Status{Issued,Returned}
    public class BorrowDetails
    {
        private static int s_borrowID=301;
        public string BorrowID { get; set; }
        public string  BookID  { get; set; }
        public string RegistrationID { get; set; }
        public DateTime BorrowedDate { get; set; }
        public Status Status{get; set;}
        public BorrowDetails(string bookID,string registrationID,DateTime borrowedDate,Status status)
        {
            s_borrowID++;
            BorrowID="LB"+s_borrowID;
            BookID=bookID;
            RegistrationID=registrationID;
            BorrowedDate=borrowedDate;
            Status=status;

        }

    }
}
