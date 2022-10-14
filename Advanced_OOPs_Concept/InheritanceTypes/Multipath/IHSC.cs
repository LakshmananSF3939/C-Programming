using System;

namespace Multipath
{
    public interface IHSC:Ipersonal
    {
        string HSCNo{get;set;}
        int Physics{get;set;}
        int chemistry{get;set;}
        int maths{get;set;}
        void HSCmark();
    }
}
