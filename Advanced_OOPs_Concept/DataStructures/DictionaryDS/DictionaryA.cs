using System;

namespace DictionaryDS;

    public partial class Dictionary<TKey,TValue>
    {
        public void AddElement(TKey key,TValue value)
        {
            if(_count==_capacity)
            {
                GrowSize();
            }
            bool temp=LinearSearch(key,out int index);
            if(temp==true)
            {
                System.Console.WriteLine("Dublicate Key");
            }
            else
            {
                KeyValue<TKey,TValue> entry=new KeyValue<TKey, TValue>();
                entry.key=key;
                entry.Value=value;
                Array[_count]=entry;

                _count++;
            }
        }
        public TValue this [TKey key]
        {
            get
            {
                TValue output=default(TValue);
                int index=0;
                bool temp=LinearSearch(key,out  index);
                if(temp)
                {
                    output=Array[index].Value;
                }
                else  
                {
                    System.Console.WriteLine("Invalid Key");
                }
                return output;
            }
            set
            {
                int index=0;
                 bool temp=LinearSearch(key,out index);
                 if(temp)
                 {
                    Array[index].Value=value;
                 }
                 else
                 {
                    System.Console.WriteLine("Invalid Key");
                 }
            }
        }
  
        public void GrowSize()
        {
            _capacity=_capacity*2;
            KeyValue<TKey,TValue>[] Array1=new KeyValue<TKey, TValue>[_capacity];

            for(int i=0;i<_count;i++)
            {
                Array1[i]=Array[i];
            }
            Array=Array1;
            
            
        }
        public bool LinearSearch(TKey key,out int index)
        {
            
            index=0;
             for(int i=0;i<_count;i++)
             {
                if(key.Equals(Array[i].key))
                {
                   index=i;
                   return true;
                   
                   
                }
                
             }
             return false;            
        }
    }

