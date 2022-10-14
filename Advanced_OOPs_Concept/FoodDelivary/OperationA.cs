using System;

namespace FoodDelivary
{
    public static partial class Operations
    {
        public static void OrderFood()
        {
           string choice;
           int totalAmount=0;
           BookingDetails book=new BookingDetails(CurrentCustomer.CustomerID,0,DateTime.Now,BookingStatus.Initiated);
           bookingList.AddElement(book);
           do 
           {
              
              foreach(FoodDetails food in foodList)
               {
                System.Console.WriteLine(food.FoodID+"\t"+food.FoodName+"\t"+food.PricePerQuantity);
               }
               System.Console.WriteLine("Select Food Id");
               string foodID=Console.ReadLine();
               System.Console.WriteLine("Food Quantity");
               int quantity=int.Parse(Console.ReadLine());
               foreach(FoodDetails food1 in foodList)
               {
                if(foodID==food1.FoodID)
                {
                    int orderPrice=quantity*food1.PricePerQuantity;
                    totalAmount+=orderPrice;
                    if(orderPrice<=CurrentCustomer.WalletBalance)
                    {
                        OrderDetails order=new OrderDetails(book.BookingID,food1.FoodID,quantity,orderPrice);
                        orderList.AddElement(order);
                        CurrentCustomer.WalletBalance-=orderPrice;
                        System.Console.WriteLine("Booking successfully--Booking ID:"+book.BookingID);
                    }
                }
               }
            System.Console.WriteLine("Do you want Purchase another food yes/no");
             choice=Console.ReadLine().ToLower();

           }while(choice=="yes");
           
            foreach(BookingDetails boo1 in bookingList)
            {
                if(CurrentCustomer.CustomerID==boo1.CustomerID)
                {
                    book.TotalPrice=totalAmount;
                    book.BookingStatus=BookingStatus.Booked;
                    
                }
            }
            
        }
       public static void CancelBooking()
       {
        foreach(BookingDetails book1 in bookingList)
        {
            if(CurrentCustomer.CustomerID==book1.CustomerID && book1.BookingStatus==BookingStatus.Booked)
            {
                System.Console.WriteLine("Booking ID:"+book1.BookingID);
                System.Console.WriteLine("Customer ID:"+book1.CustomerID);
                System.Console.WriteLine("Total Price:"+book1.TotalPrice);
                System.Console.WriteLine("Date Of Booking:"+book1.DateOfBooking);
                System.Console.WriteLine("Booking Status:"+book1.BookingStatus);
            }
        }
        foreach(BookingDetails book in bookingList)
        {
            if(CurrentCustomer.CustomerID==book.CustomerID && book.BookingStatus==BookingStatus.Booked)
            {
                System.Console.WriteLine("Enter Booking ID:");
                string bookid=Console.ReadLine();
                if(book.BookingID==bookid)
                {
                    System.Console.WriteLine("Booking Cancelled");
                    book.BookingStatus=BookingStatus.Cancelled;
                    CurrentCustomer.WalletBalance+=book.TotalPrice;
                }
            }
        }
       }
       public static void OrderHistory()
       {
            foreach(BookingDetails book in bookingList)
            {
                if(CurrentCustomer.CustomerID == book.CustomerID)
                {
                    foreach(OrderDetails order in orderList)
                    {
                        if(order.BookingID == book.BookingID)
                        {
                            System.Console.WriteLine(order.OrderID+"\t"+order.BookingID+"\t"+order.FoodID+"\t"+order.PurchaseCount+"\t"+order.PriceOfOrder);
                        }
                    }
                }
            }
       
       }
    }
}
