using System;

namespace DictionaryDS
{
    public partial class Dictionary<TKey,TValue>
    {
        private int _count;
        private int _capacity;
        public int Count { get{return _count;}  }
        public int Capacity { get{return _capacity;}  }
        private KeyValue<TKey,TValue>[] Array {get;set;}
        
        public Dictionary()
        {
            _count=0;
            _capacity=4;
            Array=new KeyValue<TKey, TValue>[_capacity];
        }

         public Dictionary(int size)
         {
            _count=0;
            _capacity=size;
            Array=new KeyValue<TKey, TValue>[_capacity];
         }
         
    }
}
