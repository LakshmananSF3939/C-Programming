using System;

namespace GroceryShopApplication
{
    public class ProductDetails
    {
        private static int s_productID=100;
        public string ProductID { get;  }
        public string ProductName { get; set; }
        public int QuantityAvailable{ get; set; }
        public double PricePerQuantity { get; set; }

        public ProductDetails(string productName,int quantity,double price)
        {
            s_productID++;
            ProductID="PID"+s_productID;
            ProductName=productName;
            QuantityAvailable=quantity;
            PricePerQuantity=price;
        }
        public ProductDetails(string data)
        {
            string[] values=data.Split(',');
            s_productID=int.Parse(values[0].Remove(0,3));
            ProductID=values[0];
            ProductName=values[1];
            QuantityAvailable=int.Parse(values[2]);
            PricePerQuantity=double.Parse(values[3]);
        }
        public void ShowProductDetails()
        {
            System.Console.WriteLine("Product ID:"+ProductID);
            System.Console.WriteLine("Product Name:"+ProductName);
            System.Console.WriteLine("Available Quantity:"+QuantityAvailable);
            System.Console.WriteLine("Price Per Quantity:"+PricePerQuantity);
        }
    }
}
