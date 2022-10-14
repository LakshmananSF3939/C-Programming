using System;

namespace FoodDelivary
{
    public class RegistrationDetails:PersonalDetails,IBalance
    {
        private static int s_customerID=1000;
        public string CustomerID { get; set; }
        public int WalletBalance { get; set; }
        public RegistrationDetails(string name,string fatherName,Gender gender,long phoneNumber,DateTime dob,string mail,string location,int walletBalance):base( name, fatherName, gender, phoneNumber, dob, mail, location)
        {
            Name=name;
            s_customerID++;
            CustomerID="CID"+s_customerID;
            WalletBalance=walletBalance;
        }
       
        public RegistrationDetails(string data)
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
            Location=values[7];
            WalletBalance=int.Parse(values[8]);

        }
        
        public void WalletRecharge()
        {
            System.Console.WriteLine("Do you want recharge your wallet balance yes/no");
            string choice=Console.ReadLine();
            if(choice=="yes")
            {
                System.Console.WriteLine("Enter Amount :");
                int Amount=int.Parse(Console.ReadLine());
                WalletBalance+=Amount;
            }
        }
    }
}
