using System;

namespace Interfaces//fully abstraction
{
    public class Draw:IRectangle
    {
        public int Area { get; set; }
         public int Length{get;set;}
        public int Breadth{get;set;}

        public Draw(int length,int breadth)
        {
            Length=length;
            Breadth=breadth;
        }
        public void CalculateArea()
        {
            Area=Length*Breadth;
        }
        public void ShowDetails()
        {  
            System.Console.WriteLine("Breadth:"+Breadth);
            System.Console.WriteLine("Length :"+Length);
            System.Console.WriteLine("Area   :"+Area);
        }
    }
}
