using System;

namespace FilterDeligate
{
    public delegate bool FilterDeligates(Person p);//filter deligate
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
