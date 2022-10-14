using System;

namespace FoodDelivary
{
    public interface  IBalance
    {
        int WalletBalance {get;set;}
        void WalletRecharge();
    }
}
