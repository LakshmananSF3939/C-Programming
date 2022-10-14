using System;

namespace MultipleInheritance
{
    public class CustomerDetails:PersonalDetails
    {
        private static int s_customerID=1000;
        public string CustomerID { get; set; }
        public double Balance { get; set; }
        public CustomerDetails(string aadharID,string name,string fatherName,Gender gender,long mobile):base( aadharID, name, fatherName, gender, mobile)
        {
            s_customerID++;
            CustomerID="CID"+s_customerID;
        }
        public void Recharge()
        {
            System.Console.WriteLine("Enter amount to recharge");
            Balance+=double.Parse(Console.ReadLine());
        }
        public void ShowCustomerDetails()
        {
            System.Console.WriteLine("Cutomer ID\t:"+CustomerID);
            ShowDetails();
            System.Console.WriteLine("Balance\t:"+Balance);
        }
    }
}
