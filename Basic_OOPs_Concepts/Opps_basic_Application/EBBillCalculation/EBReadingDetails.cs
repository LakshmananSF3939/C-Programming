using System;
using System.Collections.Generic;
namespace EBBillCalculation
{
    public class EBReadingDetails
    {
      private static int s_meterID=1000;  
      public string MeterID { get;  }
      public string UserName { get; set; }
      public long PhoneNumber { get; set; }
      public string MailId { get; set; }
      public double Units { get; set; }
      public double Amount { get;set;  }
      
      
      
      

      public EBReadingDetails(string name,long phoneNumber,string mail)
      {
        s_meterID++;
        MeterID="EB"+s_meterID;
        UserName=name;
        PhoneNumber=phoneNumber;
        MailId=mail;
        
      }
      public void CalculateAmount()
      {
        double charge;
        
        double surcharge;
       if(Units>=0 && Units<=100)
       {
                charge=0;
                surcharge=0;
                Amount=charge;
       }
       else if(Units>100 && Units<=200)
       {
                charge=Units*3.0;
                surcharge=0;
                Amount=charge;
       }
       else if (Units>200 && Units<=400)
       {
               charge=Units*5.0;
               surcharge=0;
               Amount=charge;
       }
       else if(Units>400)
       {
               charge=Units*6.0;
               surcharge=charge*0.15;
               Amount=charge+surcharge;
       }
        System.Console.WriteLine("Amount:"+Amount);
        
      }
      public void ShowDetails()
      {
        System.Console.WriteLine("Your EB ID:"+MeterID);
            System.Console.WriteLine("Your Name is "+UserName);
            System.Console.WriteLine("Your Mobile Number:"+PhoneNumber);
            System.Console.WriteLine("Your mobile ID:"+MailId);
            
            
            
      }
      
       public void UsedUnits()
       {
         System.Console.WriteLine("Enter Used Units:");
         Units=int.Parse(Console.ReadLine());
       }
      
    }
}
