using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        AccountInfo account=new AccountInfo("Lakshmanan","ganesan",9876543210,"abc@gmail.com",new DateTime(2001,02,08),"12th","HDFC0987654",50000);
        account.ShowDetails();
    }
}

