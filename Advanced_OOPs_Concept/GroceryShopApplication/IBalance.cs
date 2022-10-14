using System;

namespace GroceryShopApplication
{
    public interface IBalance
    {
        double WalletBalance {get;set;}
        void WalletRecharge();
        
    }
}
