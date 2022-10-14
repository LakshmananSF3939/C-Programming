using System;
using System.Collections.Generic;
namespace ECommerce;

    public static class Operations
    { 
        public static List<CustomerDetails> customerList=new List<CustomerDetails>();
        public static List<OrderDetails> orderList=new List<OrderDetails>();
        public static List<ProductDetails> productList=new List<ProductDetails>();
        static CustomerDetails CurrentCustomer=null;

         public static void DefaultData()
        {
            CustomerDetails customer1=new CustomerDetails("Ravi","Chennai",9885858588,50000,"ravi@mail.com");
            customerList.Add(customer1);
            CustomerDetails customer2=new CustomerDetails("Baskaran","Chennai",9888475757,60000,"baskaran@mail.com");
            customerList.Add(customer2);
            ProductDetails product1=new ProductDetails("mobile",10000,10,3);
            productList.Add(product1);
            ProductDetails product2=new ProductDetails("Tablet",15000,5,2);
            productList.Add(product2);
            ProductDetails product3=new ProductDetails("Camera",20000,3,4);
            productList.Add(product3);
            ProductDetails product4=new ProductDetails("iphone",50000,5,6);
            productList.Add(product4);
            ProductDetails product5=new ProductDetails("Laptop",40000,3,3);
            productList.Add(product5);
            OrderDetails order1=new OrderDetails(customer1.CustomerID,product1.ProductID,20000,DateTime.Now,2,OrderStatus.Ordered);
            orderList.Add(order1);
            OrderDetails order2=new OrderDetails(customer2.CustomerID,product3.ProductID,40000,DateTime.Now,2,OrderStatus.Ordered);
            orderList.Add(order2);
        }
        public static void MainMenu()
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("Select 1.Customer Registration 2.Login and Purchase 3.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Registration:");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Login:");
                        Login();

                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Exit");
                        choice="no";
                        break;

                    }
                }
            }while(choice=="yes");

        }
        public static void Registration()
        {
          System.Console.WriteLine("Enter your name:");
          string name=Console.ReadLine();
          System.Console.WriteLine("Enter Your City:");
          string city=Console.ReadLine();
          System.Console.WriteLine("Enter your phone number:");
          long mobile=long.Parse(Console.ReadLine());
          System.Console.WriteLine("Enter your mail ID");
          string mail=Console.ReadLine();
          System.Console.WriteLine("Enter your wallet balance");
          double walletBalance=double.Parse(Console.ReadLine());
          CustomerDetails customer3=new CustomerDetails(name,city,mobile,walletBalance,mail);
          customerList.Add(customer3);
          System.Console.WriteLine("Your registration ID:"+customer3.CustomerID);
        }
        public static void Login()
        {
            System.Console.WriteLine("Enter your Cutomer id:");
            string customerId=Console.ReadLine();
            foreach(CustomerDetails customer in customerList)
            {
              if(customer.CustomerID==customerId)
              {
                System.Console.WriteLine("Login successful");
                CurrentCustomer=customer;
                SubMenu();
                break;
              }
              
              
            }
        }
        public static void SubMenu()
        {
            string choice="yes";
            do
            {
            System.Console.WriteLine("Select 1.Purchase 2.Order Histry 3.Cancenl Order 4.Wallet Balence 5.Exit");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Purchase");
                    Purchase();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Order Histry");
                    OrderHistry();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Cancel order");
                    CancelOrder();
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("Wallet balance");
                    WalletBalance();
                    break;
                }
                case 5:
                {
                    System.Console.WriteLine("Exit");
                    choice="no";
                    break;
                }
            }
            }while(choice=="yes");
        } 
       public static void Purchase()
       {
        System.Console.WriteLine("Show Details:");
        foreach(ProductDetails product in productList)
        {
            //show details
            System.Console.WriteLine(product.ProductID+"\t"+product.ProductName+"\t"+product.ShippingDate+"\t"+product.Stock+"\t"+product.Price);
        }
        System.Console.WriteLine("Select Product Id");
        string productid=Console.ReadLine();
        System.Console.WriteLine("Enter the quantity of you want:");
        int quantity=int.Parse(Console.ReadLine());
        foreach(ProductDetails product1 in productList)
        {
            if(product1.ProductID==productid)
            {
            if(product1.Stock>=quantity && quantity>0)             
            {
               double deliveryCharge=50;
               double totalPrice=(quantity*product1.Price)+deliveryCharge;
               System.Console.WriteLine(totalPrice); 
               if(CurrentCustomer.WalletBalance>=totalPrice)
               {
                  CurrentCustomer.WalletBalance-=totalPrice;
                  product1.Stock-=quantity;
                  System.Console.WriteLine("Your order is successfully!!");
                  OrderDetails order1=new OrderDetails(CurrentCustomer.CustomerID,product1.ProductID,totalPrice,DateTime.Now,quantity,OrderStatus.Ordered);
                  orderList.Add(order1);
                  System.Console.WriteLine($"Delivery date:{DateTime.Now.AddDays(product1.ShippingDate)}");
               }
               else
               {
                System.Console.WriteLine("Insufficient Wallet Balance. Please recharge your wallet");
               }
            }
            else
            {
                if(productid==product1.ProductID)
                {
                     System.Console.WriteLine("Product Count is not available");
                    System.Console.WriteLine("Current Quntity is "+product1.Stock);
                }

            }
            }
        }
       }    
       public static void OrderHistry()
       {
        foreach(OrderDetails order in orderList)
        {
            if(order.CustomerID==CurrentCustomer.CustomerID)
            {
                System.Console.WriteLine("Order Id:"+order.OrderID);
                System.Console.WriteLine("Customer Id:"+order.CustomerID);
                System.Console.WriteLine("Product Id:"+order.ProductID);
                System.Console.WriteLine("Total price:"+order.TotalPrice);
                System.Console.WriteLine("Purchase date:"+order.PurchaseDate);
                System.Console.WriteLine("Quantity:"+order.Quantity);
                System.Console.WriteLine("Order Status:"+order.OrderStatus);
            }
        }
       }
       public static void WalletBalance()
       {
        foreach(CustomerDetails customer in customerList)
        {
            if(CurrentCustomer.CustomerID==customer.CustomerID)
            {
                System.Console.WriteLine("Your Wallet balance:"+customer.WalletBalance);
                System.Console.WriteLine("Do you recharge the wallet balance? say yes/no");
                string choice=Console.ReadLine();
                if(choice=="yes")
                {
                    System.Console.WriteLine("Enter Wallet Amount");
                   double rechargeBalence=double.Parse(Console.ReadLine());
                   customer.WalletBalance+=rechargeBalence;
                   System.Console.WriteLine("Your updated wallet balance :"+customer.WalletBalance);
                }
                
            }
        }
       }
       public static void CancelOrder()
       {
        foreach(OrderDetails cancel in orderList)
        {
            if(cancel.CustomerID==CurrentCustomer.CustomerID)
            {
               System.Console.WriteLine("Order Id:"+cancel.OrderID);
                System.Console.WriteLine("Customer Id:"+cancel.CustomerID);
                System.Console.WriteLine("Product Id:"+cancel.ProductID);
                System.Console.WriteLine("Total price:"+cancel.TotalPrice);
                System.Console.WriteLine("Purchase date:"+cancel.PurchaseDate);
                System.Console.WriteLine("Quantity:"+cancel.Quantity);
                System.Console.WriteLine("Order Status:"+cancel.OrderStatus); 
            }
        }
        System.Console.WriteLine("Enter the order id to be cancelled ");
        string cancellId=Console.ReadLine();
        foreach(OrderDetails cancel1 in orderList)
        {
            if(cancellId==cancel1.OrderID)
            {
                double deliveryCharge=50;
                System.Console.WriteLine("Enter the count of quntity to be cancelled");   
                    foreach(ProductDetails product in productList)
                    {
                        if(cancel1.ProductID==product.ProductID)
                        {                         
                            product.Stock+=cancel1.Quantity;                           
                            CurrentCustomer.WalletBalance+=cancel1.TotalPrice-deliveryCharge;
                            cancel1.OrderStatus=OrderStatus.Cancelled;
                            System.Console.WriteLine("Order cancelled");
                        }
                    }
                
            }
        }
       }
    }

