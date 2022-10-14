using System;

namespace Multipath
{
    public interface UGInfo:Ipersonal
    {
        string UGNo{get;set;}
        int Sem1{get;set;}
        int Sem2{get;set;}
        int Sem3{get;set;}
        int Sem4{get;set;}
         void UGMarkSheet();
    }
}
