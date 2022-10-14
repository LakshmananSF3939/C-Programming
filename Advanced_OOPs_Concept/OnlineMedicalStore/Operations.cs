using System;

namespace OnlineMedicalStore;

    public static class Operations
    {
      public static List<UserDetails> userList=new List<UserDetails>();
      
      public static List<MedicineDetails> medicineList=new List<MedicineDetails>();
      public static List<OrderDetails> orderList=new List<OrderDetails>();  
      public static UserDetails CurrentUser=null;
      public static void MainMenu()
      {
        string choice="yes";
        do
        {
          System.Console.WriteLine("Select 1.Registration 2.Login 3.Order History 4.Exit");
          int option=int.Parse(Console.ReadLine());
          switch(option)
          {
            case 1:
            {
              System.Console.WriteLine("--------------Registration---------------");
              Registration();
              break;
            }
            case 2:
            {
              System.Console.WriteLine("---------------Login----------------");
              Login();
              break;
            }
            case 3:
            {
              System.Console.WriteLine("---------------Order History---------------");
              OrderHisory();
              break;
            }
            case 4:
            {
              System.Console.WriteLine("---------------EXIT-----------------------");
              choice="no";
              break;
            }
          }
        }while(choice=="yes");
      }
      public static void Registration()
      {
        System.Console.WriteLine("Enter Your Name:");
        string name=Console.ReadLine();
        System.Console.WriteLine();
        System.Console.WriteLine("Enter Your Age:");
        int age=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter City:");
        string city=Console.ReadLine();
        System.Console.WriteLine("Enter your Phone Number:");
        long Phone=long.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Balance:");
        double balance=double.Parse(Console.ReadLine());
        UserDetails user=new UserDetails(name,age,city,Phone,balance);
        userList.AddElement(user);
        System.Console.WriteLine("Your User ID:"+user.UserID);
      }
      public static void Login()
      {
        System.Console.WriteLine("Enter your User Id:");
        string userID=Console.ReadLine();
        int flag=0;
        foreach (UserDetails user in userList)
        {
          if(userID==user.UserID)
          {
            System.Console.WriteLine("Login Successfull");
             CurrentUser=user;
             SubMenu();
             flag=1;
          }
        }
        if(flag==0)
        {
          System.Console.WriteLine("Invalid user ID");
        }
      }
      public static void OrderHisory()
      {
        foreach(OrderDetails order in orderList)
        {
          System.Console.WriteLine("Order ID:"+order.OrderID);
          System.Console.WriteLine("UserID:"+order.UserID);
          System.Console.WriteLine("Medicine ID:"+order.MedicineID);
          System.Console.WriteLine("Medicine Count:"+order.MedicineCount);
          System.Console.WriteLine("Medicine Total Price:"+order.TotalPrice);
          System.Console.WriteLine("Order Date:"+order.OrderDate);
          System.Console.WriteLine("Order Status:"+order.OrderStatus);
          System.Console.WriteLine();
        }
      }
      public static void SubMenu()
      {
        string choice="yes";
        do
        {
          System.Console.WriteLine("Select 1.Show MedicineList 2.Purchase Medicine 3.Cancel Purchase 4.Show Purchase History 5.Recharge 6.Exit");
          int option=int.Parse(Console.ReadLine());
          switch(option)
          {
            case 1:
            {
              System.Console.WriteLine("Show Medicine List");
              ShowMedicineList();
              break;
            }
            case 2:
            {
              System.Console.WriteLine("Purchase Medicine");
              PurchaseMedicine();
              break;
            }
            case 3:
            {
              System.Console.WriteLine("Cancel Purchase");
              CancelOrder();
              break;
            }
            case 4:
            {
              System.Console.WriteLine("Show Purchase Histry");
              ShowPurchaseDetails();
              break;
            }
            case 5:
            {
              System.Console.WriteLine("Recharge Balance");
              Recharge();
              break;
            }
            case 6:
            {
              System.Console.WriteLine("EXIT");
              choice="no";
              break;
            }
          }
        }while(choice=="yes");
      }
      public static void ShowMedicineList()
      {
          foreach(MedicineDetails medicine in medicineList)
          {
            System.Console.Write($"{medicine.MedicineID}\t");
            System.Console.Write($"{medicine.MedicineName}\t\t");
            System.Console.Write($"{medicine.AvailableCount}\t\t");
            System.Console.Write($"{medicine.Price}\t\t");
            System.Console.Write($"{medicine.DateOfExpiry.ToShortDateString()}");
            System.Console.WriteLine();
          }
      }
      public static void PurchaseMedicine()
      {
        System.Console.WriteLine("Medine List");
        foreach(MedicineDetails medicine in medicineList)
          {
            System.Console.Write($"{medicine.MedicineID}\t");
            System.Console.Write($"{medicine.MedicineName}\t\t");
            System.Console.Write($"{medicine.AvailableCount}\t\t");
            System.Console.Write($"{medicine.Price}\t\t");
            System.Console.Write($"{medicine.DateOfExpiry.ToShortDateString()}");
            System.Console.WriteLine();
          }
        System.Console.WriteLine("Enter the medicine Id :");
        string medicineID=Console.ReadLine();
        System.Console.WriteLine("Enter Count of Medicine ypu want to buy:");
        int count=int.Parse(Console.ReadLine());
        foreach(MedicineDetails medicine1 in medicineList)
        {
          if(medicine1.MedicineID==medicineID && medicine1.AvailableCount>=count)
          {
            if(medicine1.Price*count<=CurrentUser.Balance)
            {
               
               if(DateTime.Compare(medicine1.DateOfExpiry,DateTime.Now)>0)
               {
                int totalPrice=medicine1.Price*count;
                CurrentUser.Balance-=totalPrice;
                medicine1.AvailableCount-=count;
                OrderDetails order=new OrderDetails(CurrentUser.UserID,medicine1.MedicineID,count,totalPrice,DateTime.Now,OrderStatus.Purchased);
                orderList.AddElement(order);
                System.Console.WriteLine("Purchased Successfully!!");
               }
            }
          }
        }
      }  
      public static void CancelOrder()
      {
        System.Console.WriteLine("User Purchased Details:");
        foreach(OrderDetails order in orderList)
        {
          if(CurrentUser.UserID==order.UserID && order.OrderStatus==OrderStatus.Purchased)
          {
          System.Console.WriteLine("Order ID:"+order.OrderID);
          System.Console.WriteLine("UserID:"+order.UserID);
          System.Console.WriteLine("Medicine ID:"+order.MedicineID);
          System.Console.WriteLine("Medicine Count:"+order.MedicineCount);
          System.Console.WriteLine("Medicine Total Price:"+order.TotalPrice);
          System.Console.WriteLine("Order Date:"+order.OrderDate);
          System.Console.WriteLine("Order Status:"+order.OrderStatus);
          System.Console.WriteLine();
          }
        }
          System.Console.WriteLine(" Say your Order ID:");
          string orderID=Console.ReadLine();
        foreach(OrderDetails order in orderList)
        {
          
          if(order.OrderID==orderID && order.OrderStatus==OrderStatus.Purchased)
          {
            foreach(MedicineDetails medicine in medicineList)
            {
              if(order.MedicineID==medicine.MedicineID)
              {
                medicine.AvailableCount+=order.MedicineCount;
                CurrentUser.Balance+=order.TotalPrice;
                order.OrderStatus=OrderStatus.Cancelled;
                System.Console.WriteLine(order.OrderID+" is Cancelled Successfully");
              }
            }
          }
        }
      }
      public static void ShowPurchaseDetails()
      {
        System.Console.WriteLine("User Purchased Details:");
        foreach(OrderDetails order in orderList)
        {
          if(CurrentUser.UserID==order.UserID )
          {
          System.Console.WriteLine("Order ID:"+order.OrderID);
          System.Console.WriteLine("UserID:"+order.UserID);
          System.Console.WriteLine("Medicine ID:"+order.MedicineID);
          System.Console.WriteLine("Medicine Count:"+order.MedicineCount);
          System.Console.WriteLine("Medicine Total Price:"+order.TotalPrice);
          System.Console.WriteLine("Order Date:"+order.OrderDate);
          System.Console.WriteLine("Order Status:"+order.OrderStatus);
          System.Console.WriteLine();
          }
        }
      }
      public static void Recharge()
      {
        System.Console.WriteLine("Do you want to recharge your balance yes/no:");
        string choice=Console.ReadLine();
        if(choice=="yes")
        {
           double balance=double.Parse(Console.ReadLine());
           CurrentUser.Balance+=balance;
        }
        else
        {
          System.Console.WriteLine("Ok");
        }
      }
    }

