using System;

namespace MovieTicketBooking
{
    public interface IWallet
    {
        /// <summary>
        /// Interface property
        /// </summary>
        /// <value></value>
       double WalletBalance{get;set;} 
       /// <summary>
       /// Interface method
       /// </summary>
       void WalletRecharge();
    }
}
