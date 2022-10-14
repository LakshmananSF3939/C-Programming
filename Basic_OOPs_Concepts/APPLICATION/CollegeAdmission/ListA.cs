using System;

namespace CollegeAdmission
{
    public  partial class List<Type>
    {
        public void Insert(int index,Type data)
        {

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
             _count++;
             
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
             Type[] temp=new Type[_capacity];
             int j=0;
             for(int i=0;i<_count;i++)
             {
                if(data.Equals(Array[i]))
                {
                    continue;
                }
                temp[j]=Array[i];
                j++;
             }
             Array=temp;
            
        }
        
    }
}
