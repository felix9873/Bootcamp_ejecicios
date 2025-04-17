using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacionObjecto
{
    public class CreditCard : IPayment
    {
        private string _nroBack;
        private string _nroFront;
        private string _code;

        public CreditCard(string code, string nroFront ,string nroBack)
        {
            _code = code;
            _nroFront = nroFront;
            _nroBack = nroBack;
        }

        public void ConfirmPayment()
        {
            Console.WriteLine("pago confirmado con tarjeta de credito");
        }

        public string GetNroBack()
        {
            return _nroBack;
        }

        public string NroFront()
        {
            return _nroFront;
        }
        public string Code()
        {
            return _code;
        }

        public void SetNroBack(string nroBack)
        {
            _nroBack = nroBack;
        }
        public void SetNroFron(string nroFront)
        {
            _nroFront = nroFront;
        }

        public void SetCode(string code)
        {
            _code = code;
        }

        public void TypePayment()
        {
            Console.WriteLine("pago con tarjeta de credito");
        }
    }
}
