using Patrones1P.Class;
using Patrones1P.Interface;

namespace Patrones1P
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("**************Mostrar datos **********************");


            //IPaymentMethod_SV paymentMethod_SV = new CashPayment_SV();
            //INotificationChannel_SV notificationChannel_SV  = new EmailNotification_SV();


            //PaymentProcessor_SV paymentProcessor_SV = new PaymentProcessor_SV(paymentMethod_SV, notificationChannel_SV);

            ////paymentProcessor_SV.Notification(12.90, "pagado");
            //paymentProcessor_SV.Notification(18.90);

            IPaymentMethod_SV[] paymentMethods = new IPaymentMethod_SV[]
        {
            new CreditCardPayment_SV(),
            new CashPayment_SV()
        };

            INotificationChannel_SV[] notificationChannels = new INotificationChannel_SV[]
            {
            new EmailNotification_SV(),
            new SmsNotification_SV()
            };

            // PRINCIPIO DE INVERSION DE DEPENDENCIAS: No dependemos de implementaciones concretas.
            foreach (var paymentMethod in paymentMethods)
            {
                foreach (var notificationChannel in notificationChannels)
                {
                    PaymentProcessor_SV processor = new PaymentProcessor_SV(paymentMethod, notificationChannel);
                    processor.Notification(100.50);
                }
            }

            // Mantener la consola abierta
            Console.ReadLine();
        }

    }
}

