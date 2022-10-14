using System;
namespace Question7 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Id");
            int id=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter name:");
            string name=Console.ReadLine();
            System.Console.WriteLine("used units");
            int units=Convert.ToInt32(Console.ReadLine());
            double charge;
            double surcharge;
            double amount;
            if(units>=0 && units<=50)
            {
                charge=0;
                surcharge=0;
                amount=100;
                System.Console.WriteLine($"Name:{name}\nId:{id}\nUnit Consumed:{units}\nAmount Charges:{charge}\nSurcharge Amount:{surcharge}\nNetamount:{amount}");

            }
            else if(units>=51 && units<=199)
            {
                charge=units*1.20;
                surcharge=0;
                amount=charge;
                System.Console.WriteLine($"Name:{name}\nId:{id}\nUnit Consumed:{units}\nAmount Charges:{charge}\nSurcharge Amount:{surcharge}\nNetamount:{amount}");

            }
            else if(units>=200 && units<=400)
            {
                charge=units*1.50;
                surcharge=0;
                amount=charge;
                System.Console.WriteLine($"Name:{name}\nId:{id}\nUnit Consumed:{units}\nAmount Charges:{charge}\nSurcharge Amount:{surcharge}\nNetamount:{amount}");

            }
            else if(units>=401 && units<=600)
            {
                charge=units*1.80;
                surcharge=charge*0.15;
                amount=charge+surcharge;
                System.Console.WriteLine($"Name:{name}\nId:{id}\nUnit Consumed:{units}\nAmount Charges:{charge}\nSurcharge Amount:{surcharge}\nNetamount:{amount}");

            }
            else if(units>=600)
            {
                charge=units*2.00;
                surcharge=charge*0.15;
                amount=charge+surcharge;
                System.Console.WriteLine($"Name:{name}\nId:{id}\nUnit Consumed:{units}\nAmount Charges:{charge}\nSurcharge Amount:{surcharge}\nNetamount:{amount}");

            }
            
        }
    }
}
