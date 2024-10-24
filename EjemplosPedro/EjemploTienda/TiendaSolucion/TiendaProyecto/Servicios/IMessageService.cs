namespace TiendaProyecto.Servicios
{
    public interface IMessageService
    {
         void SendMessage(string message,string to);
    }

    public class EmailService : IMessageService
    {
        public void SendMessage(string message, string to)
        {
            Console.WriteLine($"Email sent to {to} with message: {message}");
        }
    }

    public class SmsService : IMessageService
    {
        public void SendMessage(string message, string to)
        {
            Console.WriteLine($"SMS sent to {to} with message: {message}");
        }
    }
}
