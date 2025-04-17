using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacionObjecto
{
   

    public class Paypal : IPayment
    {
        private string _email;
        private string _password;
        private CreditCard _creditAsocite;

        public Paypal(CreditCard creditCard, string password, string email)
        {
            _creditAsocite = creditCard;
            _password = password;
            _email = email;
        }

        public void ConfirmPayment()
        {
            Console.WriteLine("pago confirmado con paypal");
        }

        public void TypePayment()
        {
            Console.WriteLine("pago con paypal");
        }
    }
}
