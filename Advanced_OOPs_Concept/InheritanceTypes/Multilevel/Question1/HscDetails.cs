using System;

namespace Question1
{
    public class HscDetails:StudentInfo
    {
        private static int s_hscNO=1000;
        public string HSCNo { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public HscDetails(string name,string fatherName,long mobile,string mail,DateTime dob,string standard,string branch,int year,int physics,int chemistry,int maths):base( name,fatherName, mobile, mail, dob, standard, branch, year)
        {
            s_hscNO++;
            HSCNo="HID"+s_hscNO;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
        public void ShowMark()
        {
            Disply();
            System.Console.WriteLine("Hsc No:"+HSCNo);
            System.Console.WriteLine("Msths mark:"+Maths);
            System.Console.WriteLine("Chemistry matk:"+Chemistry);
            System.Console.WriteLine("Physics mark:"+Physics);
        }
    }
}
