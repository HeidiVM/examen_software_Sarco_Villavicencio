using Patrones1P.Class;
using Patrones1P.Interface;
// Responsabilidad Única (SRP):
//Cada clase tiene una única responsabilidad:
//CreditCardPayment_SV y CashPayment_SV solo se encargan de procesar pagos.
//EmailNotification_SV y SmsNotification_SV solo se encargan de enviar notificaciones.
//PaymentProcessor_SV se encarga de unir el proceso de pago y la notificación.

//Abierto/Cerrado (OCP):
//Si queremos agregar un nuevo método de pago  o un nuevo canal de notificación
//podemos hacerlo añadiendo las interfaces y creando nuevas clases que implementen esas interfaces sin modificar el código existente.

//Sustitución de Liskov (LSP):
//Las clases CreditCardPayment_SV y CashPayment_SV implementan la misma interfaz IPaymentMethod_SV,
//pueden ser intercambiadas sin problemas en la clase PaymentProcessor_SV.

//Segregación de la Interfaz (ISP):
//Las interfaces IPaymentMethod_SV y INotificationChannel_SV

//Inversión de Dependencias (DIP):
//Las clases PaymentProcessor dependen de las interfaces IPaymentMethod_SV
//e INotificationChannel_SV  Esto permite que las implementaciones puedan ser cambiadas fácilmente


namespace Patrones1P
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************Mostrar datos **********************");


            IPaymentMethod_SV creditCardPayment = new CreditCardPayment_SV();
            IPaymentMethod_SV cashPayment = new CashPayment_SV();

            INotificationChannel_SV emailNotification = new EmailNotification_SV();
            INotificationChannel_SV smsNotification = new SmsNotification_SV();

            // Procesar pago individualmente con tarjeta de crédito
            Console.WriteLine("Procesando pago con tarjeta de crédito:");
            PaymentProcessor_SV processor1 = new PaymentProcessor_SV(creditCardPayment, emailNotification);
            processor1.Notification(100.50);

            // Procesar pago individualmente con efectivo
            Console.WriteLine("\nProcesando pago con Efectivo:");
            PaymentProcessor_SV processor2 = new PaymentProcessor_SV(cashPayment, smsNotification);
            processor2.Notification(200.75);

            Console.ReadLine();
        }
    }
}

