using System;
using System.IO;
namespace FoodDelivary;

    public static class Files
    {
       public static void CreateFiles()
       {
        if(!Directory.Exists("Hotel"))
        {
           System.Console.WriteLine("Folder created..");
           Directory.CreateDirectory("Hotel");
        }
        if(!File.Exists("Hotel/RegistrationDetails.csv"))
        {
            System.Console.WriteLine("File Created...");
            File.Create("Hotel/RegistrationDetails.csv");
        }
        if(!File.Exists("Hotel/FoodDetails.csv"))
        {
            System.Console.WriteLine("File Created");
            File.Create("Hotel/FoodDetails.csv");
        }
        if(!File.Exists("Hotel/BookingDetails.csv"))
        {
            System.Console.WriteLine("File Created");
            File.Create("Hotel/BookingDetails.csv");
        }
        if(!File.Exists("Hotel/OrderDetails.csv"))
        {
            System.Console.WriteLine("File Created");
            File.Create("Hotel/OrderDetails.csv");
        }
       } 
       public static void ReadFiles()
       {
        string[] register=File.ReadAllLines("Hotel/RegistrationDetails.csv");
        foreach(string data in register)
        {
            RegistrationDetails customer=new RegistrationDetails(data);
            Operations.registerList.AddElement(customer);
        }
        string[] food=File.ReadAllLines("Hotel/FoodDetails.csv");
        foreach(string data1 in food)
        {
            FoodDetails food1=new FoodDetails(data1);
            Operations.foodList.AddElement(food1);
        }
        string[] book=File.ReadAllLines("Hotel/BookingDetails.csv");
        foreach(string data2 in book)
        {
            BookingDetails book1=new BookingDetails(data2);
            Operations.bookingList.AddElement(book1);
        }
        string[] order=File.ReadAllLines("Hotel/OrderDetails.csv");
        foreach(string data3 in order)
        {
            OrderDetails order1=new OrderDetails(data3);
            Operations.orderList.AddElement(order1);
        }
       }
       public static void WriteFiles()
       {
        string[] registerDetails=new string[Operations.registerList.Count];
        for(int i=0;i<Operations.registerList.Count;i++)
        {
            registerDetails[i]=Operations.registerList[i].CustomerID+","+Operations.registerList[i].Name+","+Operations.registerList[i].FatherName+","+Operations.registerList[i].Gender+","+Operations.registerList[i].MobileNumber+","+Operations.registerList[i].DOB.ToShortDateString()+","+Operations.registerList[i].MailID+","+Operations.registerList[i].Location+","+Operations.registerList[i].WalletBalance;
        }
        File.WriteAllLines("Hotel/RegistrationDetails.csv",registerDetails);
        
        string[] foodDetails=new string[Operations.foodList.Count];
        for(int i=0;i<Operations.foodList.Count;i++)
        {
            foodDetails[i]=Operations.foodList[i].FoodID+","+Operations.foodList[i].FoodName+","+Operations.foodList[i].PricePerQuantity;
        }
        File.WriteAllLines("Hotel/FoodDetails.csv",foodDetails);

        string[] bookingDetails=new string[Operations.bookingList.Count];
        for(int i=0;i<Operations.bookingList.Count;i++)
        {
            bookingDetails[i]=Operations.bookingList[i].BookingID+","+Operations.bookingList[i].CustomerID+","+Operations.bookingList[i].TotalPrice+","+Operations.bookingList[i].DateOfBooking.ToShortDateString()+","+Operations.bookingList[i].BookingStatus;
        }
        File.WriteAllLines("Hotel/BookingDetails.csv",bookingDetails);

        string[] orderDetails=new string[Operations.orderList.Count];
        for(int i=0;i<Operations.orderList.Count;i++)
        {
            orderDetails[i]=Operations.orderList[i].OrderID+","+Operations.orderList[i].BookingID+","+Operations.orderList[i].FoodID+","+Operations.orderList[i].PurchaseCount+","+Operations.orderList[i].PriceOfOrder;
        }
        File.WriteAllLines("Hotel/OrderDetails.csv",orderDetails);
       }
    }

