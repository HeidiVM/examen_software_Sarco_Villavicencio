using Patrones1P.Interface;

namespace Patrones1P.Class;

public class CreditCardPayment_SV : IPaymentMethod_SV
{
    public bool ProcessPayment_SV(double amount)
    {
       Console.WriteLine($"Procesando pago con un valor de: {amount} con tarjeta");
        return true;
    }


    
}
