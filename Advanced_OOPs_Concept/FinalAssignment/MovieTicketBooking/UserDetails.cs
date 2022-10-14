using System;

namespace MovieTicketBooking
{
    public class UserDetails:PersonalDetails,IWallet
    {
        /// <summary>
        /// Represent as Create user Id
        /// </summary>
        private static int s_userID=1000;
        /// <summary>
        /// Represent as String format user id
        /// </summary>
        /// <value></value>
        public string UserID { get; set; }

        /// <summary>
        /// Represent as User Wallet balance
        /// </summary>
        /// <value></value>
        public double WalletBalance{ get; set; }
        /// <summary>
        /// This is user details contructor and save the values in property
        /// </summary>
        /// <param name="name">user name</param>
        /// <param name="age">user age</param>
        /// <param name="number">user mobile number</param>
        /// <param name="balance">adding wallet balance</param>
        /// <returns></returns>

        public UserDetails(string name,int age,long number,double balance):base( name, age, number)
        {
          s_userID++;
          UserID="UID"+s_userID;
          WalletBalance=balance;
        }
        /// <summary>
        /// This is file manupulation constructor
        /// </summary>
        /// <param name="data"></param>

        public UserDetails(string data)
        {
           string[] values=data.Split(',');
           s_userID=int.Parse(values[0].Remove(0,3));
           UserID=values[0];
           Name=values[1];
           Age=int.Parse(values[2]);
           MobileNumber=long.Parse(values[3]);
           WalletBalance=double.Parse(values[4]);
        }
        /// <summary>
        /// Rechage balance using this method
        /// </summary>
       public void WalletRecharge()
       {
           System.Console.WriteLine("Do you want recharge your Wallet Balance");
           string choice=Console.ReadLine();
           if(choice=="yes")
           {
            System.Console.WriteLine("Enter Amount");
            double amount=double.Parse(Console.ReadLine());
            WalletBalance+=amount;
           }
       } 
    }
}
