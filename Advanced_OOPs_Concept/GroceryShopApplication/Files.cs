using System;
using System.IO;
namespace GroceryShopApplication
{
    public static class Files
    {
        public static void CreateFiles()
        {
            if(!Directory.Exists("GroceryShop"))
            {
                System.Console.WriteLine("Folder Created");
                Directory.CreateDirectory("GroceryShop");
            }
            if(!File.Exists("GroceryShop/CustomerRegistration.csv"))
            {
                System.Console.WriteLine("File Created");
                File.Create("GroceryShop/CustomerRegistration.csv");
            }
            if(!File.Exists("GroceryShop/ProductDetails.csv"))
            {
                System.Console.WriteLine("File Created");
                File.Create("GroceryShop/ProductDetails.csv");
            }
            if(!File.Exists("GroceryShop/BookingDetails.csv"))
            {
                System.Console.WriteLine("File Created");
                File.Create("GroceryShop/BookingDetails.csv");
            }
            if(!File.Exists("GroceryShop/OrderDetails.csv"))
            {
                System.Console.WriteLine("File Created");
                File.Create("GroceryShop/OrderDetails.csv");
            }
        }
        public static void ReadFiles()
        {
            string[] customer=File.ReadAllLines("GroceryShop/CustomerRegistration.csv");
            foreach(string data in customer)
            {
                CustomerRegistration customer1=new CustomerRegistration(data);
                Operation.cutomerList.Add(customer1);
            }
            string[] product=File.ReadAllLines("GroceryShop/ProductDetails.csv");
            foreach(string data in product)
            {
                ProductDetails product1=new ProductDetails(data);
                Operation.productList.Add(product1);
            }
            string[] booking=File.ReadAllLines("GroceryShop/BookingDetails.csv");
            foreach(string data in booking)
            {
                BookingDetails booking1=new BookingDetails(data);
                Operation.bookingList.Add(booking1);
            }
            string[] order=File.ReadAllLines("GroceryShop/OrderDetails.csv");
            foreach(string data in order)
            {
                OrderDetails order1=new OrderDetails(data);
                Operation.orderList.Add(order1);
            }
        }
        public static void WriteFiles()
        {
            string[] customerDetails=new string[Operation.cutomerList.Count];
            for(int i=0;i<Operation.cutomerList.Count;i++)
            {
                customerDetails[i]=Operation.cutomerList[i].CustomerID+","+Operation.cutomerList[i].Name+","+Operation.cutomerList[i].FatherName+","+Operation.cutomerList[i].Gender+","+Operation.cutomerList[i].MobileNumber+","+Operation.cutomerList[i].DOB.ToShortDateString()+","+Operation.cutomerList[i].MailID+","+Operation.cutomerList[i].WalletBalance;
            }
            File.WriteAllLines("GroceryShop/CustomerRegistration.csv",customerDetails);

            string[] productDetails=new String[Operation.productList.Count];
            for(int i=0;i<Operation.productList.Count;i++)
            {
                productDetails[i]=Operation.productList[i].ProductID+","+Operation.productList[i].ProductName+","+Operation.productList[i].QuantityAvailable+","+Operation.productList[i].PricePerQuantity;
            }
            File.WriteAllLines("GroceryShop/ProductDetails.csv",productDetails);

            string[] bookingDetails=new string[Operation.bookingList.Count];
            for(int i=0;i<Operation.bookingList.Count;i++)
            {
                bookingDetails[i]=Operation.bookingList[i].BookingID+","+Operation.bookingList[i].CustomerID+","+Operation.bookingList[i].TotalPrice+","+Operation.bookingList[i].DateOfBooking.ToShortDateString()+","+Operation.bookingList[i].BookingStatus;

            }
            File.WriteAllLines("GroceryShop/BookingDetails.csv",bookingDetails);

            string[] orderDetails=new string[Operation.orderList.Count];
            for(int i=0;i<Operation.orderList.Count;i++)
            {
                orderDetails[i]=Operation.orderList[i].OrderID+","+Operation.orderList[i].BookingID+","+Operation.orderList[i].ProductID+","+Operation.orderList[i].PurchaseCount+","+Operation.orderList[i].OrderPrice;
            }
            File.WriteAllLines("GroceryShop/OrderDetails.csv",orderDetails);

        }
    }
}
