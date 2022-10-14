using System;
using System.Collections;
namespace MovieTicketBooking
{
    public partial class List<Type>:IEnumerable,IEnumerator
    {
        /// <summary>
        /// i variable
        /// </summary>
       private int i;
       /// <summary>
       /// return type method
       /// </summary>
       /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
             i=-1;
             return (IEnumerator)this;
        }
        /// <summary>
        /// Return type method
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Reset i value method
        /// </summary>
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
