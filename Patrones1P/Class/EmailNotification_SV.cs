using Patrones1P.Interface;

namespace Patrones1P.Class;

public class EmailNotification_SV : INotificationChannel_SV
{
    public void SendNotification_SV(string message)
    {
        Console.WriteLine($"Enviando notificación por correo: {message}");
    }
}
