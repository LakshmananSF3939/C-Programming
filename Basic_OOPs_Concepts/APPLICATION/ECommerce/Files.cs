using System;
using System.IO;
namespace ECommerce
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("E_Commerce"))
            {
                Directory.CreateDirectory("E_Commerce");
                System.Console.WriteLine("Folder created");
            }
            if(!File.Exists("E_Commerce/CustomerDetails.csv"))
            {
                File.Create("E_Commerce/CustomerDetails.csv");
                System.Console.WriteLine("File created");
            }
            if(!File.Exists("E_Commerce/ProductDetails.csv"))
            {
                File.Create("E_Commerce/ProductDetails.csv");
                System.Console.WriteLine("File Created");
            }
            if(!File.Exists("E_Commerce/OrderDetails.csv"))
            {
                File.Create("E_Commerce/OrderDetails.csv");
                System.Console.WriteLine("File created");
            }
        }   
        public static void ReadFiles()
        {
            string[] customer=File.ReadAllLines("E_Commerce/CustomerDetails.csv");
            foreach(string data in customer)
            {
                CustomerDetails customer5=new CustomerDetails(data);
                Operations.customerList.Add(customer5);
            }
            string[] product=File.ReadAllLines("E_Commerce/ProductDetails.csv");
            foreach(string data in product)
            {
                ProductDetails product1=new ProductDetails(data);
                Operations.productList.Add(product1);
            }
            string[] order=File.ReadAllLines("E_Commerce/OrderDetails.csv");
            foreach(string data in order)
            {
                OrderDetails oredr1=new OrderDetails(data);
                Operations.orderList.Add(oredr1);
            }
        }
        public static void WriteFiles()
        {
            string[] customerDetails=new string[Operations.customerList.Count];
            for(int i=0;i<Operations.customerList.Count;i++)
            {
                customerDetails[i]=Operations.customerList[i].CustomerID+","+Operations.customerList[i].CustomerName+","+Operations.customerList[i].City+","+Operations.customerList[i].MobileNumber+","+Operations.customerList[i].WalletBalance+","+Operations.customerList[i].EmailId;

            }
            File.WriteAllLines("E_Commerce/CustomerDetails.csv",customerDetails);

            string[] productDetails=new string[Operations.productList.Count];
            for(int i=0;i<Operations.productList.Count;i++)
            {
                productDetails[i]=Operations.productList[i].ProductID+","+Operations.productList[i].ProductName+","+Operations.productList[i].Price+","+Operations.productList[i].Stock+","+Operations.productList[i].ShippingDate;
            }
            File.WriteAllLines("E_Commerce/ProductDetails.csv",productDetails);

            string[] orderDetails=new string[Operations.orderList.Count];
            for(int i=0;i<Operations.orderList.Count;i++)
            {
                orderDetails[i]=Operations.orderList[i].OrderID+","+Operations.orderList[i].CustomerID+","+Operations.orderList[i].ProductID+","+Operations.orderList[i].TotalPrice+","+Operations.orderList[i].PurchaseDate+","+Operations.orderList[i].Quantity+","+Operations.orderList[i].OrderStatus;
            }
            File.WriteAllLines("E_Commerce/OrderDetails.csv",orderDetails);

        }
    }
}
