using System;

namespace Question1
{
    public interface IFamily:InterfaceShowData
    {
         string FatherName { get; set; }
         string MotherName { get; set; }
         string Address { get; set; }
        
         //void ShowInfo();
        
}
}

