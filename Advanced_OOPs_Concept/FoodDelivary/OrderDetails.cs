using System;

namespace FoodDelivary
{
    public class OrderDetails
    {
        private static int s_orderID=100;
        public string OrderID { get; set; }
        public string BookingID { get; set; }
        public string FoodID { get; set; }
        public int PurchaseCount { get; set; }
        public int PriceOfOrder { get; set; }
        public OrderDetails(string bookingID,string foodID,int purchaseCount,int priceofOrder)
        {
            s_orderID++;
            OrderID="OID"+s_orderID;
            BookingID=bookingID;
            FoodID=foodID;
            PurchaseCount=purchaseCount;
            PriceOfOrder=priceofOrder;
        }
        public OrderDetails(string data)
        {
            string[] values=data.Split(',');
            s_orderID=int.Parse(values[0].Remove(0,3));
            OrderID=values[0];
            BookingID=values[1];
            FoodID=values[2];
            PurchaseCount=int.Parse(values[3]);
            PriceOfOrder=int.Parse(values[4]);
        }
        public void OrderDetail()
        {

        }
    }
}
