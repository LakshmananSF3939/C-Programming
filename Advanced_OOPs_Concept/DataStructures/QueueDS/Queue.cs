

namespace QueueDS
{
    public partial class Queue<Type>
    {
        private Type[] Array{get;set;}
        private int _head;
        private int _tail;
        private int _count;
        private int _capacity;
        public int Count{get{return _count;}}
        public Queue()
        {
            _head=0;
            _tail=0;
            _count=0;
            _capacity=4;
            Array=new Type[_capacity];
        }
        public Queue(int size)
        {
            _head=0;
            _tail=0;
            _count=0;
            _capacity=size;
            Array=new Type[_capacity];
        }
        public void EnQueue(Type data)
        {
            if(_tail==_capacity)
            {
                GrowSize();
            }
            Array[_tail]=data;
            _tail++;
            _count++;
        }
        public void GrowSize()
        {
            _capacity=_capacity*2;
            Type[] Array1=new Type[_capacity];
            for(int i=_head;i<_tail;i++)
            {
                Array1[i]=Array[i];
            }
            Array=Array1;
        }
    }
}
