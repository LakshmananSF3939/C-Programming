using System;
using System.IO;
namespace MovieTicketBooking;

    public static class Files
    {
        public static void CreateFiles()
        {
            if(!Directory.Exists("TicketBookingApp"))
            {
                System.Console.WriteLine("Folder Created...");
                Directory.CreateDirectory("TicketBookingApp");
            }

            if(!File.Exists("TicketBookingApp/UserDetails.csv"))
            {
                System.Console.WriteLine("File Created...");
                File.Create("TicketBookingApp/UserDetails.csv");
            }

            if(!File.Exists("TicketBookingApp/TheatreDetails.csv"))
            {
                System.Console.WriteLine("File Created...");
                File.Create("TicketBookingApp/TheatreDetails.csv");
            }

            if(!File.Exists("TicketBookingApp/MovieDetails.csv"))
            {
                System.Console.WriteLine("File Created...");
                File.Create("TicketBookingApp/MovieDetails.csv");
            }
            if(!File.Exists("TicketBookingApp/ScreeningDetails.csv"))
            {
                System.Console.WriteLine("File Created");
                File.Create("TicketBookingApp/ScreeningDetails.csv");
            }
            if(!File.Exists("TicketBookingApp/BookingDetails.csv"))
            {
                System.Console.WriteLine("File Created");
                File.Create("TicketBookingApp/BookingDetails.csv");
            }
        }
        public static void ReadFiles()
        {
            string[] user=File.ReadAllLines("TicketBookingApp/UserDetails.csv");
            foreach(string data in user)
            {
                UserDetails user1=new UserDetails(data);
                Operations.userList.Add(user1);
            }

            string[] theatre=File.ReadAllLines("TicketBookingApp/TheatreDetails.csv");
            foreach(string data in theatre)
            {
                TheatreDetails theatre1=new TheatreDetails(data);
                Operations.theatreList.Add(theatre1);
            }

            string[] movie=File.ReadAllLines("TicketBookingApp/MovieDetails.csv");
            foreach(string data in movie)
            {
                MovieDetails movie1=new MovieDetails(data);
                Operations.movieList.Add(movie1);
            }

            string[] screen=File.ReadAllLines("TicketBookingApp/ScreeningDetails.csv");
            foreach(string data in screen)
            {
                ScreeningDetails screen1=new ScreeningDetails(data);
                Operations.screenList.Add(screen1);
            }

            string[] booking=File.ReadAllLines("TicketBookingApp/BookingDetails.csv");
            foreach(string data in booking)
            {
                BookingDetails booking1=new BookingDetails(data);
                Operations.bookingList.Add(booking1);
            }
        }
        public static void WriteFiles()
        {
            string[] userDetail=new string[Operations.userList.Count];
            for(int i=0;i<Operations.userList.Count;i++)
            {
                userDetail[i]=Operations.userList[i].UserID+","+Operations.userList[i].Name+","+Operations.userList[i].Age+","+Operations.userList[i].MobileNumber+","+Operations.userList[i].WalletBalance;
            }
            File.WriteAllLines("TicketBookingApp/UserDetails.csv",userDetail);

            string[] theatreDetail=new string[Operations.theatreList.Count];
            for(int i=0;i<Operations.theatreList.Count;i++)
            {
                theatreDetail[i]=Operations.theatreList[i].TheatreID+","+Operations.theatreList[i].TheatreName+","+Operations.theatreList[i].Location;
            }
            File.WriteAllLines("TicketBookingApp/TheatreDetails.csv",theatreDetail);

            string[] movieDetail=new string[Operations.movieList.Count];
            for(int i=0;i<Operations.movieList.Count;i++)
            {
                movieDetail[i]=Operations.movieList[i].MoviesID+","+Operations.movieList[i].MovieName+","+Operations.movieList[i].Language;
            }
            File.WriteAllLines("TicketBookingApp/MovieDetails.csv",movieDetail);

            string[] screenDetail=new string[Operations.screenList.Count];
            for(int i=0;i<Operations.screenList.Count;i++)
            {
                screenDetail[i]=Operations.screenList[i].MoviesID+","+Operations.screenList[i].TheatreID+","+Operations.screenList[i].NoOfSeatsAvailable+","+Operations.screenList[i].TicketPrice;
            }
            File.WriteAllLines("TicketBookingApp/ScreeningDetails.csv",screenDetail);

            string[] bookingDetail=new string[Operations.bookingList.Count];
            for(int i=0;i<Operations.bookingList.Count;i++)
            {
                bookingDetail[i]=Operations.bookingList[i].BookingID+","+Operations.bookingList[i].UserID+","+Operations.bookingList[i].MoviesID+","+Operations.bookingList[i].TheatreID+","+Operations.bookingList[i].SeatCount+","+Operations.bookingList[i].TotalAmount+","+Operations.bookingList[i].BookingStatus;
            }
            File.WriteAllLines("TicketBookingApp/BookingDetails.csv",bookingDetail);
        }
    }

