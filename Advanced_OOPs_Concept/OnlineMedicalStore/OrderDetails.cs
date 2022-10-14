using System;

namespace OnlineMedicalStore
{
    public enum OrderStatus{Default,Purchased,Cancelled}
    public class OrderDetails
    {
        private static int s_orderID=2001;
        public string OrderID { get; set; }
        public string UserID { get; set; }
        public string MedicineID { get; set; }
        public int MedicineCount { get; set; }
        public int TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public OrderDetails(string userID,string medicineID,int medicineCount,int totalPrice,DateTime orderDate,OrderStatus status)
        {
            s_orderID++;
            OrderID="OID"+s_orderID;
            UserID=userID;
            MedicineID=medicineID;
            MedicineCount=medicineCount;
            TotalPrice=totalPrice;
            OrderDate=orderDate;
            OrderStatus=status;
            
        }
        public OrderDetails(string data)
        {
            string[] values=data.Split(',');
            s_orderID=int.Parse(values[0].Remove(0,3));
            OrderID=values[0];
            UserID=values[1];
            MedicineID=values[2];
            MedicineCount=int.Parse(values[3]);
            TotalPrice=int.Parse(values[4]);
            OrderDate=DateTime.ParseExact(values[5],"dd/MM/yyyy",null);
            OrderStatus=Enum.Parse<OrderStatus>(values[6]);
            
        }
    }
}
