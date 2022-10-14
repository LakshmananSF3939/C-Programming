using System;

namespace QueueDS
{
    public partial class Queue<Type>
    {
        public Type DeQueue()
        {
           Type value=default(Type);
           if(_head>_tail)
           {
            System.Console.WriteLine("Queue Empty");
           }
           else if(_head<=_tail)
           {
            value=Array[_head];
            _head++;
            _count--;
           }
           return value;
        }
    }
    public Type Peak()
    {
          Type value=default(Type);
           if(_head>_tail)
           {
            System.Console.WriteLine("Queue Empty");
           }
           else if(_head<=_tail)
           {
            value=Array[_head];           
           }
           return value;
    }
    
}
