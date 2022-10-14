using System;

namespace AbstractClasses
{
    public abstract class AbstractBase//Abstract class
    {
        protected string name;//normal field
        public abstract string Name { get; set; }//Abstract property
        public double Amount { get; set; }//Normal property
        public void Display()
        {
            System.Console.WriteLine("Name:"+name);//Normal method
        }
         public abstract void Salary(int dates);//abstract method
    }
}
