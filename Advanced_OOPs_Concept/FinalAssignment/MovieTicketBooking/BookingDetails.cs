using System;

namespace MovieTicketBooking
{
    public enum BookingStatus{Booked,Cancelled}
    public class BookingDetails
    {
        /// <summary>
        /// Represent as generating id
        /// </summary>
        private static int s_bookingID=7000;
        /// <summary>
        /// Represent as string format
        /// </summary>
        /// <value></value>
        public string BookingID { get; set; }
        /// <summary>
        /// user id in userdetails class
        /// </summary>
        /// <value></value>
        public string UserID { get; set; }
        /// <summary>
        /// Movie Id in using in this class
        /// </summary>
        /// <value></value>
        public string MoviesID { get; set; }
        /// <summary>
        /// Theatre ids
        /// </summary>
        /// <value></value>
        public string TheatreID{ get; set; }
        /// <summary>
        /// total seat count
        /// </summary>
        /// <value></value>
        public int SeatCount { get; set; }
        /// <summary>
        /// Total amount
        /// </summary>
        /// <value></value>
        public double TotalAmount { get; set; }
        /// <summary>
        /// Represent as a Enum varible {Booked,Cancelled}
        /// </summary>
        /// <value></value>
        public BookingStatus BookingStatus{ get; set; }
        /// <summary>
        /// BookingDetails class contructor
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="movieID"></param>
        /// <param name="theatreID"></param>
        /// <param name="count"></param>
        /// <param name="amount"></param>
        /// <param name="status"></param>
        public BookingDetails(string userID,string movieID,string theatreID,int count,double amount,BookingStatus status)
        {
            s_bookingID++;
            BookingID="BID"+s_bookingID;
            UserID=userID;
            MoviesID=movieID;
            TheatreID=theatreID;
            SeatCount=count;
            TotalAmount=amount;
            BookingStatus=status;
        }
        /// <summary>
        /// File manupulation class constructor
        /// </summary>
        /// <param name="data"></param>
        public BookingDetails(string data)
        {
            string[] values=data.Split(',');
            s_bookingID=int.Parse(values[0].Remove(0,3));
            BookingID=values[0];
            UserID=values[1];
            MoviesID=values[2];
            TheatreID=values[3];
            SeatCount=int.Parse(values[4]);
            TotalAmount=double.Parse(values[5]);
            BookingStatus=Enum.Parse<BookingStatus>(values[6]);
        }
    }
}
