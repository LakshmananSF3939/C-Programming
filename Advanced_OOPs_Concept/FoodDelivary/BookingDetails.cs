using System;

namespace FoodDelivary
{
    public enum BookingStatus{Default,Initiated,Booked,Cancelled}
    public class BookingDetails
    {
        private static int s_bookingID=3000;
        public string BookingID { get; set; }
        public string CustomerID { get; set; }
        public int TotalPrice { get; set; }
        public DateTime DateOfBooking { get; set; }
        public BookingStatus BookingStatus { get; set; }
        public BookingDetails(string customerID,int totalPrice,DateTime dateofBooking,BookingStatus status)
        {
            s_bookingID++;
            BookingID="BID"+s_bookingID;
            CustomerID=customerID;
            TotalPrice=totalPrice;
            DateOfBooking=dateofBooking;
            BookingStatus=status;
        }
        public BookingDetails(string data)
        {
            string[] values=data.Split(',');
            s_bookingID=int.Parse(values[0].Remove(0,3));
            BookingID=values[0];
            CustomerID=values[1];
            TotalPrice=int.Parse(values[2]);
            DateOfBooking=DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
            BookingStatus=Enum.Parse<BookingStatus>(values[4]);
        }
        public void ShowBookingDetails()
        {
            
        }
    }
}
