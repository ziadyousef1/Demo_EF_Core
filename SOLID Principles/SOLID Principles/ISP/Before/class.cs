using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.ISP.Before
{
    //states that no client should be forced to depend on methods it does not use.
    //This means creating specific and focused interfaces rather than large general ones.
    public interface IPaymentProcessor
    {
        void ProcessCreditCardPayment(string cardNumber, decimal amount);
        void ProcessPayPalPayment(string email, decimal amount);
        void ProcessBankTransfer(string accountNumber, decimal amount);
    }

}
