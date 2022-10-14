using System;
using System.Collections.Generic;
using EBPayRollLibrary;
namespace EBPayRollOperation;
public class Operations 
{
    public static void MainMenu()
    {
        List<EBReadingDetails> calculationList=new List<EBReadingDetails>();
        System.Console.WriteLine("can you see your EB bill amount:");
        string willing=Console.ReadLine();
        do
        {
            System.Console.WriteLine("Enter your Name:");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your Phone Number");
            long mobile=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Your Mail Id:");
            string mail=Console.ReadLine();
            System.Console.WriteLine("Enter used units");
            double units=double.Parse(Console.ReadLine());
            EBReadingDetails reading1=new EBReadingDetails(name,mobile,mail,units);
            calculationList.Add(reading1);
            System.Console.WriteLine("can you see your EB bill amount:");
            willing=Console.ReadLine();
        }while(willing=="yes");

        foreach(EBReadingDetails reading in calculationList)
        {
            System.Console.WriteLine("Your EB ID:"+reading.MeterID);
            System.Console.WriteLine("Your Name is "+reading.UserName);
            System.Console.WriteLine("Your Mobile Number:"+reading.PhoneNumber);
            System.Console.WriteLine("Your mobile ID:"+reading.MailId);
            System.Console.WriteLine("Used Units:"+reading.Units);
            
            System.Console.WriteLine("Amount:"+reading.CalculateAmount());
        }
    }
}
