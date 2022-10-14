using System;

namespace Question4
{
    public enum Degree{BE,Btech}
    public class DepartmentInfo
    {
        public string DepartMent { get; set; }
        public Degree Degree { get; set; }
        public DepartmentInfo(string departMent,Degree degree)
        {
            DepartMent=departMent;
            Degree=degree;
        }

    }
}
