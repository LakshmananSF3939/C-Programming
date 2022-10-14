using System;

namespace GroceryShopApplication
{
    public partial class List<Type>
    {
        public void AddRange(List<Type> data)
        {
            Type[] Array2=new Type[_capacity+data._count];
            for(int i=0;i<_count;i++)
            {
                Array2[i]=Array[i];
                
            }
            for(int i=0;i<data._count;i++)
            {
                Array2[_count+i]=data[i];
            }
            Array=Array2;
            _count=_count+data._count;
            
        }
    }
}
