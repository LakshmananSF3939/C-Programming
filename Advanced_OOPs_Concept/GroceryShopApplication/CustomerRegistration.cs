using System;

namespace GroceryShopApplication
{
    public class CustomerRegistration:PersonalDetails,IBalance
    {
        private static int s_customerID=1000;
        public string CustomerID { get;  }
        public double WalletBalance { get; set; }
        public CustomerRegistration(string name,string fatherName,Gender gender,long number,DateTime dob,string mail,double balance):base( name, fatherName, gender, number, dob, mail)
        {
               s_customerID++;
               CustomerID="CID"+s_customerID;
               WalletBalance=balance;
               
        }
        public CustomerRegistration(string data)
        {
            string[] values=data.Split(',');
            s_customerID=int.Parse(values[0].Remove(0,3));
            CustomerID=values[0];
            Name=values[1];
            FatherName=values[2];
            Gender=Enum.Parse<Gender>(values[3]);
            MobileNumber=long.Parse(values[4]);
            DOB=DateTime.ParseExact(values[5],"dd/MM/yyyy",null);
            MailID=values[6];
            WalletBalance=double.Parse(values[7]);
        }
        public void ShowCustomerDetails()
        {

             System.Console.WriteLine("Customer ID:"+CustomerID);
             System.Console.WriteLine("WalletBalance:"+WalletBalance);
             System.Console.WriteLine("Name:"+Name);
             System.Console.WriteLine("Father name:"+FatherName);
             System.Console.WriteLine("Gender:"+Gender);
             System.Console.WriteLine("Mobile Number:"+MobileNumber);
             System.Console.WriteLine("Date Of Birth:"+DOB.ToShortDateString());
             System.Console.WriteLine("Mail ID:"+MailID);
        }
        public void WalletRecharge()
        {
            System.Console.WriteLine("Do you want recharge your Balance yes/no");
            string choice=Console.ReadLine().ToLower();
            if(choice=="yes")
            {
                System.Console.WriteLine("Enter Amount");
                double amount=double.Parse(Console.ReadLine());

                WalletBalance+=amount;
                System.Console.WriteLine("Your Wallet Balance:"+WalletBalance);
            }
        }
    }
}
