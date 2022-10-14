using System;

namespace MultiLevelInheritance
{
    public interface IMarkDetails
    {
        
         int Physics { get; set; }//Property declaration only allowed
         int Chemistry { get; set; } 
         int Maths { get; set; }
         
         double Average {get;set;}
         void Calculate();//Method Declaration only allowed
         //No constructer and Object
         void GetMark(int Physics,int Chemistry,int Maths);
         void ShowMark();
    }
}
