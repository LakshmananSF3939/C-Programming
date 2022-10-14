using System;
namespace Question1 
{
    class Program 
    {
        public static void Main(string[] args)
        {
           System.Console.WriteLine("Enter basic salary of an  Employee:");
           double basic=double.Parse(Console.ReadLine());
           double da,hra,gross,month;
           if(basic<=10000)
           {
            da=basic*0.8;
            hra=basic*0.2;
           } 
           else if(basic<=20000)
           {
            da=basic*0.9;
            hra=basic*0.25;
           } 
            else
           {
            da=basic*0.95;
            hra=basic*0.3;
           } 
            month=(basic+hra+da)-(basic*0.07);
            gross=((basic+hra+da)*12)-(basic*0.07*12);
            System.Console.WriteLine("Gross salary:"+gross+"\nMonth:"+month);
        }
    }
}
