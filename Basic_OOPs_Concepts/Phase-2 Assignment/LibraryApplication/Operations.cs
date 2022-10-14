using System;
using System.Collections.Generic;
namespace LibraryApplication;

    public static class Operations
    {
        static List<UserDetails> userList=new List<UserDetails>();
        static List<BookDetails> bookList=new List<BookDetails>();
        static List<BorrowDetails> borrowList=new List<BorrowDetails>();
        public static UserDetails CurrentUser=null;
        
        public static void DefaultData()
        {
          UserDetails user1=new UserDetails("Ravichandran",Gender.Male,Department.EEE,9938388333,"ravi@gmail.com",500);
          userList.Add(user1);
          UserDetails user2=new UserDetails("Priyadharshini",Gender.Female,Department.CSE,9944444455,"priya@gmail.com",500);
          userList.Add(user2);
          BookDetails book1=new BookDetails("C#","Author1",3);
          bookList.Add(book1);
          BookDetails book2=new BookDetails("HTML","Author2",5);
          bookList.Add(book2);
          BookDetails book3=new BookDetails("CSS","Author1",3);
          bookList.Add(book3);
          BookDetails book4=new BookDetails("JS","Author1",3);
          bookList.Add(book4);
          BookDetails book5=new BookDetails("TS","Author2",2);
          bookList.Add(book5);
          BorrowDetails borrow1=new BorrowDetails(book1.BookID,user1.RegistrationID,new DateTime(2022,04,10),Status.Issued);
          borrowList.Add(borrow1);
          BorrowDetails borrow2=new BorrowDetails(book3.BookID,user1.RegistrationID,new DateTime(2022,04,12),Status.Returned);
          borrowList.Add(borrow2);
          BorrowDetails borrow3=new BorrowDetails(book4.BookID,user1.RegistrationID,new DateTime(2022,04,15),Status.Issued);
          borrowList.Add(borrow3);
          BorrowDetails borrow4=new BorrowDetails(book2.BookID,user2.RegistrationID,new DateTime(2022,04,11),Status.Returned);
          borrowList.Add(borrow4);
          BorrowDetails borrow5=new BorrowDetails(book5.BookID,user2.RegistrationID,new DateTime(2022,04,15),Status.Issued);
          borrowList.Add(borrow5);
        }
       public static void MainMenu()
       {
            string choice="yes";
            do
            {
                System.Console.WriteLine("Select 1.Registretion 2.Login 3.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Registration Process");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Login Process");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("EXIT!!");
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
           System.Console.WriteLine("Gender:");
           Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
           System.Console.WriteLine("Enter your Department:");
           Department department=Enum.Parse<Department>(Console.ReadLine(),true);
           System.Console.WriteLine("Enter your Mobile Number:");
           long mobileNumber=long.Parse(Console.ReadLine());
           System.Console.WriteLine("Enter Email ID");
           string mail=Console.ReadLine();
           System.Console.WriteLine("Enter Wallet Amount");
           int balance=int.Parse(Console.ReadLine());
           UserDetails user3=new UserDetails(name,gender,department,mobileNumber,mail,balance);
           userList.Add(user3);
           System.Console.WriteLine("Your Registration ID:"+user3.RegistrationID);
       }
       public static void Login()
       {
          System.Console.WriteLine("Enter your Registraion ID:");
          string registrationID=Console.ReadLine();
          foreach(UserDetails user in userList)
          {
            if(registrationID==user.RegistrationID)
            {
                System.Console.WriteLine("Login Successfully");
               CurrentUser=user;
               SubMenu();
            }
          }
       }
     public static void SubMenu()
     {
        string choice="yes";
        do
         {
           System.Console.WriteLine("Select 1.Borrow Book 2.Show Borrowed Book 3.Return Book 4.Exit");
           int option=int.Parse(Console.ReadLine());
           switch(option)
           {
            case 1:
            {
                System.Console.WriteLine("Borrow Book");
                BorrowBook();
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Borrowed book details");
                ShowBorrowedBook();
                break;
            }
            case 3:
            {
                System.Console.WriteLine("Return Books");
                ReturnBook();
                break;
            }
            case 4:
            {
                System.Console.WriteLine("Exit SubMenu");
                choice="no";
                break;
            }
           }
         }while(choice=="yes");
     }
     public static void BorrowBook()
     {
        //show the list of books
        System.Console.WriteLine("------------Book Details-------------");
        foreach(BookDetails book in bookList)
        {
            System.Console.WriteLine(book.BookID+"\t"+book.BookName+"\t"+book.AuthorName+"\t"+book.BookCount);
        }
        //user enter the book id
        System.Console.WriteLine("Enter Book ID to borrow:");
        string bookID=Console.ReadLine();
        //check book count from the booklist
        foreach(BookDetails book1 in bookList)
        {
            if(book1.BookID==bookID)
            {
                if(book1.BookCount>=1)
                {
                   int count=0;
                   foreach(BorrowDetails borrow in borrowList)
                   {
                    if(borrow.RegistrationID==CurrentUser.RegistrationID && borrow.Status==Status.Issued)
                    {
                        count++;
                    }
                   }
                   if(count<3)
                   {
                    BorrowDetails borrow1=new BorrowDetails(book1.BookID,CurrentUser.RegistrationID,DateTime.Now,Status.Issued);
                    borrowList.Add(borrow1);
                    book1.BookCount--;
                    System.Console.WriteLine("The book Issued successfully");
                    System.Console.WriteLine("Your Borrowed Id is "+borrow1.BorrowID);
                    break;
                   }
                   else
                   {
                    System.Console.WriteLine("You already taken 3 books");
                   }
                }
                else
                {
                    System.Console.WriteLine("Books are not available for the selected count");
                    foreach(BorrowDetails borrow in borrowList)
                    {
                        System.Console.WriteLine("The Book will be available on "+borrow.BorrowedDate.AddDays(15));
                    }
                }
            }
        }
     }
     public static void ShowBorrowedBook()
     {
          foreach(BorrowDetails borrow in borrowList)
          {
            if(CurrentUser.RegistrationID==borrow.RegistrationID)
            {
                System.Console.WriteLine("BOOK ID:"+borrow.BookID);
                System.Console.WriteLine("Borrowed Date:"+borrow.BorrowedDate);
                System.Console.WriteLine("Borrow ID:"+borrow.BorrowID);
                System.Console.WriteLine("Registration ID:"+borrow.RegistrationID);
                System.Console.WriteLine("Status:"+borrow.Status);
            }
          }
     }
     public static void ReturnBook()
     {
          foreach(BorrowDetails borrow in borrowList)
          {
            if(CurrentUser.RegistrationID==borrow.RegistrationID)
            {
                DateTime returnDate=borrow.BorrowedDate.AddDays(15);
                TimeSpan variable=DateTime.Now-returnDate;
                int noOfDays=variable.Days;
                System.Console.WriteLine($"Book Id:{borrow.BookID}\nBorrowId:{borrow.BorrowID}\nBorrowed Date:{borrow.BorrowedDate}\nReturn Date:{noOfDays*1}");
                
                if(noOfDays>0)
                {
                   System.Console.WriteLine("Do you want return the book");
                   string option =Console.ReadLine().ToLower();
                   if(option=="yes")
                   {
                    System.Console.WriteLine("Enter borrow Id");
                    string borrowId=Console.ReadLine().ToUpper();
                    if(borrow.BookID==borrowId)
                    {
                    if(borrow.Status==Status.Issued)
                    {
                        System.Console.WriteLine("Return Successfully");
                        foreach(BookDetails book in bookList)
                        {
                            if(borrow.BookID==book.BookID)
                            {
                                book.BookCount++;
                                borrow.Status=Status.Returned;
                                CurrentUser.WalletBalance-=noOfDays;
                            }
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("Book already return");
                    }
                   }
                   }

                }
                else
                {
                    noOfDays=0;
                    System.Console.WriteLine("Do you want return the book");
                   string option =Console.ReadLine().ToLower();
                   if(option=="yes")
                   {
                    System.Console.WriteLine("Enter borrow Id");
                    string borrowId=Console.ReadLine().ToUpper();
                    if(borrow.BookID==borrowId)
                    {
                    if(borrow.Status==Status.Issued)
                    {
                        System.Console.WriteLine("Return Successfully");
                        foreach(BookDetails book in bookList)
                        {
                            if(borrow.BookID==book.BookID)
                            {
                                book.BookCount++;
                                borrow.Status=Status.Returned;
                            }
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("Book already return");
                    }
                   }
                }
            }
          }
          
     }
    }
    }
