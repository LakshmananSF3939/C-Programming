using System;

namespace AbstractClasses
{
    public class Syncfusion : AbstractBase
    {
        
        //Abstract property definition
       public override string Name {get{return name;}set{name=value;}}
       //Abstract Method Definition
        public override void Salary(int dates)
        {
            Display();
            Amount=(double)dates*500;
            System.Console.WriteLine("Salary:"+Amount);
        }
    }
}
