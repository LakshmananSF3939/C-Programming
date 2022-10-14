using System;

namespace ECommerce
{
    public class ProductDetails
    {
      private static int s_productID=100;
      public string ProductID { get; set; } 
      public string ProductName { get; set; } 
      public double Price { get; set; }
      public int Stock { get; set; }
      public int ShippingDate { get; set; }
      public ProductDetails(string productName,double price,int stock,int shippingDate)
      {
        s_productID++;
        ProductID="PID"+s_productID;
        ProductName=productName;
        Price=price;
        Stock=stock;
        ShippingDate=shippingDate;
      }
      public ProductDetails(string data)
      {
        string[] values=data.Split(',');
        s_productID=int.Parse(values[0].Remove(0,3));
        ProductID=values[0];
        ProductName=values[1];
        Price=double.Parse(values[2]);
        Stock=int.Parse(values[3]);
        ShippingDate=int.Parse(values[4]);
      }
    }
}
