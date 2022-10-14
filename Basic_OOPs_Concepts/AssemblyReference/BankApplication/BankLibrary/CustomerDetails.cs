using System;
using System.Collections.Generic;
namespace BankLibrary
{
  public enum Gender{Default,Male,Female,TransGender}
  public enum AccountType{Default,FD,SB,RD}
    public class CustomerDetails
    {
        private static int s_accountNumber=1000;
        public string AccountNumber { get;  }
        
        
        public string Name { get; set; }

        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        
        public DateTime DOB { get; set; }
        
        public AccountType AccountType { get; set; }
        
        public double Balance { get; set; }
        
        
        public CustomerDetails(string name,string fathername,DateTime dob,Gender gender,AccountType accountType,double balance)
        {
          s_accountNumber++;
          AccountNumber="HDFC"+s_accountNumber;
          Name=name;
          FatherName=fathername;
          DOB=dob;
          Gender=gender;
          AccountType=accountType;
          Balance=balance;
        }
        public void Deposit()
        {
          System.Console.WriteLine("Enter Deposit money:");
          double deposit=double.Parse(Console.ReadLine()); 
          Balance+=deposit;
        }
        public void WithDraw()
        {
          System.Console.WriteLine("Enter your withdraw anount:");

          Balance-=double.Parse(Console.ReadLine());
        }
        public void BalanceShow()
        {
          
          
            System.Console.WriteLine("Your Bank Balance:"+Balance);
          
        }
    }
}
