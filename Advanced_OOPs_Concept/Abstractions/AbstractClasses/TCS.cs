using System;

namespace AbstractClasses
{
    public class TCS:AbstractBase
    {
         //Abstract property definition
       public override string Name {get{return name;}set{name=value;}}
       //Abstract Method Definition
        public override void Salary(int dates)
        {
            Display();
            Amount=(double)dates*300;
            System.Console.WriteLine("Salary:"+Amount);
        }
    }
}
