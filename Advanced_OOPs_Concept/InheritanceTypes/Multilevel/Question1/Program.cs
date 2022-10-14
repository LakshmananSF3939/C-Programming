using System;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
        HscDetails hsc=new HscDetails("Lakshmanan","Ganesan",9876543210,"Abc@gmail",DateTime.Now,"12th","BIO MATHS",2,180,180,198);
        hsc.ShowMark();
    }
}
