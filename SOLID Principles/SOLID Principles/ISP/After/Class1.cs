using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.ISP.After
{
    // after adhering to the ISP principle
    // we have created specific interfaces for each payment method

    public interface ICreditCardPaymentProcessor
    {
        void ProcessCreditCardPayment(string cardNumber, decimal amount);
    }

    public interface IPayPalPaymentProcessor
    {
        void ProcessPayPalPayment(string email, decimal amount);
    }

    public interface IBankTransferPaymentProcessor
    {
        void ProcessBankTransfer(string accountNumber, decimal amount);
    }
    public class CreditCardPaymentProcessor : ICreditCardPaymentProcessor
    {
        public void ProcessCreditCardPayment(string cardNumber, decimal amount)
        {
            // Credit card logic
        }
    }

    public class PayPalPaymentProcessor : IPayPalPaymentProcessor
    {
        public void ProcessPayPalPayment(string email, decimal amount)
        {
            // PayPal logic
        }
    }

    public class BankTransferProcessor : IBankTransferPaymentProcessor
    {
        public void ProcessBankTransfer(string accountNumber, decimal amount)
        {
            // Bank logic
        }
    }

}
