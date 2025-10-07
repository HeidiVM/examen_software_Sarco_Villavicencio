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

    public void Notification(double amount, string message) {

        _paymentMethod.ProcessPayment_SV(amount);
        _notificationChannel.SendNotification_SV(message);
    }




}
