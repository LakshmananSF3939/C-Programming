using System;

namespace OperatorOverLoading;

    public class Box
    {
        private int length;
        private int breadth;
        private int height;
        public Box (int length1,int breadth1,int height1)
        {
           length=length1;
           breadth=breadth1;
           height=height1;
        }
        public Box()
        {

        }
        public double Calculate()
        {
            return length*breadth*height;
        }
       public static Box operator +(Box box1,Box box2)
    {
        Box box=new Box();
        box.length=box1.length+box2.length;
        box.breadth=box1.breadth+box2.breadth;
        box.height=box1.height+box2.height;
        return box;
    }
    }

