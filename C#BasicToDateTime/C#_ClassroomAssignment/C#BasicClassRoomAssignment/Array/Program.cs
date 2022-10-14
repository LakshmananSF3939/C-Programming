using System;
namespace Question4 
{
    class Program 
    {
        public static void Main(string[] args)
        {
           int c=0;
         String[] names= new String[5];
         for (int i = 0; i <names.Length; i++)
         {
            System.Console.WriteLine("Enter names:");
            names[i]=Console.ReadLine();
         } 
         System.Console.WriteLine("Print Names:");
         for( int i=0;i<names.Length;i++)
         {
            System.Console.WriteLine(names[i]+" ");
         }  
         System.Console.WriteLine("Enter user Input:");
         string userInput=Console.ReadLine();
         for(int i=0;i<names.Length;i++)
         {
            if(userInput==names[i])
            {
                System.Console.WriteLine($"The name is present in the array and the index {i}");
                c++;
            }
         }
          if(c==0)
            {
                System.Console.WriteLine("The name is not present");
            }
            c=0;
           foreach(string namess in names) 
           {
             if(userInput==namess)
            {
                System.Console.WriteLine("The name is present in the array and the index ");
                c++;
            }
           }
            if(c==0)
            {
                System.Console.WriteLine("The name is not present");
            }
    }
}
}
