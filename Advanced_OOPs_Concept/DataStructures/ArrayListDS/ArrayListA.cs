using System;

namespace ArrayListDS
{
    public  partial class ArrayList
    {
        public void Insert(int index,dynamic data)
        {
             _count++;
            dynamic[] Array2=new dynamic[_capacity+1];
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
        public void Remove(dynamic data)
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
