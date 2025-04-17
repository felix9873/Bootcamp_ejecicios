



using programacionObjecto;

CreditCard creditCard = new CreditCard("156", "34335535", "3232424");

Paypal paypal = new Paypal(creditCard, "feegegdsd" , "felix@gmail.com");

creditCard.TypePayment();

creditCard.ConfirmPayment();

paypal.ConfirmPayment();
paypal.TypePayment();

