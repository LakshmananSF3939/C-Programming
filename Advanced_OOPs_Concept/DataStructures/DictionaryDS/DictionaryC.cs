using System;
using System.Collections;
 namespace DictionaryDS
{
    public partial class Dictionary<TKey, TValue>:IEnumerable,IEnumerator
    {
         private int i;
        public IEnumerator GetEnumerator()
        {
             i=-1;
             return (IEnumerator)this;
        }
        public bool MoveNext()
        {
            if(i<_count-1)
            {
                ++i;
                return true;
            }
            Reset();
            return false;
        }
        public void Reset()//i for next turn
        {
            i=-1;
        }
        public Object Current
        {
           get{return Array[i];}
        }
    }
}
