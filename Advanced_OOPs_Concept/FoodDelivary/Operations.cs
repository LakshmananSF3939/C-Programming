using System;

namespace FoodDelivary
{
    public delegate void EventManager();
    public static partial class Operations
    {
        public static List<RegistrationDetails> registerList=new List<RegistrationDetails>();
        public static List<FoodDetails> foodList=new List<FoodDetails>();
        public static List<BookingDetails> bookingList=new List<BookingDetails>();
        public static List<OrderDetails> orderList=new List<OrderDetails>();
        public static RegistrationDetails CurrentCustomer=null;
        public static event EventManager eventLink=null;
        public static void SubsCribe()
        {
            eventLink+=new EventManager(Files.CreateFiles);
            eventLink+=new EventManager(Files.ReadFiles);
            eventLink+=new EventManager(Operations.MainMenu);
            eventLink+=new EventManager(Files.WriteFiles);
        }
        public static void StartEvent()
        {
            SubsCribe();
            eventLink();
        }
        public static void MainMenu()
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("Select 1.Registration 2.Login 3.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Registration");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Login");
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
            System.Console.WriteLine("Enter your Name:");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your Father Name:");
            string fatherName=Console.ReadLine();
            System.Console.WriteLine("Gender:");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine());
            System.Console.WriteLine("Mobile No");
            long mobile=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Date Of Birth:");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("Mail ID:");
            string mail=Console.ReadLine();
            System.Console.WriteLine("Enter Location:");
            string location=Console.ReadLine();
            System.Console.WriteLine(" Enter Wallet Balance:");
            int walletBalance=int.Parse(Console.ReadLine());
            RegistrationDetails register=new RegistrationDetails(name,fatherName,gender,mobile,dob,mail,location,walletBalance);
            registerList.AddElement(register);
            System.Console.WriteLine("Your CustomerId:"+register.CustomerID);
        }
        public static void Login()
        {
            System.Console.WriteLine("Enter CustomerID:");
            string customerID=Console.ReadLine();
            foreach(RegistrationDetails register in registerList)
            {
                if(register.CustomerID==customerID)
                {
                   CurrentCustomer=register;
                   System.Console.WriteLine("Login Successfull");
                   SubMenu();
                }
            }
        }
        public static void SubMenu()
        {
            string choice="yes";
            do
            {
              System.Console.WriteLine("Select 1.Show food item Details 2.Order Food 3.Cancel Booking 4.Order History 5.Wallet Recharge 6.Exit");
              int option=int.Parse(Console.ReadLine());
              switch(option)
              {
                case 1:
                {
                    System.Console.WriteLine("Show food details");
                    ShowFoodItemDetails();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Order Food");
                    OrderFood();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Cancel Order");
                    CancelBooking();
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("Order History");
                    OrderHistory();
                    break;
                }
                case 5:
                {
                    System.Console.WriteLine("Wallet Recharge");
                    CurrentCustomer.WalletRecharge();
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
        public static void ShowFoodItemDetails()
        {
            foreach(FoodDetails food in foodList)
            {
                System.Console.WriteLine(food.FoodID+"\t"+food.FoodName+"\t"+food.PricePerQuantity);
            }
        }
    }
}

