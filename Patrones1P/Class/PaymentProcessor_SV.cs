using Patrones1P.Interface;
//Aplicaicón de principio DIP

//Inyección de dependencias
namespace Patrones1P.Class;

public class PaymentProcessor_SV
{
    private readonly IPaymentMethod_SV _paymentMethod;
    private readonly INotificationChannel_SV _notificationChannel;

    public PaymentProcessor_SV(IPaymentMethod_SV paymentMethod_SV, INotificationChannel_SV notificationChannel_SV)
    {
        _paymentMethod = paymentMethod_SV;
        _notificationChannel = notificationChannel_SV;
    }

    public void Notification(double amount) {

        bool paymentSuccess = _paymentMethod.ProcessPayment_SV(amount);
      //  string message = paymentSuccess ? $"Pago de ${amount} procesado exitosamente." : "Hubo un error al procesar el pago.";
        _notificationChannel.SendNotification_SV($"Pago de {amount}");
    }

}





