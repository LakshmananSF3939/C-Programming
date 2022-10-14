using System;

namespace ListDS
{
    public  partial class List<Type>
    {
        public void Insert(int index,Type data)
        {
             _count++;
            Type[] Array2=new Type[_capacity+1];
             for(int i=0;i<_count;i++)
             {
                if(i<index)
                {
                    Array2[i]=Array[i];
                }
                else if(i==index)
                {
                    Array2[i]=data;
                   
                }
                else if(i>index)
                {
                     Array2[i]=Array[i-1];
                }

             }
             Array=Array2;
            
             
        }
        public void RemoveAt(int index)
        {
           
            for(int i=0;i<_count;i++)
            {
                if(i>=index)
                {
                    Array[i]=Array[i+1];
                 
                }
               
            }
            _count--;
           
        }
        public void Remove(Type data)
        {
            int Count=0;
            for(int i=0;i<_count;i++)
            {
                if(Array[i].Equals(data))
                {
                    if(Count==0)
                    {
                        Array[i]=Array[i+1];
                        Count=1;
                    }
                }
                else if(Count==1)
                {
                    Array[i]=Array[i+1];
                }
            }
            _count--;
            
        }
        
    }
}
