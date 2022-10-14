using System;

namespace StackDS
{
    public partial class Stack<Type>
    {
        public void Push(Type data)
        {
            if(_count==_capacity)
            {
                //Grow Size();
            }
            Array[_count]=data;
            _count++;
        }
        public void GrowSize()
        {
            _capacity=_capacity*2;
            Type[] Array1=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                Array1[i]=Array[i];
            }
            Array=Array1;
        }
    }
}
