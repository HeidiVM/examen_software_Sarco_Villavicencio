using Patrones1P.Interface;
using System;

namespace Patrones1P.Class;

// Usando el principio SRP
public class CashPayment_SV : IPaymentMethod_SV
{
    public bool ProcessPayment_SV(double amount)
    {
        Console.WriteLine($"Procesando pago con un valor de: {amount} en efectivo");
        return true;
    }
}
