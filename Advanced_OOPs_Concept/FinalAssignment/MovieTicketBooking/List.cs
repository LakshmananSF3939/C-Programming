using System;

namespace MovieTicketBooking
{
    public partial class List<Type>
    {
        /// <summary>
        /// Represent as creating any data type array
        /// </summary>
        /// <value></value>
        private Type[] Array{get;set;}
        /// <summary>
        /// private array count
        /// </summary>
        private int _count;
        /// <summary>
        /// private array capacity
        /// </summary>
        private int _capacity;
        /// <summary>
        /// Count property
        /// </summary>
        /// <value></value>
        public int Count { get{return _count;}}
        /// <summary>
        /// Capacity property
        /// </summary>
        /// <value></value>
        public int Capacity { get{return _capacity;} }
        /// <summary>
        /// Indexor
        /// </summary>
        /// <value></value>
        public Type this[int i]
        {
            get{return Array[i];}
            set{Array[i]=value;}
        }
        /// <summary>
        /// default constructor
        /// </summary>
        public List()
        {
            _count=0;
            _capacity=4;
            Array=new Type[_capacity];
        }
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="size"></param>
        public List(int size)
        {
            _count=0;
            _capacity=size;
            Array=new Type[_capacity];
        }
        /// <summary>
        /// Add list method
        /// </summary>
        /// <param name="data"></param>
        public void Add(Type data)
        {
            if(_count==_capacity)
            {
                GrowSize();
            }
            Array[_count]=data;
            _count++;
        }
        /// <summary>
        /// Represent as growing array size
        /// </summary>
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
