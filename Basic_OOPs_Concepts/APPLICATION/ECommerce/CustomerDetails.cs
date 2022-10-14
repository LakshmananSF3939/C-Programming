using System;

namespace ECommerce
{
    public class CustomerDetails
    {
        private static int s_customerID=1000;
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string City { get; set; }
        public long MobileNumber { get; set; }
        public double WalletBalance { get; set; }
        public string EmailId { get; set; }
        public CustomerDetails(string name,string city,long mobile,double balance,string email)
        {
            s_customerID++;
            CustomerID="CID"+s_customerID;
            CustomerName=name;
            City=city;
            MobileNumber=mobile;
            WalletBalance=balance;
            EmailId=email;
        }
        public CustomerDetails(string data)
        {
            string[] values=data.Split(',');
            s_customerID=int.Parse(values[0].Remove(0,3));
            CustomerID=values[0];
            CustomerName=values[1];
            City=values[2];
            MobileNumber=int.Parse(values[3]);
            WalletBalance=double.Parse(values[4]);
            EmailId=values[5];
        }
    }
}
