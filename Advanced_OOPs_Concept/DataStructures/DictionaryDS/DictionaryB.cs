using System;

namespace DictionaryDS;

    public partial class Dictionary<TKey,TValue>
    {
        public bool ContainsKey(TKey key)
        {
          for(int i=0;i<_count;i++)
          {
            if(key.Equals(Array[i].key))
            {
                return true;
            }
          }
          return false;
        }
        public bool ContainsValue(TKey Value)
        {
            for(int i=0;i<_count;i++)
            {
                if(Value.Equals(Array[i].key))
                {
                    return true;
                }
            }
            return false;
        }
        public KeyValue<TKey,TValue> ElementAt(int number)
        {
            KeyValue<TKey,TValue> output=null;
            for(int i=0;i<_count;i++)
            {
                if(i==number)
                {
                    output=Array[i];
                    break;
                }
            }
            return output;
        }
    }

