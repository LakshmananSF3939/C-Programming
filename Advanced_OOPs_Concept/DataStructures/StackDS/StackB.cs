using System;

namespace StackDS;
public partial class Stack<Type> 
{
    public Type Pop() 
    {
        Type value=default(Type);
      if(_count<0)
      {
          System.Console.WriteLine("Empty stock");
      }
      else if(_count>=0)
      {
        value=Array[_count];
        _count--;
      }
      return value;
    }
    public bool Contains(Type Data)
    {
        int flag=0;
        for(int i=0;i<_count;i++)
        {
            if(Data.Equals(Array[i]))
            {
               flag=1;
            }
        }
        
        if(flag==1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
   public Type Peak()
   {
   int value= _count;
    return Array[_count];
    
   }
}