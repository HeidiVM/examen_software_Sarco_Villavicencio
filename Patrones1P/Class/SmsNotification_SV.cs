using Patrones1P.Interface;

namespace Patrones1P.Class
{
    public class SmsNotification_SV : INotificationChannel_SV
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Enviando notificación por SMS: {message}");
        }
    }
}
