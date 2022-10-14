using System;

namespace GroceryShopApplication
{
    public class OrderDetails
    {
        private static int s_orderID=100;
        public string OrderID { get;  }
        public string BookingID { get; set; }
        public string ProductID{ get; set; }
        public int PurchaseCount { get; set; }
        public double OrderPrice { get; set; }

        public  OrderDetails(string bookingID,string productID,int count,double price)
        {
             s_orderID++;
             OrderID="OID"+s_orderID;
             BookingID=bookingID;
             ProductID=productID;
             PurchaseCount=count;
             OrderPrice=price;
        }
        public OrderDetails(string data)
        {
            string[] values=data.Split(',');
            s_orderID=int.Parse(values[0].Remove(0,3));
            OrderID=values[0];
            BookingID=values[1];
            ProductID=values[2];
            PurchaseCount=int.Parse(values[3]);
            OrderPrice=double.Parse(values[4]);

        }
        public void ShowOrderDetails()
        {
            System.Console.WriteLine("Order ID:"+OrderID);
            System.Console.WriteLine("Booking ID:"+BookingID);
            System.Console.WriteLine("Product ID:"+ProductID);
            System.Console.WriteLine("Purchase Count:"+PurchaseCount);
            System.Console.WriteLine("Order Price:"+OrderPrice);
        }
    }
}
