using System;

namespace Question2
{
    public class AccountInfo:PersonalInfo
    {
        private static int s_accountNumber=1000;
        public string AccountNumber { get; set; }
        public string BranchName { get; set; }
        public string IFSCCode { get; set; }
        public int Balance { get; set; }
        public AccountInfo(string name,string fatherName,long mobile,string mail,DateTime dob,string branch,string ifsc,int balance):base( name, fatherName, mobile, mail, dob)
        {
            s_accountNumber++;
            AccountNumber="AID"+s_accountNumber;
            BranchName=branch;
            IFSCCode=ifsc;
            Balance=balance;
        }
        public void ShowDetails()
        {
            Show();
            System.Console.WriteLine("Account Number:"+AccountNumber);
            System.Console.WriteLine("Branch:"+BranchName);
            System.Console.WriteLine("IFSC:"+IFSCCode);
            System.Console.WriteLine("Balance:"+Balance);
        }
    }
}
