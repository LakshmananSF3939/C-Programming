using System;
using Outside;
namespace Inside
{
    public class First:Third
    {
        public int PulicNumber=10;
        private int PrivateNumber=20;
        public int PrivateOutput{get {return PrivateNumber;}}
        internal int InternalNumber=30;
        protected int ProtectedNumber=40;
        public int ProtectedInternalNumber1 {get{return ProtectedInternalNumber;}}
    }
}
