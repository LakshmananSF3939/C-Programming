using System;
using System.Collections.Generic;

namespace MovieTicketBooking;

//using Deligates
public delegate void EventManager();

    public static class Operations
    {
       //User list
       public static List<UserDetails> userList=new List<UserDetails>();
       //Theatre List
       public static List<TheatreDetails> theatreList=new List<TheatreDetails>();
       //Movie List
       public static List<MovieDetails> movieList=new List<MovieDetails>();
       //Screening list
       public static List<ScreeningDetails> screenList=new List<ScreeningDetails>();
       //Booking List
       public static List<BookingDetails> bookingList=new List<BookingDetails>();

       //current user
       static UserDetails currentUser=null;
       //Events
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
       public static void DefaultData()
       {
        //User Default Details
        UserDetails user1=new UserDetails("RaviChandran",30,8599488003,1000);
        UserDetails user2=new UserDetails("Baskaran",30,9857747327,2000);
        userList.Add(user1);
        userList.Add(user2);

        //Theatr Default Details
        TheatreDetails theatre1=new TheatreDetails("Inox","AnnaNagar");
        TheatreDetails theatre2=new TheatreDetails("Ega Theatre","Chetpet");
        TheatreDetails theatre3=new TheatreDetails("Kamala","VadaPalani");
        theatreList.Add(theatre1);
        theatreList.Add(theatre2);
        theatreList.Add(theatre3);

        //Movie Default Details
        MovieDetails movie1=new MovieDetails("Bahubali","Telugu");
        MovieDetails movie2=new MovieDetails("PonniyinSelvan","Tamil");
        MovieDetails movie3=new MovieDetails("Cobra","Tamil");
        MovieDetails movie4=new MovieDetails("Vikram","Hindi");
        MovieDetails movie5=new MovieDetails("Vikram","Tamil");
        MovieDetails movie6=new MovieDetails("Beast","English");
        movieList.Add(movie1);
        movieList.Add(movie2);
        movieList.Add(movie3);
        movieList.Add(movie4);
        movieList.Add(movie5);
        movieList.Add(movie6);

        //Screening  Default Details
        ScreeningDetails screen1=new ScreeningDetails("MID501","TID301",5,200);
        ScreeningDetails screen2=new ScreeningDetails("MID502","TID301",2,300);
        ScreeningDetails screen3=new ScreeningDetails("MID506","TID301",1,50);
        ScreeningDetails screen4=new ScreeningDetails("MID501","TID302",11,400);
        ScreeningDetails screen5=new ScreeningDetails("MID502","TID302",20,300);
        ScreeningDetails screen6=new ScreeningDetails("MID504","TID302",2,500);
        ScreeningDetails screen7=new ScreeningDetails("MID505","TID303",11,100);
        ScreeningDetails screen8=new ScreeningDetails("MID502","TID303",21,200);
        ScreeningDetails screen9=new ScreeningDetails("MID504","TID303",2,350);
        screenList.Add(screen1);
        screenList.Add(screen2);
        screenList.Add(screen3);
        screenList.Add(screen4);
        screenList.Add(screen5);
        screenList.Add(screen6);
        screenList.Add(screen7);
        screenList.Add(screen8);
        screenList.Add(screen9);

        //Booking Default data
        BookingDetails book1=new BookingDetails("UID1001","MID501","TID301",1,200,BookingStatus.Booked);
        BookingDetails book2=new BookingDetails("UID1001","MID504","TID302",1,400,BookingStatus.Booked);
        BookingDetails book3=new BookingDetails("UID1002","MID505","TID302",1,300,BookingStatus.Booked);
        bookingList.Add(book1);
        bookingList.Add(book2);
        bookingList.Add(book3);
       }

        public static void MainMenu()
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("1.Registration\n2.Login\n3.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        Registration();
                        break;
                    }
                     case 2:
                    {
                        Login();
                        break;
                    }
                     case 3:
                    {
                        System.Console.WriteLine("EXIT MainMenu");
                        choice="no";
                        break;
                    }
                    default:
                    {
                        System.Console.WriteLine(".......Invalid Option......");
                        break;
                    }
                }
 
            }while(choice=="yes");
        }
        public static void Registration()
        {
           // Collecting user details

           System.Console.WriteLine("Enter your name:");
           string name=Console.ReadLine();
           System.Console.WriteLine("Enter you Age:");
           int age=int.Parse(Console.ReadLine());
           System.Console.WriteLine("Enter your PhoneNumber:");
           long number=long.Parse(Console.ReadLine());
           System.Console.WriteLine("Enter Wallet Balance:");
           double balance=double.Parse(Console.ReadLine());
           UserDetails user=new UserDetails(name,age,number,balance);
           userList.Add(user);
           System.Console.WriteLine("Your Registration successfull & your User ID:"+user.UserID);
        }
        public static void Login()
        {
            System.Console.WriteLine("Enter your User ID:");
            string userID=Console.ReadLine().ToUpper();
            int flag=0;
            foreach(UserDetails user in userList)
            {
                if(userID==user.UserID)
                {
                   currentUser=user;
                   System.Console.WriteLine("Login Succesully");
                   flag=1;
                   SubMenu();
                }
            }
            if(flag==0)
            {
                System.Console.WriteLine(".....Invalid user ID.....");
            }
        }
        public static void SubMenu()
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("a.Ticket Booking\nb.Ticket Cancelling\nc.Booking History\nd.Wallet Recharge\ne.Exit");
                char option=char.Parse(Console.ReadLine());
                switch(option)
                {
                    case 'a':
                    {
                        TicketBooking();
                        break;
                    }
                    case 'b':
                    {
                        TicketCancelling();
                        break;
                    }
                    case 'c':
                    {
                        BookingHistory();
                        break;
                    }
                    case 'd':
                    {
                        currentUser.WalletRecharge();
                        break;
                    }
                    case 'e':
                    {
                        System.Console.WriteLine("<<<EXIT Sub Menu>>>");
                        choice="no";
                        break;
                    }
                    default:
                    {
                        System.Console.WriteLine("..........In valid option.........");
                        break;
                    }
                }
            }while(choice=="yes");
        }
        public static void TicketBooking()
        {
           //show the theatre list
           System.Console.WriteLine("TheatreID       TheatreName        TheatreLocation");
           foreach(TheatreDetails theatre in theatreList)
           {
            System.Console.WriteLine(theatre.TheatreID+"\t\t"+theatre.TheatreName+"\t\t"+theatre.Location);
           }

           //user select theatre id
           
           System.Console.WriteLine("select Theatre ID:");
           string theatreID=Console.ReadLine().ToUpper();
           
           int flag1=0;
           //Movies screening shows
          // System.Console.WriteLine("MovieID    TheatreID   seats   PricePerTicket");
           foreach(ScreeningDetails screen in screenList)
           {
            if(theatreID==screen.TheatreID)
            {
              System.Console.WriteLine(screen.MoviesID+"\t\t"+screen.TheatreID+"\t\t"+screen.NoOfSeatsAvailable+"\t\t"+screen.TicketPrice);
              flag1=1;
            }
           }
           
           if(flag1==1)
           {
           //select movie id in that screening list
           System.Console.WriteLine("Select Movie ID:");
           string movieID=Console.ReadLine().ToUpper();

           
           //If the required count is not available in the Theatre seat availability, then show like 
           //“Required Seat count not available.
           int flag=0;
           foreach(ScreeningDetails screening in screenList)
           {
            if(theatreID==screening.TheatreID && movieID==screening.MoviesID)
            {
                //Ask count of seat
                System.Console.WriteLine("How many ticket you want?");
                int count=int.Parse(Console.ReadLine());

                if(count<=screening.NoOfSeatsAvailable)
                {
                   flag=1;
                    //seat avilable and calculate total amount
                    double amount=(count*screening.TicketPrice)+(0.18*screening.TicketPrice);

                    //compare total amount with wallet balance
                    if(currentUser.WalletBalance>=amount)
                    {
                      // Deduct the total amount from the wallet balance of the current logged in user.
                      currentUser.WalletBalance-=amount;

                      // Deduct the count from the seat availability of the movie 
                      screening.NoOfSeatsAvailable-=count;
                      System.Console.WriteLine("Booking Succesful");
                      BookingDetails booking =new BookingDetails(currentUser.UserID,screening.MoviesID,screening.TheatreID,count,amount,BookingStatus.Booked);
                      bookingList.Add(booking);
                    }
                    else
                    {
                        System.Console.WriteLine("Wallet balance is Insufficient \nPlease recharge Your Wallet");
                    }
                    
                }
            }
           }
           if(flag==0)
           {
            System.Console.WriteLine("Required Seat count not available");
           }
           }
           else
           {
            System.Console.WriteLine("......Invalid Theatre ID......");
           }
        
        }
        public static void TicketCancelling()
        {
         //show booking histry of current user
         foreach(BookingDetails booking in bookingList)
         {
            if(currentUser.UserID==booking.UserID)
            {
                System.Console.WriteLine("Booking ID:"+booking.BookingID);
                System.Console.WriteLine("User ID:"+booking.UserID);
                System.Console.WriteLine("Movie ID:"+booking.MoviesID);
                System.Console.WriteLine("Theatre ID:"+booking.TheatreID);
                System.Console.WriteLine("Seat Count:"+booking.SeatCount);
                System.Console.WriteLine("Total Amount:"+booking.TotalAmount);
                System.Console.WriteLine("Booking Status:"+booking.BookingStatus);
            }
         }

         //select booking id u want to cancel
         System.Console.WriteLine("Select Booking ID:");
         string bookingID=Console.ReadLine().ToUpper();
         int flag=0;
         //check booking status is booked
         foreach(BookingDetails booking in bookingList)
         {
            if(currentUser.UserID==booking.UserID && booking.BookingStatus==BookingStatus.Booked)
            {
               if(bookingID==booking.BookingID)
               {
                  flag=1;
                  foreach(ScreeningDetails screen in screenList)
                  {
                     //get the count and add to the movie list
                     if(booking.MoviesID==screen.MoviesID && screen.TheatreID==booking.TheatreID)
                     {
                       screen.NoOfSeatsAvailable+=booking.SeatCount;
                     
                       //20 rs reduce and add wallet balance
                       currentUser.WalletBalance+=booking.TotalAmount-20;

                       //change the booking status is cancelled
                       booking.BookingStatus=BookingStatus.Cancelled;
                       System.Console.WriteLine("Your Booking Cancelled is successfully");

                    }
                  } 
                }
            }
         }
         if(flag==0)
         {
           System.Console.WriteLine("..........Invalid Booking Id.......");
         }

        }
        public static void BookingHistory()
        {
            System.Console.WriteLine("Booking History...");
            foreach(BookingDetails booking in bookingList)
            {
                if(currentUser.UserID==booking.UserID)
                {
                    System.Console.WriteLine("Booking ID:"+booking.BookingID);
                    System.Console.WriteLine("User ID:"+booking.UserID);
                    System.Console.WriteLine("Movie ID:"+booking.MoviesID);
                    System.Console.WriteLine("Theatre ID:"+booking.TheatreID);
                    System.Console.WriteLine("Seat Count:"+booking.SeatCount);
                    System.Console.WriteLine("Total Amount:"+booking.TotalAmount);
                    System.Console.WriteLine("Booking Status:"+booking.BookingStatus);
                }
            }
        }
        
    }

