using System;

namespace ProjetoPOO
{
    public class NotificadorWhatsApp : INotificador
    {
        public string ObterCanal()
        {
            return "WhatsApp";
        }

        public bool EnviarAlerta(string destinatario, string mensagem)
        {
            Console.WriteLine($"[WhatsApp para {destinatario}]: {mensagem}");
            return true;
        }
    }
}
