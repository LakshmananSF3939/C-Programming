using System;
//using System.Collections.Generic;
namespace GroceryShopApplication;
public delegate void EventManager();
public static class Operation 
{
    //customerlist
     public static List<CustomerRegistration> cutomerList=new List<CustomerRegistration>();
     //Product list
     public static List<ProductDetails> productList=new List<ProductDetails>();
     //Booking list
     public static List<BookingDetails> bookingList=new List<BookingDetails>();
     //Order list
     public static List<OrderDetails> orderList=new List<OrderDetails>();
     static CustomerRegistration currentCustomer=null;
     public static event EventManager eventlink=null;
     public static void Subscribe()
     {
        eventlink+=new EventManager(Files.CreateFiles);
        eventlink+=new EventManager(Files.ReadFiles);
        eventlink+=new EventManager(Operation.MainMenu);
        eventlink+=new EventManager(Files.WriteFiles);
     }
     public static void StartEvent()
     {
        Subscribe();
        eventlink();
     }
    public static void MainMenu()
    {
        

        string choice="yes";
        do
        {
           System.Console.WriteLine("1.Customer Registration\n2.Login\n3.Exit");
         int option=int.Parse(Console.ReadLine());
         switch(option)
         {
            case 1:
            {
                CustomerRegistration();
                break;
            }
            case 2:
            {
                CustomerLogin();
                break;
            }
            case 3:
            {
                System.Console.WriteLine("Exit Main Menu");
                choice="no";
                break;
            }
         }

        }while(choice=="yes");
 
    }
   public  static void CustomerRegistration()
    {
        System.Console.WriteLine("Enter your name:");
        string name=Console.ReadLine();
        System.Console.WriteLine("Enter your Father Name:");
        string fatherName=Console.ReadLine();
        System.Console.WriteLine("Enter Gender:");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine());
        System.Console.WriteLine("Enter Mobile Number:");
        long mobileNumber=long.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Date of birth:");
        DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        System.Console.WriteLine("Enter Mail ID:");
        string mail=Console.ReadLine();
        CustomerRegistration customer=new CustomerRegistration(name,fatherName,gender,mobileNumber,dob,mail,0);
        cutomerList.Add(customer);
        System.Console.WriteLine("Registration Successful!Your Customer ID:"+customer.CustomerID);
    }
    public static void CustomerLogin()
    {
        System.Console.WriteLine("Enter you Customer ID");
        string customerID=Console.ReadLine().ToUpper();
        int flag=0;
        foreach(CustomerRegistration customer in cutomerList)
         {
            if(customerID==customer.CustomerID)
            {
               flag=1;
               currentCustomer=customer;
               System.Console.WriteLine("Login Successfully");
               SubMenu();
            }
            
         }
         if(flag==0)
         {
            System.Console.WriteLine("Invalid Customer ID");
         }
    }
    public static void SubMenu()
    {
        string choice="yes";
        do
        {
           System.Console.WriteLine("1.Show CustomerDetails\n2.Show Product Details\n3.Wallet Recharge\n4.Take Order\n5.Cancel Order\n6.Exit");
        int option=int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                currentCustomer.ShowCustomerDetails();
                break;
            }
            case 2:
            {
                ShowProductDetails();
                break;
            }
            case 3:
            {
                currentCustomer.WalletRecharge();
                break;
            }
            case 4:
            {
                TakeOrder();
                break;
            }
            
            case 5:
            {
                CancelOrder();
                break;
            }
            case 6:
            {
                System.Console.WriteLine("Sub Menu Exit");
                choice="no";
                break;
            }
        }
        }while(choice=="yes");
        
    }
    public static void AddDefaultData()
    {
       CustomerRegistration customer1=new CustomerRegistration("Ravi","Ettaparajan",Gender.Male,9787654321,new DateTime(1999,11,11),"ravi@gmail.com",0);        
         CustomerRegistration customer2=new CustomerRegistration("Baskaran","Sthurajan",Gender.Male,9686654321,new DateTime(1999,11,11),"baskaran@gmail.com",0);

         cutomerList.Add(customer1);
         cutomerList.Add(customer2);
         

         //Product Details Data
         ProductDetails product1=new ProductDetails("Sugar",20,40);        
         ProductDetails product2=new ProductDetails("Rice",100,50);        
         ProductDetails product3=new ProductDetails("Milk",10,40);         
         ProductDetails product4=new ProductDetails("Coffee",10,10);        
         ProductDetails product5=new ProductDetails("Tea",10,10);        
         ProductDetails product6=new ProductDetails("Masala powder",10,20);        
         ProductDetails product7=new ProductDetails("Salt",10,10);        
         ProductDetails product8=new ProductDetails("Turmeric Powder",10,25);
         ProductDetails product9=new ProductDetails("Chilli powder",10,20);
         ProductDetails product10=new ProductDetails("Grounut Oil",10,140);

          productList.Add(product1);
          productList.Add(product2);
          productList.Add(product3);
          productList.Add(product4);
          productList.Add(product5);
          productList.Add(product6);
          productList.Add(product7);
          productList.Add(product8);
          productList.Add(product9);
          productList.Add(product10);

         //Order Details Data
         OrderDetails order1=new OrderDetails("BID3001","PID101",2,80);
         OrderDetails order2=new OrderDetails("BID3001","PID102",2,100);
         OrderDetails order3=new OrderDetails("BID3001","PID103",1,40);
         OrderDetails order4=new OrderDetails("BID3002","PID101",1,40);
         OrderDetails order5=new OrderDetails("BID3002","PID102",4,200);
         OrderDetails order6=new OrderDetails("BID3002","PID110",1,140);
         OrderDetails order7=new OrderDetails("BID3002","PID109",1,20);
         OrderDetails order8=new OrderDetails("BID3003","PID102",2,100);
         OrderDetails order9=new OrderDetails("BID3003","PID108",4,100);
         OrderDetails order10=new OrderDetails("BID3003","PID101",2,80);

         orderList.Add(order1);
         orderList.Add(order2);
         orderList.Add(order3);
         orderList.Add(order4);
         orderList.Add(order5);
         orderList.Add(order6);
         orderList.Add(order7);
         orderList.Add(order8);
         orderList.Add(order9);
         orderList.Add(order10);
         //Booking Details
         BookingDetails booking1=new BookingDetails("CID3001",220,new DateTime(2022,07,26),BookingStatus.Booked);
         BookingDetails booking2=new BookingDetails("CID3002",400,new DateTime(2022,07,26),BookingStatus.Booked);
         BookingDetails booking3=new BookingDetails("CID3001",280,new DateTime(2022,07,26),BookingStatus.Cancelled);
         
        bookingList.Add(booking1);
        bookingList.Add(booking2);
        bookingList.Add(booking3);
    }
    public static void ShowProductDetails()
    {
     System.Console.WriteLine("Product Details.....");
         foreach(ProductDetails product in productList)
         {
            product.ShowProductDetails();
         }
    }
    public static void TakeOrder()
    {
        //Create a booking object
        BookingDetails booking11 =new BookingDetails(currentCustomer.CustomerID,0,DateTime.Now,BookingStatus.Initiated);
        
        //create local order list
        List<OrderDetails> temporderList=new List<OrderDetails>();

        string choice="";
        double totalAmount=0;
        do
        {
          //Show product detail list
           ShowProductDetails();

          //select a product id & check the product id
          System.Console.WriteLine("Select a Product ID from above the list:");
          string productID=Console.ReadLine().ToUpper();
          int flag=0;
          foreach(ProductDetails product in productList)
          {

            if(productID==product.ProductID)
            {
             flag=1;
             //select the quantity & check availablity
             System.Console.WriteLine("Enter Count:");
             int count=int.Parse(Console.ReadLine());

             if(count<=product.QuantityAvailable)
             {
                 //calculate price and compare with customer wallet
                 double amount=count*product.PricePerQuantity;

                 //total price add in  confirm booking;  
                 // totalAmount+=amount;

                 //Take order and repeat
                 OrderDetails order11=new OrderDetails(booking11.BookingID,product.ProductID,count,amount);
                 temporderList.Add(order11);
                 System.Console.WriteLine($"The product Id {product.ProductID} is added to a list");

                 product.QuantityAvailable-=count;
             }
             else
             {
                System.Console.WriteLine("Product count  is not available");
             }

           }
         }
         if(flag==0)
         {
              System.Console.WriteLine("Product is not available");
         }

         System.Console.WriteLine("Do you want to order another product to card Enter (yes/no) ");
         choice=Console.ReadLine();
        }while(choice=="yes");
        
       
        //Temp order list to get total amount
        foreach(OrderDetails temporder in temporderList)
        {
            totalAmount+=temporder.OrderPrice;
        }
        System.Console.WriteLine("Do you want conform your order (yes/no):");
        string choose=Console.ReadLine().ToLower();
       if(choose=="yes")
       {
         string proceed="yes";
         while(proceed=="yes")
         {
            if(totalAmount<=currentCustomer.WalletBalance)
            {
              booking11.TotalPrice=totalAmount;
              booking11.BookingStatus=BookingStatus.Booked;
              bookingList.Add(booking11);
              currentCustomer.WalletBalance-=totalAmount;
              orderList.AddRange(temporderList);
              System.Console.WriteLine("Booking Successful and  your booking ID:"+booking11.BookingID);
              break;
            }
            else
            {
               System.Console.WriteLine("You have Insufficient balance");
               currentCustomer.WalletRecharge();
            }
         }
       }
       else
       {
         foreach(ProductDetails product in productList)
         {
            foreach(OrderDetails temporder in temporderList)
            {
                if(product.ProductID==temporder.ProductID)
                {
                    product.QuantityAvailable+=temporder.PurchaseCount;
                }
            }
         }
       }

    }
   
    public static void CancelOrder()
    {
        foreach(BookingDetails booking in bookingList)
        {
            if(currentCustomer.CustomerID==booking.CustomerID && booking.BookingStatus==BookingStatus.Booked)
            {
                booking.ShowBookingDetails();
            }
        }
        System.Console.WriteLine("Enter Booking Id");
        string bookingID=Console.ReadLine().ToUpper();
        foreach(BookingDetails booking1 in bookingList)
        {
            if(bookingID==booking1.BookingID)
            {
                booking1.BookingStatus=BookingStatus.Cancelled;
                currentCustomer.WalletBalance+=booking1.TotalPrice;
                foreach(OrderDetails order in orderList)
                {
                    if(booking1.BookingID==order.BookingID)
                    {
                        foreach(ProductDetails product in productList)
                        {
                            if(order.ProductID==product.ProductID)
                            {
                                System.Console.WriteLine("Cancelled");
                                product.QuantityAvailable+=order.PurchaseCount;
                            }
                        }
                    }
                }
            }
        }
    }
}
